using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Circle : Figure
    {
        float radius_Squared, diameter, size;

        public Circle() 
        {
        }
        public override bool test(float x, float y)
        {
            Set(size);
            float dx = x - pos_x;
            float dy = y - pos_y;
            if (dx * dx + dy * dy <= radius_Squared) return true;
            return false;
        }

        public override void draw(Graphics g)
        {
            float x0 = pos_x - size;
            float y0 = pos_y - size;
            Pen p = new Pen(color, thickness);
            g.DrawEllipse(p, x0, y0, diameter, diameter);
        }

        public override void Set(float rad)
        {
             size = rad;
             diameter = rad * 2.0f;
             radius_Squared = rad * rad;
        }
        public override float sdf(Vec2 p)
        {
            
            return (pos - p).len()- radius_Squared;
        }

    }
}
