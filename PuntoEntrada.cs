

using System;
using System.Text.RegularExpressions;

namespace practica2025
{
    class PuntoEntrada
    {
        //Atributos de clase
        public string nombre, url, nombreDirector, telefono, nodo;
        public byte potenciaMaxima;

        //Constructor 1
        public PuntoEntrada(string nombre, byte PotenciaMaxima, string url, string nombreDirector, string telefono, string nodo)
        {
            this.nombre = nombre;
            this.potenciaMaxima = PotenciaMaxima;
            
            if (!IsValidUrl(url))
            {
                throw new ArgumentException("La URL ingresada no es valida. Por favor ingrese una URL valida.");
            }

            this.url = url;
            
            this.nombreDirector = nombreDirector;
            this.telefono = telefono;
            this.nodo = nodo;
        }

        //Constructor 2
        public PuntoEntrada()
        {
            this.nombre = "Punto Default";
            this.potenciaMaxima = 100;
            this.url = "http://default.url";
            this.nombreDirector = "Director Default";
            this.telefono = "000-000-0000";
            this.nodo = "Nodo Default";

        }
        public string GetNombre
        {
            get {return nombre;}
        }

        public int GetPotencia
        {
            get {return potenciaMaxima;}
        }

        public string GetUrl
        {
            get {return url;}
        }

        public string GetNombreDirector
        {
            get {return nombreDirector;}
            set {nombreDirector = value;}
        }

        public string GetTelDirector
        {
            get {return telefono;}
            set {telefono = value;}
        }

        public string GetNodoConexion
        {
            get {return nodo;}
        }
            

        public void MostarInfo()
        {
            Console.WriteLine($"Hola, el nombre del punto es {nombre} y su potencia maxima es {potenciaMaxima} .");
            Console.WriteLine($"El URL del punto de entrada es {url}.");
            Console.WriteLine($"El nombre del director es {nombreDirector} y su telefono es {telefono}.");
            Console.WriteLine($"El nodo de conexion es {nodo}.");
        }
        public void MostrarInfoRed()
        {
            Console.WriteLine($"Hola, el nombre del punto es {nombre} y su potencia maxima es {potenciaMaxima}, El URL del punto de entrada es {url} ");
        }

        public void InfoDirector()
        {
            Console.WriteLine($"El nombre del director es {nombreDirector} y su telefono es {telefono}.");

        }

        public void NodoConexion()
        {
            Console.WriteLine($"El nodo de conexion es {nodo}.");
        }

        public static bool IsValidInteger(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out _);
        }

        public static bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return false;

            string regexValidet = @"^(https?:\/\/)?[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(\/.*)?$";
            return Regex.IsMatch(url, regexValidet);
        }

        public static bool IsValidPhone(string telDirector)
        {
            if (string.IsNullOrEmpty(telDirector))
                return false;

            string regexValidetPhone = @"^(\d{3}[-]?){2}\d{4}$|^(\d{10})$";
            return Regex.IsMatch(telDirector, regexValidetPhone);
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
            byte potenciaMaxima = byte.Parse(potenciaInput);

            Console.WriteLine("Ingrese el URL del punto de entrada:");
            string url = Console.ReadLine()!;
            
            // En caso de que la URL no sea valida, se pedira que ingrese una URL valida hasta que sea valida.
            while (!IsValidUrl(url))
            {
                Console.WriteLine("La URL ingresada no es valida. Por favor ingrese una URL valida.");
                url = Console.ReadLine()!;
            }

            //Nro teléfono no válido
            while(!IsValidPhone(telefono))
            {
                Console.WriteLine("No ingresaste un número de teléfono. Ingrese un número de teléfono");
                telefono = Console.ReadLine()!; 
            }

            Console.WriteLine("Ingrese el nombre del director:");
            string nombreDirector = Console.ReadLine()!;


            Console.WriteLine("Ingrese el teléfono del director:");
            string telefono = Console.ReadLine()!;


            Console.WriteLine("Ingrese el nodo de conexión:");
            string nodo = Console.ReadLine()!;

           

            // Asignar los valores ingresados a las propiedades del objeto
            this.nombre = nombre;
            this.potenciaMaxima = potenciaMaxima;
            this.url = url;
            this.nombreDirector = nombreDirector;
            this.telefono = telefono;
            this.nodo = nodo;

        }
    }
}