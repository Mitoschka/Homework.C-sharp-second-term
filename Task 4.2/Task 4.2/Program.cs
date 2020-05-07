using System;

namespace Task_4._2
{
    class Program
    {
        static void Main()
        {
            try
            {
                var list = new UniqueList();
                list.AddUniqueElement("abc", 0);
                Console.WriteLine(list.GetItemValue(0));
                list.AddUniqueElement("abc", 1);
            }
            catch (AddException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DeleteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
