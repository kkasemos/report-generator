using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public class ReportGenerator
    {
        public string Generate(string data)
        {
            var stringBuilder = new StringBuilder();
            var records = data.Split(new string[] { "\r\n" }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(l => l.Split(','));

            var recordGroups = records.GroupBy(
                r => r[0],
                (name, elements) => new
                {
                    Name = name,
                    Amount = elements.Max(e => e[1]),
                    Qty = elements.Count()
                });

            foreach (var rg in recordGroups)
            {
                stringBuilder.AppendLine(string.Format("{0},{1},{2}", 
                    rg.Name, rg.Amount, rg.Qty));
            }

            return stringBuilder.ToString();
        }
    }
}
