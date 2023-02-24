using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Habitacion_Individual : Habitacion,IReservable
    {
        public int Precio = 200;
        public int qnoches = 3;
        //public int Nhabitacion = 01;
        //public string thabitacion = "Individual";
        //public int ncamas = 1;
        public override double Ctarifa()
        {
            //this.Precio = 1000;
            //double tnoche = Precio * qnoches; 
            //return tnoche;
            return Precio * qnoches;
            
        }

        public void ReservarHabitacion()
        {
            double preciofinal = Ctarifa();
            Console.WriteLine("Su reservacion es por un monto de ${0}", preciofinal,Nhabitacion,ncamas,thabitacion);
        }


    }
}
