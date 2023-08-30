using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionMontecarlo.Classes
{
   // Supongamos que tenemos un satelite, que para su funcionamiento depende de que al menos 2 paneles solares de los 5
   // que tiene disponibles esten funcionando. y queremos calcular Phi la vida util esperada del satelite (El tiempo
   // promedio de funcionamiento hasta que falla,  usualmente conocido en la literatura como MTTF).
    //Supongamos que cada panel solar tiene una vida util que es aleatoria y esta uniformemente distribuida en el rango
    //[1000hrs,5000hs] (Valor promedio 3000). Para estimar por Monte Carlo el valor de Phi, haremos n experimentos,
    //cada uno de los cuales consistira en sortear el tiempo de falla de cada uno de los paneles solares del satelite y
    //observar cual es el momento en el cual han fallado 4 de los mismos, esta variable aleatoria cuya esperanza es el
    //tiempo promedio de funcionamiento del satelite. El valor promedio de las n observaciones nos proporcionara
    //una estimacion de Phi.

    //BLITZCRANK ES UN ROBOT

// Codigo:

// Definimos una clase que represente un panel solar
    internal class PanelSolar
        {

            public int vidaUtil;
            public int min;
            public int max;
            // Constructor
            public PanelSolar(int min, int max)
            {
                // Generamos un numero aleatorio entre min y max
                Random rnd = new Random();
                vidaUtil = rnd.Next(min, max);
                this.min = min;
                this.max = max;
            }

            public int getVidaUtil()
            {
                // Volvemos a generar un numero aleatorio
                Random rnd = new Random();
                vidaUtil = rnd.Next(min, max);
                return vidaUtil;
            }
        }

    internal class Satelite
    {

        // Definimos los atributos
        public int numExperimentos;
        public int[,] conteo;
        public PanelSolar[] paneles;
        public int[] promedios;
        public int promedioFinal;
        // Creamos el constructor que guarda el numero de experimentos
        public Satelite(int numExperimentos)
        {
            this.numExperimentos = numExperimentos;
            // Creamos el conteo de experimetnos como una matriz
            this.conteo = new int[numExperimentos, 5];
            // Creamos 5 paneles solares
            this.paneles = new PanelSolar[5];
            // Inicializamos los paneles solares
            for (int i = 0; i < 5; i++)
            {
                this.paneles[i] = new PanelSolar(1000, 5000);
            }
            // Inicializamos los promedios
            this.promedios = new int[5];

        }

        // Metodo que realiza los experimentos
        public int experimentos()
        {
            // Creamos un contador de experimentos
            int cont = 0;
            while (cont < this.numExperimentos)
            {
                // Creamos un ciclo que recorra los paneles
                for (int i = 0; i < 5; i++)
                {
                    conteo[cont, i] = paneles[i].getVidaUtil();
                }
                cont++;
            }
            // Promediamos los resultados
            int[] promedios = new int[5];
            // Creamos un ciclo que recorra los experimentos
            for (int i = 0; i < this.numExperimentos; i++)
            {
                // Creamos un ciclo que recorra los paneles
                for (int j = 0; j < 5; j++)
                {
                    promedios[j] += conteo[i, j];
                }
            }
            // Creamos un ciclo que recorra los paneles
            promedioFinal = 0;
            for (int i = 0; i < 5; i++)
            {
                promedios[i] /= this.numExperimentos;
                promedioFinal += promedios[i];
            }
            promedioFinal /= 5;
            return promedioFinal;
        }

        // Funcion para obtener el conteo
        public int[,] getConteo()
        {
            return conteo;
        }

        // Funcino para obtener el promedio de cada panel
        public int[] getPromedios()
        {
            return promedios;
        }

        // Metodo que imprime los resultados
        public void imprimir()
        {
            Console.WriteLine("El promedio de vida util del satelite es: " + promedioFinal);
        }
    }
    

}
