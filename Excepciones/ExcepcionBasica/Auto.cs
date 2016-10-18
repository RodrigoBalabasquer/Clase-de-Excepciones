using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class Auto
    {
        public string Marca;
        public int Numero;
        public List<Rueda> ListaDeRuedas;
        public Auto(string Marca,int Numero)
        {
            this.Marca = Marca;
            this.Numero = Numero;
            this.ListaDeRuedas = new List<Rueda>();
        }
        public void Andar() 
        {
            if (this.ListaDeRuedas.Count < 4)
            {
                throw new MiExcepcion("ERROR", DateTime.Now);
            }
            else 
            {
                try
                {
                    foreach (Rueda item in this.ListaDeRuedas)
                    {
                        item.Rodar();
                    }
                }
                catch (PinchaduraExcepcion Pincho)
                {
                    throw new AutoExcepcion("Pinchazo", Pincho.HoraDeLaExcepcion, this,Pincho);
                }
                
            }
        }
    }
}
