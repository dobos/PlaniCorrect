using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;

namespace Elte.PlaniCorrect.Lib
{
    class Layout
    {
        private PointF center;
        private List<Line> lines;

        public PointF Center
        {
            get { return center; }
            set { center = value; }
        }

        public List<Line> Lines
        {
            get { return lines; }
        }

        public Layout()
        {
            InitializeMembers(new StreamingContext());
        }

        public Layout(Layout old)
        {
            CopyMembers(old);
        }

        [OnDeserializing]
        private void InitializeMembers(StreamingContext context)
        {
            this.center = new PointF(0, 0);
            this.lines = new List<Line>();
        }

        private void CopyMembers(Layout old)
        {
            this.center = old.center;
            this.lines = new List<Line>();
            foreach (var line in old.lines)
            {
                this.lines.Add((Line)line.Clone());
            }
        }
    }
}
