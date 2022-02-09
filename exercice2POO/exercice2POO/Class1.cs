using System;
using System.Collections.Generic;
using System.Text;

namespace exercice2POO
{
    class Livre
    {
        private string titre;
        private string auteur;
        private int prix;

        public Livre(string titre, string auteur, int prix)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.prix = prix;
        }

        public string Titre
        {
            get
            {
                return titre;
            }
            set
            {
                titre = value;
            }
        }

        public string Auteur
        {
            get
            {
                return auteur;
            }
            set
            {
                auteur = value;
            }
        }

        public int Prix
        {
            get
            {
                return prix;
            }
            set
            {
                prix = value;
            }
        }

        public void Afficher()
        {
            Console.WriteLine("\nLe titre est " + this.Titre + "\nl'auteur est " + this.Auteur + "\nle prix est de " + this.Prix + "€\n");
        }
    }


}
