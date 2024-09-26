using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Dictionaty
{
    internal class Analizer
    {
        static List<Word> words;
        public static List<Word> GetListOfWord(List<string> _lst)
        {
            List<Word> result = new List<Word>();
            int counter = 0;
            do 
            {
                // Вхождение первого слова -> count
                //_tmp = 1ое слово
                // Удалить все вхождения
                // Добавить в result.add("слово", counter)
            }
            while (_lst.Count > 0);
            return result;
        }

    }
}
