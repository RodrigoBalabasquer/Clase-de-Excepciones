using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class PinchaduraExcepcion:MiExcepcion
    {
        public DateTime HoraDeLaExcepcion;
        public string TextoHoraDeLaExcepcion;
        public string MarcaDeRueda;
        public PinchaduraExcepcion(string message, DateTime Hora, string Marca, Exception exepcionAnterior)
            : base(message, Hora, exepcionAnterior) 
        {
            this.TextoHoraDeLaExcepcion = Convert.ToString(Hora);
            this.MarcaDeRueda = Marca;
        }
        public PinchaduraExcepcion(string message, DateTime Hora, string Marca)
            : base(message, Hora)
        {
            this.TextoHoraDeLaExcepcion = Convert.ToString(Hora);
            this.MarcaDeRueda = Marca;
        }
    }
}
