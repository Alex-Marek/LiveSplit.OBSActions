using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace LiveSplit.UI.Components
{
    public class ReplayBufferManager
    {
        private OBSWebSocket _obs;

        private TaskCompletionSource<bool> _replayBufferStartedTcs;
        private TaskCompletionSource<bool> _replayBufferStoppedTcs;
        private TaskCompletionSource<bool> _replayBufferSavedTcs;

        private Queue<Func<Task>> _replayBufferQueue = new Queue<Func<Task>>();

        private bool _isProcessingReplayBufferQueue = false;

        private string mostRecentReplayBufferPath;

        public ReplayBufferManager(OBSWebSocket obs)
        {
            _obs = obs;
            _obs.ReplayBufferStateChanged += OnReplayBufferStateChanged;
            _obs.ReplayBufferSaved += OnReplayBufferSaved;
        }

        public string getMostRecentReplayBuffer()
        {
            return this.mostRecentReplayBufferPath;
        }

        public void QueueStartReplayBuffer()
        {
            _replayBufferQueue.Enqueue(StartReplayBuffer);
            ProcessReplayBufferQueue();
        }

        public void QueueStopReplayBuffer()
        {
            _replayBufferQueue.Enqueue(StopReplayBuffer);
            ProcessReplayBufferQueue();
        }

        public void QueueSaveReplayBuffer()
        {
            _replayBufferQueue.Enqueue(SaveReplayBuffer);
            ProcessReplayBufferQueue();
        }

        public void QueueRenameMostRecentReplay(string newName)
        {
            _replayBufferQueue.Enqueue(() => RenameMostRecentReplayAsync(newName));
            ProcessReplayBufferQueue();
        }

        public void QueueDeleteMostRecentReplay()
        {
            _replayBufferQueue.Enqueue(() => DeleteMostRecentReplayAsync());
            ProcessReplayBufferQueue();
        }

        private async void ProcessReplayBufferQueue()
        {
            if (_isProcessingReplayBufferQueue)
                return;

            _isProcessingReplayBufferQueue = true;

            while (_replayBufferQueue.Count > 0)
            {
                var command = _replayBufferQueue.Dequeue();
                await command();

                await Task.Delay(100);
            }

            _isProcessingReplayBufferQueue = false;
        }

        private async Task StartReplayBuffer()
        {
            _replayBufferStartedTcs = new TaskCompletionSource<bool>();
            _obs.StartReplayBuffer();
            await _replayBufferStartedTcs.Task;
        }

        private async Task StopReplayBuffer()
        {
            _replayBufferStoppedTcs = new TaskCompletionSource<bool>();
            _obs.StopReplayBuffer();
            await _replayBufferStoppedTcs.Task;
        }

        private async Task SaveReplayBuffer()
        {
            _replayBufferSavedTcs = new TaskCompletionSource<bool>();
            _obs.SaveReplayBuffer();
            await _replayBufferSavedTcs.Task;
        }

        private void OnReplayBufferStateChanged(object sender, ReplayBufferStateChangedEventArgs args)
        {
            switch (args.OutputState.State)
            {
                case OutputState.OBS_WEBSOCKET_OUTPUT_STARTED:
                    _replayBufferStartedTcs.SetResult(true);
                    break;
                case OutputState.OBS_WEBSOCKET_OUTPUT_STOPPED:
                    _replayBufferStoppedTcs.SetResult(true);
                    break;
            }
        }

        private void OnReplayBufferSaved(object sender, ReplayBufferSavedEventArgs args)
        {
            if (args.SavedReplayPath != null)
            {
                mostRecentReplayBufferPath = args.SavedReplayPath;
            }
            _replayBufferSavedTcs.SetResult(true);
        }

        private Task RenameMostRecentReplayAsync(string newName)
        {
            return Task.Run(() => RenameMostRecentReplay(newName));
        }
        private void RenameMostRecentReplay(string newName)
        {
            string mostRecentReplay = this.mostRecentReplayBufferPath;

            string directory = Path.GetDirectoryName(this.mostRecentReplayBufferPath);
            string newFilePath = Path.Combine(directory, newName);
            if (mostRecentReplay != null)
            {
                try
                {
                    if (File.Exists(mostRecentReplay))
                    {
                        File.Move(mostRecentReplay, newFilePath);
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        private Task DeleteMostRecentReplayAsync()
        {
            return Task.Run(() => DeleteMostRecentReplay());
        }
        private void DeleteMostRecentReplay()
        {
            string mostRecentReplay = this.mostRecentReplayBufferPath;
            if (mostRecentReplay != null)
            {
                try
                {
                    if (File.Exists(mostRecentReplay))
                    {
                        File.Delete(mostRecentReplay);
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
