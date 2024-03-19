using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public static class Identifier
    {
        public static string Clean(string id)
        {
            string result = id.Replace(" ", "_");

            Regex pattern = new Regex(@"[\x00-\x1F\x7F]");
            result = pattern.Replace(result, "CTRL");
            if (result != null && result.Contains("-"))
            {
                string[] words = result.Split('-');
                result = words[0];
                for (int i = 0; i < words.Length; i++)
                {
                    result += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
                }
            }

            Regex pattern2 = new Regex(@"[^a-zA-Z_ΟàḃḂçĐ]");
            result = pattern2.Replace(result, "");

            return result;
        }
    }
}
