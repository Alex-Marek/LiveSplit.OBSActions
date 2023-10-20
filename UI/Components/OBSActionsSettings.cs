using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class OBSActionsSettings : UserControl
    {
        public bool startRecording { get; set; }
        public bool stopRecording { get; set; }
        public bool deleteRecordings { get; set; }

        public bool startReplayBuffer { get; set; }
        public bool resetReplayBuffer { get; set; }
        public bool goldReplay { get; set; }

        public string webSocketIp { get; set; }
        public string webSocketPassword { get; set; }

        public LayoutMode Mode { get; set; }

        public OBSActionsSettings()
        {
            InitializeComponent();
            startRecording = false;
            stopRecording = false;
            deleteRecordings = false;
            startReplayBuffer = false;
            resetReplayBuffer = false;
            goldReplay = false;
        }

        private void OBSActionsSettings_Load(object sender, EventArgs e)
        { 
            chkStartRecording.Enabled = true;
            chkStartRecording.DataBindings.Clear();
            chkStartRecording.DataBindings.Add("Checked", this, "startRecording", false, DataSourceUpdateMode.OnPropertyChanged);

            chkStopRecording.Enabled = true;
            chkStopRecording.DataBindings.Clear();
            chkStopRecording.DataBindings.Add("Checked", this, "stopRecording", false, DataSourceUpdateMode.OnPropertyChanged);

            chkDeleteRecording.Enabled = true;
            chkDeleteRecording.DataBindings.Clear();
            chkDeleteRecording.DataBindings.Add("Checked", this, "deleteRecordings", false, DataSourceUpdateMode.OnPropertyChanged);

            chkGoldReplay.Enabled = true;
            chkGoldReplay.DataBindings.Clear();
            chkGoldReplay.DataBindings.Add("Checked", this, "goldReplay", false, DataSourceUpdateMode.OnPropertyChanged);

            chkReplayStart.Enabled = true;
            chkReplayStart.DataBindings.Clear();
            chkReplayStart.DataBindings.Add("Checked", this, "startReplayBuffer", false, DataSourceUpdateMode.OnPropertyChanged);

            chkReplayResetSplit.Enabled = true;
            chkReplayResetSplit.DataBindings.Clear();
            chkReplayResetSplit.DataBindings.Add("Checked", this, "resetReplayBuffer", false, DataSourceUpdateMode.OnPropertyChanged);

            txtIP.Enabled = true;
            txtIP.DataBindings.Clear();
            txtIP.DataBindings.Add("Text", this, "webSocketIP");

            txtPassword.Enabled = true;
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", this, "webSocketPassword");
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                SettingsHelper.CreateSetting(document, parent, "startRecording", startRecording) ^
                SettingsHelper.CreateSetting(document, parent, "stopRecording", stopRecording) ^
                SettingsHelper.CreateSetting(document, parent, "deleteRecordings", deleteRecordings) ^
                SettingsHelper.CreateSetting(document, parent, "startReplayBuffer", startReplayBuffer) ^
                SettingsHelper.CreateSetting(document, parent, "resetReplayBuffer", resetReplayBuffer) ^
                SettingsHelper.CreateSetting(document, parent, "goldReplay", goldReplay) ^
                SettingsHelper.CreateSetting(document, parent, "webSocketIP", webSocketIp) ^
                SettingsHelper.CreateSetting(document, parent, "webSocketPassword", webSocketPassword);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            startRecording = SettingsHelper.ParseBool(element["startRecording"], false);
            stopRecording = SettingsHelper.ParseBool(element["stopRecording"], false);
            deleteRecordings = SettingsHelper.ParseBool(element["deleteRecordings"], false);
            startReplayBuffer = SettingsHelper.ParseBool(element["startReplayBuffer"], false);
            resetReplayBuffer = SettingsHelper.ParseBool(element["resetReplayBuffer"], false);
            goldReplay = SettingsHelper.ParseBool(element["goldReplay"], false);
            webSocketIp = SettingsHelper.ParseString(element["webSocketIP"]);
            webSocketPassword = SettingsHelper.ParseString(element["webSocketPassword"]);
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
