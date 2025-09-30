using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_DSII_Daniel_Mancia
{
    class Vehiculo
    {
        //Propiedades
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Año { get; set; }

        public double VelocidadActual { get; set; }

        public string Color { get; set; }

        public double Precio { get; set; }

        //Constructor: Donde inicializamos los valores de la clase.
        public Vehiculo(string marca, string modelo, int año, string color, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            VelocidadActual = 0.0;
            Color = color;
            Precio = precio;
        }

        //Metodos Implementados
        public void Acelerar(double cantidad)
        {
            VelocidadActual += cantidad;
            Console.WriteLine();
            Console.WriteLine($"La velocidad actual es: {VelocidadActual} Km/h");
            Console.WriteLine("---------------------------------------------------");
        }

        public void Frenar (double cantidad)
        {
            VelocidadActual -= cantidad;
            if(VelocidadActual < 0)
            {
                VelocidadActual = 0; //la velocidad no puede ser negativa
            }
            Console.WriteLine();
            Console.WriteLine($"La velocidad actual es: {VelocidadActual} Km/h");
            Console.WriteLine("---------------------------------------------------");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Velocidad Actual: {VelocidadActual} Km/h");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Precio: ${Precio}");
        }
    }
}