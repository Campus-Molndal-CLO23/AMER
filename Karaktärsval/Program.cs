// Karaktärsval 

Console.WriteLine("vilken färg de vill ha?");
Console.WriteLine(" ");
Console.WriteLine("Välja 1, 2, 3 eller 4 ");

string valdFarg = Console.ReadLine(); 
switch(valdFarg)
{
    case "1":
        Console.WriteLine("Du har valt en blå ljussabelkristall.");
        break;
   
    case "2":
        Console.WriteLine("Du har valt en grön ljussabelkristall.");
        break;
    
    case "3":
        Console.WriteLine("Du har valt en röd ljussabelkristall.");
        break;
   
    case "4":
        Console.WriteLine("Du har valt en lila ljussabelkristall.");
        break;

    default :
        Console.WriteLine("Ogiltigt val. Välj 1, 2, 3 eller 4");
        break;

}





