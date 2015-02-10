using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Alumno
    {
        /// <summary>
        /// Creamos variable privada y de tipo string.
        /// </summary>
        private string nombre;
        /// <summary>
        /// Creamos variable privada y de tipo int.
        /// </summary>
        private int nota;

        /// <summary>
        /// Creamos método público  de tipo string para obtener el Nombre.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Creamos método público  de tipo int para obtener el Nota,
        /// Debe cumplir la condición del if para obtener la nota en 0 y 10.
        /// </summary>
        public int Nota
        {
            get { return nota; }
            set
            {
                //Con esta condición me sale el test TestNotaNoValida2 como no superada, las otras sí
                //if (value>=0)

                //Con esta condición el test me salen las tres pruebas superadas
                if (value >= 0 && value <= 10)
                    nota = value;
            }
        }

        /// <summary>
        /// Creamos método público  de tipo boolean para saber si la nota es Aprobado,
        /// devuelve true si es mayor o igual a 5 o devuelve false si la nota es menor a 5.
        /// </summary>
        public Boolean Aprobado
        {
            get
            {
                if (nota >= 5)
                    return true;
                else
                    return false;
            }
        }
    }
}
