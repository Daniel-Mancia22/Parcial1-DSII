using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_DSII_Daniel_Mancia
{
    class Motocicleta : Vehiculo
    {
        //Propiedad
        public int Cilindraje { get; set; }

        //Constructor: valores heredados y la propiedad Cilindraje
        public Motocicleta(string marca, string modelo, int año, string color, double precio, int cilindraje)
            : base(marca, modelo, año, color, precio) // Llamamos al constructor de la clase Vehiculo
        {
            Cilindraje = cilindraje;
        }

        //Sobrescribir el método MostrarInformacion de la clase vehiculo para incluir el Cilindraje
        public new void MostrarInformacion()
        {
            base.MostrarInformacion(); //Llamamos al método de la clase base para mostrar los detalles básicos
            Console.WriteLine($"Cilindraje: {Cilindraje} cc"); // Muestra el cilindraje de la motocicleta
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
        }
    }
}