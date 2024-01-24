using System;

namespace MyApp // Note: le namespace réel dépend du nom du projet.
{
    internal class Program

    {
        static  int DemanderNombre(int min, int max)
    {
        Console.WriteLine("Entrez un nombre entre 1 et 10: ");

        int Nbr = Convert.ToInt32(Console.ReadLine());
            return Nbr;
        }
        static void Main(string[] args)
        {

            const int MAX_MAGIC = 10;
            const int MAX_COUP = 4;

            // On déclare les variables 
            int NbrJoueurs;
            int NbrMagique;

            // Premier tirage du nombre magique 
            var rnd = new Random();
            NbrMagique = rnd.Next(1, 11);

            int essais = 0;

            // Utilisation d'une boucle while pour permettre 4 essais maximum
            while (essais < 4)
            {
                // Demandez à l'utilisateur de saisir un nombre
                //Console.Write("Entrez un nombre entre 1 et 10: ");

                // Convertie ce qu'on reçoit en chaine de caractère en nombres -- C'est équivalent au int.pars
                //NbrJoueurs = Convert.ToInt32(Console.ReadLine());
                 NbrJoueurs = DemanderNombre(1, MAX_MAGIC);
                essais++;

                if (NbrJoueurs < NbrMagique)
                {
                    Console.WriteLine("Plus grand");
                }
                else if (NbrJoueurs > NbrMagique)
                {
                    Console.WriteLine("Plus petit");
                }
                else
                {
                    Console.WriteLine($"Vous avez trouvé le nombre magique en {essais} essais !");
                    return; // Sortez du programme après avoir trouvé le nombre magique
                }
            }

            // Si l'utilisateur n'a pas trouvé le nombre magique en 4 essais
            Console.WriteLine($"Désolé, vous n'avez pas trouvé le nombre magique. Le nombre magique était {NbrMagique}.");


            /*******************************
             *     CREER UNE FONCTION      *
            ********************************/



        }
    }
}

/*
// On déclare les variables 
string NbrJoueurs = "";
string NbrMagique = "";

// Premier tturage du nombre magique 
var rnd = new Random();
NbrMagique = rnd.Next();

Console.WriteLine("Quelle est votre proposition entre 1 et 10");
Console.WriteLine("C'est plus grand");*/
