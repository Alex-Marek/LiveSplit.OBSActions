using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    public class OBSActionsComponent : LogicComponent, IDeactivatableComponent
    {

        // Done with the assistance of this tutorial: https://gist.github.com/TheSoundDefense/cf85fd68ae582faa5f1cc95f18bba4ec
        // Minor changes:
        // Implement LogicComponent, and IDeactivatableComponent instead of IComponent because this component doesn't need to display anything
        // Instead of adding LiveSplit.Core and UpdateManager as projects to the solution add the dlls as References (Resolved NuGet issue for me)
        public OBSActionsSettings Settings { get; set; }
        protected LiveSplitState CurrentState { get; set; }

        public bool Activated { get; set; }

        public override string ComponentName => "OBS Actions";

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
        }

        public override void Dispose()
        {
            CurrentState.OnStart -= state_OnStart;
            CurrentState.OnSplit -= state_OnSplitChange;
            CurrentState.OnSkipSplit -= state_OnSplitChange;
            CurrentState.OnUndoSplit -= state_OnSplitChange;
            CurrentState.OnReset -= state_OnReset;
        }

        void state_OnStart(object sender, EventArgs e)
        {

        }

        void state_OnSplitChange(object sender, EventArgs e)
        {

        }

        void state_OnReset(object sender, TimerPhase e)
        {

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

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode){ }

        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();
    }
}