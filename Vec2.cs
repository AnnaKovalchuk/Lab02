using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Vec2
    {
        public float x, y;

        public static Vec2 fromPolar(float angle)
        {
            float a = angle / 180.0f * (float)Math.PI;
            float x = (float)Math.Cos(a);
            float y = (float)Math.Sin(a);
            return new Vec2(x, y);
        }

        public Vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vec2()
        { 
        
        }

        public static Vec2 operator +(Vec2 a, Vec2 b)
        {
            return new Vec2(a.x + b.x, a.y + b.y);
        }

        public static Vec2 operator -(Vec2 a, Vec2 b)
        {
            return new Vec2(a.x - b.x, a.y - b.y);
        }

        public static Vec2 operator -(Vec2 a, float b)
        {
            return new Vec2(a.x - b, a.y - b);
        }

        public static Vec2 operator *(Vec2 a, float b)
        {
            return new Vec2(a.x * b, a.y * b);
        }

        public float len()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }

        public Vec2 abs()
        {
            float xa = (float)Math.Abs(x);
            float ya = (float)Math.Abs(y);
            return new Vec2(xa, ya);
        }
        
        public Vec2 max(float v)
        {
            return new Vec2((float)Math.Max(x, v), (float)Math.Max(y, v));
        }
    }
}
