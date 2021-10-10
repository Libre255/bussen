using System;
using static System.Console;
using static System.ConsoleColor;

namespace Bussen{
	public class Menu{
		private int OptionIndex;
		private string[] Options;
		public Menu(string[] options){	
			Options = options;
			OptionIndex = 1;

		} 
		private void DisplayOptions (){
			WriteLine("Welcome to the awesome Buss-simulator");
			WriteLine("Use UP and DOWN arrows to nagivate");

			for (var i = 0; i < Options.Length; i++)
			{ 
				if(i == OptionIndex){
				ForegroundColor = Black;
				BackgroundColor = White;
				}else{
				ResetColor();
				}
				WriteLine($"<< {Options[i]} >>");
			}
			ResetColor();
		}

		public int Run(){
			ConsoleKey keyPressed;
			do{
				Clear();
				DisplayOptions();
				keyPressed = ReadKey(true).Key;

				if(keyPressed == ConsoleKey.UpArrow && OptionIndex > 0){
					OptionIndex --;
				}else if(keyPressed == ConsoleKey.DownArrow && OptionIndex < Options.Length - 1){
					OptionIndex ++; 
				}
				
			}while(keyPressed != ConsoleKey.Enter);
			
			return OptionIndex;
		}
	}
}