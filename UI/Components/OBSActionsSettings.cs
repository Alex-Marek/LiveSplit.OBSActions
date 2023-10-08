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

        public bool goldReplay { get; set; }

        public LayoutMode Mode { get; set; }

        public OBSActionsSettings()
        {
            InitializeComponent();
            startRecording = false;
            stopRecording = false;
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

            chkGoldReplay.Enabled = true;
            chkGoldReplay.DataBindings.Clear();
            chkGoldReplay.DataBindings.Add("Checked", this, "goldReplay", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                SettingsHelper.CreateSetting(document, parent, "startRecording", startRecording) ^
                SettingsHelper.CreateSetting(document, parent, "stopRecording", stopRecording) ^
                SettingsHelper.CreateSetting(document, parent, "goldReplay", goldReplay);
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
            goldReplay = SettingsHelper.ParseBool(element["goldReplay"], false);
        }
    }
}
