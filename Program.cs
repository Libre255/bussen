using System;
using static System.Console;
namespace Bussen
{
    class Program
    {
        static void Main(string[] args)
        {
            var minbuss = new BussConfig();
            string Prompt = "Welcom passanger";
            string[]Options = {"Start Buss","Add passangeres", "Calculate total Age", "Exit"};
           
            Menu myMenu = new Menu(Prompt, Options);
            
            myMenu.DisplayOptions();
            //Denna del körs först! 
			//Denna del av koden kan upplevas väldigt förvirrande. Men i sådana fall är det bara att "skriva av".
			//Programmet skapar ett så kallat objekt av klassen "Buss". Det är det objekt vi kommer jobba med.
			//Följande rad skapar en buss:
			
			//Följande rad anropar metoden Run() som finns i vårt nya buss-objekt.
			minbuss.Run();
			//När metoden Run() tar slut så kommer koden fortsätta här. Då är programmet slut
			Write("Press any key to continue . . . ");
			ReadKey(true);
        }
    }
}
