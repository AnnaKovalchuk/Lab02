using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Ray
    {
        public Vec2 org;
        public Vec2 dir;

        public Ray(Vec2 org, Vec2 dir)
        {
            this.org = org;
            this.dir = dir;
        }

        public Vec2 pointAtDistance(float t)
        {
            return org + dir * t;
        }
    }
}
