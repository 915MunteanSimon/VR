using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_rt
{
    public abstract class Geometry
    {
        public Color Color { get; set; }
        public Material Material { get; set; }

        public Geometry(Material material, Color color)
        {
            Material = material;
            Color = color;
        }

        public abstract Intersection GetIntersection(Line line, double minDist, double maxDist);

        public abstract Vector Normal(Vector v);
    }
}
