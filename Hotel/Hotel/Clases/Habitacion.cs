using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public abstract class Habitacion
    {
        public int Nhabitacion { get; set; } //nhabitacion es numero de habitacion
        public string thabitacion { get; set; } //thabitacion es tamaño de la habitacion(individual, doble o suite)

        public int ncamas { get; set; } //ncamas es numeros de camas en la habitacion

        public double Precio { get; set; }

        public int qnoches { get; set; } //ncamas es numeros de camas en la habitacion

        public abstract double Ctarifa(); // Ctarifa es calcular tarifa

    }


}
