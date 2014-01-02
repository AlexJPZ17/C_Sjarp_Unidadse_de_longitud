using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidadse_de_longitud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UnidadesDeMedidas()
        {
            //Declaramos las variables 
            double res1, res2, res3, res4, res5, res6, res7, valor;
            string unidades;

            //Condición que valida el TextBox Valor si  está vacío 
            if (TextBox_Valor.Text == "")
            {
                MessageBox.Show("Ingrese un valor a convertir", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Coloca el Focus en el TextBox Valor
                TextBox_Valor.Focus();

            }
            else
            {
                //Función que convierte en un tipo double el valor que se ingrese por 
                //el TextBox Valor y lo almacena en la variable valor 
                valor = Double.Parse(TextBox_Valor.Text);
                //Método para extraer los Items seleccionado en el ComboBox
                unidades = ComboBox_Opciones.Text;
                /*Condición que evalúa la variable unidades si es igual a las funciones 
                  Seleccionada en el ComboBox y si la variable unidades es igual a
                  Unidades a convertir que muestre un mensaje*/
                if (unidades == "Unidades a convertir")
                {
                    MessageBox.Show("Seleccione unas de las unidades a concertir", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    /* Con la instrucción switch nos ayudara a ejecutar las opciones 
                      seleccionada en el ComboBox de acuerdo a la unidad de medida 
                      que escojamos */
                    switch (unidades)
                    {
                       case "Milimetros":
                           //limpiamos el ListBox antes de mostrar el resultado
                            ListBox_Medidas.Items.Clear();
                           //Medidas en milimetros
                            res1 = valor * 0.1;
                            res2 = valor * 0.03937;
                            res3 = valor * 0.00328084;
                            res4 = valor * 0.001;
                            res5 = valor * 0.0010936;
                            res6 = valor * 0.000001;
                            res7 = valor * 0.0000006;
                            ListBox_Medidas.Items.Add(res1 + " Centímetros");
                            ListBox_Medidas.Items.Add(res2 + " Pulgadas");
                            ListBox_Medidas.Items.Add(res3 + " Pies");
                            ListBox_Medidas.Items.Add(res4 + " Metros");
                            ListBox_Medidas.Items.Add(res5 + " Yardas");
                            ListBox_Medidas.Items.Add(res6 + " Kilómetros");
                            ListBox_Medidas.Items.Add(res7 + " Millas");
                            break;

                       case "Centimetros":
                            //limpiamos el ListBox antes de que de el resultado
                            ListBox_Medidas.Items.Clear();
                            //Medidas en centímetros
                            res1 = valor * 10.0;
                            res2 = valor * 0.3937;
                            res3 = valor * 0.0328084;
                            res4 = valor * 0.01;
                            res5 = valor * 0.010936;
                            res6 = valor * 0.00001;
                            res7 = valor * 0.000006;
                            ListBox_Medidas.Items.Add(res1 + " Milímetros");
                            ListBox_Medidas.Items.Add(res2 + " Pulgadas");
                            ListBox_Medidas.Items.Add(res3 + " Pies");
                            ListBox_Medidas.Items.Add(res4 + " Metros");
                            ListBox_Medidas.Items.Add(res5 + " Yardas");
                            ListBox_Medidas.Items.Add(res6 + " Kilómetros");
                            ListBox_Medidas.Items.Add(res7 + " Millas");

                            break;

                       case "Pulgadas":
                            //limpiamos el ListBox antes de que de el resultado
                            ListBox_Medidas.Items.Clear();
                            //Medias en pulgadas
                            res1 = valor * 25.4;
                            res2 = valor * 2.54;
                            res3 = valor * 0.083;
                            res4 = valor * 0.0254;
                            res5 = valor * 0.027;
                            res6 = valor * 0.0000254;
                            res7 = valor * 0.0000158;
                            ListBox_Medidas.Items.Add(res1 + " Milímetros");
                            ListBox_Medidas.Items.Add(res2 + " Centimetros");
                            ListBox_Medidas.Items.Add(res3 + " Pies");
                            ListBox_Medidas.Items.Add(res4 + " Metros");
                            ListBox_Medidas.Items.Add(res5 + " Yardas");
                            ListBox_Medidas.Items.Add(res6 + " Kilómetros");
                            ListBox_Medidas.Items.Add(res7 + " Millas");

                            break;

                       case "Pies":
                            //limpiamos el ListBox antes de que de el resultado
                            ListBox_Medidas.Items.Clear();
                            //Medidas en pies 
                            res1 = valor * 304.8;
                            res2 = valor * 30.48;
                            res3 = valor * 12;
                            res4 = valor * 0.3048;
                            res5 = valor * 0.33;
                            res6 = valor * 0.0003048;
                            res7 = valor * 0.0001894;
                            ListBox_Medidas.Items.Add(res1 + " Milímetros");
                            ListBox_Medidas.Items.Add(res2 + " Centímetros");
                            ListBox_Medidas.Items.Add(res3 + " Pulgadas");
                            ListBox_Medidas.Items.Add(res4 + " Metros");
                            ListBox_Medidas.Items.Add(res5 + " Yardas");
                            ListBox_Medidas.Items.Add(res6 + " Kilómetros");
                            ListBox_Medidas.Items.Add(res7 + " Millas");

                            break;

                       case "Metros":
                            //limpiamos el ListBox antes de que de el resultado
                            ListBox_Medidas.Items.Clear();
                            //Medidas en metros
                            res1 = valor * 1000;
                            res2 = valor * 100;
                            res3 = valor * 39.37008;
                            res4 = valor * 3.28084;
                            res5 = valor * 1.09361;
                            res6 = valor * 0.001;
                            res7 = valor * 0.00062;
                            ListBox_Medidas.Items.Add(res1 + " Milímetros");
                            ListBox_Medidas.Items.Add(res2 + " Centímetros");
                            ListBox_Medidas.Items.Add(res3 + " Pulgadas");
                            ListBox_Medidas.Items.Add(res4 + " Pies");
                            ListBox_Medidas.Items.Add(res5 + " Yardas");
                            ListBox_Medidas.Items.Add(res6 + " Kilómetros");
                            ListBox_Medidas.Items.Add(res7 + " Millas");

                            break;

                       case "Yardas":
                            //limpiamos el ListBox antes de que de el resultado
                            ListBox_Medidas.Items.Clear();
                            //Medidas en yardas 
                            res1 = valor * 914.4;
                            res2 = valor * 91.44;
                            res3 = valor * 36;
                            res4 = valor * 3;
                            res5 = valor * 0.9144;
                            res6 = valor * 0.0009144;
                            res7 = valor * 0.00056;
                            ListBox_Medidas.Items.Add(res1 + " Milímetros");
                            ListBox_Medidas.Items.Add(res2 + " Centímetros");
                            ListBox_Medidas.Items.Add(res3 + " Pulgadas");
                            ListBox_Medidas.Items.Add(res4 + " Pies");
                            ListBox_Medidas.Items.Add(res5 + " Metros");
                            ListBox_Medidas.Items.Add(res6 + " Kilómetros");
                            ListBox_Medidas.Items.Add(res7 + " Millas");

                            break;

                       case "Kilometros":
                            //limpiamos el ListBox antes de que de el resultado
                            ListBox_Medidas.Items.Clear();
                            //Medidas en kilómetros 
                            res1 = valor * 1000000;
                            res2 = valor * 100000;
                            res3 = valor * 39370.08;
                            res4 = valor * 3280.84;
                            res5 = valor * 1000;
                            res6 = valor * 1093.613;
                            res7 = valor * 0.62137;
                            ListBox_Medidas.Items.Add(res1 + " Milímetros");
                            ListBox_Medidas.Items.Add(res2 + " Centímetros");
                            ListBox_Medidas.Items.Add(res3 + " Pulgadas");
                            ListBox_Medidas.Items.Add(res4 + " Pies");
                            ListBox_Medidas.Items.Add(res5 + " Metros");
                            ListBox_Medidas.Items.Add(res6 + " Yardas");
                            ListBox_Medidas.Items.Add(res7 + " Millas");

                            break;

                       case "Millas":
                            //limpiamos el ListBox antes de que de el resultado
                            ListBox_Medidas.Items.Clear();
                            //Medidas en millas 
                            res1 = valor * 1609344;
                            res2 = valor * 160934.4;
                            res3 = valor * 63360;
                            res4 = valor * 5280;
                            res5 = valor * 1609.344;
                            res6 = valor * 1760;
                            res7 = valor * 1.60934;
                            ListBox_Medidas.Items.Add(res1 + " Milímetros");
                            ListBox_Medidas.Items.Add(res2 + " Centímetros");
                            ListBox_Medidas.Items.Add(res3 + " Pulgadas");
                            ListBox_Medidas.Items.Add(res4 + " Pies");
                            ListBox_Medidas.Items.Add(res5 + " Metros");
                            ListBox_Medidas.Items.Add(res6 + " Yardas");
                            ListBox_Medidas.Items.Add(res7 + " Kilómetros");

                            break;


                    }
                }
            }
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            UnidadesDeMedidas();
        }

        private void Button_Clean_Click(object sender, EventArgs e)
        {
            TextBox_Valor.Text = "";
            TextBox_Valor.Focus();
            ListBox_Medidas.Items.Clear();
            ComboBox_Opciones.Text = "Unidades a convertir";

        }
    }
}
