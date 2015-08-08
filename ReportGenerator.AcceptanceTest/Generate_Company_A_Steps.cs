using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ReportGenerator.AcceptanceTest
{
    [Binding]
    public sealed class Generate_Company_A_Steps
    {
        private ReportGenerator reportGenerator;
        private StringBuilder stringBuilder;
        private string outputString;

        [Given(@"Input is")]
        public void GivenInputIs(Table table)
        {
            reportGenerator = new ReportGenerator();
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
            outputString = reportGenerator.Generate(stringBuilder.ToString());
        }

        [Then(@"Output is")]
        public void ThenOutputIs(Table table)
        {
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
    }
}
