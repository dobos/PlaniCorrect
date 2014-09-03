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
        private Control parametersControl;

        public ControlForm()
        {
            InitializeComponent();
            InitializeMembers();
        }

        private void InitializeMembers()
        {
            this.parametersControl = null;
        }

        private void OnCommand(object sender, EventArgs e)
        {
            var control = (ToolStripItem)sender;

            if (control.Tag != null && control.Tag is Commands)
            {
                switch ((Commands)control.Tag)
                {
                    case Commands.AddCircle:
                        Program.Layout.Lines.Add(new Circle());
                        RefreshLineList();
                        break;
                    case Commands.AddRay:
                        Program.Layout.Lines.Add(new Ray());
                        RefreshLineList();
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private void RefreshLineList()
        {
            lineList.Items.Clear();

            foreach (var line in Program.Layout.Lines)
            {
                lineList.Items.Add(CreateLineListItem(line));
            }

            Program.Screen.Picture.Invalidate();
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
            Program.Screen.Show();
        }

        private void lineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parametersControl != null)
            {
                parametersControl.Parent.Controls.Remove(parametersControl);
                parametersControl.Dispose();
                parametersControl = null;
            }

            if (lineList.SelectedIndices.Count > 0)
            {
                var item = lineList.Items[lineList.SelectedIndices[0]].Tag;

                if (item is Circle)
                {
                    var pc = new Controls.CircleParameters()
                    {
                        Circle = (Circle)item
                    };

                    parametersControl = pc;
                }
                else if (item is Ray)
                {
                    var pc = new Controls.RayParameters()
                    {
                        Ray = (Ray)item
                    };

                    parametersControl = pc;
                }

                linePanel.Controls.Add(parametersControl);
            }
        }

        
    }
}
