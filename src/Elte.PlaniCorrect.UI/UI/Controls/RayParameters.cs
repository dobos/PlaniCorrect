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
    public partial class RayParameters : UserControl
    {
        private Ray ray;

        public Ray Ray
        {
            get { return ray; }
            set { ray = value; }
        }

        public RayParameters()
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
                    ray.Radius += increment;
                    break;
                case Commands.RadiusDown:
                    ray.Radius -= increment;
                    break;
                case Commands.AngleUp:
                    ray.Angle += increment * 0.1f;
                    break;
                case Commands.AngleDown:
                    ray.Angle -= increment * 0.1f;
                    break;
                case Commands.WidthUp:
                    ray.Width1 += increment;
                    break;
                case Commands.WidthDown:
                    ray.Width1 -= increment;
                    break;
                case Commands.Width2Up:
                    ray.Width2 += increment;
                    break;
                case Commands.Width2Down:
                    ray.Width2 -= increment;
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
