using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terminal.String;
using static Terminal.TerminalColor;

namespace Terminal.Color
{
    public static class Color
    {
        private static IEnumerable<int> SolveRgb(string rgb)
        {
            string[] rgb_handle = rgb.Split(',');
            for (int i = 0; i < rgb_handle.Length; i++)
            {
                yield return int.Parse(rgb_handle[i].Trim());
            }
        }
        public static string MakeColored(this string text,string rgb)
        {
            int[] rgbval = new int[3];
            int f = 0;
            foreach (int a in SolveRgb(rgb))
            {
                rgbval[f] = a;
                f++;
            }
            return ($"\x1b[38;2;{rgbval[0]};{rgbval[1]};{rgbval[2]}m{text}\x1b[0m");
        }
        public static string AliceBlue { get; private set; } = "240, 248, 255";
        public static string AntiqueWhite { get; private set; } = "250, 235, 215";
        public static string Aqua { get; private set; } = "0, 255, 255";
        public static string Aquamarine { get; private set; } = "127, 255, 212";
        public static string Azure { get; private set; } = "240, 255, 255";
        public static string Beige { get; private set; } = "245, 245, 220";
        public static string Bisque { get; private set; } = "255, 228, 196";
        public static string Black { get; private set; } = "0, 0, 0";
        public static string BlanchedAlmond { get; private set; } = "255, 235, 205";
        public static string Blue { get; private set; } = "0, 0, 255";
        public static string BlueViolet { get; private set; } = "138, 43, 226";
        public static string Brown { get; private set; } = "165, 42, 42";
        public static string BurlyWood { get; private set; } = "222, 184, 135";
        public static string CadetBlue { get; private set; } = "95, 158, 160";
        public static string Chartreuse { get; private set; } = "127, 255, 0";
        public static string Chocolate { get; private set; } = "210, 105, 30";
        public static string Coral { get; private set; } = "255, 127, 80";
        public static string CornflowerBlue { get; private set; } = "100, 149, 237";
        public static string Cornsilk { get; private set; } = "255, 248, 220";
        public static string Crimson { get; private set; } = "220, 20, 60";
        public static string Cyan { get; private set; } = "0, 255, 255";
        public static string DarkBlue { get; private set; } = "0, 0, 139";
        public static string DarkCyan { get; private set; } = "0, 139, 139";
        public static string DarkGoldenrod { get; private set; } = "184, 134, 11";
        public static string DarkGray { get; private set; } = "169, 169, 169";
        public static string DarkGreen { get; private set; } = "0, 100, 0";
        public static string DarkKhaki { get; private set; } = "189, 183, 107";
        public static string DarkMagenta { get; private set; } = "139, 0, 139";
        public static string DarkOliveGreen { get; private set; } = "85, 107, 47";
        public static string DarkOrange { get; private set; } = "255, 140, 0";
        public static string DarkOrchid { get; private set; } = "153, 50, 204";
        public static string DarkRed { get; private set; } = "139, 0, 0";
        public static string DarkSalmon { get; private set; } = "233, 150, 122";
        public static string DarkSeaGreen { get; private set; } = "143, 188, 139";
        public static string DarkSlateBlue { get; private set; } = "72, 61, 139";
        public static string DarkSlateGray { get; private set; } = "47, 79, 79";
        public static string DarkTurquoise { get; private set; } = "0, 206, 209";
        public static string DarkViolet { get; private set; } = "148, 0, 211";
        public static string DeepPink { get; private set; } = "255, 20, 147";
        public static string DeepSkyBlue { get; private set; } = "0, 191, 255";
        public static string DimGray { get; private set; } = "105, 105, 105";
        public static string DodgerBlue { get; private set; } = "30, 144, 255";
        public static string Firebrick { get; private set; } = "178, 34, 34";
        public static string FloralWhite { get; private set; } = "255, 250, 240";
        public static string ForestGreen { get; private set; } = "34, 139, 34";
        public static string Fuchsia { get; private set; } = "255, 0, 255";
        public static string Gainsboro { get; private set; } = "220, 220, 220";
        public static string GhostWhite { get; private set; } = "248, 248, 255";
        public static string Gold { get; private set; } = "255, 215, 0";
        public static string Goldenrod { get; private set; } = "218, 165, 32";
        public static string Gray { get; private set; } = "128, 128, 128";
        public static string Green { get; private set; } = "0, 128, 0";
        public static string GreenYellow { get; private set; } = "173, 255, 47";
        public static string Honeydew { get; private set; } = "240, 255, 240";
        public static string HotPink { get; private set; } = "255, 105, 180";
        public static string IndianRed { get; private set; } = "205, 92, 92";
        public static string Indigo { get; private set; } = "75, 0, 130";
        public static string Ivory { get; private set; } = "255, 255, 240";
        public static string Khaki { get; private set; } = "240, 230, 140";
        public static string Lavender { get; private set; } = "230, 230, 250";
        public static string LavenderBlush { get; private set; } = "255, 240, 245";
        public static string LawnGreen { get; private set; } = "124, 252, 0";
        public static string LemonChiffon { get; private set; } = "255, 250, 205";
        public static string LightBlue { get; private set; } = "173, 216, 230";
        public static string LightCoral { get; private set; } = "240, 128, 128";
        public static string LightCyan { get; private set; } = "224, 255, 255";
        public static string LightGoldenrodYellow { get; private set; } = "250, 250, 210";
        public static string LightGray { get; private set; } = "211, 211, 211";
        public static string LightGreen { get; private set; } = "144, 238, 144";
        public static string LightPink { get; private set; } = "255, 182, 193";
        public static string LightSalmon { get; private set; } = "255, 160, 122";
        public static string LightSeaGreen { get; private set; } = "32, 178, 170";
        public static string LightSkyBlue { get; private set; } = "135, 206, 250";
        public static string LightSlateGray { get; private set; } = "119, 136, 153";
        public static string LightSteelBlue { get; private set; } = "176, 196, 222";
        public static string LightYellow { get; private set; } = "255, 255, 224";
        public static string Lime { get; private set; } = "0, 255, 0";
        public static string LimeGreen { get; private set; } = "50, 205, 50";
        public static string Linen { get; private set; } = "250, 240, 230";
        public static string Magenta { get; private set; } = "255, 0, 255";
        public static string Maroon { get; private set; } = "128, 0, 0";
        public static string MediumAquamarine { get; private set; } = "102, 205, 170";
        public static string MediumBlue { get; private set; } = "0, 0, 205";
        public static string MediumOrchid { get; private set; } = "186, 85, 211";
        public static string MediumPurple { get; private set; } = "147, 112, 219";
        public static string MediumSeaGreen { get; private set; } = "60, 179, 113";
        public static string MediumSlateBlue { get; private set; } = "123, 104, 238";
        public static string MediumSpringGreen { get; private set; } = "0, 250, 154";
        public static string MediumTurquoise { get; private set; } = "72, 209, 204";
        public static string MediumVioletRed { get; private set; } = "199, 21, 133";
        public static string MidnightBlue { get; private set; } = "25, 25, 112";
        public static string MintCream { get; private set; } = "245, 255, 250";
        public static string MistyRose { get; private set; } = "255, 228, 225";
        public static string Moccasin { get; private set; } = "255, 228, 181";
        public static string NavajoWhite { get; private set; } = "255, 222, 173";
        public static string Navy { get; private set; } = "0, 0, 128";
        public static string OldLace { get; private set; } = "253, 245, 230";
        public static string Olive { get; private set; } = "128, 128, 0";
        public static string OliveDrab { get; private set; } = "107, 142, 35";
        public static string Orange { get; private set; } = "255, 165, 0";
        public static string OrangeRed { get; private set; } = "255, 69, 0";
        public static string Orchid { get; private set; } = "218, 112, 214";
        public static string PaleGoldenrod { get; private set; } = "238, 232, 170";
        public static string PaleGreen { get; private set; } = "152, 251, 152";
        public static string PaleTurquoise { get; private set; } = "175, 238, 238";
        public static string PaleVioletRed { get; private set; } = "219, 112, 147";
        public static string PapayaWhip { get; private set; } = "255, 239, 213";
        public static string PeachPuff { get; private set; } = "255, 218, 185";
        public static string Peru { get; private set; } = "205, 133, 63";
        public static string Pink { get; private set; } = "255, 192, 203";
        public static string Plum { get; private set; } = "221, 160, 221";
        public static string PowderBlue { get; private set; } = "176, 224, 230";
        public static string Purple { get; private set; } = "128, 0, 128";
        public static string Red { get; private set; } = "255, 0, 0";
        public static string RosyBrown { get; private set; } = "188, 143, 143";
        public static string RoyalBlue { get; private set; } = "65, 105, 225";
        public static string SaddleBrown { get; private set; } = "139, 69, 19";
        public static string Salmon { get; private set; } = "250, 128, 114";
        public static string SandyBrown { get; private set; } = "244, 164, 96";
        public static string SeaGreen { get; private set; } = "46, 139, 87";
        public static string SeaShell { get; private set; } = "255, 245, 238";
        public static string Sienna { get; private set; } = "160, 82, 45";
        public static string Silver { get; private set; } = "192, 192, 192";
        public static string SkyBlue { get; private set; } = "135, 206, 235";
        public static string SlateBlue { get; private set; } = "106, 90, 205";
        public static string SlateGray { get; private set; } = "112, 128, 144";
        public static string Snow { get; private set; } = "255, 250, 250";
        public static string SpringGreen { get; private set; } = "0, 255, 127";
        public static string SteelBlue { get; private set; } = "70, 130, 180";
        public static string Tan { get; private set; } = "210, 180, 140";
        public static string Teal { get; private set; } = "0, 128, 128";
        public static string Thistle { get; private set; } = "216, 191, 216";
        public static string Tomato { get; private set; } = "255, 99, 71";
        public static string Turquoise { get; private set; } = "64, 224, 208";
        public static string Violet { get; private set; } = "238, 130, 238";
        public static string Wheat { get; private set; } = "245, 222, 179";
        public static string White { get; private set; } = "255, 255, 255";
        public static string WhiteSmoke { get; private set; } = "245, 245, 245";
        public static string Yellow { get; private set; } = "255, 255, 0";
        public static string YellowGreen { get; private set; } = "154, 205, 50";
    }
}
