using System;
using System.Collections.Generic;
using System.Text;

namespace exercice3POO
{
    class Employe
    {
        private string matricule;
        private string nom;
        private string prenom;
        private string dateNaissance;
        private string dateEmbauche;
        private double salaire;

        public Employe(string matricule, string nom, string prenom, string dateNaissance, string dateEmbauche, double salaire)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.dateEmbauche = dateEmbauche;
            this.salaire = salaire;
        }
        public string Matricule
        {
            get
            {
                return matricule;
            }
            set
            {
                matricule = value;
            }
        }
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }
        public string DateNaissance
        {
            get
            {
                return dateNaissance;
            }
            set
            {
                dateNaissance = value;
            }
        }
        public string DateEmbauche
        {
            get
            {
                return dateEmbauche;
            }
            set
            {
                dateEmbauche = value;
            }
        }
        public double Salaire
        {
            get
            {
                return salaire;
            }
            set
            {
                salaire = value;
            }
        }
        
        public int Age(string dateNaissance)
        {
            DateTime naissance = Convert.ToDateTime(dateNaissance);
            int age = DateTime.Now.Year - naissance.Year;
            DateTime DateAnniv = new DateTime(DateTime.Now.Year, naissance.Month, naissance.Day);
            if (DateAnniv > DateTime.Now)
            {
                age--;
            }
            return(age);
        }
        public int Anciennete(string dateEmbauche)
        {
            DateTime embauche = Convert.ToDateTime(dateEmbauche);
            int temps = DateTime.Now.Year - embauche.Year;
            DateTime DateEmb = new DateTime(DateTime.Now.Year, embauche.Month, embauche.Day);
            if(DateEmb > DateTime.Now)
            {
                temps--;
            }
            return(temps);
        }
        public double AumentationDuSalaire(int temps)
        {
            if(temps < 5)
            {
                this.salaire = salaire *1.02; 
            }
            if (temps < 10)
            {
                this.salaire = salaire * 1.05;
            }
            else
            {
                this.salaire = salaire * 1.1;
            }
            return(this.salaire);
        }

        public void AfficherEmploye(string dateNaissance, string dateEmbauche)
        {
            char[] maj = this.prenom.ToCharArray();
            maj[0] = char.ToUpper(maj[0]);
            Console.WriteLine("\n");
            Console.WriteLine(" - Matricule : " + this.matricule);
            Console.WriteLine(" - Nom Complet : " + this.nom.ToUpper() + " " + new string(maj));
            Console.WriteLine(" - Age : " + this.Age(dateNaissance) + "ans");
            Console.WriteLine(" - Ancienneté : " + this.Anciennete(dateEmbauche) + "ans");
            Console.WriteLine(" - Salaire : " + this.AumentationDuSalaire(this.Anciennete(dateEmbauche)) + "€");
        }
    }
}
