using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab01
{
    internal class RGB
    {
         float r, g, b;

        public static RGB getRandom()
        {
            Random rnd = new Random();
            float r = (float)rnd.NextDouble();
            float g = (float)rnd.NextDouble();
            float b = (float)rnd.NextDouble();
            return new RGB(r, g, b);
        }

        public RGB()
        {

        }

        public RGB(float x)
        {
            this.r = x;
            this.g = x;
            this.b = x;
        }

        public RGB(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static RGB operator +(RGB a, RGB b)
        {
            return new RGB(a.r + b.r, a.g + b.g, a.b + b.b);
        }

        public static RGB operator *(RGB a, float b)
        {
            return new RGB(a.r * b, a.g * b, a.b * b);
        }

        public Color getColor()
        {
            int cr = (int)(r * 255.0f);
            int cg = (int)(g * 255.0f);
            int cb = (int)(b * 255.0f);
            cr = Math.Min(Math.Max(cr, 0), 255);
            cg = Math.Min(Math.Max(cg, 0), 255);
            cb = Math.Min(Math.Max(cb, 0), 255);
            return Color.FromArgb(cr, cg, cb);
        }
    }
}
