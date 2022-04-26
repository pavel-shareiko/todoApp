using System;
using System.Windows.Forms;

namespace ToDoApp.UI
{
    public static class FormExtension
    {
        public static void ApplyToPanel(this Form newForm, Panel panel)
        {
            if (newForm is null)
            {
                throw new ArgumentNullException(nameof(newForm), "Form is null");
            }

            if (panel is null)
            {
                throw new ArgumentNullException(nameof(panel), "Panel is null");
            }

            if (panel.Controls.Count > 1)
            {
                throw new InvalidOperationException(
                    "Cannot apply form to panel because panel has more than one control");
            }

            if (panel.Controls.Count == 1)
            {
                panel.Controls.RemoveAt(0);
            }

            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;

            panel.Controls.Add(newForm);
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Show();
        }
    }
}