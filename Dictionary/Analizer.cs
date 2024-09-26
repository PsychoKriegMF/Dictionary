using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Dictionary
{
    internal class Analizer
    {
        static List<Word> words;
        public static List<Word> GetListOfWord(List<string> _lst)
        {
            List<Word> result = new List<Word>();
            int counter = 0;
            string _tmp;
            do
            {
                //Вхождение первого слова -> counter
                //_tmp = присвоить первое слово
                //Удалить ВСЕ вхождения
                //Добавить в result.add("слово", counter)
            }
            while (_lst.Count > 0);
            return result;
        }
    }
}
