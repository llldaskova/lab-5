using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.Models
{
    public class WorkToFail
    {
        public static void WriteToFail(string  name,string value)
        {
            File.WriteAllText(name, value);
        }
        public static string ReadFromFile(string name)
        {
            return File.ReadAllText(name);
        }
    }
}
