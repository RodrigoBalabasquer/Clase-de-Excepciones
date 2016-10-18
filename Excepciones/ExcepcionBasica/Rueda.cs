using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class Rueda
    {
        public string Marca;
        public static Random random;
        public Rueda(string Marca) 
        {
            this.Marca = Marca;
        }
        static Rueda() 
        {
            random = new Random();
        }
        public void Pinchar() 
        {   
            throw new PinchaduraExcepcion("Se pincho la rueda",DateTime.Now,this.Marca);
        }
        public void Rodar() 
        {
            int numero;
            numero = random.Next(1, 11);
            if (numero == 5)
                Pinchar();
                Console.WriteLine("Numero random: " + numero);
        }
    }
}
