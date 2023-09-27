namespace ProgramRepeaterNS;

public class Config{
  public string? Name {get; set;}
  public string? Description {get; set;}
  public int Period {get; set;}
  public bool Enabled {get; set;}
  public int? ContainerId {get; set;}
  public List<int>? ProgramIds {get; set;}
  public Config(){

  }

}