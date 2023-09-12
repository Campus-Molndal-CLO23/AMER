// Rymdskepp



using System;

int counter = 0;
bool b = true;

while  (b = true)
{
    Console.WriteLine("välja skepp (1, 2 eller 3)");
    string skeppsVal = Console.ReadLine();
          switch (skeppsVal)
            {

            case "1":
                Console.WriteLine("Du valde U.S.S. Enterprise!");
                break;

            case "2":
                Console.WriteLine("Du valde Klingon Bird of Prey!");
                break;
        
            case "3":
                Console.WriteLine("Du valde Romulan Warbird!");
                break;

            default:
                counter+= 1;
                Console.WriteLine("Fel valt.....");
           
            break;

             }//end of switch

        if(counter==4) //Counter for Fel Valt
        {
            b = false;
            break;
        }
    
}//end of while loop
Console.WriteLine("================================================");
Console.WriteLine("                                                ");
Console.WriteLine("Hejdå");
Console.ReadLine();