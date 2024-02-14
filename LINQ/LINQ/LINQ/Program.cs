using System;
using System.Collections.Generic;
using System.Linq;  

namespace MyApp
{
    internal class Program
    {
        public class Personne
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {

            #region Avec des objets

        var Personnes = new List<Personne>
        {
           new Personne{Nom = "Durant", Prenom = "Jean", Age = 50},
           new Personne{Nom = "Dupond", Prenom = "Charles", Age = 25},
           new Personne{Nom = "Terrieur", Prenom = "Alain", Age = 34},
           new Personne{Nom = "Terrieur", Prenom = "Alex", Age = 36},
           new Personne{Nom = "Delachanche", Prenom = "Jay", Age = 15}

        };

            /***************** REQUETE METHODE -> Afiicher les personnes par ordre CROISSANT de l'age *****************/
            var resqOrderAge = Personnes.OrderBy(p=>p.Age);
            

            // Afficher les résultats
            Console.WriteLine("Résultats :");
            Console.WriteLine("");
            foreach (var personne in resqOrderAge)
            {
                Console.WriteLine($"{personne.Nom} , {personne.Prenom}, {personne.Age}");
            }

            Console.WriteLine("");
            Console.WriteLine("****************************************************************");
            #endregion




            /***************** REQUETE METHODE -> Afficher les personnes par ordre DECROISSANT de l'age *****************/
            var resqDescAge = Personnes.Where(p => p.Nom == "Terrieur")
                                       .OrderByDescending(p => p.Age);

            // Afficher les résultats
            Console.WriteLine("Résultats :");
            Console.WriteLine("");
            foreach (var personne in resqDescAge)
            {
                Console.WriteLine($"{personne.Nom} , {personne.Prenom}, {personne.Age}");
            }

            Console.WriteLine("");
            Console.WriteLine("****************************************************************");





            #region Avec LISTE
            var Maliste = new List<string>() { "pêche", "pomme", "poire", "orange", "banane", "ananas", "raisin" };
            #region Len > 5

            // Requête LINQ pour sélectionner les éléments dont la longueur est supérieure à 5
            var resreq = from fruit in Maliste
                         where fruit.Length > 5
                         select fruit;

            Console.WriteLine("");
            Console.WriteLine($"Le nombres de fruits est de {resreq.Count()} !");

            // Afficher les résultats
            foreach (var fruit in resreq)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("");
            Console.WriteLine("****************************************************************");


            // Requête LINQ pour sélectionner les éléments dont le nom commence par la lettre p
            var res2 = from fruit in Maliste
                       where fruit.StartsWith("p", StringComparison.OrdinalIgnoreCase) // Evite la casse
                       orderby fruit
                       select fruit;

            // Afficher les résultats
            foreach (var fruit in res2)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("");
            Console.WriteLine("****************************************************************");



            /***************** REQUETE METHODE -> Liste nombres *****************/

            List<int> nombres = new List<int> { 5, 12, 24, 0, 3, 50 };

            var res3 = nombres
                .Where(numero => numero > 10)  
                .ToList();

            // Affiche le résultat
            Console.WriteLine("Résultats :");
            foreach (var numero in res3)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("");
            Console.WriteLine("****************************************************************");







            /***************** REQUETE METHODE -> FRUITS *****************/

            List<string> listfruits = new List<string> { "pêche", "pomme", "poire", "orange", "banane", "ananas", "raisin" };

            var reqMetFruits = listfruits.Where(fruit => fruit.Length > 5);

            // Affiche le résultat
            Console.WriteLine("");
            Console.WriteLine($"Le nombres de fruits est de {reqMetFruits.Count()} !");

            // Afficher les résultats
            foreach (var fruit in reqMetFruits)
            {
                Console.WriteLine($"Il y a {fruit}");
            }

            Console.WriteLine("");
            Console.WriteLine("****************************************************************");






            /***************** REQUETE METHODE -> FRUITS Commençant par un p *****************/
            var resqStartP = Maliste
               .Where(fruit => fruit.StartsWith("p", StringComparison.OrdinalIgnoreCase))  
               .OrderBy(fruit => fruit)  
               .ToList();

            // Afficher les résultats
            Console.WriteLine("Résultats :");
            Console.WriteLine("");
            foreach (var fruit in resqStartP)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("");
            Console.WriteLine("****************************************************************");


            #region Recherhe Mot

            // Recherche Mots dans un texte
            string text = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";

            string search = "data";

            string[] motsTab = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            #region AVEC REQ
            var searchQuery = from word in motsTab
                              where word.ToLower() == search
                              select word;

            Console.WriteLine($"Nombre d'occurences du mot '{search}' : {searchQuery.Count()}");
            #endregion

            #region AVEC MET
            var searchMet = motsTab.Where(word => word.ToLower() == search);
            Console.WriteLine($"Nombre d'occurences du mot '{search}' : {searchMet.Count()}");
            #endregion

            #endregion




            #endregion

            #endregion
        }
    }
}
