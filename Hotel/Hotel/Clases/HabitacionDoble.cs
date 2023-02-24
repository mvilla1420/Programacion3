using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class HabitacionDoble : Habitacion,IReservable
    {
        public override double Ctarifa()
        {
            throw new NotImplementedException();
        }

        public void ReservarHabitacion()
        {
            throw new NotImplementedException();
        }
    }
}
