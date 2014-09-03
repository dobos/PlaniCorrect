using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elte.PlaniCorrect.UI.Forms
{
    public partial class ScreenForm : Form
    {
        public PictureBox Picture
        {
            get { return picture; }
        }

        public ScreenForm()
        {
            InitializeComponent();
        }

        private void ScreenForm_Load(object sender, EventArgs e)
        {
            var rect = Screen.GetBounds(this);
            this.Location = rect.Location;
            this.Size = rect.Size;
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            var bounds = e.Graphics.VisibleClipBounds;

            e.Graphics.Clear(Color.White);

            e.Graphics.TranslateTransform(bounds.Width / 2, bounds.Height / 2);

            foreach (var line in Program.Layout.Lines)
            {
                line.Draw(e.Graphics, Program.Layout.Center);
            }
        }


    }
}
