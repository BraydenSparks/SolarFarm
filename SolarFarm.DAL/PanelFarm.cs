using SolarFarm.Core.DTO;
using SolarFarm.Core.Interfaces;
using SolarFarm.DAL.Formatters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.DAL
{
    public class PanelFarm : IPanelFarm
    {
        private List<SolarPanel> _panels;
        private string _path;

        public PanelFarm()
        {
            _panels = new List<SolarPanel>();
            _path = Directory.GetCurrentDirectory() + "/Data/SolarFarm.csv";
            SolarPanelCSVFormatter csv = new SolarPanelCSVFormatter();
            using (StreamReader sr = new StreamReader(_path))
            {
                string currentLine = sr.ReadLine();
                if (currentLine != null)
                {
                    currentLine = sr.ReadLine();
                }
                while (currentLine != null)
                {
                    SolarPanel panel = csv.Deserialize(currentLine.Trim());
                    _panels.Add(panel);
                    currentLine = sr.ReadLine();
                }
            }
        }

        public Result<SolarPanel> Add()
        {
            return new Result<SolarPanel>();
        }

        public Result<SolarPanel> Edit()
        {
            return new Result<SolarPanel>();
        }

        public Result<List<SolarPanel>> GetAll()
        {
            return new Result<List<SolarPanel>>();
        }

        public Result<SolarPanel> Remove()
        {
            return new Result<SolarPanel>();
        }

        public void WriteToFile()
        {
            SolarPanelCSVFormatter csv = new SolarPanelCSVFormatter();
            File.WriteAllText(_path, "Section,Row,Column,Year,Material,IsTracking");
            bool appendMode = true;
            using (StreamWriter sw = new StreamWriter(_path, appendMode))
            {
                foreach (SolarPanel panel in _panels)
                {
                    sw.Write($"\n{csv.Serialize(panel)}");
                }
            }
        }
    }
}
