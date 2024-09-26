using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary
{
    internal class FSWork
    {
        static char[] delimiters = { ' ', '.', ',' };
        public static List<string> ReadToListOfString(string _path)
        {
            List<string> result = new List<string>();
            string _str;
            using (StreamReader sr = new StreamReader(_path))
            {
                _str = sr.ReadToEnd();
            }
            result = _str.Split(delimiters).ToList<string>();
            return result;
        }
    }
}
