using System;
using System.Collections;
using System.Collections.Generic;

namespace practica2025
{
    class NodoDistribucion
    {
        //Atributos de la clase
        private ushort codigo;
        private string ubicacion, puntoConexion, repartidorOut;

        //Constructor con todos los atributos de la clase
        public NodoDistribucion(ushort codigo, string ubicacion, string puntoConexioIn, string repartidorOut)
        {
            this.codigo = codigo;
            this.ubicacion = ubicacion;
            this.puntoConexioIn = puntoConexioIn;
            this.repartidorOut = repartidorOut;
        }

        //Constructor con valores por defecto

        public NodoDistribucion()
        {
            this.codigo = 0;
            this.ubicacion = "Ubicacion Default";
            this.puntoConexioIn = "Punto Default";
            this.repartidorOut = "Repartidor Default";

        }

        public int getCodigo
        {
            get
            {
                return codigo;
            }
        }

        public string getUbicacion
        {
            get
            {
                return ubicacion;
            }
            set
            {
                ubicacion = value;
            }
        }

        public string getPuntoConexion
        {
            get
            {
                return puntoConexioIn
            }
            set
            {
                puntoConexioIn = value;
            }
        }

        public string getRepartidor
        {
            get
            {
                return repartidorOut;
            }
            set 
            {
                repartidorOut = value;
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nodo de Distribución Código: {codigo}, Ubicación: {ubicacion}, Punto de Conexión de entrada: {puntoConexioIn}, Repartidor de salida: {repartidorOut}");
        }

        public void CargarDatos()
        {
            // Lógica para cargar datos del nodo de distribución
            Console.WriteLine("Ingrese el código del nodo de distribución:");
            string codigoInput = Console.ReadLine()!;
            while (!PuntoEntrada.IsValidInteger(codigoInput))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero para el código:");
                codigoInput = Console.ReadLine()!;
            }
            int codigo = int.Parse(codigoInput);
            Console.WriteLine("Ingrese calle y altura del nodo de distribución:");
            string ubicacion = Console.ReadLine()!;
            Console.WriteLine("Ingrese el punto de conexión de entrada:");
            string puntoConexioIn = Console.ReadLine()!;
            Console.WriteLine("Ingrese el repartidor de salida:");
            string repartidorOut = Console.ReadLine()!;

            this.codigo = codigo;
            this.ubicacion = ubicacion;
            this.puntoConexioIn = puntoConexioIn;
            this.repartidorOut = repartidorOut;

        }
        
        public static bool IsValidInteger(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out _);
        }
    

    }
}