using System;
using System.Collections.Generic;

namespace Task_6._1
{
    public class FilterFunction
    {
        /// <summary>
        /// Filter принимает список и функцию, возвращающую булевое значение по элементу списка.
        /// </summary>
        /// <param name="list"> Список для передачи в функцию </param>
        /// <param name="function"> Лямбда - выражение </param>
        /// <returns> Список полученный путём преобразования с помощью функции </returns>
        public List<int> Filter(List<int> list, Func<int, bool> function)
        {
            List<int> resultList = new List<int>();
            for (int i = 0; i != list.Count; ++i)
            {
                if (function(list[i]) == true)
                {
                    resultList.Add(list[i]);
                }
            }
            return resultList;
        }
    }
}
