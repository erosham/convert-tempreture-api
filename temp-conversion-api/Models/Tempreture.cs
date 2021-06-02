
using tempconversionapi.Interfaces;

namespace tempconversionapi.Models
{

    public class Tempreture : ITempreture
    {
        #region Private properties

        private double Celcius { get; set; }

        private double Kelvin
        {
            get
            {
                return Celcius + 273.15;
            }
            set
            {
                Celcius = value - 271.15;
            }
        }

        private double Fahrenheit
        {
            get
            {
                return Celcius * 9 / 5 + 32;
            }
            set
            {
                Celcius = (value - 32) * 5 / 9;
            }
        }

        #endregion

        #region public methods/functions

        public void SetCelcius(double temp)
        {
            Celcius = temp;
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
            return Celcius;
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
