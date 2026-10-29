using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ComLabManager.UI.Views.Controls
{
    // A clickable dashboard metric: accent strip, big value, and a title underneath
    public class KpiCard : UserControl
    {
        private static readonly Color NormalBackColor = Color.White;
        private static readonly Color HoverBackColor = Color.FromArgb(241, 245, 249);

        private readonly Panel pnlAccent;
        private readonly Label lblValue;
        private readonly Label lblTitle;

        public KpiCard()
        {
            pnlAccent = new Panel { Dock = DockStyle.Left, Width = 5, BackColor = SystemColors.Highlight };
            lblValue = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "0"
            };
            lblTitle = new Label
            {
                Dock = DockStyle.Bottom,
                Height = 30,
                ForeColor = Color.FromArgb(71, 85, 105),
                TextAlign = ContentAlignment.TopCenter,
                Text = "Metric"
            };

            Controls.Add(lblValue);
            Controls.Add(lblTitle);
            Controls.Add(pnlAccent);

            BackColor = NormalBackColor;
            Cursor = Cursors.Hand;
            Margin = new Padding(6);

            // The whole card is one click target, including its labels
            foreach (Control child in Controls)
            {
                child.Click += (s, e) => OnClick(e);
                child.MouseEnter += (s, e) => SetHover(true);
                child.MouseLeave += (s, e) => SetHover(ClientRectangle.Contains(PointToClient(MousePosition)));
            }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        // Filled in at runtime from the dashboard metrics, so the designer doesn't save it
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Value
        {
            get => lblValue.Text;
            set => lblValue.Text = value;
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color AccentColor
        {
            get => pnlAccent.BackColor;
            set => pnlAccent.BackColor = value;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            SetHover(true);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            SetHover(ClientRectangle.Contains(PointToClient(MousePosition)));
        }

        private void SetHover(bool hovering)
        {
            BackColor = hovering ? HoverBackColor : NormalBackColor;
        }
    }
}
