using SolarFarm.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.Core.Interfaces
{
    public interface IPanelFarm
    {
        public Result<List<SolarPanel>> GetAll();

        public Result<SolarPanel> Add();

        public Result<SolarPanel> Edit();

        public Result<SolarPanel> Remove();
    }
}
