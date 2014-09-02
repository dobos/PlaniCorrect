using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Elte.PlaniCorrect.Lib
{
    class Layout
    {
        private List<Line> lines;

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
            this.lines = new List<Line>();
        }

        private void CopyMembers(Layout old)
        {
            this.lines = new List<Line>();
            foreach (var line in old.lines)
            {
                this.lines.Add((Line)line.Clone());
            }
        }
    }
}
