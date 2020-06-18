using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task_4._2
{
    /// <summary>
    /// Class with Main function.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function in program.
        /// </summary>
        private static void Main()
        {
            try
            {
                var list = new UniqueList();
                list.AddElement("abc", 0);
                Console.WriteLine(list.GetItemValue(0));
                list.AddElement("abc", 1);
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
