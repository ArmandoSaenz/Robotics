using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Convertions
    {
        static public double R2D(double radians) => radians * 180 / Math.PI;
        static public double D2R(double degrees) => degrees * Math.PI / 180;
    }
}
