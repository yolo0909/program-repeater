
using ProgramRepeaterNS;
namespace ConsoleUi;

static class Program{

  
  
  static int ParseUserInput(string[] args){

    if(args.Length == 0){
      Console.WriteLine("No arguments provided");
      return 0;
    }

    switch (args[1]){

      case "--enable":
        ProgramRepeater.Enable();
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
        ProgramRepeater.List();
        break;
      
      case "--enabled":
        break;

      case "--help":
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