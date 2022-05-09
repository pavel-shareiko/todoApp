using System;
using System.Windows.Forms;

namespace ToDoApp.UI
{
    public static class FormExtension
    {
        public static void ApplyToPanel(this UserControl userControl, Panel panel, bool saveToParentTag = true)
        {
            if (userControl is null)
            {
                throw new ArgumentNullException(nameof(userControl), "Form is null");
            }

            if (panel is null)
            {
                throw new ArgumentNullException(nameof(panel), "Panel is null");
            }

            if (panel.Controls is null)
            {
                throw new ArgumentNullException(nameof(panel), "Panel controls are null");
            }

            if (panel.Controls.Count > 1)
            {
                throw new InvalidOperationException(
                    "Cannot apply the form to the panel because panel has more than one control");
            }

            if (panel.Controls.Count == 1)
            {
                panel.Controls.RemoveAt(0);
            }

            userControl.Dock = DockStyle.Fill;
            panel.Controls.Add(userControl);
            userControl.Visible = true;

            if (saveToParentTag)
            {
                panel.Tag = userControl;
            }

            userControl.Show();
        }

        public static void AddToPanel(this UserControl userControl, Panel panel)
        {
            if (userControl is null)
            {
                throw new ArgumentNullException(nameof(userControl), "Form is null");
            }

            if (panel is null)
            {
                throw new ArgumentNullException(nameof(panel), "Panel is null");
            }

            userControl.Location = panel.Location;
        }
    }
}