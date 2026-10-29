using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComLabManager.UI.Views.Controls
{
    // A thin bar telling the user a page was opened pre-filtered, with a link to clear it
    public class FilterBanner : UserControl
    {
        private readonly Label lblDescription;
        private readonly LinkLabel lnkShowAll;

        public event EventHandler? Cleared;

        public FilterBanner()
        {
            lblDescription = new Label
            {
                Dock = DockStyle.Fill,
                ForeColor = Color.FromArgb(30, 41, 59),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };
            lnkShowAll = new LinkLabel
            {
                Dock = DockStyle.Right,
                Width = 110,
                Text = "Show all",
                TextAlign = ContentAlignment.MiddleCenter
            };
            lnkShowAll.LinkClicked += (s, e) =>
            {
                Hide();
                Cleared?.Invoke(this, EventArgs.Empty);
            };

            Controls.Add(lblDescription);
            Controls.Add(lnkShowAll);

            BackColor = Color.FromArgb(255, 243, 205);
            Dock = DockStyle.Top;
            Height = 34;
            Visible = false;
        }

        public void ShowFilter(string description)
        {
            lblDescription.Text = $"Showing: {description}";
            Show();
        }
    }
}
