using ProgramRepeaterNS;

namespace ConsoleUiNS;

public static class Ui{
  public static void List(){

    UserProgram[] programs = ProgramRepeater.GetAllPrograms();

    Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10} | {3,10}","Id", "Period", "Enabled", "Name"));

    for(int i = 0; i < programs.GetLength(0); i++){
      Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10} | {3,10}", programs[i].Id, programs[i].Config.Period, programs[i].Config.Enabled, programs[i].Config.Name));
    }

  }

  public static void Enable(int id){
    UserProgram[] programs = ProgramRepeater.GetAllPrograms();
    
    foreach(UserProgram program in programs){

      if(program.Id == id){

        if(program.Config.Enabled == true ){
          Console.WriteLine("Program already enabled");
          return;
        }else{
          ProgramRepeater.Enable(program.Path, id);
          return;
        }              
      }

    }
    Console.WriteLine("Program not found");
  }
}
