using SimulacionMontecarlo.Classes;
using System;
using System.Windows.Forms;

namespace SimulacionMontecarlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 0: Condicíon de vacío
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;

            }
            // Paso 1: Inicialización de parámetros
            int numSimulacion = Convert.ToInt32(textBox1.Text);

            // Paso 2: Declarar clase Satelite
            Satelite SatelitesSimulados = new Satelite(numSimulacion, 5000, 1000, 5);
            // Paso 3: Llamar método principal
            SatelitesSimulados.experimentos();

            string promedio = Convert.ToString(SatelitesSimulados.getPromedioFinal());

            textBox2.Text = promedio;

            int[] listaPromedios = SatelitesSimulados.getPromedios();
            List <int> listaP = listaPromedios.ToList();
            llenarGrid(listaP);
       
        }

        public void llenarGrid(List <int> lista)
        {
            
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";


            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Satelite");
            dataGridView1.Columns.Add(numeroColumna2, "Promedio");

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }


        }
    }
}