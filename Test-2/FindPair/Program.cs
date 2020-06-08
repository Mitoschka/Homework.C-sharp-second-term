using System;
using System.Windows.Forms;

/// <summary>
/// Пространство имён
/// </summary>
namespace FindPair
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int sizeOfTable = 4;
            string[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Length > 1)
            {
                bool isCorrectInput = Int32.TryParse(arguments[1], out sizeOfTable);
                if (arguments.Length != 2 || !isCorrectInput || sizeOfTable < 1 || sizeOfTable % 2 != 0)
                {
                    MessageBox.Show("Некорректные данные в командной строке.");
                    return;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameForm(sizeOfTable));
        }
    }
}
