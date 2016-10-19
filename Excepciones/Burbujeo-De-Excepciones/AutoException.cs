using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujeo_De_Excepciones
{
    public class AutoException:MyException
    {
        public DateTime HoraDeLaExcepcion;
        public string TextoHoraDeLaExcepcion;
        public Auto AutoDeLaExcepcion;
        public AutoException(string message, DateTime Hora, Auto auto, Exception exepcionAnterior)
            : base(message, Hora,exepcionAnterior) 
        {   
            this.TextoHoraDeLaExcepcion = Convert.ToString(Hora);
            this.AutoDeLaExcepcion = auto;
        }
        public AutoException(string message, DateTime Hora, Auto auto)
            : base(message, Hora)
        {
            this.TextoHoraDeLaExcepcion = Convert.ToString(Hora);
            this.AutoDeLaExcepcion = auto;
        }
    }
}
