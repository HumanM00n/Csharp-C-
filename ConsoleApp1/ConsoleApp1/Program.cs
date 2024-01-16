using System;
using System.ComponentModel.Design;

namespace ConsoleApp1 // Note : l'espace de noms réel dépend du nom du projet.f
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Déclaration des variables
            // string prenom = "";
            // string age = "";
            // int maVariable = 25;

            // maVariable++; // Ajoute +1 à maVariable
            // Console.WriteLine(maVariable); 
            // Commenté pour ne pas afficher maVariable

            // Console.WriteLine("Bonjour " + prenom); // Concaténation + Chaine de caractère.

            // Demander le prénom à l'utilisateur
            // Console.Write("Quel est votre prénom ?");
            // prenom = Console.ReadLine(); // On attend que l'utilisateur donne une réponse pour passer à la suite, 
            // Console.ReadLine(); // À laisser vide ET renvoie tout ce que l'utilisateur a tapé sur le clavier jusqu'à ce qu'il clique sur Entrée.

            // Permet de faire une chaîne de caractères avec le nom de la variable entre les guillemets avec des crochets.
            // Console.WriteLine($"Bonjour {prenom}, Enchanté");

            // Demander l'âge à l'utilisateur
            // Console.Write("Quel est votre âge ?");
            // age = Console.ReadLine();

            // Afficher le résultat
            // Console.WriteLine($"Bonjour {prenom}, Enchanté, vous avez {age} ans(s)");
            // Console.WriteLine($"Et dans un an tu auras {maVariable} ans");

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //string prenom = ""; // :variable prenom string age = ""; // :variable age
            // string ageStr = ""; // on récupère le readline c'est pour avoir l'age +1
            // int ageNbr = 0; //age convertu en nombre

            // Console.WriteLine("bonjour c'est mymy "+ prenom); :Concatenation + chaine de caractère 

            // permet de faire une chaine de caractère avec le nom de la variable entre les guillemets
            // on demande le prenom :

            // Console.WriteLine("Quel est ton prenom bg ?");// si je met que le write tout seul le curseur sera a la fin de la première ligne 
            // prenom = Console.ReadLine();               // attente que l'utilisateur tape une réponse pour passer a la suite donc le programme s'execute 


            // Console.ReadLine(); // a laisser tout le temps vide elle nous renvoie tous ce que l'utilisateur a envoyer jusqu'a ce que l'utilisateur a fait envoyer / appuyer sur entrée
            // "
            // On demande l'age :
            // Console.WriteLine("Quel est ton age bggg ?");
            // ageStr = Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------


            /* COMMENT INTERCEPTER LES EXCEPTIONS */

            // On utilise le bloc Try.... Catch --> Exemple :

            /* Try {
             * 
             *  Le code sensible est dans le try, qui peut provoquer une exception
             * 
             * }
             * catch {
             * 
             * On place le code qui va corriger l'exception
             * 
             * } */

            string prenom = ""; // :variable prenom string age = ""; // :variable age
            string ageStr = ""; // on récupère le readline c'est pour avoir l'age +1
            int ageNbr = 0; //age convertu en nombre


            Console.WriteLine("Quel est votre prenom ?");// si je met que le write tout seul le curseur sera a la fin de la première ligne 
            prenom = Console.ReadLine();               // attente que l'utilisateur tape une réponse pour passer a la suite donc le programme s'execute 


            // Console.ReadLine(); // a laisser tout le temps vide elle nous renvoie tous ce que l'utilisateur a envoyer jusqu'a ce que l'utilisateur a fait envoyer / appuyer sur entrée

           

            try { 

            // Conversion
            ageNbr = int.Parse(ageStr); // c'est pour convertir mon ageStr en nombre 
            ageNbr = ageNbr + 1;


            // la reponse apres que l'utilisateurs est rentrer ces deux réponses :
            Console.WriteLine($"bonjour {prenom}, je t'annonce que dans 1 an tu auras {ageNbr} ans ");
            }
            catch(Exception ex) {
                Console.WriteLine("Veuillez entrer un âge valide !!!");
                Console.WriteLine(ex.Message);

                /* LES BOUCLES CONDITIONNELLES  */

                // if(/*condition*/)
                // {
                /* Code so condition vérifiée */
                //  }
                // else { 
                /* Code si condition n'est pas vérifiée */
                // }

                /* Double condition */

                // if (/*condition*/)
                // {
                /* Code si condition vérifiée */
                // }
                // elif(/* Condition 2 */) {

                // }
                // else {
                /* Code si condition n'est pas vérifiée */
                // }



                // On demande l'age :
                // Nous allons tester si le prenom 

                if(prenom.Length >=3) {

                    Console.WriteLine("Quel est votre age ?");
                    ageStr = Console.ReadLine();
                    ageNbr = int.Parse(ageStr);
                    ageNbr = ageNbr + 1;

                    Console.WriteLine($"Et dans un an tu auras {ageNbr} ans");
                }
                else
                {
                    Console.WriteLine($"Le prénom doit comporter au moins 3 caractères !");
                }
            }
        }
    }
}



