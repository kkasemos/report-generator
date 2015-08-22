using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public class ReportGenerator
    {
        public string Generate(string data, List<string> dupProducts)
        {
            var stringBuilder = new StringBuilder();
            var records = data.Split(new string[] { "\r\n" }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(l => l.Split(','));

            // Group by Product Name and Amount 
            var recordGroups = records.GroupBy(
                r => new { Name = r[0], Amount = r[1] },
                (key, elements) => new
                {
                    Name = key.Name,
                    Amount = key.Amount,
                    Qty = elements.Count()
                });

            // Find the records are duplicate after grouping
            var dupRecords = recordGroups.GroupBy(
                g => g.Name,
                (key, elements) => new
                {
                    Name = key,
                    Qty = elements.Count()
                })
                .Where(r => r.Qty > 1);

            foreach (var rg in recordGroups)
            {
                if(!dupRecords.Any(d => d.Name.Equals(rg.Name)))
                {
                    stringBuilder.AppendLine(string.Format("{0},{1},{2}",
                        rg.Name, rg.Amount, rg.Qty));
                }
            }

            dupProducts.AddRange(dupRecords.Select(d => d.Name).ToList());

            return stringBuilder.ToString();
        }
    }
}
