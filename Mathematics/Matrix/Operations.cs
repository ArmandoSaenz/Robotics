using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Matrix
{
    public class Operations
    {
        static public double[,] Product(double[,] A, double[,] B)
        {
            if(A.GetLength(1) != B.GetLength(0))
            {
                throw new ArgumentException("Dimensions do not match");
            }
            int rows = A.GetLength(0);
            int cols = B.GetLength(1);
            int items = A.GetLength(1);
            double[,] C = new double[rows, cols];
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                    for (int k = 0; k < items; ++k)
                    {
                        C[i, j] += A[i, k] * B[k, j]; 
                    }
            return C;
        }

    }
}
