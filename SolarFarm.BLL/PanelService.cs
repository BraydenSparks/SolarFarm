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
        private IPanelFarm _farm;

        public PanelService(IPanelFarm farm)
        {
            _farm = farm;
        }

        public Result<SolarPanel> Add(SolarPanel panel)
        {
            return _farm.Add();
        }

        public Result<List<SolarPanel>> LoadSection(string sectionName)
        {
            return _farm.GetAll();
        }

        public Result<SolarPanel> Remove(string sectionName, int row, int column)
        {
            return _farm.Remove();
        }

        public Result<SolarPanel> Update(string sectionName, int row, int column)
        {
            return _farm.Edit();
        }
    }
}
