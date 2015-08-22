using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.AcceptanceTest
{
    public class ReportGeneratorDriver
    {
        public void GenerateReport(string inputFilePath, out string message)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.FileName = "ReportGenerator.exe";
            process.StartInfo.Arguments = inputFilePath;
            process.Start();
            process.WaitForExit();

            if(process.ExitCode == -1)
            {
                message = process.StandardError.ReadToEnd();
            }
            else
            {
                message = string.Empty;
            }
        }
    }
}
