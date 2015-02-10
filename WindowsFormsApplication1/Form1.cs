using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Creamos un objeto de la clase Alumnos
        /// </summary>
        private Alumnos alumno = new Alumnos();

        /// <summary>
        /// Creamos y asignamos valor a las variables
        /// </summary>
        private string lista = "";
        private double media = 0;
        private string resultado = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ceamos objeto de la clase Alumno
            Alumno alum = new Alumno();

            //Asignamos lo que nos viene de los textBox
            alum.Nombre = tNombre.Text;
            alum.Nota = int.Parse(tNota.Text);

            //Llamamos al método AgregarAlumno para que añada el objeto (alum)
            alumno.AgregarAlumno(alum);

            tNombre.Clear();
            tNota.Clear();

            //Hago un if para mostrar si la nota introducida es Aprobado o Suspenso
            if (alum.Aprobado == true)
            {
                resultado = "Aprobado";
            }
            else
            {
                resultado = "Suspenso";
            }

            //Montamos el resultado para mostralo en el textBox correspondiente
            lista = lista + alum.Nombre + " " + alum.Nota + " " + resultado + "\r\n";
            tLista.Text = lista;

            //Calculo la nota media llamando al método de la clase Alumnos.
            //Muestro el resultado en el textoBox de la Nota media.
            media = alumno.MediasNotas();
            tNotaMedia.Text = media.ToString();
        }
    }
}
