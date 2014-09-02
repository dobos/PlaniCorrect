using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elte.PlaniCorrect.Lib;

namespace Elte.PlaniCorrect.UI.Forms
{
    public partial class ControlForm : Form
    {
        private Layout layout;

        public ControlForm()
        {
            InitializeComponent();
            InitializeMembers();
        }

        private void InitializeMembers()
        {
            this.layout = new Layout();
        }

        private void OnCommand(object sender, EventArgs e)
        {
            var control = (ToolStripItem)sender;

            if (control.Tag != null && control.Tag is Commands)
            {
                switch ((Commands)control.Tag)
                {
                    case Commands.AddCircle:
                        layout.Lines.Add(new Circle());
                        RefreshLineList();
                        break;
                    case Commands.AddRay:
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private void RefreshLineList()
        {
            lineList.Items.Clear();

            foreach (var line in layout.Lines)
            {
                lineList.Items.Add(CreateLineListItem(line));
            }
        }

        private ListViewItem CreateLineListItem(Line line)
        {
            var li = new ListViewItem()
            {
                Text = line.Name,
                Tag = line
            };

            return li;
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            var f = new Forms.ScreenForm();
            f.Show();
        }

        
    }
}
