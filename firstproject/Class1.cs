using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class point
    {
            public int x;
            public int y;
        public override string ToString()
        {
            return $"({x},{y})";
            
        }
        public override bool Equals(object? obj)
        {
            return x== ((point)obj).x && y== ((point)obj).y ;
        }
    }
    class point3D : point
    {
        public int z;
    }
}
