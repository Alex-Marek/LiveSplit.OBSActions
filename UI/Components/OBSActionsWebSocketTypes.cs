using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LiveSplit.UI.Components
{
    public class ServerMessage
    {
        [JsonProperty(PropertyName = "op")]
        public int Op { get; set; }

        [JsonProperty(PropertyName = "d")]
        public JObject Data { get; set; }
    }

    public class OBSAuthInfo
    {
        public OBSAuthInfo() { }
        public OBSAuthInfo(JObject data)
        {
            JsonConvert.PopulateObject(data.ToString(), this);
        }

        [JsonProperty(PropertyName = "challenge")]
        public string Challenge;

        [JsonProperty(PropertyName = "salt")]
        public string PasswordSalt;
    }

    public enum OutputState
    {
        OBS_WEBSOCKET_OUTPUT_STARTING,
        OBS_WEBSOCKET_OUTPUT_STARTED,
        OBS_WEBSOCKET_OUTPUT_STOPPING,
        OBS_WEBSOCKET_OUTPUT_STOPPED,
        OBS_WEBSOCKET_OUTPUT_PAUSED,
        OBS_WEBSOCKET_OUTPUT_RESUMED
    }
    public class OutputStateChanged
    {
        public OutputStateChanged(JObject body)
        {
            JsonConvert.PopulateObject(body.ToString(), this);
        }
        public OutputStateChanged() { }

        private OutputState? state;
        [JsonProperty(PropertyName = "outputActive")]
        public bool IsActive { set; get; }

        [JsonProperty(PropertyName = "outputState")]
        public string StateStr { set; get; }

        public OutputState State
        {
            get
            {
                if (state.HasValue)
                {
                    return state.Value;
                }

                switch (StateStr)
                {
                    case "OBS_WEBSOCKET_OUTPUT_STARTING":
                        state = OutputState.OBS_WEBSOCKET_OUTPUT_STARTING;
                        break;
                    case "OBS_WEBSOCKET_OUTPUT_STARTED":
                        state = OutputState.OBS_WEBSOCKET_OUTPUT_STARTED;
                        break;
                    case "OBS_WEBSOCKET_OUTPUT_STOPPING":
                        state = OutputState.OBS_WEBSOCKET_OUTPUT_STOPPING;
                        break;
                    case "OBS_WEBSOCKET_OUTPUT_STOPPED":
                        state = OutputState.OBS_WEBSOCKET_OUTPUT_STOPPED;
                        break;
                    case "OBS_WEBSOCKET_OUTPUT_PAUSED":
                        state = OutputState.OBS_WEBSOCKET_OUTPUT_PAUSED;
                        break;
                    case "OBS_WEBSOCKET_OUTPUT_RESUMED":
                        state = OutputState.OBS_WEBSOCKET_OUTPUT_RESUMED;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                return state.Value;
            }
        }
    }

    public class RecordStateChanged : OutputStateChanged
    {
        [JsonProperty(PropertyName = "outputPath")]
        public string OutputPath { set; get; }

        public RecordStateChanged(JObject body) : base(body)
        {
            JsonConvert.PopulateObject(body.ToString(), this);
        }

        public RecordStateChanged() { }
    }
    public class RecordStateChangedEventArgs : EventArgs
    {
        public RecordStateChanged OutputState { get; }

        public RecordStateChangedEventArgs(RecordStateChanged outputState)
        {
            OutputState = outputState;
        }
    }

    public class ReplayBufferSavedEventArgs : EventArgs
    {
        public string SavedReplayPath { get; }

        public ReplayBufferSavedEventArgs(string savedReplayPath)
        {
            SavedReplayPath = savedReplayPath;
        }
    }
    public class ReplayBufferStateChangedEventArgs : EventArgs
    {
        public OutputStateChanged OutputState { get; }

        public ReplayBufferStateChangedEventArgs(OutputStateChanged outputState)
        {
            OutputState = outputState;
        }
    }
}
