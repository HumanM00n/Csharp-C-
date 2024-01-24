using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prenom = string.Empty;

            // Demander le prénom avec une longueur de plus de 3 caractères 
            while (prenom.Length <= 3) { 
                Console.Write("Quel est votre nom ? :");
                prenom = Console.ReadLine();

            }

            Console.WriteLine("Quel est votre âge ? :");
            string age = Console.ReadLine();

            Console.WriteLine($"Enchanté {prenom}, vous avez {age} ans");

            //Dans un an vous aurez +1

            // Capter une erreur et sortir proprement du code sans avoir une erreur système 
            try
            {
                int ageNbr = int.Parse(age);
                if (ageNbr > 0)
                {
                    // L'age doit être un nombre positif
                    Console.WriteLine($"Dans un an vous aurez {ageNbr + 1} ans");
                }
                else
                {

                    Console.WriteLine("Vueillez entre un âge supérieur à 0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Votre âge est incorrect");
            }

            /* RAPPEL POUR LES CONDTIONS SIMPLE
             
             == Egalité
            != Différent
            < Strictement supérieur 
            > Strictement inférieur 
            <= Supérieur ou égal
            >= Inférieur ou egal 
             */

            /* Combiner plusieurs condition
             * (cond1) op (cond2) op (cond...)
          "ET" (cond1) && (cond2)
                    Les deux conditions doivent être vraies 
          "OU"  (cond1) || (cond2)
                    Résultat vrai si 1 des condition des deux conditions est vraie
            */

            


        }
    }
}













