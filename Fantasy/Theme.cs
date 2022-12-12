using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy
{
    public class Theme
    { 
        public enum ThemeCol
        {
            Primary,
            Secondary,
            Tertiary,
            Text
        }
         public static List<Dictionary<ThemeCol, Color>> Colors = new List<Dictionary<ThemeCol, Color>>();
         static Theme()
         {
            Colors.Add(new Dictionary<ThemeCol, Color>() {
                { ThemeCol.Primary, ColorTranslator.FromHtml("0xF7E2E2") },
                { ThemeCol.Secondary, ColorTranslator.FromHtml("0xDBDBDB") },
                { ThemeCol.Tertiary, Color.White },
                { ThemeCol.Text, Color.Black }
            });
            Colors.Add(new Dictionary<ThemeCol, Color>() {
                { ThemeCol.Primary, ColorTranslator.FromHtml("0x4C6793")},
                { ThemeCol.Secondary, ColorTranslator.FromHtml("0x395B64")},
                { ThemeCol.Tertiary, ColorTranslator.FromHtml("0x2C3333")},
                { ThemeCol.Text, ColorTranslator.FromHtml("0xE7F6F2")}
            });
            Colors.Add(new Dictionary<ThemeCol, Color>() {
                { ThemeCol.Primary, ColorTranslator.FromHtml("0x7F8487") },
                { ThemeCol.Secondary, ColorTranslator.FromHtml("0x2C3333") },
                { ThemeCol.Tertiary, ColorTranslator.FromHtml("0x181818") },
                { ThemeCol.Text, Color.White }
            });
        }
    }
}
