using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesviacionEstandar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            double[] cantPersonas;
            double media = 0, varianza = 0, desviacion, desvMuestra, altura,  aux, aux2;
            int cant_Personas, i;

            //Asignacion de tamaño del arreglo
            
            if (txtCantPersonas.Text != string.Empty){

                //Carga de las Alturas
                try{
                    cant_Personas = Int32.Parse(txtCantPersonas.Text);
                    if (cant_Personas > 0 && cant_Personas != 0){
                        cantPersonas = new double[cant_Personas];
                        for (i = 0; i < cant_Personas; i++){
                            altura = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la altura en centimetros: ", "ALTURAS"));
                            if (altura > 0)
                            {
                                cantPersonas[i] = altura;
                                media += altura;
                                cboAlturas.Items.Add("Pers. N°" + (i + 1) + " " + altura + "cm");
                            }
                            else{
                                MessageBox.Show("Solo numeros positivos, vuelva a cargar");
                                i-=1;                                   
                            }
                        }
                        //Calculo de la media
                        media /= cant_Personas;
                        txtMedia.Text = media.ToString("#.##cm");

                        //calculo de la varianza
                        for (i = 0; i < cant_Personas; i++){
                            aux = cantPersonas[i] - media;
                            varianza += Math.Pow(aux, 2);
                        }
                        aux2 = varianza;//aux para el calculo de una muestra N-1
                        varianza /= cant_Personas;
                        txtVar.Text = varianza.ToString("#.##cm");//Varianza de la población

                        //Calculo Desviacion Estandar de Población
                        desviacion = Math.Sqrt(varianza);
                        txtDesv.Text = desviacion.ToString("#.##cm");

                        aux2 = aux2 / (cant_Personas - 1);//Varianza de la muestra cant_Personas es N-1
                        txtVarMuestra.Text = aux2.ToString();
                        desvMuestra = Math.Sqrt(aux2);
                        txtDesvMuestra.Text = desvMuestra.ToString("#.##");

                        //Calculo Gral por encima, debajo y dentro de la media
                        for (i = 0; i < cant_Personas; i++){
                            if (cantPersonas[i] > media ) cboArriba.Items.Add("Pers. N°" + (i + 1) + " con" + cantPersonas[i] + "cm");
                            else if (cantPersonas[i] < media ) cboAbajo.Items.Add("Pers. N°" + (i + 1) + " con" + cantPersonas[i] + "cm");
                            else if (cantPersonas[i] < (media + desviacion) && cantPersonas[i] > (media - desviacion)) cboDentro.Items.Add("Pers. N°" + (i + 1) + " con" + cantPersonas[i] + "cm");
                        }
                    }else MessageBox.Show("Solo numeros positivos o mayores a 0 (CERO)");
                }catch (Exception){
                    MessageBox.Show("Por Favor! Solo ingrese numeros/positivos <<REINTENTE>>");
                }
            }else MessageBox.Show("Por favor ingrese la cantidad de Personas");            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtCantPersonas.Clear();
            cboAbajo.Items.Clear();
            cboArriba.Items.Clear();
            cboDentro.Items.Clear();
            cboAlturas.Items.Clear();
            txtDesvMuestra.Text = string.Empty;
            txtVarMuestra.Text = string.Empty;
            txtDesv.Text = string.Empty;
            txtMedia.Text = string.Empty;
            txtVar.Text = string.Empty;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
