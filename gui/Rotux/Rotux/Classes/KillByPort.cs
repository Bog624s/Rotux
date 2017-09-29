using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

public class PRC
{
    public int PID { get; set; }
    public int Port { get; set; }
    public string Protocol { get; set; }
}
public class ProcManager
{
    public void KillByPort(int port)
    {
        if (!(Environment.OSVersion.Platform == PlatformID.Win32NT))
        {
            Console.WriteLine("OS is not windows, so cannot kill processes by port!");
            return;

        }
        var processes = GetAllProcesses();
        if (processes.Any(p => p.Port == port))
            try
            {
                Process.GetProcessById(processes.First(p => p.Port == port).PID).Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Process was killed!");
            }
        else
        {
            Console.WriteLine("No process to kill!");
        }
    }

    public List<PRC> GetAllProcesses()
    {

        var pStartInfo = new ProcessStartInfo();
        pStartInfo.FileName = "netstat.exe";
        pStartInfo.Arguments = "-a -n -o";
        pStartInfo.CreateNoWindow = true;
        pStartInfo.UseShellExecute = false;
        pStartInfo.RedirectStandardInput = true;
        pStartInfo.RedirectStandardOutput = true;
        pStartInfo.RedirectStandardError = true;

        var process = new Process()
        {
            StartInfo = pStartInfo
        };
        process.Start();

        var soStream = process.StandardOutput;

        var output = soStream.ReadToEnd();
        if (process.ExitCode != 0)
            throw new Exception("The exit code wasn't 0.");

        var result = new List<PRC>();

        var lines = Regex.Split(output, "\r\n");
        foreach (var line in lines)
        {
            if (line.Trim().StartsWith("Proto"))
                continue;

            var parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var len = parts.Length;
                if (len > 2)
                    result.Add(new PRC
                    {
                        Protocol = parts[0],
                        Port = int.Parse(parts[1].Split(':').Last()),
                        PID = int.Parse(parts[len - 1])
                    });
            } catch
            {
                Console.WriteLine("Couldn't parse the output from netstat, is your PC running any other language than English?");
            }



        }
        return result;
    }
}