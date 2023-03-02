using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logique;

namespace Devops.Exercices.Tableaux
{
    public class Tableau2 : ICommand
    {
        public string Name => "tableau 2";

        public void Execute()
        {
            Console.Write("Combien de nombre premier voulez vous afficher? ");
            long yourInteger;
            yourInteger = Int32.Parse(Console.ReadLine());
            List<long> listPremier = new List<long>();



            ChercherNbPremier(yourInteger, listPremier);
            AffichageListe(listPremier);


        }
        void AffichageListe(List<long> l)
        {
            foreach (var item in l)
            {
                Console.Write(item + " ");
            }
        }

        void ChercherNbPremier(long integer, List<long> l)
        {   int cpt = 0;

            for (long i = 2; cpt <= integer -1; i ++)
            {
               
                

                //Control i si est un nombre  premier ou pas
                if ((i % 2 != 0) || (i == 2))
                {
                    l.Add(i); 
                    cpt++;
                }


            }
        }
    }

    
}     

