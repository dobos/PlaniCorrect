using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace Elte.PlaniCorrect.Lib
{
    class Circle : Line
    {
        private float radius;
        private float width;

        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        public Circle()
        {
            InitializeMembers(new StreamingContext());
        }

        public Circle(Circle old)
        {
            CopyMembers(old);
        }

        [OnDeserializing]
        private void InitializeMembers(StreamingContext context)
        {
            this.radius = 100;
            this.width = 10;
        }

        private void CopyMembers(Circle old)
        {
            this.radius = old.radius;
            this.width = old.width;
        }

        public override object Clone()
        {
            return new Circle(this);
        }

        public override void Draw(System.Drawing.Graphics g, System.Drawing.PointF center)
        {
            var path = new GraphicsPath();

            path.AddEllipse(center.X, center.Y, 2 * radius, 2 * radius);
            path.AddEllipse(center.X, center.Y, 2 * (radius + width), 2 * (radius + width));
        }
    }
}
