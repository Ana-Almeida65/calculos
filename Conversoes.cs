using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    ///<summary>
    ///Implementa operações de converão.
    /// </summary>
    internal static class Conversoes
    {
    
        ///<summary>
        ///Tipo conversao de temperatura. 
        /// </summary>
        
         public enum ConversaoTemperatura
         {
            Nulo=0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        ///<summary>
        /// Conversão de Temperaturas
        ///</summary>
        ///<param name= "conversao"> A Conversao a efetuarr </param>
        ///<param name= "temperatura"> A Temperatura a converter</param>
        ///<returns> retorna o resultado da conversao </returns>
        
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao==ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao==ConversaoTemperatura.FahrenheitCelsius)
            {
                return((temperatura - 32)/1.8000);
            }
            return -1;
        }
    }
}
