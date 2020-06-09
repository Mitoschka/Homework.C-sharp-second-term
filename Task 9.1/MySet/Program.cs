using System;
/// <summary>
/// Global namespace.
/// </summary>
namespace MySet
{
    /// <summary>
    /// Class with Main function.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main function in program.
        /// </summary>
        static void Main()
        {
            var set = new MySet<string>();
            set.Add("abc");
            set.Add("aaa");
            set.Add("bbb");
            set.Add("ccc");
            set.Clear();
            Console.WriteLine(set.Count);
        }
    }
}
