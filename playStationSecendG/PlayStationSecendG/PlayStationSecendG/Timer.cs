using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PlayStationSecendG
{
    public class Timer
    {
        public string timer="";
        
        private int h, m, s;
        public Timer()
        {
            h = 0;
            m = 0;
            s = 0;
        }

        public void IncrementTime()
        {
            s++;

            if (s == 60)
            {
                s = 0;
                m++;

                if (m == 60)
                {
                    m = 0;
                    h++;
                }
            }
        }
        public void decrementTime(ref int h, ref int m, ref int s)
        {
            if (s > 0)
            {
                s--;
            }
            else if (m > 0)
            {
                m--;
                s = 59;
            }
            else if (h > 0)
            {
                h--;
                m = 59;
                s = 59;
            }
        }
        public string GetFormattedTime(ref int h, ref int m, ref int s)
        {
            return string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }
        public string GetFormattedTime()
        {
            return string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }
        public void ResetTime()
        {
            h = 0;
            m = 0;
            s = 0;
        }
        public static void getRoomTime(ref string time,   Label label)
        {
            label.Text = time;
        } 

    }
}
