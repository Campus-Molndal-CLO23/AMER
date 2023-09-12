// See https://aka.ms/new-console-template for more information



string korrektLosenord = "MittLosenord123";

Console.WriteLine("Mata in din Losenord....   ");
string anvanadreLosenord = Console.ReadLine();

if (korrektLosenord == anvanadreLosenord)
{
    Console.WriteLine("Välkommen, Jedi-mästare!");
}
else
{
    Console.WriteLine("Fel lösenord. Försök igen.");

}