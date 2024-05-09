using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{//DETALLES DEL PROGRAMA
    /*Programa: CLASE PERSONA CON INTERFAZ
    Versión: 1.0*/
    //Mirsha América Múgica Monsalve DI22135
    class Persona //clase padre
    {
        protected string NombreCompleto;
        protected string FechaN;
        protected int Edad;
        protected int DNI_Matricula;
        protected string Carrera_Puesto;

        public string nombrecompleto //Este es el inicio de las cajas de memoria
        {//este es para que el usuario ingrese su nombre completo
            get { return NombreCompleto; }//el método get se utiliza para obtener los datos de la caja de memoria, el nombre del usuario
            set { NombreCompleto = value; }//el método set se utiliza para asignarle un nuevo valor a la propiedad, en este caso el nombre que ingrese el usuario
        }
        public string fechan
        {//este es para que el usuario ingrese su fecha de nacimiento
            get { return FechaN; }//el método get se utiliza para obtener los datos de la caja de memoria: la fecha de nacimiento del usuario
            set { FechaN = value; }//el método set se utiliza para asignarle un nuevo valor a la propiedad ´fecha de nacimiento´
        }
        public int edad
        {//este es para que el usuario ingrese cuántos años tiene
            get { return Edad; }
            set { Edad = value; }
        }
        public int dni_matricula
        {//este es para que el usuario ingrese su DNI o su matrícula en caso de ser alumno
            get { return DNI_Matricula; }
            set { DNI_Matricula = value; }
        }
        public string carrera_Puesto
        {//este es para que el usuario ingrese la carrera que está estudiando o el puesto que tiene en su empleo
            get { return Carrera_Puesto; }
            set { Carrera_Puesto = value; }
        }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        //aqui va el constructor para cargar datos en las cajas de memoria
        //nombre, edad, fecha de nacimiento(es un tipo cadena!!!!! string)
    }

    class Alumno : Persona //alumno es la clase hija de persona
    {

        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    class Empleado : Persona //empleado es la clase hija de persona
    {
        protected int Sueldo;
        public int sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }

    class Docente : Persona //docente es la clase hija de persona
    {
        protected int Sueldo;
        public int sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
