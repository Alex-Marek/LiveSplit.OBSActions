using LiveSplit.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    public class OBSActionsComponent : LogicComponent, IDeactivatableComponent
    {
        public OBSActionsSettings Settings { get; set; }
        protected LiveSplitState CurrentState { get; set; }

        private OBSWebSocket obs;

        private RecordingManager recordingManager;
        private ReplayBufferManager replayBufferManager;

        public bool Activated { get; set; }

        public override string ComponentName => "OBS Actions";

        private static DateTime lastAttemptedConnect = DateTime.MinValue;

        public OBSActionsComponent(LiveSplitState state)
        {
            Activated = true;
            Settings = new OBSActionsSettings();

            CurrentState = state;

            state.OnStart += state_OnStart;
            state.OnSplit += state_OnSplitChange;
            state.OnSkipSplit += state_OnSplitChange;
            state.OnUndoSplit += state_OnSplitChange;
            state.OnReset += state_OnReset;
            CurrentState = state;

            this.obs = new OBSWebSocket();
            this.recordingManager = new RecordingManager(obs);
            this.replayBufferManager = new ReplayBufferManager(obs);
        }

        public override void Dispose()
        {
            CurrentState.OnStart -= state_OnStart;
            CurrentState.OnSplit -= state_OnSplitChange;
            CurrentState.OnSkipSplit -= state_OnSplitChange;
            CurrentState.OnUndoSplit -= state_OnSplitChange;
            CurrentState.OnReset -= state_OnReset;
            if (this.obs.isIdentified == true)
            {
                this.obs.Disconnect();
            }
        }

        //Every 3 seconds attempt to reconnect to the websocket server if not already connected
        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) 
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan timeSinceLastCalled = currentTime - lastAttemptedConnect;
            if (timeSinceLastCalled.TotalSeconds >= 3 && obs.isIdentified == false && Settings.webSocketIp != null)
            {
                if (Settings.webSocketIp.Contains("ws://") == false) { Settings.webSocketIp = "ws://" + Settings.webSocketIp; }
                obs.Connect(Settings.webSocketIp, Settings.webSocketPassword);
                recordingManager = new RecordingManager(obs);
                replayBufferManager = new ReplayBufferManager(obs);
                lastAttemptedConnect = currentTime;
            }
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            Settings.Mode = mode;
            return Settings;
        }

        public override System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public override void SetSettings(System.Xml.XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        void state_OnStart(object sender, EventArgs e)
        {
            if (Settings.startRecording == true && obs.isIdentified == true)
            {
                recordingManager.QueueStartRecording();
            }

            if (Settings.startReplayBuffer == true && obs.isIdentified == true)
            {
                replayBufferManager.QueueStartReplayBuffer();
            }
        }

        void state_OnSplitChange(object sender, EventArgs e)
        {
            //If the last split was the final one
            if (CurrentState.CurrentPhase == TimerPhase.Ended && obs.isIdentified == true)
            {
                if (Settings.stopRecording == true)
                {
                    recordingManager.QueueStopRecording();
                    // If Personal Best Run
                    if (CurrentState.Run.Last().PersonalBestSplitTime[CurrentState.CurrentTimingMethod] == null || CurrentState.Run.Last().SplitTime[CurrentState.CurrentTimingMethod] < CurrentState.Run.Last().PersonalBestSplitTime[CurrentState.CurrentTimingMethod])
                    {
                        recordingManager.QueueRenameMostRecentRecording($"PB: {CurrentState.Run.Last().SplitTime[CurrentState.CurrentTimingMethod]}");
                    }
                    // If not personal best run
                    else
                    {
                        if (Settings.deleteRecordings == true)
                        {
                            recordingManager.QueueDeleteMostRecentRecording();
                        }
                    }
                }
            }
            //If the last split was just a regular non-last one
            else if (CurrentState.CurrentPhase != TimerPhase.Ended && obs.isIdentified == true)
            {
                var splitIndex = CurrentState.CurrentSplitIndex - 1;
                var timeDifference = CurrentState.Run[splitIndex].SplitTime[CurrentState.CurrentTimingMethod] - CurrentState.Run[splitIndex].Comparisons[CurrentState.CurrentComparison][CurrentState.CurrentTimingMethod];
                TimeSpan? curSegment = LiveSplitStateHelper.GetPreviousSegmentTime(CurrentState, splitIndex, CurrentState.CurrentTimingMethod);

                //If current segment finished with a time
                if (curSegment != null)
                {
                    // if current segment is the fastest ever done
                    if (CurrentState.Run[splitIndex].BestSegmentTime[CurrentState.CurrentTimingMethod] == null || curSegment < CurrentState.Run[splitIndex].BestSegmentTime[CurrentState.CurrentTimingMethod])
                    {
                        if (Settings.goldReplay == true && obs.isIdentified == true)
                        {
                            replayBufferManager.QueueSaveReplayBuffer();
                        }
                    }
                }
            }
            //Regardless of if the split is the end of the run or not reset the replay buffer
            if (Settings.resetReplayBuffer == true && obs.isIdentified == true)
            {
                replayBufferManager.QueueStopReplayBuffer();
                replayBufferManager.QueueStartReplayBuffer();
            }

        }

        void state_OnReset(object sender, TimerPhase e)
        {
            // Reset = last run not completed = it's not pb = delete it
            if (Settings.stopRecording == true && obs.isIdentified == true)
            {
                recordingManager.QueueStopRecording();
                if (Settings.deleteRecordings == true)
                {
                    recordingManager.QueueDeleteMostRecentRecording();
                }
            }
        }


        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();
    }
}