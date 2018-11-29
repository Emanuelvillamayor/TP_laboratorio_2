using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Numero
    {
    #region ATRIBUTOS

        private double numero;

    #endregion

    #region PROPIEDADES

    public string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }

    #endregion

    #region CONSTRUCTORES
    public Numero() : this(0)
    {

    }
    public Numero(double nume)
    {
      SetNumero = nume.ToString();
    }
    public Numero(string strNumero)
    {
      SetNumero = strNumero;
    }
    #endregion

    #region METODOS

    /// <summary>
    /// Convierte un numero binario a Decimal
    /// </summary>
    /// <param name="binario"></param>
    /// <returns>El numero convertido a binario , caso contrario "valor invalido"</returns>
    public static string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            if (double.TryParse(binario, out double ndecimal))
            {
                double final = Convert.ToDouble(binario);
                string comprobar = (Math.Truncate(final).ToString());
                int[] cadena = new int[comprobar.Length];
                double num = 0;
                int i = 0;
                int flag = 1;

                for (i = 0; i < comprobar.Length; i++)
                {
                    cadena[i] = (int)char.GetNumericValue(comprobar[i]);
                    if (cadena[i] != 1 && cadena[i] != 0)
                    {
                        flag = 0;
                        break;
                    }

                }

                if (flag == 1 && comprobar != "" && comprobar != null)
                {
                    for (i = 1; i <= comprobar.Length; i++)
                    {
                        num += int.Parse(comprobar[i - 1].ToString()) * (int)Math.Pow(2, comprobar.Length - i);
                    }
                    retorno = num.ToString();
                }
            }
            return retorno;
        }





    /// <summary>
    /// Convierte un numero decimal a binario
    /// </summary>
    /// <param name="numero"></param>
    /// <returns>El numero convertido a decimal , caso contrario "valor invalido"</returns>
    public static string DecimalBinario(string numero)
    {
      string retorno = "Valor invalido";

            if (double.TryParse(numero.ToString(), out double nDecimal) &&Convert.ToDouble(numero) >0)
            {
                double final = Convert.ToDouble(numero);
                string comprobar = (Math.Truncate(final).ToString());
                int[] cadena = new int[comprobar.Length];
                int entero;
                int flag = 1;
                int i;

                for (i = 0; i < comprobar.Length; i++)
                {
                    cadena[i] = (int)char.GetNumericValue(comprobar[i]);
                    if (cadena[i] < 0 || cadena[i] > 9)
                    {
                        flag = 0;
                        break;
                    }

                }
                if (flag == 1)
                {
                    comprobar = "";
                    entero = (int)final;
                    while (entero > 0)
                    {
                        comprobar = (entero % 2).ToString() + comprobar;
                        entero = entero / 2;
                    }

                    if (final == 0)
                    {
                        comprobar = "0";
                    }
                    retorno = comprobar;
                }
            }
        return retorno;
      }

    
        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El numero convertido a decimal , caso contrario "valor invalido"</returns>
        public static string DecimalBinario(double numero)
        {                   
            return DecimalBinario(numero.ToString());
        }



       

        /// <summary>
        /// Suma el atributo numero de dos objetos de tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la suma</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double retorno;
            retorno = n1.numero + n2.numero;
            return retorno;
        }

        /// <summary>
        /// Resta el atributo numero de dos objetos de tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la resta</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double retorno;
            retorno = n1.numero - n2.numero;
            return retorno;
        }

        /// <summary>
        /// Multiplica el atributo numero de dos objetos de tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la multiplicacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double retorno;
            retorno = n1.numero * n2.numero;
            return retorno;
        }

        /// <summary>
        /// Divide el atributo "numero" de dos objetos de tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la division</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno;
            retorno = n1.numero / n2.numero;
            return retorno;
        }



        /// <summary>
        /// Comproba que el valor pasado por parametro sea numerico
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El numero en formato double , caso contrario "0"</returns>
        private double ValidarNumero(string numero)
        {
            double retorno = 0;
            double auxout;

            if (double.TryParse(numero, out auxout) == true)
            {
                retorno = auxout;
            }

            return retorno;
        }
        #endregion
 
     


    }
}
