using Logique;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices
{
    public class Jeu : ICommand
    {
        int Col = 9;
        int Ligne = 9;
        string Perso = "A";
        int colPerso = 1;
        int lignePerso = 1;

        public string Name => "Jeu";


        public void Execute()
        {

            string[,] table = new string[Ligne, Col];
            CreerTab(table);
            AfficherTab(table);

            for (int i = 0; i < 20; i++)
            {

                string A = AskMove();
                Move(A, table);
                Console.Clear();
                AfficherTab(table);
            }


        }
        void CreerTab(string[,] table)
        {
            for (int i = 0; i <= Ligne - 1; i++)
            {
                for (int j = 0; j <= Col - 1; j++)
                {
                    if (i == lignePerso && j == colPerso)
                    {
                        table[i, j] = Perso;
                    }
                    else
                    {
                        if (i == 0 || j == 0 || i == Ligne - 1 || j == Col - 1)
                        {
                            table[i, j] = "#";
                        }
                        else
                        {
                            table[i, j] = " ";
                        }
                    }

                }
            }
        }
        void AfficherTab(string[,] table)
        {
            for (int i = 0; i <= Ligne - 1; i++)
            {
                for (int j = 0; j <= Col - 1; j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine(" ");
            }
        }
        string AskMove()
        {
            string rep;
            do
            {
                Console.WriteLine("Où voulez vous vous Aller ?");
                Console.WriteLine("Devant = Z");
                Console.WriteLine("Gauche = Q");
                Console.WriteLine("Droite = D");
                Console.WriteLine("Arrière = S");
                
                rep = Request();
            } while (rep != "z" && rep != "q" && rep != "d" && rep != "s");

            return rep;

        }
        void Move(string Direction, string[,] table)
        {
            table[lignePerso, colPerso] = " ";
            
            if (Direction == "d")
            {
               
                 if (colPerso < Col -2)
                 {
                    colPerso++;
                 }
                 else Console.WriteLine( "limite atteinte!");
            }
            if (Direction == "s")
            {
                if (lignePerso < Ligne - 2)
                {
                    lignePerso++;
                }
                else Console.WriteLine("Dégage Connard");
               
            }
            if (Direction == "q")
            {
                if (colPerso > 1)
                {
                    colPerso--;
                }
                else Console.WriteLine("Fais demi-tour, Crétin!");
            }
            if (Direction == "z")
            {
                if(lignePerso > 1)
                {
                    lignePerso--;
                }
                else Console.WriteLine("Arrière toute, Merdaillon!"); ;
            }


            table[lignePerso, colPerso] = Perso;
        }

        string Request()
        {
            string strings;
            do
            {
                strings = Console.ReadLine() ?? "erreur";
                if (strings == "erreur")
                {
                    Console.WriteLine("Encodage vide");
                }
            } while (strings == "erreur");

            return strings;
        }

    }
}