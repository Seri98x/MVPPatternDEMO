using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVPPatternDEMO.CustomControls
{
    public partial class PlaceholderTextBox : TextBox
    {
        public string PlaceholderText { get; set; } = "";
        public Color PlaceholderColor { get; set; } = Color.Gray;

        public PlaceholderTextBox()
        {
            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Text = PlaceholderText;
            this.ForeColor = PlaceholderColor;
        }


        protected override void OnEnter(EventArgs e)
        {
            if (this.Text == PlaceholderText)
            {
                this.Text = "";
                this.ForeColor = this.ForeColor; // Change text color back to original
            }

            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                this.Text = PlaceholderText;
                this.ForeColor = this.PlaceholderColor; // Change text color to placeholder color
            }

            base.OnLeave(e);
        }

 
        }
    }

