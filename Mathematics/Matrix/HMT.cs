using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Matrix
{
    public class HMT
    {
        private double[,] matrix = new double[4, 4]
        {
            { 1, 0, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 0, 1, 0 },
            { 0, 0, 0, 1 }
        };
        public double[,] Matrix => matrix;
        public HMT() { }
        public HMT(HMT A, HMT B) 
        {
            matrix = Mathematics.Matrix.Operations.Product(A.Matrix, B.Matrix);
        }
        public HMT(List<HMT> items)
        {
            foreach (HMT item in items)
            {
                matrix = Mathematics.Matrix.Operations.Product(matrix, item.Matrix);                   
            }
        }
        public double[,] RotateZ(double angle)
        {
            double[,] rotate = new double[4, 4]
                {
                    { Math.Cos(angle), -Math.Sin(angle), 0, 0},
                    { Math.Sin(angle), Math.Cos(angle), 0, 0},
                    { 0, 0, 1, 0},
                    { 0, 0, 0, 1},

                };
            matrix = Mathematics.Matrix.Operations.Product(matrix, rotate);
            return matrix;
        }
        public double[,] RotateY(double angle)
        {
            double[,] rotate = new double[4, 4]
                {
                    { Math.Cos(angle), 0, Math.Sin(angle), 0},
                    { 0, 1, 0, 0},
                    { -Math.Sin(angle), 0, Math.Cos(angle), 0},
                    { 0, 0, 0, 1},

                };
            matrix = Mathematics.Matrix.Operations.Product(matrix, rotate);
            return matrix;
        }
        public double[,] RotateX(double angle)
        {
            double[,] rotate = new double[4, 4]
                {
                    { 1, 0, 0, 0},
                    { 0, Math.Cos(angle), -Math.Sin(angle), 0},
                    { 0, Math.Sin(angle), Math.Cos(angle), 0},
                    { 0, 0, 0, 1},

                };
            matrix = Mathematics.Matrix.Operations.Product(matrix, rotate);
            return matrix;
        }

        public double[,] Translate(double x, double y, double z)
        {
            matrix[0, 3] += x;
            matrix[1, 3] += y;
            matrix[2, 3] += z;
            return matrix;
        }

        public double[,] DH(double a, double alpha, double d, double theta)
        {
            matrix = new double[,]
                {
                    {Math.Cos(theta), -Math.Sin(theta), 0, a },
                    {Math.Sin(theta)*Math.Cos(alpha), Math.Cos(theta)*Math.Cos(alpha), -Math.Sin(alpha), -Math.Sin(alpha)*d },
                    {Math.Sin(theta)*Math.Sin(alpha), Math.Cos(theta)*Math.Sin(alpha), Math.Cos(alpha), Math.Cos(alpha)*d },
                    {0,0,0,1 }
                };
            return matrix;
        }
    }
}
