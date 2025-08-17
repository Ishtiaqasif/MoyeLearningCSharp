using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    internal static class MoyesGeometry
    {
        public static (float,float,float) SquareAreaPerimeterDiagonal(float x)
        {
            float area = 0;
            float perimeter = 0;
            float diagonal=0;

            area = x * x;
            perimeter = 4 * x;
            diagonal = x * (float)Math.Sqrt(2);

            return (area, perimeter, diagonal);
        }
        
    }
}
