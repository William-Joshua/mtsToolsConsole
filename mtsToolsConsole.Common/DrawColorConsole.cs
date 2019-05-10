using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolsConsole.Common
{
    public class DrawColorConsole
    {
        /// <summary>
        /// 转换字符串为颜色 仅支持 xxx, xxx, xxx
        /// </summary>
        /// <param name="colorText"></param>
        /// <returns></returns>
        public static int[] ConvertStr2RGB(string colorText)
        {
            try
            {
                string[] ColorRGBStrArray = new string[3];
                int[] ColorRGBArray = new int[3];
                ColorRGBStrArray = colorText.Split(',');

                for(int icnt=0;icnt <3;icnt++)
                {
                    ColorRGBArray[icnt] = Convert.ToInt32(ColorRGBStrArray[icnt].ToString().Trim());
                }
                return ColorRGBArray;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
