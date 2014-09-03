using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elte.PlaniCorrect.Lib;

namespace Elte.PlaniCorrect.UI.Controls
{
    public partial class CircleParameters : UserControl
    {
        private Circle circle;

        public Circle Circle
        {
            get { return circle; }
            set { circle = value; }
        }

        public CircleParameters()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            bool ctrl = (Control.ModifierKeys & Keys.Control) == Keys.Control;
            bool shift = (Control.ModifierKeys & Keys.Shift) == Keys.Shift;

            int increment = 1;
            
            if (shift)
            {
                increment = 10;
            }

            if (ctrl)
            {
                increment = 100;
            }

            switch (((Commands)((Button)sender).Tag))
            {
                case Commands.RadiusUp:
                    circle.Radius += increment;
                    break;
                case Commands.RadiusDown:
                    circle.Radius -= increment;
                    break;
                case Commands.WidthUp:
                    circle.Width += increment;
                    break;
                case Commands.WidthDown:
                    circle.Width -= increment;
                    break;
                default:
                    throw new NotImplementedException();
            }

            Program.Screen.Picture.Invalidate();
        }

        private void UpdateTextBox(TextBox textBox, int increment)
        {
            textBox.Text = (int.Parse(textBox.Text) + increment).ToString();
        }
    }
}
