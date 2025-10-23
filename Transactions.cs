using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionsNS
{
    public class Transactions
    {
        #region Declaration des tableaux

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
                { 19.99m, 29.99m, 39.99m, 49.99m }, // PC
                { 49.99m, 59.99m, 69.99m, 79.99m }, // PlayStation
                { 39.99m, 49.99m, 59.99m, 69.99m }, // Xbox
                { 29.99m, 39.99m, 49.99m, 59.99m }, // Switch
                { 9.99m, 14.99m, 19.99m, 24.99m }   // Mobile
            };
        }
        #endregion

        #region Constructeur

        // constructeur du .dll

        /// <summary>
        /// Constructeur par defaut : 
        /// </summary>
        public Transactions()
        {
            InitPlatforme();
            InitGenre();
            InitPrix();
        }

        #endregion

        #region Getters
        // Definir les Getters pour les combobox:
        public string[] GetPlatforme()
        {
            return tPlatforme;
        }
        public string[] GetGenre()
        {
            return tGenre;
        }
        public decimal GetPrix(int platforme, int genre)
        {
            return tPrix[platforme, genre];
        }
        #endregion

       



    }
}
