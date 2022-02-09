using System;

namespace exercice3POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matricule : ");
            string matricule = Console.ReadLine();
            Console.WriteLine("Nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Prenom : ");
            string prenom = Console.ReadLine();
            Console.WriteLine("Date de naissance : ");
            string dateNaissance = Console.ReadLine();
            Console.WriteLine("Date d'embauche : ");
            string dateEmbauche = Console.ReadLine();
            Console.WriteLine("Salaire : ");
            int salaire = int.Parse(Console.ReadLine());

            Employe employe = new Employe(matricule, nom, prenom, dateNaissance, dateEmbauche, salaire);
            employe.AfficherEmploye(dateNaissance, dateEmbauche);
        }
    }
}
