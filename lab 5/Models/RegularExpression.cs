using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_5.Models
{
    class RegularExpression
    {
        public static string ExpressionProcessing(string name, string reg)
        {
            try
            {
                var regex = new Regex(reg);
                MatchCollection matches = regex.Matches(name);
                if (matches.Count > 0)
                {
                    string result = "";
                    foreach (Match match in matches)
                        result += match + "\n";
                    return result;
                }
                else
                {
                    return ("Совпадений не найдено");
                }
            }
            catch
            {
                return "Ошибка!";
            }
        }
    }
}
