using SolarFarm.Core.DTO;
using SolarFarm.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.DAL.Formatters
{
    public class SolarPanelCSVFormatter : ISolarPanelFormatter
    {
        public SolarPanel Deserialize(string data)
        {
            SolarPanel result = new SolarPanel();

            string[] fields = data.Split(",");
            result.Section = fields[0];
            result.Row = int.Parse(fields[1]);
            result.Column = int.Parse(fields[2]);
            result.Year = int.Parse(fields[3]);
            result.Material = (Materials)int.Parse(fields[4]);
            result.IsTracking = bool.Parse(fields[5]);

            return result;
        }

        public string Serialize(SolarPanel panel)
        {
            return $"{panel.Section},{panel.Row},{panel.Column},{panel.Year},{panel.Material},{panel.IsTracking}";
        }
    }
}
