using System;
using System.Windows.Forms;

namespace TestForm
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() =>
            Application.Run(new Form1());
    }
}
