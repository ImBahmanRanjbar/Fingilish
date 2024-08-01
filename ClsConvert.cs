using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finglish
{
    public static class ClsConvert
    {

        public static string Persian2Phinglish(this string strpersian)
        {
           
            string strphinglish = string.Empty;

            strphinglish = strpersian.Replace("اَ", "a")
                                   .Replace("اُ", "o")
                                   .Replace("اِ", "e")
                                   .Replace("اع", "e")
                                   .Replace("او", "oo")
                                   .Replace("وا", "a")
                                   .Replace("َ", "a")
                                   .Replace("ُ", "o")
                                   .Replace("ِ", "e")
                                   .Replace("ا", "a")
                                   .Replace("آ", "a")
                                   .Replace("ب", "b")
                                   .Replace("پ", "p")
                                   .Replace("ت", "t")
                                   .Replace("ث", "s")
                                   .Replace("ج", "j")
                                   .Replace("چ", "ch")
                                   .Replace("ح", "h")
                                   .Replace("خ", "kh")
                                   .Replace("د", "d")
                                   .Replace("ذ", "z")
                                   .Replace("ر", "r")
                                   .Replace("ز", "z")
                                   .Replace("س", "s")
                                   .Replace("ش", "sh")
                                   .Replace("ص", "s")
                                   .Replace("ض", "z")
                                   .Replace("ط", "t")
                                   .Replace("ظ", "z")
                                   .Replace("ع", "A")
                                   .Replace("غ", "gh")
                                   .Replace("ق", "gh")
                                   .Replace("ف", "f")
                                   .Replace("ک", "k")
                                   .Replace("گ", "g")
                                   .Replace("ل", "l")
                                   .Replace("م", "m")
                                   .Replace("ن", "n")
                                   .Replace("و", "v")
                                   .Replace("ه", "h")
                                   .Replace("ی", "i")
                                   .Replace("ای", "i")
                                   .Replace("اً", "an");
                                  













            return strphinglish;

        }
    }
}
