// See https://aka.ms/new-console-template for more information
Console.WriteLine("saisie ton prenom");
const int majorite = 18;
string prenom = Console.ReadLine();
Console.WriteLine("saisie ton age");
string age = Console.ReadLine();
int a = int.Parse(age);
Console.WriteLine("Bonjour " + prenom + ", vous avez " + age);

bool majeure = (a >= 18);
if (majeure == true)
{
    Console.WriteLine("Vous etes majeure");

}
else
{
    Console.WriteLine("Vous etes mineur");

}