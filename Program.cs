using SIEleccionReina.Formularios;
using System;
using System.Windows.Forms;

namespace SIEleccionReina
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormSplash splash = new FormSplash();
            splash.Show();
            splash.Refresh();
            System.Threading.Thread.Sleep( 2100 );
            splash.Close();

            Application.Run(new FormLogin());
        }
    }
}
