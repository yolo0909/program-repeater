using System.Data;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProgramRepeaterNS;

public static class ProgramRepeater{

  public static UserProgram GetProgram(string path,  int id){

    DateTime dateTime = DateTime.Now;
    long timestamp = ((DateTimeOffset) dateTime).ToUnixTimeMilliseconds();
    UserProgram program = new UserProgram(path, id, timestamp);
    Config a = new Config();
    Console.WriteLine(a.ToString());

    try{
      using(StreamReader reader = new StreamReader(String.Format($@"{path}{Globals.pathSeparator}config.json"))){
        string config_raw = reader.ReadToEnd();
        try{
          Config config = JsonSerializer.Deserialize<Config>(config_raw);    
          program.Config = config!;
        }catch(Exception e){
          Console.WriteLine(e.ToString());  
          throw new Exception("Error reading json of config file");
        }
        
        /*
        program.Config.Name = config.Name;
        program.Config.Description = config.Description;
        program.Config.Period = config.Period;
        program.Config.Enabled = config.Enabled;
        program.Config.ContainerId = config.ContainerId;
        program.Config.ProgramIds = config.ProgramIds;
        */
      }

    }catch(Exception e){

      Console.WriteLine(e.ToString() , " : Error reading config file"); 
      //program = new UserProgram(path, id , timestamp, new Config("Error", "Error", 0, false, 0, new List<int>()));
      /*
      program.Config.Name = "Error";
      program.Config.Description = "Error";
      program.Config.Period = 0;
      program.Config.Enabled = false;
      program.Config.ContainerId = 0;
      program.Config.ProgramIds = new List<int>(); 
      */
    }
    return program;
  }

  public static UserProgram[] GetAllPrograms(){
    string[] programDirectories = System.IO.Directory.GetDirectories(@$"{Globals.executionPath}{Globals.pathSeparator}..{Globals.pathSeparator}..{Globals.pathSeparator}..{Globals.pathSeparator}..{Globals.pathSeparator}..{Globals.pathSeparator}resources{Globals.pathSeparator}programs");
    UserProgram[] userPrograms =  new UserProgram[programDirectories.GetLength(0)];
    for (int i = 0; i < userPrograms.GetLength(0); i++){ 
      userPrograms[i] = GetProgram(programDirectories[i], i);
    }

    return userPrograms;
  }
  
  public static void UpdateProgramConfig(UserProgram program){
    string config_raw = JsonSerializer.Serialize<Config>(program.Config);
    System.IO.File.WriteAllText(String.Format($@"{program.Path}{Globals.pathSeparator}config.json"), config_raw);
    
  }
  public static async void Enable(string path, int id){

    Process process = new Process();
    process.StartInfo.Arguments = String.Format($@"{path}");
    process.StartInfo.FileName = String.Format($@"..{Globals.pathSeparator}..{Globals.pathSeparator}..{Globals.pathSeparator}..{Globals.pathSeparator}Repeater{Globals.pathSeparator}bin{Globals.pathSeparator}debug{Globals.pathSeparator}net7.0{Globals.pathSeparator}Repeater.exe");
    process.Start();
    Console.WriteLine(process.Id);
    Console.WriteLine("Yo");
  }
}