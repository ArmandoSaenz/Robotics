using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braccio.Models
{
    public class Posture
    {
        public int Angle1 { set; get; }
        public int Angle2 { set; get; }
        public int Angle3 { set; get; }
        public int Angle4 { set; get; }
        public int Angle5 { set; get; }
        public int Angle6 { set; get; }

        public void SetPosture(int[] posture)
        {
            Angle1 = posture[0];
            Angle2 = posture[1];
            Angle3 = posture[2];
            Angle4 = posture[3];
            Angle5 = posture[4];
            Angle6 = posture[5];
        }
        public int[] GetPosture()
        {
            return new int[] { Angle1, Angle2, Angle3, Angle4, Angle5, Angle6 };
        }
    }
}
