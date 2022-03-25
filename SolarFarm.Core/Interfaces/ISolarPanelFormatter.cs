using SolarFarm.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.Core.Interfaces
{
    public interface ISolarPanelFormatter
    {
        SolarPanel Deserialize(string data);
        string Serialize(SolarPanel panel);
    }
}
