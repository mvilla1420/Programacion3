using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hotel
    {
        List<Habitacion> listaReservacion = new List<Habitacion>();

        public string nombreHotel { get; set; }
        public void agregarHabitacion(Habitacion habitacion) 
        {
        
            listaReservacion.Add(habitacion);   
        }
        public void MostrarHabitacion() 
        {
            Console.WriteLine("********Reservacion******** \n Hotel {0}", this.nombreHotel);

            foreach (var habitacion in listaReservacion)
            {
                Console.WriteLine("Numero de la habitacion:{0} \nNumero de camas: {1} \nTipo de la habitacion: {2} ", habitacion.Nhabitacion, habitacion.ncamas,habitacion.thabitacion);
            }

            Console.ReadLine();


        }
    }
}
