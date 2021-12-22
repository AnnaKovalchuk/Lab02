using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Triangle : Figure
    {
        float size;
        public Triangle()
        {
        }
        public PointF ptest = new PointF();
        public override bool test(float x, float y)
        {

            
            float xmin = pos_x - size;
            float ymin = pos_y - size;
            float xmax = pos_x;
            float ymax = pos_y;
            
            if (x < xmin || y < ymin) return false;
            if (x > xmax || y > ymax) return false;
            //if (x + xmin > (y / Math.Sqrt(y)) + ymin) return false;
            return true;
        }
        public PointF[] p = new PointF[3];
        public override void draw(Graphics g)
        {
            p[0].X = pos_x;
            p[0].Y = pos_y;

            p[1].X = (float)(pos_x + size * -Math.Cos(0));
            p[1].Y = (float)(pos_y + size * -Math.Sin(0));

            p[2].X = (float)(pos_x + size * -Math.Cos(Math.PI / 3));
            p[2].Y = (float)(pos_y + size * -Math.Sin(Math.PI / 3));
            Pen pen = new Pen(color, thickness);
            g.DrawPolygon(pen, p);
        }
        public override void Set(float sz)
        {
            size = sz;
        }
        public override float sdf(Vec2 p)
        {
            Vec2 d = (p - pos).abs() - size;

            float inner_d = Math.Min(Math.Max(d.x, d.y), 0.0f);
            float outer_d = d.max(0.0f).len();

            return inner_d + outer_d;
        }


    }
}