using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        #region METODOS


        /// <summary>
        /// Valida que el operador pasado por parametro sea +,-,* o /
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>El operador pasado por paramtro , en caso de error retorna  + </returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";

            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;
            }
            return retorno;

        }



        /// <summary>
        /// Valida y realiza la operacion entre ambos numeros pasados por Parametro
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de la operaccion selecionada</returns>
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            string validar;
            double retorno;

            validar = ValidarOperador(operador);
            switch (validar)
            {
                case "+":
                    retorno = n1 + n2;
                    break;
                case "-":
                    retorno = n1 - n2;
                    break;
                case "*":
                    retorno = n1 * n2;
                    break;
                case "/":          
                    retorno = n1 / n2;
               if(double.IsInfinity(retorno))
                 {
                   retorno = double.MinValue;
                 }
                    break;
                default:
                    retorno = n1 + n2;
                    break;
            }
            return retorno;
        }

        #endregion

    }
}
