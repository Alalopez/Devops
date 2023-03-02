using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Tableaux
{
    public class Tableau1 : ICommand
    {
        public string Name => "Tableau 1";

        public void Execute()
        {
            Console.Write("Entrer un nombre Entier: ");
            long yourInteger;
            yourInteger = Int32.Parse(Console.ReadLine());
            List<long> listPremier = new List<long>();

            ChercherNbPremier(yourInteger, listPremier);
            AffichageListe(listPremier);

            Console.WriteLine("\n------------------------------");
            yourInteger = 400;
            listPremier = new List<long>();
            ChercherNbPremier(yourInteger, listPremier);
            AffichageListe(listPremier);

            Console.WriteLine("\n------------------------------");
            yourInteger = 50;
            listPremier = new List<long>();
            ChercherNbPremier(yourInteger, listPremier);
            AffichageListe(listPremier);
        }


        void AffichageListe(List<long> l)
        {
            foreach (long item in l)
            {
                Console.Write(item + " ");
            }
        }
        void ChercherNbPremier(long integer, List<long> l)
        {
            long i = 2;
            while (i <= integer)
            {
                //Control i si est un nombre  premier ou pas
                if ((i % 2 != 0) || (i == 2))
                {
                    l.Add(i);
                }
                i++;

            }
        }
    }
}

