using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace LiveSplit.UI.Components
{
    public class OBSWebSocket
    {
        public event EventHandler<RecordStateChangedEventArgs> RecordStateChanged;
        public event EventHandler<ReplayBufferStateChangedEventArgs> ReplayBufferStateChanged;
        public event EventHandler<ReplayBufferSavedEventArgs> ReplayBufferSaved;

        public bool isIdentified = false;
        private WebSocket obs;
        private string url = null;
        private string password = null;

        public OBSWebSocket()
        {

        }

        public void Connect(string url, string password = null)
        {
            this.url = url;
            if (password != null) { this.password = password; }
            if (url != null)
            {
                this.obs = new WebSocket(url);
                this.obs.ConnectAsync();
                obs.OnMessage += HandleMessage;
            }
        }
        public void Disconnect()
        {
            this.obs.CloseAsync();
        }
        private void SendSimpleRequest(string nameOfRequest)
        {
            if (this.isIdentified == true)
            {
                var msg = CreateMessage(6, nameOfRequest);
                this.obs.Send(msg.ToString());
            }
        }
        public void StartRecord() { SendSimpleRequest("StartRecord"); }
        public void StopRecord() { SendSimpleRequest("StopRecord"); }
        public void StartReplayBuffer() { SendSimpleRequest("StartReplayBuffer"); }
        public void StopReplayBuffer() { SendSimpleRequest("StopReplayBuffer"); }
        public void SaveReplayBuffer() { SendSimpleRequest("SaveReplayBuffer"); }
        private void HandleMessage(object sender, MessageEventArgs e)
        {
            ServerMessage msg = JsonConvert.DeserializeObject<ServerMessage>(e.Data);
            JObject body = msg.Data;

            switch (msg.Op)
            {
                case 0: //Hello Message
                    RespondHello(body);
                    break;
                case 2: //Identified Message
                    this.isIdentified = true;
                    break;
                case 5: // Event Message
                    string eventType = body["eventType"].ToString();
                    Task.Run(() => { ProcessEventType(eventType, body); });
                    break;
            }
        }

        private JObject CreateMessage(int operationCode, string requestType, JObject additionalFields = null)
        {
            string messageID = Guid.NewGuid().ToString();
            JObject message = new JObject()
            {
                {"op", operationCode }
            };

            JObject data = new JObject();

            switch (operationCode)
            {
                case 6:
                    data.Add("requestType", requestType);
                    data.Add("requestId", messageID);
                    data.Add("requestData", additionalFields);
                    break;
            }

            if (additionalFields != null)
            {
                data.Merge(additionalFields);
            }
            message.Add("d", data);
            return message;
        }

        private void IdentifyRespond(string password, OBSAuthInfo authInfo = null)
        {
            var requestFields = new JObject
            {
                { "rpcVersion", 1 }
            };

            if (authInfo != null)
            {
                string secret = GenerateSHA256Base64(password + authInfo.PasswordSalt);
                string authResponse = GenerateSHA256Base64(secret + authInfo.Challenge);
                requestFields.Add("authentication", authResponse);
            }
            requestFields.Add("EventSubscriptions", 64);
            var res = CreateMessage(1, null, requestFields);
            this.obs.Send(res.ToString());
        }

        private void RespondHello(JObject message)
        {
            OBSAuthInfo authInfo = null;
            if (message.ContainsKey("authentication"))
            {
                authInfo = new OBSAuthInfo((JObject)message["authentication"]);
            }

            IdentifyRespond(this.password, authInfo);
        }

        private static string GenerateSHA256Base64(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(bytes);

                return Convert.ToBase64String(hashBytes);
            }
        }

        private void ProcessEventType(string eventType, JObject body)
        {
            body = (JObject)body["eventData"];
            switch (eventType)
            {
                case nameof(RecordStateChanged):
                    RecordStateChanged?.Invoke(this, new RecordStateChangedEventArgs(new RecordStateChanged(body)));
                    break;

                case nameof(ReplayBufferStateChanged):
                    ReplayBufferStateChanged?.Invoke(this, new ReplayBufferStateChangedEventArgs(new OutputStateChanged(body)));
                    break;

                case nameof(ReplayBufferSaved):
                    ReplayBufferSaved?.Invoke(this, new ReplayBufferSavedEventArgs((string)body["savedReplayPath"]));
                    break;
            }
        }
    }
}
