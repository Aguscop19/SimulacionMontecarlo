using SimulacionMontecarlo.Classes;

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
            // Paso 0: Condic�on de vac�o
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Los n�meros tienen que ser MAYOR que cero, NO VAC�OS");
                return;

            }
            // Paso 1: Inicializaci�n de par�metros
            int numSimulacion = Convert.ToInt32(textBox1.Text);
           
            // Paso 2: Declarar clase Satelite
            Satelite SatelitesSimulados = new Satelite(numSimulacion, 5000, 1000,5);
            // Paso 3: Llamar m�todo principal
            SatelitesSimulados.experimentos();

            string promedio = Convert.ToString(SatelitesSimulados.getPromedioFinal());

            textBox2.Text = promedio;

        }
    }
}