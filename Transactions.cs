using System;      
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionsNS
{
    /// <summary>
    /// Classe Transactions permettant de récupérer les prix selon la plateforme et le genre.
    /// Contient des surcharges GetPrix avec validation et gestion d'exceptions.
    /// </summary>
    public class Transactions
    {
        #region Déclarations des tableaux

        private string[] tPlatforme;
        private string[] tGenre;
        private decimal[,] tPrix;

        #endregion

        #region Initialisation des tableaux
        private void InitPlatforme()
        {
            tPlatforme = new string[5] { "PC", "PlayStation", "Xbox", "Switch", "Mobile" };
        }

        private void InitGenre()
        {
            tGenre = new string[4] { "Action", "Aventure", "RPG", "Stratégie" };
        }

        private void InitPrix()
        {
            tPrix = new decimal[5, 4]
            {
                { 19.99m, 29.99m, 39.99m, 49.99m },
                { 49.99m, 59.99m, 69.99m, 79.99m },
                { 39.99m, 49.99m, 59.99m, 69.99m },
                { 29.99m, 39.99m, 49.99m, 59.99m },
                { 9.99m, 14.99m, 19.99m, 24.99m }
            };
        }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur par défaut : initialise les tableaux.
        /// </summary>
        public Transactions()
        {
            InitPlatforme();
            InitGenre();
            InitPrix();
        }
        #endregion

        #region Getters pour ComboBox
        /// <summary>
        /// Retourne toutes les plateformes disponibles.
        /// </summary>
        public string[] GetPlatforme() => tPlatforme;

        /// <summary>
        /// Retourne tous les genres disponibles.
        /// </summary>
        public string[] GetGenre() => tGenre;
        #endregion

        #region Méthodes GetPrix surchargées

        /// <summary>
        /// Retourne le prix selon les indices du tableau.
        /// </summary>
        /// <param name="platforme">Indice de la plateforme (0 à 4).</param>
        /// <param name="genre">Indice du genre (0 à 3).</param>
        /// <returns>Prix du jeu (Decimal).</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// L'indice plateforme ou genre est hors limites.
        /// </exception>
        /// 


        public decimal GetPrix(int platforme, int genre)
        {
            if (platforme < 0 || platforme >= tPlatforme.Length)
                throw new ArgumentOutOfRangeException(nameof(platforme), "Indice de plateforme hors limites!");
            if (genre < 0 || genre >= tGenre.Length)
                throw new ArgumentOutOfRangeException(nameof(genre), "Indice de genre hors limites!");
            return tPrix[platforme, genre];
        }



        /// <summary>
        /// Retourne le prix selon le nom de la plateforme et du genre.
        /// </summary>
        /// <param name="platforme">Nom de la plateforme.</param>
        /// <param name="genre">Nom du genre.</param>
        /// <returns>Prix du jeu (Decimal).</returns>
        /// <exception cref="ArgumentException">
        /// Plateforme inconnue ou genre inconnu.
        /// </exception>
        /// 

        public decimal GetPrix(string platforme, string genre)
        {
            int posPlatforme = Array.IndexOf(tPlatforme, platforme);
            int posGenre = Array.IndexOf(tGenre, genre);
            if (posPlatforme < 0)
                throw new ArgumentException("Plateforme inconnue!", nameof(platforme));
            if (posGenre < 0)
                throw new ArgumentException("Genre inconnu!", nameof(genre));
            return tPrix[posPlatforme, posGenre];
        }

        #endregion
    }
}
