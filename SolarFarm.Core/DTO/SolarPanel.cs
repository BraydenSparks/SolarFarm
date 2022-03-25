using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.Core.DTO
{
    public class SolarPanel
    {
        public string Section { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public string Year { get; set; }
        public bool IsTracking { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------");
            sb.AppendLine($"Section: {Section}");
            sb.AppendLine($"Row: {Row}");
            sb.AppendLine($"Column: {Column}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"IsTracking: {IsTracking}");
            sb.AppendLine("------------------");

            return sb.ToString();
        }
    }
}
