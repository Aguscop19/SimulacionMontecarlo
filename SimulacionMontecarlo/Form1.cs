using Microsoft.Office.Interop.Excel;
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
            if (textBox1.Text.Equals("") ||
                (textBox3.Text.Equals("")) ||
                (textBox4.Text.Equals("")) ||
                (textBox5.Text.Equals("")))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;

            }
            // Paso 1: Inicialización de parámetros
            int numSimulacion = Convert.ToInt32(textBox1.Text);
            int LimInf = Convert.ToInt32(textBox3.Text);
            int LimMax = Convert.ToInt32(textBox4.Text);
            int numPan = Convert.ToInt32(textBox5.Text);


            // Paso 2: Declarar clase Satelite
            Satelite SatelitesSimulados = new Satelite(numSimulacion, LimMax, LimInf, numPan);
            // Paso 3: Llamar método principal
            SatelitesSimulados.experimentos();

            //Se imprime el promedio
            string promedio = Convert.ToString(SatelitesSimulados.getPromedioFinal());

            textBox2.Text = promedio;

            //Se imprime la desviacion estandar
            string desvesta = Convert.ToString(SatelitesSimulados.CalcularDesviacionEstandar());
            textBox6.Text = desvesta;

            //Se llena en datagrid


            
            int[,] listaP = SatelitesSimulados.getConteo();
            
            llenarGrid(listaP);



        }

        public void llenarGrid(int[,] lista)
        {
            int rows = lista.GetLength(0);
            int columns = lista.GetLength(1);

            dataGridView1.Columns.Clear();

            // Agrega las columnas al DataGridView
            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns.Add("Column", "Satelite " + (i+1));
            }

            // Agrega las filas al DataGridView
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                for (int j = 0; j < columns; j++)
                {
                    row.Cells[j].Value = lista[i, j];
                }

                dataGridView1.Rows.Add(row);
            }


        }

        public void DescargaExcel(DataGridView data)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            // Paso 1: Construyes columnas
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }
            // Paso 2: Construyes filas
            int indiceFilas = 0;

            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            // Paso 3: visibilidad
            exportarExcel.Visible = true;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }
    }
}