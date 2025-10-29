// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections;
using System.Collections.Generic;

namespace practica2025
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Puntos = new ArrayList();
            ArrayList Nodos = new ArrayList();
            ArrayList Distribucion = new ArrayList();
         
           /* PuntoEntrada punto1 = new PuntoEntrada("Punto Central", 500, "http://puntocentral.url", "Juan Perez", "123-456-7890", "Nodo A");
            PuntoEntrada punto2 = new PuntoEntrada();
            Puntos.Add(punto1);
            Puntos.Add(punto2);
            foreach (PuntoEntrada punto in Puntos)
            {
                punto.MostarInfo();
                Console.WriteLine();
            }
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();*/
            bool corte = true;
            
            while (corte)
            {
                Menu();

              string entrada = Console.ReadLine()!;

    // Validación
              if (string.IsNullOrWhiteSpace(entrada))
               {
                  Console.WriteLine("Entrada vacía. Por favor ingrese un número.");
                  continue;
                }

                if (!int.TryParse(entrada, out int opcion))
                {
                  Console.WriteLine("Entrada no válida. Por favor ingrese un número entero.");
                  continue;
             }


                switch (opcion)
                {
                    case 0:
                        corte = false;
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;

                    case 1:

                        // Lógica para mostrar puntos de entrada
                        PuntoEntrada nuevoPunto = new PuntoEntrada();
                        nuevoPunto.CargarDatos();
                        Puntos.Add(nuevoPunto);
                        break;

                    case 2:
                        Console.WriteLine("Agregando nuevo punto de entrada...");
                        // Lógica para agregar punto de entrada
                        break;

                    case 3:
                        // Lógica para eliminar punto de entrada
                        NodoDistribucion nuevoNodo = new NodoDistribucion();
                        nuevoNodo.CargarDatos();
                        Nodos.Add(nuevoNodo);
                        break;

                    case 4:
                        Console.WriteLine("Creando nodo de distribución...");
                        // Lógica para crear nodo de distribución
                        break;
                    case 5:
                        Console.WriteLine("Conectando 2 nodos de distribución...");
                        // Lógica para conectar 2 nodos de distribución
                        break;
                    case 6:
                        Console.WriteLine("Desconectando 2 nodos de distribución...");
                        // Lógica para desconectar 2 nodos de distribución
                        break;
                    case 7:
                        Console.WriteLine("Creando tramo de línea...");
                        // Lógica para crear tramo de línea
                        break;
                    case 8:
                        Console.WriteLine("Creando bifurcador...");
                        // Lógica para crear bifurcador
                        break;
                    case 9:
                        Console.WriteLine("Encontrando nodos de distribución sin energía...");
                        // Lógica para encontrar nodos de distribución sin energía
                        break;


                    default:
                        Console.WriteLine("Opción no válida. Por favor intente de nuevo.");
                        break;
                }
            }















        }

        public static void Menu()
        {
            Console.WriteLine("***BIENVENIDO A LA GESTION ELECTRICA MUNICIPAL***\n");
            Console.WriteLine();
            Console.WriteLine("Elija una opcion del menu para continuar:");
            Console.WriteLine("0_ Salir del programa");
            Console.WriteLine("1_ Crear punto de entrada");
            Console.WriteLine("2_ Eliminar punto de entrada");
            Console.WriteLine("3_ Crear nodo de distribucion");
            Console.WriteLine("4_ Conectar 2 nodo de distribucion");
            Console.WriteLine("5_ Desconectar 2 nodo de distribucion");
            Console.WriteLine("6_ Crear tramo de linea (debera agregar fuente de energia)");
            Console.WriteLine("7_ Crear bifurcador (debera agregar fuente de energia)");
            Console.WriteLine("8_ Encontrar nodos de distribucion sin energia");
            Console.WriteLine("9_ Seguir linea hasta fuente de energia");


        }


    
        public static bool IsValidInteger(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out _);
        }

        /*private class NodoDistribucion
        {
            internal void CargarDatos()
            {
                throw new NotImplementedException();
            }
        }*/
    }
}

