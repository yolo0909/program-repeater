namespace app;

public static class Globals{
  public static string? executionPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
}