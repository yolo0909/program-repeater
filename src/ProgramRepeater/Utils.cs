namespace ProgramRepeaterNS;

public class Utils{

  public static long GetTimestamp(){
    DateTime dateTime = DateTime.Now;
    long timestamp = ((DateTimeOffset) dateTime).ToUnixTimeMilliseconds();
    return timestamp;
  }

}