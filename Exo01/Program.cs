// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ecris ton prenom");
var prenom = Console.ReadLine();
Console.WriteLine("Ecris ton age");
string age = Console.ReadLine();
int t = Convert.ToInt32(age);
Console.WriteLine("bonjour "+prenom +",vous avez "+t+" ans");
Console.WriteLine($"Bonjour {prenom}, vous avez {t} ans ");