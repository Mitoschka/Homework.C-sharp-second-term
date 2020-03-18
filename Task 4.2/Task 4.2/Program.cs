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
                list.AddUniqueElementToList("cat");
                list.AddUniqueElementToList("dog");
                list.DeleteElement("cat");
                Console.WriteLine(list.IsContain("cat"));
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
