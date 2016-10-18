using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class MiExcepcion: Exception
    {
        public DateTime HoraDeLaExcepcion;
        public string TextoHoraDeLaExcepcion;
        public MiExcepcion(string message, DateTime Hora):base(message)
        {
            this.HoraDeLaExcepcion = Hora;
            this.TextoHoraDeLaExcepcion = Convert.ToString(Hora);
        }
        public MiExcepcion(string message,DateTime Hora,Exception exepcionAnterior)
            : base(message, exepcionAnterior)
        {
            this.HoraDeLaExcepcion = Hora;
            this.TextoHoraDeLaExcepcion = Convert.ToString(Hora);
        }
    }
}
