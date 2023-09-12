// Ålder Kontroll


int minAlder = 18;

Console.WriteLine("Hur Gammal är du?");
int användarenAlder = Convert.ToInt32(Console.ReadLine());

if(användarenAlder >= minAlder)
{
    Console.WriteLine("Du är gammal nog att köra rymdskepp!");

}
else
{
    Console.WriteLine("Du är för ung för att köra rymdskepp..");
}