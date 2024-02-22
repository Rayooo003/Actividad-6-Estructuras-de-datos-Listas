//ESTRUCTURA DE DATOS ACT 6 LISTAS.

//Se utiliza para poder utilizar funcionalidades básicas y tipos fundamentales en C#.
using System;

//Se utiliza para para colecciones, como listas, diccionarios y colas.
using System.Collections.Generic;

//Definimos un nuevo espacio de nombres llamado *ListaDeEstudiantes*.
namespace ListaDeEstudiantes
{
    // Clase para representar una calificación.
    //Declaramos la clase de nombre *Calificacion*.
    class Calificacion
    {
        //Propiedad de tipo doble (admite decimales) por ello se utiliza en lugar de int.
        public double Valor { get; set; }

        //Constructor que acepta un valor para iniciar una calificación.
        public Calificacion(double valor)
        {
            Valor = valor;
        }
    }

    // Se declara una clase de nombre *Estudiante*.
    class Estudiante
    {
        //Propiedad *Nombre* utilizada para el nombre del estudiante.
        public string Nombre { get; set; }

        //Lista de calificaciones.
        public List<Calificacion> Calificaciones { get; set; }

        //Constructor que inicializa el nombre y crea el listado de calificaciones.
        public Estudiante(string nombre)
        {
            Nombre = nombre;
            Calificaciones = new List<Calificacion>();
        }
    }

    //Declaramos la clase principal *Program*
    class Program
    {
        //Este es el método de entrada principal (`Main`). El programa comienza su ejecución aquí.
        //Toma un arreglo de cadenas como argumento (que no se utiliza en este caso).
        static void Main(string[] args)
        {
            // Crear una lista enlazada de estudiantes
            LinkedList<Estudiante> ListadoEstudiantes = new LinkedList<Estudiante>();

            // lista del combre de cada estudiante *Gabriel, Mariana, Abraham, Julian, Eicker *.
            // En cada linea se agrega el nombre de un nuevo estudiante a la lista.
            ListadoEstudiantes.AddLast(new Estudiante("Gabriel"));
            ListadoEstudiantes.AddLast(new Estudiante("Mariana"));
            ListadoEstudiantes.AddLast(new Estudiante("Abraham"));
            ListadoEstudiantes.AddLast(new Estudiante("Julian"));
            ListadoEstudiantes.AddLast(new Estudiante("Eicker"));

            // Agregar calificaciones a los estudiantes (cinco calificaciones por cada estudiante)

            //Itera a través de cada estudiante en la lista.
            foreach (var estudiante in ListadoEstudiantes)
            {

                //Bucle que se ejecuta por cada calificación en este caso 5 veces.
                for (int i = 0; i < 5; i++)
                {
                   //Proyecta en la consola un mensaje pidiendo al usuario una calificación.
                   //Por cada estudiante en turno.
                    Console.Write($"Ingrese la calificación {i + 1} para {estudiante.Nombre}: ");

                    //Lee la entrada del usuario como una cadena.
                    //Este la convierte a un valor `double` para la calificación.
                    double calificacion = Convert.ToDouble(Console.ReadLine());

                    //Agrega la calificación ingresada a la lista de calificaciones del estudiante.
                    estudiante.Calificaciones.Add(new Calificacion(calificacion));
                }
            }

            // Imprimir la lista enlazada completa

            //Imprime un encabezado para mostrar la lista de estudiantes y sus calificaciones.
            Console.WriteLine("\nListado de estudiantes con sus respectivas calificaciones:");

            //Itera nuevamente a través de cada estudiante en la lista.
            foreach (var estudiante in ListadoEstudiantes)
            {

                //Muestra el nombre del estudiante.
                Console.WriteLine($"Estudiante: {estudiante.Nombre}");

                //Imprime un encabezado para las calificaciones.
                Console.WriteLine("Calificaciones:");

                //Itera a través de las calificaciones del estudiante actual.
                foreach (var calificacion in estudiante.Calificaciones)
                {
                    //Muestra cada calificación en la lista.
                    Console.WriteLine($"- {calificacion.Valor}");
                }
                Console.WriteLine();
            }

            
        }
    }
}

