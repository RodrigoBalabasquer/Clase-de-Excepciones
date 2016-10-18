using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class Carrera
    {
        public List<Auto> ListaDeAutos;
        public string Autodromo;
        public Carrera(string Autodromo) 
        {
            this.ListaDeAutos = new List<Auto>();
            this.Autodromo = Autodromo;
        }
        public void CorrerCarrera() 
        {
            if (this.ListaDeAutos.Count == 0)
            {
                throw new MiExcepcion("ERROR", DateTime.Now);
            }
            else 
            {
                foreach (Auto item in this.ListaDeAutos)
                {
                    item.Andar();
                }
            }
        }
    }
}
