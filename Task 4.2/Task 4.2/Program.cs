using System;

namespace MyList
{
    class Program
    {
        static void Main()
        {
            try
            {
                UniqueList list = new UniqueList();
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
