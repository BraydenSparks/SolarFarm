using SolarFarm.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.Core.Interfaces
{
    public interface IPanelService
    {
        // Add a solar panel to the farm.
        Result<SolarPanel> Add(SolarPanel panel);

        // Update a solar panel.
        Result<SolarPanel> Update(string seectionName, int row, int column);

        // Remove a solar panel.
        Result<SolarPanel> Remove(string seectionName, int row, int column);

        // Display all solar panels in a section.
        Result<List<SolarPanel>> LoadSection(string sectionName);
    }
}
