using SolarFarm.Core.DTO;
using SolarFarm.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.DAL
{
    public class PanelFarm : IPanelFarm
    {
        private List<SolarPanel> _panels;


        public Result<SolarPanel> Add()
        {
            throw new NotImplementedException();
        }

        public Result<SolarPanel> Edit()
        {
            throw new NotImplementedException();
        }

        public Result<List<SolarPanel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Result<SolarPanel> Remove()
        {
            throw new NotImplementedException();
        }
    }
}
