using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class AutoExcepcion:MiExcepcion
    {
        public DateTime HoraDeLaExcepcion;
        public string TextoHoraDeLaExcepcion;
        public Auto AutoDeLaExcepcion;
        public AutoExcepcion(string message, DateTime Hora, Auto auto, Exception exepcionAnterior)
            : base(message, Hora,exepcionAnterior) 
        {   
            this.TextoHoraDeLaExcepcion = Convert.ToString(Hora);
            this.AutoDeLaExcepcion = auto;
        }
    }
}
