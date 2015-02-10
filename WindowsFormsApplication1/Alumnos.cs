using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication1
{
    class Alumnos
    {
        /// <summary>
        /// Creamos e inicializamos un campo privado llamado listaAlumnos de tipo ArrayList
        /// </summary>
        private ArrayList listaAlumnos = new ArrayList();

        /// <summary>
        /// Creamos una propiedad de tipo ArrayList llamada ListaAlumnos,
        /// en el cual devuelve el campo listaAlumnos.
        /// </summary>
        public ArrayList ListaAlumnos
        {
            get { return listaAlumnos; }

        }

        /// <summary>
        /// Creamos método de tipo void llamado AgregarAlumno,
        /// para que acepte un parámetro de la clase Alumno y lo añada
        /// a listaAlumnos.
        /// </summary>
        /// <param name="alum"> 
        /// Parámetro de la clase Alumno que va a ser añadido a listaAlumnos.
        /// </param>
        public void AgregarAlumno(Alumno alum)
        {
            listaAlumnos.Add(alum);

        }

        /// <summary>
        /// Creamos método de tipo double llamado MediasNotas,
        /// que va a ir calculando la nota media de todos los 
        /// alumnos que agregemos a la lista de alumnos.
        /// </summary>
        /// <returns>
        ///Devuelve la nota de media de todos los alumnos de la lista. 
        /// </returns>
        public double MediasNotas()
        {
            int media;
            double resultado;
            resultado = 0;
            double cantidad;
            cantidad = listaAlumnos.Count;

            foreach (Alumno valor in listaAlumnos)
            {
                media = valor.Nota;

                resultado = resultado + media;
            }

            resultado = resultado / cantidad;

            return resultado;

        }
    }
}
