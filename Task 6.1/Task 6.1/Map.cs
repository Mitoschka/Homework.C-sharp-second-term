using System;
using System.Collections.Generic;

namespace Task_6._1
{
    public static class MapFunction
    {
        /// <summary>
        /// Map принимает список и функцию, преобразующую элемент списка.
        /// </summary>
        /// <param name="list"> Список для передачи в функцию </param>
        /// <param name="function"> Лямбда - выражение </param>
        /// <returns> Список полученный путём преобразования с помощью функции </returns>
        public static List<int> Map(List<int> list, Func<int, int> function)
        {
            var resultList = new List<int>();
            for(int i = 0; i != list.Count; ++i)
            {
                int element = function(list[i]);
                resultList.Add(element);
            }
            return resultList;
        }
    }
}