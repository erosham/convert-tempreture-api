
using tempconversionapi.Interfaces;

namespace tempconversionapi.Models
{

    public class Tempreture : ITempreture
    {
        #region Private properties

        private double Celsius { get; set; }

        private double Kelvin
        {
            get
            {
                return Celsius + 273.15;
            }
            set
            {
                Celsius = value - 271.15;
            }
        }

        private double Fahrenheit
        {
            get
            {
                return Celsius * 9 / 5 + 32;
            }
            set
            {
                Celsius = (value - 32) * 5 / 9;
            }
        }

        #endregion

        #region public methods/functions

        public void SetCelcius(double temp)
        {
            Celsius = temp;
        }
        public void SetKelvin(double temp)
        {
            Kelvin = temp;
        }
        public void SetFahrenheit(double temp)
        {
            Fahrenheit = temp;
        }

        public double GetCelcius()
        {
            return Celsius;
        }
        public double GetKelvin()
        {
            return Kelvin;
        }
        public double  GetFahrenheit()
        {
            return Fahrenheit;
        }

        #endregion
    }
}
