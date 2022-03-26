using SolarFarm.Core.Interfaces;
using SolarFarm.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.BLL
{
    public static class PanelServiceFactory
    {
        public static IPanelService GetPanelService()
        {
            return new PanelService(new PanelFarm());
        }

    }
}
