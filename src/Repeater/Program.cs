using System.Diagnostics;
using ProgramRepeaterNS;
namespace RepeaterNS;

static class Repeater{

  static void Main(){
    string[] args = Environment.GetCommandLineArgs();
    string path = args[1]; 
    UserProgram program = ProgramRepeater.GetProgram(path, 0);
    int period = program.Config.Period; 
    string[] programFiles = System.IO.Directory.GetFiles(path);

    programFiles = programFiles.Where(file => !(file.Contains("config.json"))).ToArray();

    foreach(string file in programFiles){

      Console.WriteLine(file);
    }
    program.Config.ContainerId = Process.GetCurrentProcess().Id;
    program.Config.Enabled = true;
    ProgramRepeater.UpdateProgramConfig(program);
  }
    
}