using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppArreglo
{
    class Alumno
    {
        private string nombre;
        private string apellidos;
        private string matricula;

        Alumno[] arregloAlumno = new Alumno[5];
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                apellidos = value;
            }
        }
        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }
        public Alumno()
        {
            nombre = " ";
            apellidos = " ";
            matricula = " ";
        }
        public override string ToString()
        {
            return nombre + " " + apellidos + " " + matricula;
        }
        public void Insertar()
        {
            Alumno[] arregloAlumno = new Alumno[5];

            for (int i = 0; i < arregloAlumno.Length; i++)
            {
                arregloAlumno[i] = new Alumno();
                Console.WriteLine("Ingresa el nombre");
                arregloAlumno[i].nombre = " ";
                arregloAlumno[i].Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese los apellidos");
                arregloAlumno[i].Apellidos = " ";
                arregloAlumno[i].Apellidos = Console.ReadLine();
                Console.WriteLine("Ingrese la matricula");
                arregloAlumno[i].Matricula = Console.ReadLine();

                Console.WriteLine(arregloAlumno[i].ToString());
                Console.ReadKey();
            }
        }
    }
}

