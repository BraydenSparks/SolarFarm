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
        public int Year { get; set; }
        public Materials Material { get; set; }
        public bool IsTracking { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------");
            sb.AppendLine($"Section: {Section}");
            sb.AppendLine($"Row: {Row}");
            sb.AppendLine($"Column: {Column}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"Material: {GetAbv()}");
            sb.AppendLine($"IsTracking: {GetTrackingStatus()}");
            sb.AppendLine("------------------");

            return sb.ToString();
        }

        public string GetAbv()
        {
            switch (Material)
            {
                case Materials.MULTICRYSTALLINESILICON:
                    return "Multi-Si";
                case Materials.MONOCRYSTALLINESILICON:
                    return "Mono-Si";
                case Materials.AMORPHOUSSILICON:
                    return "A-Si";
                case Materials.CADMIUMTELLURIDE:
                    return "CdTe";
                case Materials.COPPERINDIUMGALLIUMSELENIDE:
                    return "CIGS";
                default:
                    return "";  
            }
        }

        public string GetTrackingStatus()
        {
            return (IsTracking) ? "Yes" : "No";
        }
    }
}
