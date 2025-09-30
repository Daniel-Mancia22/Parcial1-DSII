// See https://aka.ms/new-console-template for more information

using System;
using Parcial1_DSII_Daniel_Mancia;

class Program
{
    static void Main()
    {
        // Creamos el de objeto Vehiculo y de Motocicleta
        Vehiculo miVehiculo = new Vehiculo("Toyota", "Corolla", 2022, "Negro", 5000);
        Motocicleta miMotocicleta = new Motocicleta("Honda", "CBR 600RR", 2022, "Blanco", 2300, 599);

        bool condicion = true;

        while (condicion)
        {
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*************** Menu De Opciones *****************");
            Console.WriteLine("**************************************************");
            Console.WriteLine("1. Acelerar Vehiculo");
            Console.WriteLine("2. Acelerar Motocicleta");
            Console.WriteLine("3. Frenar Vehiculo");
            Console.WriteLine("4. Frenar Motocicleta");
            Console.WriteLine("5. Mostrar Informacion Vehiculo");
            Console.WriteLine("6. Mostrar Informacion Motocicleta");
            Console.WriteLine("7. Salir");
            Console.WriteLine("**************************************************");
            Console.Write("Selecciona una opcion: ");
            string opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":// Acelerar Vehiculo
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine($"Velocidad Actual Del Vehiculo: {miVehiculo.VelocidadActual} Km/h");
                    Console.WriteLine();
                    Console.Write($"Ingresa la cantidad para acelerar en Km/h: ");

                    if (double.TryParse(Console.ReadLine(), out double cantidadAceleracion))
                    {
                        if (cantidadAceleracion > 0) {
                            miVehiculo.Acelerar(cantidadAceleracion);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Por favor, ingresa un número positivo para acelerar");
                            Console.WriteLine("---------------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Caracteres no validos, deben ser numeros positivos");
                        Console.WriteLine("---------------------------------------------------");
                    }
                    break;

                case "2":// Acelerar Motocicleta
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine($"Velocidad Actual De la Motocicleta: {miMotocicleta.VelocidadActual} Km/h");
                    Console.WriteLine();
                    Console.Write("Ingresa la cantidad para acelerar en Km/h: ");
                    if (double.TryParse(Console.ReadLine(), out double cantidadAceleracionM))
                    {
                        if (cantidadAceleracionM > 0)
                        {
                            miMotocicleta.Acelerar(cantidadAceleracionM);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Por favor, ingresa un número positivo para acelerar");
                            Console.WriteLine("---------------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Caracteres no validos, deben ser numeros positivos");
                        Console.WriteLine("---------------------------------------------------");
                    }
                    break;

                case "3":// Frenar Vehiculo
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine($"Velocidad Actual Del Vehiculo: {miVehiculo.VelocidadActual} Km/h");
                    Console.WriteLine("Ingresa un Numero Positivo para restarlo a la velocidad");
                    Console.WriteLine();
                    Console.Write("Ingresa la cantidad para frenar en Km/h: ");
                    if (double.TryParse(Console.ReadLine(), out double cantidadFrenado))
                    {
                        if (cantidadFrenado > 0)
                        {
                            miVehiculo.Frenar(cantidadFrenado);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Por favor, ingresa un numero positivo para Frenar");
                            Console.WriteLine("---------------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Caracteres no validos, deben ser numeros positivos");
                        Console.WriteLine("---------------------------------------------------");
                    }
                    break;

                case "4": // Frenar Motocicleta
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine($"Velocidad Actual De la Motocicleta: {miMotocicleta.VelocidadActual} Km/h");
                    Console.WriteLine("Ingresa un Numero Positivo para restarlo a la velocidad");
                    Console.WriteLine();
                    Console.Write("Ingresa la cantidad para frenar en Km/h: ");
                    if (double.TryParse(Console.ReadLine(), out double cantidadFrenadoM))
                    {
                        if (cantidadFrenadoM > 0)
                        {
                            miMotocicleta.Frenar(cantidadFrenadoM);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Por favor, ingresa un numero positivo para Frenar");
                            Console.WriteLine("---------------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Caracteres no validos, deben ser numeros positivos");
                        Console.WriteLine("---------------------------------------------------");
                    }
                    break;

                case "5": // Mostrar Información Vehiculo
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Información del Vehiculo:");
                    Console.WriteLine();
                    miVehiculo.MostrarInformacion();
                    break;

                case "6": // Mostrar Información Motocicleta
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Información de la motocicleta:");
                    Console.WriteLine();
                    miMotocicleta.MostrarInformacion();
                    break;

                case "7":
                    condicion = false;
                    break;

                default:
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    Console.WriteLine("---------------------------------------------------");
                    break;
            }

            // Pausa para que el usuario vea el resultado antes de volver al menú
            if (condicion)
            {
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}