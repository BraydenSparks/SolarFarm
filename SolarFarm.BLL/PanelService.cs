using SolarFarm.Core.DTO;
using SolarFarm.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.BLL
{
    public class PanelService : IPanelService
    {
        public Result<SolarPanel> Add(SolarPanel panel)
        {
            throw new NotImplementedException();
        }

        public Result<List<SolarPanel>> LoadSection(string sectionName)
        {
            throw new NotImplementedException();
        }

        public Result<SolarPanel> Remove(string seectionName, int row, int column)
        {
            throw new NotImplementedException();
        }

        public Result<SolarPanel> Update(string seectionName, int row, int column)
        {
            throw new NotImplementedException();
        }
    }
}
