using System;
using System.Collections;
using System.Collections.Generic;

namespace practica2025
{
    class Tramo
    {
        int codigoTramo:
        byte fases;
        string calle, fuenteIn, fuenteOut;
        ushort alturaInicio, alturaFin;
  

        public Tramo(int codigoTramo, string calle, ushort alturaInicio, ushort alturaFin, byte fases, string fuenteIn, string fuenteOut)
        {
            this.codigoTramo = codigoTramo;
            this.calle = calle;
            this.alturaInicio = alturaInicio;
            this.alturaFin = alturaFin;
            this.fases = fases;
            this.fuenteIn = fuenteIn;
            this.fuenteOut = fuenteOut;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Tramo Código: {codigoTramo}, Direccion: {calle}, Punto de Inicio: {alturaInicio}, Punto de Fin: {alturaFin}");
            Console.WriteLine($"Fases: {fases}, Fuente de Entrada: {fuenteIn}, Fuente de Salida: {fuenteOut}");
        }

        //PROPS
        public int getCodigoTramo
        {
            get {return codigoTramo;}
        }

        public byte getFases
        {
            get {return fases;}
            set {fases = value;}
        }

        public string getCalle
        {
            get {return calle;}
        }

        public ushort getAlturaInicio
        {
            get {return alturaInicio;}
        }

        public ushort getAlturaFin
        {
            get {return alturaFin;}
        }

        public string getFuenteIn
        {
            get {return fuenteIn;}
        }

        public string getFuenteOut
        {
            get {return fuenteOut;}
        }

        public void CargarDatos()
        {
            // Lógica para cargar datos del tramo
            Console.WriteLine("Ingrese el código del tramo:");
            string codigoInput = Console.ReadLine()!;
            while (!PuntoEntrada.IsValidInteger(codigoInput))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero para el código:");
                codigoInput = Console.ReadLine()!;
            }
            int codigoTramo = int.Parse(codigoInput);
            Console.WriteLine("Ingrese la calle del tramo:");
            string calle = Console.ReadLine()!;
            Console.WriteLine("Ingrese la altura de inicio:");
            string alturaInicioInput = Console.ReadLine()!;
            while (!PuntoEntrada.IsValidInteger(alturaInicioInput))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero para la altura de inicio:");
                alturaInicioInput = Console.ReadLine()!;
            }
            int alturaInicio = int.Parse(alturaInicioInput);
            Console.WriteLine("Ingrese la altura de fin:");
            string alturaFinInput = Console.ReadLine()!;
            while (!PuntoEntrada.IsValidInteger(alturaFinInput))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero para la altura de fin:");
                alturaFinInput = Console.ReadLine()!;
            }
            int alturaFin = int.Parse(alturaFinInput);
            Console.WriteLine("Ingrese el número de fases:");
            string fasesInput = Console.ReadLine()!;
            while (!PuntoEntrada.IsValidInteger(fasesInput))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero para las fases:");
                fasesInput = Console.ReadLine()!;
            }
            int fases = int.Parse(fasesInput);
            Console.WriteLine("Ingrese la fuente de entrada:");
            string fuenteIn = Console.ReadLine()!;
            Console.WriteLine("Ingrese la fuente de salida:");
            string fuenteOut = Console.ReadLine()!;
            Tramo nuevoTramo = new Tramo(codigoTramo, calle, alturaInicio, alturaFin, fases, fuenteIn, fuenteOut);
            Console.WriteLine("Tramo creado con éxito.");

            this.codigoTramo = codigoTramo;
            this.calle = calle;
            this.alturaInicio = alturaInicio;
            this.alturaFin = alturaFin;
            this.fases = fases;
            this.fuenteIn = fuenteIn;
            this.fuenteOut = fuenteOut;

            
        }   



    // Validación
              /*if (string.IsNullOrWhiteSpace(entrada))
                {
                  Console.WriteLine("Entrada vacía. Por favor ingrese un número.");
                  continue;
                }

                if (!int.TryParse(entrada, out int opcion))
                {
                  Console.WriteLine("Entrada no válida. Por favor ingrese un número entero.");
                  continue;
                }*/
                
    }
}