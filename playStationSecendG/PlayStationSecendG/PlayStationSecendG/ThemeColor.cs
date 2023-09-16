using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStationSecendG
{
    public static class ThemeColor
    {
        public static List<string> colorList = new List<string>()
        {   "#2D1082","#381A8C",
            "#4C2FA0","#5D3FB5",
            "#6848C1","#093478",
            "#0874BA","#0E649B",
            "#1B6CA0","#174D6F",
            "#223C4D","#3E5564",
            "#719AB5","#0C83D1",
            "#3F51B5","#009688",
            "#FF5722","#607D8B",
            "#FF9800","#9C27B0",
            "#EA676C","#E41A4A",
            "#5978BB","#018790",
            "#0E3441","#00B0AD",
            "#721D47","#EA4833",
            "#EF937E","#F37521",
            "#A12059","#126881",
            "#8BC240","#364D5B",
            "#C7DC5B","#0094BC",
            "#E4126B","#43B76E",
            "#7BCFE9","#B71C46",
            "#2196F3",
        };



        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }


    }
}
