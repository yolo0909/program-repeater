namespace ProgramRepeaterNS;

public static class Globals{
  public static string? executionPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
  public static char pathSeparator = Path.DirectorySeparatorChar;
  
}