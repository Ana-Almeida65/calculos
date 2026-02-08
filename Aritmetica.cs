using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
   
    ///<summary>
    ///Implementa operações aritméticas
    /// </summary>
    internal class Aritmetica
    
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
        ///Operação somar.
        /// </summary>
        /// <returns> retorna a soma de dois números</returns>
        public int Somar(int x, int y)
        {
            return x + y;
        }
       
        ///<summary>
        ///Operação subtrair.
        /// </summary>
        /// <returns> retorna o resultado da subtração de dois números</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao==ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura*1.8000 + 32);
            }
            else if (conversao==ConversaoTemperatura.FahrenheitCelsius)
            {
                return((temperatura-32)/1.8000);
            }
            return -1;
        }
    }
}