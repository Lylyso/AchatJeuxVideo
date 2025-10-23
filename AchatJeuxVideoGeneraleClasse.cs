using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ce = AchatJeuxVideo.AchatJeuxVideoGeneraleClasse.CodesErreurs;

namespace AchatJeuxVideo
{
    internal class AchatJeuxVideoGeneraleClasse
    {
        #region Enumeration

        public enum CodesErreurs
        {
            ErreurPlatforme,
            ErreurGenre,
            ErreurPrix,
            ErreurIndeterminee
        }

        #endregion

        #region Declaration

        public static string[] tMessages;

        #endregion

        #region Initialisation

        public static void InitMessagesErreurs()
        {
            tMessages = new string[4];
            tMessages[(int)ce.ErreurPlatforme] = "Erreur liée à la plateforme.";
            tMessages[(int)ce.ErreurGenre] = "Erreur liée au genre.";
            tMessages[(int)ce.ErreurPrix] = "Erreur liée au prix.";
            tMessages[(int)ce.ErreurIndeterminee] = "Erreur indéterminée...";
        }

        #endregion
    }
}
