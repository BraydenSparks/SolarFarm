using SolarFarm.BLL;
using SolarFarm.Core.Interfaces;
using SolarFarm.UI;
using System;

namespace SolarFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleIO io = new ConsoleIO();
            IPanelService service = PanelServiceFactory.GetPanelService();
            Controller controller = new Controller(io,service);
            controller.Run();
        }
    }
}
