using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace app;

public static class ProgramRepeater{

  private static UserProgram[] GetAllPrograms(){
    string[] programDirectories = System.IO.Directory.GetDirectories(@$"{Globals.executionPath}\..\..\..\..\resources\programs");
    UserProgram[] userPrograms =  new UserProgram[programDirectories.GetLength(0)];
    for (int i = 0; i < userPrograms.GetLength(0); i++){

      DateTime dateTime = DateTime.Now;
      long timestamp = ((DateTimeOffset) dateTime).ToUnixTimeMilliseconds();
      userPrograms[i] = new UserProgram(programDirectories[i], i, timestamp);

      try{

        using(StreamReader reader = new StreamReader(String.Format($@"{programDirectories[i]}\config.json"))){
          string config_raw = reader.ReadToEnd();
          Config? config = JsonSerializer.Deserialize<Config>(config_raw);
          userPrograms[i].Name = config.Name;
          userPrograms[i].Description = config.Description;
          userPrograms[i].Period = config.Period;
          userPrograms[i].Enabled = config.Enabled;
        }

      }catch{

        Console.WriteLine("Error reading config file"); 

      }

    }
        
    return userPrograms;
  }
  public static void List(){
    UserProgram[] programs = GetAllPrograms();
    programs.ToList().ForEach(program => Console.WriteLine(program));  
    Console.WriteLine("List");
  } 

  public static void Enable(){
    Console.WriteLine("Enable");
  }
}