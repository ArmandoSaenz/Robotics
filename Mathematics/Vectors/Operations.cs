using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Vectors
{
    public class Operations
    {
        static public float PointProduct(float[] x, float[] y)
        {
            if (x.Length != y.Length)
            {
                string msg = "The vectors dimension don't match";
                throw new Exception(msg);
            }
            float product = 0;
            int maxIndex = x.Length;
            for (int i = 0; i < maxIndex; ++i)
            {
                product += x[i] * y[i];
            }
            return product;
        }
    }
}
