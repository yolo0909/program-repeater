using System.Data.Common;

namespace app;

public class UserProgram{

  public string? Name {get; set;}
  public int Id {get; set;}
  public string? Description {get; set;}
  public int Period {get; set;}
  public bool Enabled {get; set;} 
  public string Path {get; set;}
  public string? ProgramId {get; set;}
  public long Timestamp {get; set;}
  public UserProgram(string path, int id, long timestamp){
    if (path == null){
      throw new ArgumentNullException(nameof(path));
    }
    this.Path = path;
    this.Id = id;
    this.Timestamp = timestamp;
  }

}
