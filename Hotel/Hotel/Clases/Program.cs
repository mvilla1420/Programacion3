using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel1 = new Hotel();

            Habitacion_Individual individual1 = new Habitacion_Individual();

            
            individual1.ReservarHabitacion();

            individual1.Nhabitacion = 20;
            individual1.ncamas = 2;
            individual1.thabitacion = "Individual";


            hotel1.agregarHabitacion(individual1);

            hotel1.MostrarHabitacion();



            //HabitacionDoble doble1= new HabitacionDoble();  
            //Suite suite1= new Suite();

        }
    }
}
