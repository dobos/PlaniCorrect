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


    }
}
