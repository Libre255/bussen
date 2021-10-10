using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Bussen{
  
  public class BussConfig {
    private int [] Passengers = {12,43,23};
	private string[] MenuOptions = {
			"Add passangeres",
			"Print the all the passengers", 
			"Calculate the total age of all passengers", 
			"Calculate the average age",
			"Show the oldest passenger age",
			"Exit"
		};
    public void Run(){
		Menu myMenu = new Menu(MenuOptions);

     	int OptionIndex = myMenu.Run();

		switch (OptionIndex){
			case 0:add_passenger();
				break;
			case 1:print_buss();
				break;
			case 2:calc_total_age();
				break;
			case 3:calc_average_age();
				break;
			case 4:max_age();
				break;
			case 5:Exit();
				break;
			default:WriteLine("Welcom Aboard!");		
			break;
		}
	}  
	
	private void Exit(){
		WriteLine("Hope you enjoy your ride");
	}
	private void reRunMenu(){
		WriteLine("<< Press any key to go back to the menu  >>");
		ReadKey(true);
		Run();
	}
	private void add_passenger(){
		Clear();
		WriteLine($"Current Passangers: {Passengers.Length}");
		
		if(Passengers.Length == 25){
			WriteLine("The buss is full!!");
			
		}else{
			WriteLine("What age are you?");
			var input = ReadLine();
			int answer;
            bool parseSuccess = int.TryParse(input, out answer);
			if(parseSuccess){
				var tempList = Passengers.ToList();
				tempList.Add(answer);
				Passengers = tempList.ToArray();
			}else{
				WriteLine("You can only write numbers!");
			}
		}
		reRunMenu();
	}
	private void print_buss(){
		Clear();
		for (var i = 0; i < Passengers.Length; i++)	{
			WriteLine($"Passenger {i+1} has the age: {Passengers[i]}");
		}
		reRunMenu();
	}
	private void calc_total_age(){
		Clear();
		int totalAge = 0;
		
		for (var i = 0; i < Passengers.Length; i++)	{
			totalAge += Passengers[i];
		}

		WriteLine($"The total age of all passengers are: {totalAge}");
		reRunMenu();
	}
	private void calc_average_age(){
		Clear();
		double averegeAge = 0;
		
		for (var i = 0; i < Passengers.Length; i++)	{
			averegeAge += Passengers[i];
		}

		WriteLine($"The average age of the passengers in the buss are: {averegeAge/2}");
		reRunMenu();
	}
	private void max_age(){
		Clear();
		WriteLine($"The oldest person in the buss are: {Passengers.Max()}");
		reRunMenu();
	}
  }
}