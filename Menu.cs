using static System.Console;
using static System.ConsoleColor;

namespace Bussen{
  public class Menu
  {
    private int SelectedOptionIndex;
    private string[] Options;
    private string Prompt;
    public Menu(string prompt, string[] options){
      Prompt = prompt;
      Options = options;
      SelectedOptionIndex = 1;

    } 
    public void DisplayOptions (){
      WriteLine(Prompt);
      for (var i = 0; i < Options.Length; i++)
      { 
        if(i == SelectedOptionIndex){
          ForegroundColor = Black;
          BackgroundColor = White;
        }else{
          ResetColor();
        }
          WriteLine($"<< {Options[i]} >>");
      }
      ResetColor();
    }
  }

}