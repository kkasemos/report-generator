using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> dupProducts = new List<string>();
            var reportGenerator = new ReportGenerator();
            var inputData = File.ReadAllText(args[0]);
            var outputData = reportGenerator.Generate(inputData, dupProducts);

            File.WriteAllText("out.txt", outputData);
            if (dupProducts.Count > 0)
            {
                var errorMessages = dupProducts.Select(d => string.Format("{0} records have different amounts", d));
                File.WriteAllText("error.log", string.Join("\n\r", errorMessages));
                Console.Error.WriteLine("Error occurred, please see the error.log file");
                Environment.Exit(-1);
            }
        }
    }
}
