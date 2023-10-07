using System.Data.Common;

namespace ProgramRepeaterNS;

public class UserProgram{

  public int Id {get; set;} 
  public string Path {get; set;}
  public long Timestamp {get; set;}
  public Config Config {get; set;}
  public UserProgram(string path, int id, long timestamp){
    
    this.Path = path;
    this.Id = id;
    this.Timestamp = timestamp;
    this.Config = new Config();
  }

}
