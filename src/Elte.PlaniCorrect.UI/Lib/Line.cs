using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace Elte.PlaniCorrect.Lib
{
    public abstract class Line : ICloneable
    {
        private string name;
        private Color color;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        protected Line()
        {
            InitializeMembers(new StreamingContext());
        }

        protected Line(Line old)
        {
            CopyMembers(old);
        }

        [OnDeserializing]
        private void InitializeMembers(StreamingContext context)
        {
            this.name = "New Line";
            this.color = Color.Black;
        }

        private void CopyMembers(Line old)
        {
            this.name = old.Name + " - Copy";
            this.color = old.color;
        }

        public abstract object Clone();

        public abstract void Draw(Graphics g, PointF center);
    }
}
