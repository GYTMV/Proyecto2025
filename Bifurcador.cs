using System;
using System.Collections;
using System.Collections.Generic;

namespace practica2025
{
    class Bifurcador
    {
        int codigoBifurcador;
        string ubicacion;
        string fuenteIn;
        string fuenteOut1;
        string fuenteOut2;

        public Bifurcador(int codigoBifurcador, string ubicacion, string fuenteIn, string fuenteOut1, string fuenteOut2)
        {
            this.codigoBifurcador = codigoBifurcador;
            this.ubicacion = ubicacion;
            this.fuenteIn = fuenteIn;
            this.fuenteOut1 = fuenteOut1;
            this.fuenteOut2 = fuenteOut2;
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Bifurcador Código: {codigoBifurcador}, Ubicación: {ubicacion}, Fuente de Entrada: {fuenteIn}");
            Console.WriteLine($"Fuente de Salida 1: {fuenteOut1}, Fuente de Salida 2: {fuenteOut2}");
        }

        public void CargarDatos()
        {
            // Lógica para cargar datos del bifurcador
            Console.WriteLine("Ingrese el código del bifurcador:");
            string codigoInput = Console.ReadLine()!;
            while (!PuntoEntrada.IsValidInteger(codigoInput))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero para el código:");
                codigoInput = Console.ReadLine()!;
            }
            int codigoBifurcador = int.Parse(codigoInput);
            Console.WriteLine("Ingrese la ubicación del bifurcador:");
            string ubicacion = Console.ReadLine()!;
            Console.WriteLine("Ingrese la fuente de entrada:");
            string fuenteIn = Console.ReadLine()!;
            Console.WriteLine("Ingrese la fuente de salida 1:");
            string fuenteOut1 = Console.ReadLine()!;
            Console.WriteLine("Ingrese la fuente de salida 2:");
            string fuenteOut2 = Console.ReadLine()!;
            
            this.codigoBifurcador = codigoBifurcador;
            this.ubicacion = ubicacion;
            this.fuenteIn = fuenteIn;
            this.fuenteOut1 = fuenteOut1;
            this.fuenteOut2 = fuenteOut2;

            
        }   


        
    // Validación
             /* if (string.IsNullOrWhiteSpace(entrada))
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