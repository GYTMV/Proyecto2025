

using System;

namespace practica2025
{
    class PuntoEntrada
    {
        private byte nuevo;
       
        public string Nombre { get; set; }
        public int PotenciaMaxima { get; set; }
        public string URL { get; set; }
        public string NombreDirector { get; set; }
        public string TelDirector { get; set; }
        public string NodoConexion { get; set; }

        public PuntoEntrada()
        {
            this.Nombre = "Punto Default";
            this.PotenciaMaxima = 100;
            this.URL = "http://default.url";
            this.NombreDirector = "Director Default";
            this.TelDirector = "000-000-0000";
            this.NodoConexion = "Nodo Default"; 

        }

        public PuntoEntrada(string nombre, int PotenciaMaxima, string url, string nombreDirector, string telDirector, string nodoConexion)
        {
            this.Nombre = nombre;
            this.PotenciaMaxima = PotenciaMaxima;
            this.URL = url;
            this.NombreDirector = nombreDirector;
            this.TelDirector = telDirector;
            this.NodoConexion = nodoConexion;
        }


        public void MostarInfo()
        {
            Console.WriteLine($"Hola, el nombre del punto es {Nombre} y su potencia maxima es {PotenciaMaxima} .");
            Console.WriteLine($"El URL del punto de entrada es {URL}.");
            Console.WriteLine($"El nombre del director es {NombreDirector} y su telefono es {TelDirector}.");
            Console.WriteLine($"El nodo de conexion es {NodoConexion}.");
        }
        public static bool IsValidInteger(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out _);
        }

        public void CargarDatos()
        {
            // Lógica para cargar datos del punto de entrada
            Console.WriteLine("Ingrese el nombre del punto de entrada:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la potencia máxima:");
            string potenciaInput = Console.ReadLine();

            while (!IsValidInteger(potenciaInput))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero para la potencia máxima:");
                potenciaInput = Console.ReadLine()!;
            }
            int potenciaMaxima = int.Parse(potenciaInput);

            Console.WriteLine("Ingrese el URL del punto de entrada:");
            string url = Console.ReadLine()!;

            Console.WriteLine("Ingrese el nombre del director:");
            string nombreDirector = Console.ReadLine()!;

            Console.WriteLine("Ingrese el teléfono del director:");
            string telDirector = Console.ReadLine()!;

            Console.WriteLine("Ingrese el nodo de conexión:");
            string nodoConexion = Console.ReadLine()!;

            // Asignar los valores ingresados a las propiedades del objeto
            this.Nombre = nombre;
            this.PotenciaMaxima = potenciaMaxima;
            this.URL = url;
            this.NombreDirector = nombreDirector;
            this.TelDirector = telDirector;
            this.NodoConexion = nodoConexion;

        }
    }
}