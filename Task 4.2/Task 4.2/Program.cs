using System;

namespace Task_4._2
{
    class Program
    {
        static void Main()
        {
            try
            {
                UniqueList list = new UniqueList();
                list.AddUniqueElementToList("abc", 0);
                Console.WriteLine(list.GetItemValue(0));
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
