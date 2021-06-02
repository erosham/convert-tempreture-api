using Microsoft.AspNetCore.Mvc;
using System;
using tempconversionapi.Interfaces;
using tempconversionapi.Models;

namespace tempconversionapi.Controllers
{

    [Route("api/TempretureConvert/{tempFrom:int}/{tempTo:int}/{temp:double}")]
    public class TempretureConvertController : Controller
    {
        private readonly ITempreture _tempreture;

        public TempretureConvertController(ITempreture tempreture)
        {
            _tempreture = tempreture;
        }

        /// <summary>
        /// Get the converted tempreture value
        /// </summary>
        /// <param name="tempFrom"></param>
        /// <param name="tempTo"></param>
        /// <param name="temp"></param>
        /// <returns></returns>
        [HttpGet]
        public double Get(TempretureEnum tempFrom, TempretureEnum tempTo, double temp)
        {
            double retValue = temp;

            switch (tempFrom)
            {
                case TempretureEnum.Celsius:
                    _tempreture.SetCelcius(temp);

                    if (tempTo == TempretureEnum.Fahrenheit)
                        retValue = _tempreture.GetFahrenheit();
                    
                    if (tempTo == TempretureEnum.Kelvin )
                        retValue =  _tempreture.GetKelvin();
                    
                    break;
                case TempretureEnum.Fahrenheit:
                    _tempreture.SetFahrenheit(temp);

                    if (tempTo == TempretureEnum.Celsius)
                        retValue =  _tempreture.GetCelcius();

                    if (tempTo == TempretureEnum.Kelvin)
                        retValue =  _tempreture.GetKelvin();

                    break;
                case TempretureEnum.Kelvin:
                    _tempreture.SetKelvin(temp);

                    if (tempTo == TempretureEnum.Celsius)
                        retValue =  _tempreture.GetCelcius();

                    if (tempTo == TempretureEnum.Fahrenheit)
                        retValue =  _tempreture.GetFahrenheit();
                    break;
            }
            return Math.Round(retValue,2);
        }
    }
}