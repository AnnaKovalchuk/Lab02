using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Figure
    {
        public float pos_x, pos_y;
        public int thickness;
        public Color color = Color.Black;
        public bool colTrue;
        public bool selected;
        public RGB clr;
        public Vec2 pos;
        public Figure()
        {
            clr = RGB.getRandom();
            pos = new Vec2(pos_x, pos_y);
        }
        virtual public bool test(float x, float y)
        {
            return false;
        }

        virtual public void draw(Graphics g)
        {

        }
        virtual public void Set(float sz)
        {

        }

        virtual public float sdf(Vec2 p)
        {
            return 0.0f;
        }
    }
}
