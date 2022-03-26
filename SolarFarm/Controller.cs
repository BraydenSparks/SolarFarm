using SolarFarm.Core.DTO;
using SolarFarm.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.UI
{
    public class Controller
    {
        private ConsoleIO _io;
        public IPanelService Service;

        public Controller(ConsoleIO io, IPanelService service)
        {
            _io = io;
            Service = service;
        }

        public void Run()
        {
            bool running = true;
            DisplayStartup();
            while (running)
            {
                switch (GetMenuOption())
                {
                    case 0:
                        running = Exit();
                        break;
                    case 1:
                        FindBySection();
                        break;
                    case 2:
                        AddPanel();
                        break;
                    case 3:
                        UpdatePanel();
                        break;
                    case 4:
                        RemovePanel();
                        break;
                    default:
                        break;
                }
            }
        }

        private void RemovePanel()
        {
            _io.Display("Remove a Panel\n" +
                "=====================");

            string sectionName = _io.GetString("Section");
            int row = _io.GetInt("Row");
            int column = _io.GetInt("Column");

            Service.Remove(sectionName,row,column);
        }

        private void UpdatePanel()
        {
            _io.Display("Update a Panel\n" +
                 "=====================");

            string sectionName = _io.GetString("Section");
            int row = _io.GetInt("Row");
            int column = _io.GetInt("Column");

            Service.Update(sectionName, row, column);
        }

        private void AddPanel()
        {
            _io.Display("Add a Panel\n" +
                "=====================");

            SolarPanel panel = new SolarPanel();
            string sectionName = _io.GetString("Section");
            int row = _io.GetInt("Row");
            int column = _io.GetInt("Column");
            int year = _io.GetInt("Installation Year");
            Materials m = _io.GetMaterials("Material");
            bool isTracking = _io.GetBool("Tracked");

            Service.Add(panel);
        }

        private void FindBySection()
        {
            _io.Display("Find Panels by Section\n" +
                "=====================");
            string sectionName = _io.GetString("Section");


            Service.LoadSection(sectionName);
        }

        private bool Exit()
        {
            _io.DisplayWarning("You are about to exit...");
            string result = _io.GetYesNo("Are you sure you would like to exit? (y/n)");
            if (result == "y")
            {
                _io.DisplayWarning("--- Exiting Solar Farm ---");
                return false;
            }
            return true;
        }

        private int GetMenuOption()
        {
            DisplayMenu();
            int result = 0;
            bool isValidOption = false;
            while(!isValidOption)
            {
                result = _io.GetInt("Select [0-4]");
                if(result >= 0 && result <= 4)
                {
                    isValidOption = true;
                }
                else
                {
                    _io.DisplayError("Invalid menu option!");
                }
            }
            return result;
        }

        private void DisplayMenu()
        {
            _io.Display("Main Menu\n" + "=====================\n" +
                "0. Exit\n" +
                "1. Find Panels by Section\n" +
                "2. Add a Panel\n" +
                "3. Update a Panel\n" +
                "4. Remove a Panel");
        }

        private void DisplayStartup()
        {
            _io.Display("Welcome to Solar Farm\n" +
                "=====================\n");
        }
    }
}
