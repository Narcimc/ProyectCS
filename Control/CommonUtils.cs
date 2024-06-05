using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Control
{
    internal enum TipoVoto
    {
        Reina,
        Fotogenia
    }

    internal enum VotoTipoCRUD
    {
        ConsultaIndividualEstudiante,
        ConsultaTodosEstudiantes,
        InsertarVoto
    }

    internal enum CandidataTipoCrud
    { 
        ConsultaIndividualCandidata,
        ConsultaTodasCandidatas,
        InsertarCandidata,
        ModificarCantidata,
        EliminarCandidata,
        ConsultaCortaTodasCandidatasIdNombreApellido
    }

    internal static class CommonUtils
    {
        internal static string COMMON_ERROR_MSJ = "Oops, algo no salio muy bien...";
        internal static string VOTO_YA_REGISTRADO_MSJ = "Su voto ya ha sido registrado";
        internal static string ERROR_AL_VOTAR_MSJ = "Ocurrió un error al registrar el voto, intentelo de nuevo, si este error persiste contacte al administrador del sistema.";
    }
}
