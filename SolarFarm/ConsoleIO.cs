using SolarFarm.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarFarm.UI
{
    public class ConsoleIO
    {
        // nullable console input methods -----
        public int? GetIntOrNull(string message)
        {
            int result = 0;
            Prompt(message);
            if (!int.TryParse(Console.ReadLine(), out result))
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public decimal? GetDecimalOrNull(string message)
        {
            decimal result = 0;
            Prompt(message);
            if (!Decimal.TryParse(Console.ReadLine(), out result))
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public string? GetStringOrNull(string message)
        {
            Prompt(message);
            return Console.ReadLine().Trim().ToLower();
        }

        // non nullable input methods
        public int GetInt(string message)
        {
            int? result = GetIntOrNull(message);
            while (result == null)
            {
                DisplayError("Error: invalid input!");
                result = GetIntOrNull(message);
            }
            return (int)result;
        }
        public decimal GetDecimal(string message)
        {
            decimal? result = GetDecimalOrNull(message);
            while (result == null)
            {
                DisplayError("Error: invalid input!");
                result = GetIntOrNull(message);
            }
            return (decimal)result;
        }

        public string GetString(string message)
        {
            string result = GetStringOrNull(message);
            while (string.IsNullOrEmpty(result))
            {
                DisplayError("Error: input can not be null");
                result = GetStringOrNull(message);
            }
            return result;
        }

        public string GetYesNo(string message)
        {
            string result = "";
            bool isYesNo = false;
            while (!isYesNo)
            {
                result = GetString(message);
                if (result == "y" || result == "n")
                {
                    isYesNo = true;
                }
                else
                {
                    DisplayError("Error: Input was not y or n.");
                }
            }
            return result;
        }
        public bool GetBool(string message)
        {
            bool result = false;
            bool isBool = false;
            while (!isBool)
            {
                Prompt(message);
                if (!bool.TryParse(Console.ReadLine(), out result))
                {
                    DisplayError("Error: Must be true or false.");
                }
                else
                {
                    isBool = true;
                }
            }
            return result;
        }

        public Materials GetMaterials(string message)
        {
            while (true)
            {
                string code = GetString(message);
                switch (code)
                {
                    case "multi-si":
                        return Materials.MULTICRYSTALLINESILICON;
                    case "mono-si":
                        return Materials.MONOCRYSTALLINESILICON;
                    case "a-si":
                        return Materials.AMORPHOUSSILICON;
                    case "cdte":
                        return Materials.CADMIUMTELLURIDE;
                    case "cigs":
                        return Materials.COPPERINDIUMGALLIUMSELENIDE;
                    default:
                        DisplayError("Error: Invalid material code.\n" +
                            "Multi-Si, Mono-Si, A-Si, CdTe, or CIGS.");
                        break;
                }
            }
        }

        // Console output methods -----
        public void Prompt(string message)
        {
            Console.Write(message + ": ");
        }
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        public void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Display($"\n{message}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void DisplayWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Display($"\n{message}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void DisplaySuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Display($"\n{message}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}