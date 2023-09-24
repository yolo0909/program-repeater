
using ProgramRepeaterNS;
namespace ConsoleUiNS;

static class Program{

  
  
  static int ParseUserInput(string[] args){

    if(args.Length == 1){
      Console.WriteLine("No arguments provided");
      return 0;
    }

    switch (args[1]){

      case "--enable":
        
        try{
          int id = Int32.Parse(args[2]);
          Ui.Enable(id);
        }catch (Exception e){
          Console.WriteLine(e.ToString() , " \n Invalid argument");
        }

        break;

      case "--disable":
        break;
      
      case "--shutdown":
        break;

      case "--add":
        break;

      case "--remove":
        break;
      
      case "--list":
        Ui.List();
        break;
      
      case "--enabled":
        break;

      case "--help":
        break;

      default:
        Console.WriteLine("Invalid argument");
        break;
    }


    return 1;
  }
  static void Main(){

    string[] args = Environment.GetCommandLineArgs();
    ParseUserInput(args);

    Console.WriteLine("Hello World!");
  }

}