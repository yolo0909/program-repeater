using System.Data.Common;

namespace ProgramRepeaterNS;

public class UserProgram{

  public int Id {get; set;} 
  public string Path {get; set;}
  public long Timestamp {get; set;}
  private Config config;
  public Config Config
  {
    get => config;
    set => config = value;   
  }

  public UserProgram(string path, int id, long timestamp){
    if (path == null){
      throw new ArgumentNullException(nameof(path));
    }
    this.Path = path;
    this.Id = id;
    this.Timestamp = timestamp;
    Config = new Config();
  }

}
