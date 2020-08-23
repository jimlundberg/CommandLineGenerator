using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

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


        public static void StandardOutputDisplay()
        {
            Console.WriteLine("Standard Out");
        }

        public Process ExecuteCommand()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Executable);

            startInfo.Arguments = String.Format("-d {0} {1} {2}", ProcessingDir, StartPort, CpuCores);
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = ProcessingDir;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            Process ModelerProcess = Process.Start(startInfo);
            ModelerProcess.PriorityClass = ProcessPriorityClass.High;

            return ModelerProcess;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CommandLineGenerator cmdLine1 = new CommandLineGenerator();
            cmdLine1.SetExecutableDir(@"C:\SSMCharacterizationHandler\Application\Modelers\780200XXC00\780200XXC00.exe");
            cmdLine1.SetRepositoryDir(@"C:\SSMCharacterizationHandler\ProcessingBuffer\1185840_202003250942");
            cmdLine1.SetStartPort("-s 3000");
            cmdLine1.SetCpuCores("-p 4");
            Process Job1 = cmdLine1.ExecuteCommand();

            Thread.Sleep(1000);

            CommandLineGenerator cmdLine2 = new CommandLineGenerator();
            cmdLine2.SetExecutableDir(@"C:\SSMCharacterizationHandler\Application\Modelers\780200XXC00\780200XXC00.exe");
            cmdLine2.SetRepositoryDir(@"C:\SSMCharacterizationHandler\ProcessingBuffer\1307106_202002181307");
            cmdLine2.SetStartPort("-s 3001");
            cmdLine2.SetCpuCores("-p 4");
            Process Job2 = cmdLine2.ExecuteCommand();

            Thread.Sleep(20000);

            Console.WriteLine($"ProcessName                 : {Job1.ProcessName}");
            Console.WriteLine($"StartInfo                   : {Job1.StartInfo}");
            Console.WriteLine($"Id                          : {Job1.Id}");
            Console.WriteLine($"SessionId                   : {Job1.SessionId}");
            Console.WriteLine($"Handle                      : {Job1.Handle}");
            Console.WriteLine($"SafeHandle                  : {Job1.SafeHandle}");
            Console.WriteLine($"GetType                     : {Job1.GetType()}");
            Console.WriteLine($"Basepriority                : {Job1.BasePriority}");
            Console.WriteLine($"Process Number of Modules   : {Job1.Modules}");
            Console.WriteLine($"Threads                     : {Job1.Threads}");
            Console.WriteLine($"HandleCount                 : {Job1.HandleCount}");
            Console.WriteLine($"MaxWorkingSet               : {Job1.MaxWorkingSet}");
            Console.WriteLine($"MinWorkingSet               : {Job1.MinWorkingSet}");
            Console.WriteLine($"MainWindowHandle            : {Job1.MainWindowHandle}");
            Console.WriteLine($"MachineName                 : {Job1.MachineName}");
            Console.WriteLine($"ToString                    : {Job1.ToString()}");
            Console.WriteLine($"MainModule                  : {Job1.MainModule}");
            Console.WriteLine($"MainWindowTitle             : {Job1.MainWindowTitle}");
            Console.WriteLine($"NonpagedSystemMemorySize64  : {Job1.NonpagedSystemMemorySize64}");
            Console.WriteLine($"PeakVirtualMemorySize64     : {Job1.PeakVirtualMemorySize64}");
            Console.WriteLine($"PagedSystemMemorySize64     : {Job1.PagedSystemMemorySize64}");
            Console.WriteLine($"PrivateMemorySize64         : {Job1.PrivateMemorySize64}");
            Console.WriteLine($"VirtualMemorySize64         : {Job1.VirtualMemorySize64}");
            Console.WriteLine($"NonpagedSystemMemorySize64  : {Job1.PagedMemorySize64}");
            Console.WriteLine($"WorkingSet64                : {Job1.WorkingSet64}");
            Console.WriteLine($"PeakWorkingSet64            : {Job1.PeakWorkingSet64}");
            Console.WriteLine($"PriorityBoostEnabled        : {Job1.PriorityBoostEnabled}");
            Console.WriteLine($"Site                        : {Job1.Site}");
            Console.WriteLine($"Responding                  : {Job1.Responding}");
            Console.WriteLine($"ProcessorAffinity           : {Job1.ProcessorAffinity}");
            Console.WriteLine($"StartTime                   : {Job1.StartTime}");
            Console.WriteLine($"PrivilegedProcessorTime     : {Job1.PrivilegedProcessorTime}");
            Console.WriteLine($"PriorityClass               : {Job1.PriorityClass}");
            Console.WriteLine($"TotalProcessorTime          : {Job1.TotalProcessorTime}");
            Console.WriteLine($"UserProcessorTime           : {Job1.UserProcessorTime}");

            Console.WriteLine(" ");

            Console.WriteLine($"ProcessName                 : {Job2.ProcessName}");
            Console.WriteLine($"StartInfo                   : {Job2.StartInfo}");
            Console.WriteLine($"Id                          : {Job2.Id}");
            Console.WriteLine($"SessionId                   : {Job2.SessionId}");
            Console.WriteLine($"Handle                      : {Job2.Handle}");
            Console.WriteLine($"SafeHandle                  : {Job2.SafeHandle}");
            Console.WriteLine($"GetType                     : {Job2.GetType()}");
            Console.WriteLine($"Basepriority                : {Job2.BasePriority}");
            Console.WriteLine($"Process Number of Modules   : {Job2.Modules}");
            Console.WriteLine($"Threads                     : {Job2.Threads}");
            Console.WriteLine($"HandleCount                 : {Job2.HandleCount}");
            Console.WriteLine($"MaxWorkingSet               : {Job2.MaxWorkingSet}");
            Console.WriteLine($"MinWorkingSet               : {Job2.MinWorkingSet}");
            Console.WriteLine($"MainWindowHandle            : {Job2.MainWindowHandle}");
            Console.WriteLine($"MachineName                 : {Job2.MachineName}");
            Console.WriteLine($"ToString                    : {Job2.ToString()}");
            Console.WriteLine($"MainModule                  : {Job2.MainModule}");
            Console.WriteLine($"MainWindowTitle             : {Job2.MainWindowTitle}");
            Console.WriteLine($"NonpagedSystemMemorySize64  : {Job2.NonpagedSystemMemorySize64}");
            Console.WriteLine($"PeakVirtualMemorySize64     : {Job2.PeakVirtualMemorySize64}");
            Console.WriteLine($"PagedSystemMemorySize64     : {Job2.PagedSystemMemorySize64}");
            Console.WriteLine($"PrivateMemorySize64         : {Job2.PrivateMemorySize64}");
            Console.WriteLine($"VirtualMemorySize64         : {Job2.VirtualMemorySize64}");
            Console.WriteLine($"NonpagedSystemMemorySize64  : {Job2.PagedMemorySize64}");
            Console.WriteLine($"WorkingSet64                : {Job2.WorkingSet64}");
            Console.WriteLine($"PeakWorkingSet64            : {Job2.PeakWorkingSet64}");
            Console.WriteLine($"PriorityBoostEnabled        : {Job2.PriorityBoostEnabled}");
            Console.WriteLine($"Site                        : {Job2.Site}");
            Console.WriteLine($"Responding                  : {Job2.Responding}");
            Console.WriteLine($"ProcessorAffinity           : {Job2.ProcessorAffinity}");
            Console.WriteLine($"StartTime                   : {Job2.StartTime}");
            Console.WriteLine($"PrivilegedProcessorTime     : {Job2.PrivilegedProcessorTime}");
            Console.WriteLine($"PriorityClass               : {Job2.PriorityClass}");
            Console.WriteLine($"TotalProcessorTime          : {Job2.TotalProcessorTime}");
            Console.WriteLine($"UserProcessorTime           : {Job2.UserProcessorTime}");

            // Kill both processes - watch Task Manager...
            Thread.Sleep(5000);
            Job1.Kill();

            Thread.Sleep(1000);
            Job2.Kill();

            Console.WriteLine(" ");

            Job1.WaitForExit();
            Console.WriteLine("Job 1 killed");

            Job2.WaitForExit();
            Console.WriteLine("Job 2 killed");
        }
    }
}
