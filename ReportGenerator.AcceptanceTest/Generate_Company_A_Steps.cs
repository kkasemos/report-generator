using NUnit.Framework;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace ReportGenerator.AcceptanceTest
{
    [Binding]
    public sealed class Generate_Company_A_Steps
    {
        private StringBuilder stringBuilder;
        private ReportGeneratorDriver driver = new ReportGeneratorDriver();
        private string message;
        private string logFileName;

        [Given(@"Input is")]
        public void GivenInputIs(Table table)
        {
            stringBuilder = new StringBuilder();

            foreach (var row in table.Rows)
            {
                var name = row["Product Name"];
                var amount = row["Amount"];

                string line = string.Format("{0},{1}", name, amount);
                stringBuilder.AppendLine(line);
            }
        }

        [When(@"It generates a report")]
        public void WhenItGeneratesAReport()
        {
            string tempFileName = Path.GetTempFileName();

            File.WriteAllText(tempFileName, stringBuilder.ToString());
            driver.GenerateReport(tempFileName, out message);
        }

        [Then(@"Output is")]
        public void ThenOutputIs(Table table)
        {
            var outputString = File.ReadAllText("out.txt");
            var expectedStringBuilder = new StringBuilder();

            foreach (var row in table.Rows)
            {
                var name = row["Product Name"];
                var amount = row["Amount"];
                var qty = row["Qty"];

                string line = string.Format("{0},{1},{2}", name, amount, qty);
                expectedStringBuilder.AppendLine(line);
            }

            Assert.AreEqual(expectedStringBuilder.ToString(), outputString);
        }

        [Then(@"Error message ""(.*)"" displayed")]
        public void ThenErrorMessageDisplayed(string expectedMsg)
        {
            Assert.AreEqual(expectedMsg, message.Trim());
        }

        [Then(@"Error log file is ""(.*)""")]
        public void ThenErrorLogFileIs(string expectedLogFileName)
        {
            logFileName = expectedLogFileName;
            Assert.IsTrue(File.Exists(expectedLogFileName));
        }

        [Then(@"Error log file contains")]
        public void ThenErrorLogFileContains(string expectedContent)
        {
            var content = File.ReadAllText(logFileName);
            Assert.AreEqual(expectedContent, content);
        }
    }
}
