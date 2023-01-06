using System;
using System.Windows.Forms;
using EAutomize.Form;

namespace EAutomize
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main() // точка входа
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgresBar()); // запуск логотипа
        }
    }
}
