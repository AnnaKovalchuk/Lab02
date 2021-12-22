using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Rectangle : Figure
    {
        float size, half_side;
        public Rectangle()
        {
            
        }

        public override bool test(float x, float y)
        {
            float xmin = pos_x - half_side;
            float ymin = pos_y - half_side;
            float xmax = pos_x + half_side;
            float ymax = pos_y + half_side;
            if (x < xmin || y < ymin) return false;
            if (x > xmax || y > ymax) return false;
            return true;
        }

        public override void draw(Graphics g)
        {
            float x0 = pos_x - half_side;
            float y0 = pos_y - half_side;
            Pen p = new Pen(color, thickness);
            g.DrawRectangle(p, x0, y0, size, size);
        }

        public override void Set(float sz)
        {
            size = sz;
            half_side = sz * 0.5f;
        }
        public override float sdf(Vec2 p)
        {
            Vec2 d = (p - pos).abs() - half_side;

            float inner_d = Math.Min(Math.Max(d.x, d.y), 0.0f);
            float outer_d = d.max(0.0f).len();

            return inner_d + outer_d;
        }
    }
}
