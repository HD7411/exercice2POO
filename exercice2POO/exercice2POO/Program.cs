using System;

namespace exercice2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool oui = true;
            while (oui)
            {
                Console.WriteLine("Titre du livre : ");
                string titre = Console.ReadLine();
                Console.WriteLine("Auteur du livre : ");
                string auteur = Console.ReadLine();
                Console.WriteLine("Prix du livre : ");
                int prix = int.Parse(Console.ReadLine());

                Livre livre = new Livre(titre, auteur, prix);

                livre.Afficher();
            }
            
        }
    }
}
