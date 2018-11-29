using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
       Numero n1;
       Numero n2;
       
        string operador;
        string resultado;

        public FormCalculadora()
        {
            InitializeComponent();
            this.cbxOperar.SelectedIndex = 0;
            this.lblResultado.Text = "0";
            resultado = "0";

        }

    
        /// <summary>
        /// Realiza la operacion pasada por parametros entre dos numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de esa operacion</returns>
        private static double Operar(string n1, string n2, string operador)
        {
            return Calculadora.Operar(new Numero(n1),new Numero(n2), operador);
        }

        /// <summary>
        /// borra los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cbxOperar.Text = "";
            this.lblResultado.Text = "0";
        }



        /// <summary>
        /// Llama al metodo Operar y asigna los resultados 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
           
            operador = this.cbxOperar.Text;
            resultado = Operar(txtNumero1.Text,txtNumero2.Text, operador).ToString();
            this.lblResultado.Text = resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte el resultado de decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text =Numero.DecimalBinario(lblResultado.Text);
        }


        /// <summary>
        /// Convierte el resutlado de binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecimal_Click(object sender, EventArgs e)
        {
          
            this.lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }
    }
}
