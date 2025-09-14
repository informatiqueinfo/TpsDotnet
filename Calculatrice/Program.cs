// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Calculatrice;

Console.WriteLine("Bienvenue à ma calculatrice!");

var nb1 = decimal.Parse(Console.ReadLine());
var nb2 = decimal.Parse(Console.ReadLine());
MaCalculatrice calc = new MaCalculatrice(nb1,nb2);

Console.WriteLine("Choisis deux nombres :");


Console.WriteLine("Choisis l'opération :");
Console.WriteLine("  1) Addition (+)");
Console.WriteLine("  2) Soustraction (-)");
Console.WriteLine("  3) Multiplication (*)");
Console.WriteLine("  4) Division (/)");
Console.Write("Ton choix : ");

if (!int.TryParse(Console.ReadLine(), out int operation))
{
    Console.WriteLine("Choix invalide.");
    return;
}

try
{
    decimal resultat = operation switch
    {
        1 => calc.Addition(calc.nb1, calc.nb2),
        2 => calc.Soustraction(calc.nb1, calc.nb2),
        3 => calc.Multiplication(calc.nb1, calc.nb2),
        4 => calc.Division(calc.nb1, calc.nb2),
        _ => throw new ArgumentOutOfRangeException(nameof(operation), "Opération inconnue.")
    };

    Console.WriteLine($"Résultat : {resultat}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erreur : {ex.Message}");
}

