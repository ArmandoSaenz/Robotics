using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private int Convert2Int(object value)
        {
            if(value is int)
            {
                return (int)value;
            }
            else if(value is string)
            {
                return int.Parse(value.ToString());
            }
            return 0;
        }
        public void SetPosture(DataGridViewRow posture)
        {

            Angle1 = Convert2Int(posture.Cells[0].Value);
            Angle2 = Convert2Int(posture.Cells[1].Value);
            Angle3 = Convert2Int(posture.Cells[2].Value);
            Angle4 = Convert2Int(posture.Cells[3].Value);
            Angle5 = Convert2Int(posture.Cells[4].Value);
            Angle6 = Convert2Int(posture.Cells[5].Value);
        }
    }
}
