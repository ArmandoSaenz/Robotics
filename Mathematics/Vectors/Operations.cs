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
        static public float PointProductOpt(List<float[]> x)
        {
            if (!x.TrueForAll(arg => arg.GetLength(1) == 2))
            {
                string msg = "The matrix columns number don't match";
                throw new Exception(msg);
            }
            return x.Sum(arg => arg[0] * arg[1]);
        }

        static public float[] CrossProduct(float[] x, float[] y)
        {
            if (x.Length != 3 || y.Length != 3)
            {
                string msg = "The vectors dimension don't match";
                throw new Exception(msg);
            }
            return new float[] { x[1] * y[2] - x[2] * y[1], x[2] * y[1] - x[0] * y[2], x[0] * y[1] - x[1] * y[0] };
        }

        static public float L2Norm(float[] x)
        {
            float result = 0;
            foreach (float xi in x)
                result += xi * xi;
            result = (float)Math.Sqrt(result);
            return result;
        }
        static public float[] Unitary(float[] x)
        {
            int maxIndex = x.Length;
            float[] xuni = new float[maxIndex];
            x.CopyTo(xuni, 0);
            float norm = L2Norm(x);
            for (int i = 0; i < maxIndex; ++i)
                xuni[i] /= norm;
            return xuni;
        }
        static public float[] UnitaryOpt(float[] x)
        {
            float norm = L2Norm(x);
            Func<float, float> Product = factor => factor * (1/norm);
            return Array.ConvertAll(x, new Converter<float, float>(Product));
        }

        static public float[] ScalarProduct(float[] x, float a)
        {
            int maxIndex = x.Length;
            float[] y = new float[maxIndex];
            x.CopyTo(y, 0);
            for (int i = 0; i < maxIndex; ++i)
                y[i] *= a;
            return y;
        }

        static public float[] ScalarProducOpt(float[] x, float a)
        {
            Func<float, float> Product = factor => factor * a;
            return Array.ConvertAll(x, new Converter<float, float>(Product));
        }
    }
}
