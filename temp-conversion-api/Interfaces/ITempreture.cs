using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tempconversionapi.Interfaces
{
    public interface ITempreture
    {
        /// <summary>
        /// set the tempreture in celcius
        /// </summary>
        /// <param name="temp"></param>
        void SetCelcius(double temp);
        /// <summary>
        /// set the tempreture in kelvin
        /// </summary>
        void SetKelvin(double temp);
        /// <summary>
        /// set the tempreture in fahrenheit
        /// </summary>
        void SetFahrenheit(double temp);

        /// <summary>
        /// get the tempreture in celcius
        /// </summary>
        /// <param name="temp"></param>
        double GetCelcius();
        /// <summary>
        /// get the tempreture in kelvin
        /// </summary>
        double GetKelvin();
        /// <summary>
        /// get the tempreture in fahrenheit
        /// </summary>
        double GetFahrenheit();
    }
}
