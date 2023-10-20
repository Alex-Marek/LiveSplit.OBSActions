using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace LiveSplit.UI.Components
{
    public class RecordingManager
    {
        private OBSWebSocket _obs;

        private TaskCompletionSource<bool> _recordStartedTcs;
        private TaskCompletionSource<bool> _recordStoppedTcs;

        private Queue<Func<Task>> _recordingQueue = new Queue<Func<Task>>();

        private bool _isProcessingRecordingQueue = false;

        private string mostRecentRecordingPath;

        public RecordingManager(OBSWebSocket obs)
        {
            _obs = obs;
            _obs.RecordStateChanged += OnRecordStateChanged;
        }

        public string getMostRecentRecordingPath()
        {
            return this.mostRecentRecordingPath;
        }

        public void QueueStartRecording()
        {
            _recordingQueue.Enqueue(StartRecording);
            ProcessRecordingQueue();
        }

        public void QueueStopRecording()
        {
            _recordingQueue.Enqueue(StopRecording);
            ProcessRecordingQueue();
        }

        public void QueueRenameMostRecentRecording(string newName)
        {
            _recordingQueue.Enqueue(() => RenameMostRecentRecordingAsync(newName));
            ProcessRecordingQueue();
        }

        public void QueueDeleteMostRecentRecording()
        {
            _recordingQueue.Enqueue(() => DeleteMostRecentRecordingAsync());
            ProcessRecordingQueue();
        }

        private async void ProcessRecordingQueue()
        {
            if (_isProcessingRecordingQueue)
                return;

            _isProcessingRecordingQueue = true;

            while (_recordingQueue.Count > 0)
            {
                var command = _recordingQueue.Dequeue();
                await command();

                await Task.Delay(100);
            }

            _isProcessingRecordingQueue = false;
        }

        private async Task StartRecording()
        {
            _recordStartedTcs = new TaskCompletionSource<bool>();
            _obs.StartRecord();
            await _recordStartedTcs.Task;
        }

        private async Task StopRecording()
        {
            _recordStoppedTcs = new TaskCompletionSource<bool>();
            _obs.StopRecord();
            await _recordStoppedTcs.Task;
        }

        private void OnRecordStateChanged(object sender, RecordStateChangedEventArgs args)
        {
            switch (args.OutputState.State)
            {
                case OutputState.OBS_WEBSOCKET_OUTPUT_STARTED:
                    _recordStartedTcs.SetResult(true);
                    break;
                case OutputState.OBS_WEBSOCKET_OUTPUT_STOPPED:
                    _recordStoppedTcs.SetResult(true);
                    if (args.OutputState.OutputPath != null)
                    {
                        this.mostRecentRecordingPath = args.OutputState.OutputPath;
                    }
                    break;
            }
        }

        private Task RenameMostRecentRecordingAsync(string newName)
        {
            return Task.Run(() => RenameMostRecentRecording(newName));
        }

        private void RenameMostRecentRecording(string newName)
        {
            string mostRecentRecording = this.mostRecentRecordingPath;

            string directory = Path.GetDirectoryName(this.mostRecentRecordingPath);
            string newFilePath = Path.Combine(directory, newName);
            if (mostRecentRecording != null)
            {
                try
                {
                    if (File.Exists(mostRecentRecording))
                    {
                        File.Move(mostRecentRecording, newFilePath);
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private Task DeleteMostRecentRecordingAsync()
        {
            return Task.Run(() => DeleteMostRecentRecording());
        }
        private void DeleteMostRecentRecording()
        {
            string mostRecentRecording = this.mostRecentRecordingPath;
            if (mostRecentRecording != null)
            {
                try
                {
                    if (File.Exists(mostRecentRecording))
                    {
                        File.Delete(mostRecentRecording);
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
