using SIEleccionReina.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
           Application.Run(new FormReiFaSi());
            Application.Run(new FRMGaleriaFotos());
            Application.Run(new RegistroDeCandidatas());
           Application.Run(new FRMCarreras());
           Application.Run(new FRMAlbum());
            Application.Run(new FRMGaleriaFotos());
            Application.Run(new ModuloAdministrador());
           Application.Run(new FrmReina());
            Application.Run(new FRMVistaDatosCandidata());
           Application.Run(new FrmVotarFotogenica());
           Application.Run(new FRMVotoReina());
            Application.Run(new FrmResultados());
            Application.Run(new FRMEstadisticasReinas());
            Application.Run(new FrmEstadisticaFotogenica());
            Application.Run(new FrmVotarFotogenica());
            Application.Run(new FrmResultadosFotogenica());
           Application.Run(new FrmEstudiante());


















        }
    }
}
