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
            while(result == null)
            {
                DisplayError("Error: input can not be null");
                result = GetIntOrNull(message);
            }
            return (int)result;
        }
        public decimal GetDecimal(string message)
        {
            decimal? result = GetDecimalOrNull(message);
            while (result == null)
            {
                DisplayError("Error: input can not be null");
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
                if(result == "y" || result == "n")
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
