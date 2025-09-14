// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Bienvenue au jeu Nombre Mystere");

const int Mystere = 6;
Console.WriteLine("Essaies de deviner le chiffre, Inseres ton prénom pour commencer ");
var prenom = Console.ReadLine();
Console.WriteLine("choisis un nombre entre 1 et 10");
int a = int.Parse(Console.ReadLine());
while (a < 1 || a > 10)
{
    
    
}
try
{
    while (a != Mystere)
    {
        if (a > Mystere)
        {
            Console.WriteLine("Tu as perdu, choisis un chiffre moins !!");
            a = int.Parse(Console.ReadLine());

        }
        else
        {
            Console.WriteLine("Tu as perdu, choisis un chiffre plus !!");

            a = int.Parse(Console.ReadLine());
        }
    }

    if (a == Mystere)
    {
        Console.WriteLine("Tu as gagné, Bravo !!");
    }
}
catch
{
    Console.WriteLine("Corriges le format avant de commencer");

}