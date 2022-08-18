using System;
using System.Reflection.Metadata.Ecma335;

namespace MVC_2.Models
{
    public class Doctor
    {
        public static string Message { get; set; }


        public static string CheckFever(string name, string radiobt, double temperature)
        {
            double tempInCelsius;
            /* Fahrenheit to Celsius = (Fahrenheit  - 32) * 5 / 9 */
            if (radiobt != "celsius")
            {
                tempInCelsius = (temperature - 32) * 5 / 9;
                temperature = tempInCelsius;
            }

          /** Below 35 celsius = hypothermia
              35 to 37.9 Normal,
              38 to 39.4 Fever
              39.5 to 40.99 high fever
              41 very high **/
            switch (temperature)
            {
                case < 35:
                    Message = "You have hypothermia.";
                    break;
                case < 38:
                    Message = "You dont have a fever.";
                    break;
                case < 39.5:
                    Message = "You have a mild fever.";
                    break;
                case < 41:
                    Message = "You have a high fever.";
                    break;
                default:
                    Message = "Call your doctor! You have a very high fever.";
                    break;
            }
            Message = $"Hi {name}, {Message}";
            return Message;
        }
        

    }
}

