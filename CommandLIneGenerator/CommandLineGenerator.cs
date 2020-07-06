using System;
using System.IO;
using System.Diagnostics;

namespace CommandLIneGenerator
{
    class CommandLineGenerator
    {
        private string cmd;
        private string Executable = "Executable";
        private string ProcessingDir = "Processing dir";
        private string StartPort = "Start Port";
        private string CpuCores = "Cpu Cores";

        public CommandLineGenerator() { cmd = ""; }

        public string GetCurrentDirector() { return Directory.GetCurrentDirectory(); }
        public void SetExecutableDir(string _Executable) { Executable = _Executable; }
        public void SetRepositoryDir(string _ProcessingDir) { ProcessingDir = _ProcessingDir; }
        public void SetStartPort(string _StartPort) { StartPort = _StartPort; }
        public void SetCpuCores(string _CpuCores) { CpuCores = _CpuCores; }
        public string AddToCommandLine(string addCmd) { return (cmd += addCmd); }

        public void ExecuteCommand()
        {
            var proc = new Process();
            proc.StartInfo.FileName = Executable;
            proc.StartInfo.Arguments = string.Format(@"{0} {1} {2}", ProcessingDir, StartPort, CpuCores);
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            string outPut = proc.StandardOutput.ReadToEnd();

            proc.WaitForExit();
            var exitCode = proc.ExitCode;
            proc.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CommandLineGenerator cl = new CommandLineGenerator();

            cl.SetExecutableDir(@"C:\SSMCharacterizationHandler\Application\Modelers\780200XXC00\780200XXC00.exe");
            cl.SetRepositoryDir(@"C:\SSMCharacterizationHandler\ProcessingBuffer\1307106_202002181307");
            cl.SetStartPort("-s 3000");
            cl.SetCpuCores("-p 4");

            cl.ExecuteCommand();
        }
    }
}
