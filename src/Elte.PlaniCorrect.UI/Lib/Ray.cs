﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace Elte.PlaniCorrect.Lib
{
    public class Ray : Line
    {
        private float angle;
        private float radius;
        private float width1;
        private float width2;

        public float Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public float Width1
        {
            get { return width1; }
            set { width1 = value; }
        }

        public float Width2
        {
            get { return width2; }
            set { width2 = value; }
        }

        public Ray()
        {
            InitializeMembers(new StreamingContext());
        }

        public Ray(Ray old)
        {
            CopyMembers(old);
        }

        [OnDeserializing]
        private void InitializeMembers(StreamingContext context)
        {
            this.angle = 15;
            this.radius = 100;
            this.width1 = 20;
            this.width2 = 10;
        }

        private void CopyMembers(Ray old)
        {
            this.angle = old.angle;
            this.radius = old.radius;
            this.width1 = old.width1;
            this.width2 = old.width2;
        }

        public override object Clone()
        {
            return new Ray(this);
        }

        public override void Draw(System.Drawing.Graphics g, System.Drawing.PointF center)
        {
            var pp = new PointF[4];

            var cosa = Math.Cos(angle / 180.0 * Math.PI);
            var sina = Math.Sin(angle / 180.0 * Math.PI);

            pp[0].X = (float)(radius * cosa + width1 * sina / 2);
            pp[0].Y = (float)(radius * sina - width1 * cosa / 2);
            pp[1].X = (float)(radius * cosa - width1 * sina / 2);
            pp[1].Y = (float)(radius * sina + width1 * cosa / 2);

            var r2 = g.VisibleClipBounds.Width;
            pp[2].X = (float)(r2 * cosa - width2 * sina / 2);
            pp[2].Y = (float)(r2 * sina + width2 * cosa / 2);
            pp[3].X = (float)(r2 * cosa + width2 * sina / 2);
            pp[3].Y = (float)(r2 * sina - width2 * cosa / 2);
            

            var path = new GraphicsPath();
            path.AddPolygon(pp);
            g.FillPath(Brushes.Black, path);
        }
    }
}
