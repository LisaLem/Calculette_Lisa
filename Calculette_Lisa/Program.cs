﻿
using System;

List<double> notes = new List<double>();
do
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\tSuper calculette :)\n");
    Console.ResetColor();

    Console.ForegroundColor= ConsoleColor.DarkGray;
    Console.WriteLine("\t1 - Addition \n");
    Console.WriteLine("\t2 - Soustraction \n");
    Console.WriteLine("\t3 - Multiplication \n");
    Console.WriteLine("\t4 - Division \n");
    Console.WriteLine("\t0 - Quitter \n");
    Console.WriteLine(" \n");
    Console.Write($"\tQuel calcul voulez-vous effectuer ? ");
    int gestionNotes = int.Parse(Console.ReadLine());
    Console.ResetColor();

    switch (gestionNotes)
    {
        case 1:
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("- Addition -\n");

            Console.Write("Entrez votre premier nombre s'il-vous-plaît : ");
            int nombreA1 = int.Parse(Console.ReadLine());

            Console.Write("Entrez votre deuxime nombre s'il-vous-plaît : ");
            int nombreA2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Le résultat de votre calcul est : {nombreA1 + nombreA2}");
            
            Console.ResetColor();

            break;


        case 2:
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Soustraction -\n");

            Console.Write("Entrez votre premier nombre s'il-vous-plaît : ");
            int nombreS1 = int.Parse(Console.ReadLine());

            Console.Write("Entrez votre deuxime nombre s'il-vous-plaît : ");
            int nombreS2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Le résultat de votre calcul est : {nombreS1 - nombreS2}");
            
            Console.ResetColor();

            break;

        case 3:
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Multiplication -\n");

            Console.Write("Entrez votre premier nombre s'il-vous-plaît : ");
            int nombreM1 = int.Parse(Console.ReadLine());

            Console.Write("Entrez votre deuxime nombre s'il-vous-plaît : ");
            int nombreM2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Le résultat de votre calcul est : {nombreM1 * nombreM2}");
            
            Console.ResetColor();

            break;

        case 4:
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Division -\n");

            Console.Write("Entrez votre premier nombre s'il-vous-plaît : ");
            int nombreD1 = int.Parse(Console.ReadLine());

            Console.Write("Entrez votre deuxime nombre s'il-vous-plaît : ");
            int nombreD2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Le résultat de votre calcul est : {nombreD1 / nombreD2}");

            Console.ResetColor();

            break;

        case 0:

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine("\n A la prochaine, salut ! ");
            Console.ResetColor();

            Environment.Exit(0);

            break;
    }


}

while (true);



// Version basique

//int resultat;

//Console.Write("Entrez votre premier nombre s'il-vous-plaît : ");
//int nombre1 = int.Parse(Console.ReadLine());

//Console.Write("Entrez votre deuxime nombre s'il-vous-plaît : ");
//int nombre2 = int.Parse(Console.ReadLine());

//Console.Write("Entrez votre symbole calculateur (+-*/) : ");
//string symbole = Console.ReadLine();

//if (symbole == "+")
//{
//    Console.WriteLine($"Le résultat de votre calcul est : {nombre1 + nombre2}");
//}
//else if (symbole == "-")
//{
//    Console.WriteLine($"Le résultat de votre calcul est : {nombre1 - nombre2}");
//}
//else if (symbole == "*")
//{
//    Console.WriteLine($"Le résultat de votre calcul est : {nombre1 * nombre2}");
//}
//else if (symbole == "/")
//{
//    Console.WriteLine($"Le résultat de votre calcul est : {nombre1 / nombre2}");
//}



// ESSAI 1

//void Additionner(int nombre1, int nombre2)
//{
//    int resultat = nombre1 + nombre2;
//}

//void Soustraire(int nombre1, int nombre2)
//{
//    int resultat = nombre1 - nombre2; 
//}
////Soustraire();

//void Multiplier(int nombre1, int nombre2)
//{
//    int resultat = nombre1 * nombre2;
//}

//void Diviser(int nombre1, int nombre2)
//{
//    int resultat = nombre1 / nombre2;
//    Console.WriteLine($"Votre calcul est égal à {resultat}\n"); 
//} 


//void Calcul(string calcul)
//{
//    switch (calcul)
//    {
//        case "+":
//            int resultatA = nombre1 + nombre2;
//            Console.WriteLine($"Votre calcul est égal à {resultatA}\n");
//            break;

//        case "-":
//            int resultatS = nombre1 - nombre2;
//            Console.WriteLine($"Votre calcul est égal à {resultatS}\n");
//            break;

//        case "*":
//            int resultatM = nombre1 * nombre2;
//            Console.WriteLine($"Votre calcul est égal à {resultatM}\n");
//            break;

//        case "/":
//            int resultatD = nombre1 / nombre2;
//            Console.WriteLine($"Votre calcul est égal à {resultatD}\n");
//            break;

//        default:
//            Console.WriteLine("Erreur de saisie.");
//            break;
//    }
//}




//switch(symbole)
//{
//    case "+":
//        resultat = nombre1 + nombre2;
//        break;
//    case "-":
//        resultat = nombre1 - nombre2;
//        break; 
//    case "*":
//        resultat = nombre1 * nombre2;
//        break;
//    case "/":
//        resultat = nombre1 / nombre2;
//        break;
//    default:
//        Console.WriteLine("Mauvaise saisie, navrée.");
//        break; 
//}
//Console.ReadLine();