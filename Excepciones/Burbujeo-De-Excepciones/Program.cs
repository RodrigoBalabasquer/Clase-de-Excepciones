using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujeo_De_Excepciones
{
    class Program
    {
        static void Main()
        {
            //1) Constructor-Instancia-Program
            //2) Static-Instancia-Program
            //3) Instancia-Static-Constructor-Program
            //4) 3 Metodos Static-Program
            //5) 3 Instancia-Static-Constructor-Program

            Auto unAuto = new Auto();
            //1)
            
            try
            {
                unAuto.MalAuto();
            }
            catch (MyException Ex)
            {
                
                Console.WriteLine(Ex.InnerException.Message);
                Console.WriteLine(Ex.Message);
            }
            

            //2) 

            try
            {   
                 
                unAuto.MalFuncionamiento();
            }
            catch (MyException Ex)
            {

                Console.WriteLine(Ex.InnerException.Message);
                Console.WriteLine(Ex.Message);
            }

            //3)

            try
            {
                Auto OtroAuto = new Auto(2015, "Chevrolet");
            }
            catch (MyException Ex)
            {

                Console.WriteLine(Ex.Message);
                Console.WriteLine(Ex.InnerException.Message);
                Console.WriteLine(Ex.InnerException.InnerException.Message);
            }

            //4)

            try
            {
                Program.Nada();
            }
            catch (MyException Ex)
            {

                Console.WriteLine(Ex.Message);
                Console.WriteLine(Ex.InnerException.Message);
                Console.WriteLine(Ex.InnerException.InnerException.Message);
            }
            Console.ReadKey();
        }
        #region 4)
        public static void Nada()
        {
            try
            {
                Program.Noda();
            }
            catch (MyException Ex)
            {

                throw new MyException("ERROR", DateTime.Now,Ex);
            }
        }
        public static void Noda()
        {
            try
            {
                Program.Nuda();
            }
            catch (MyException Ex)
            {

                throw new MyException("OTRO ERROR", DateTime.Now,Ex);
            }
        }
        public static void Nuda()
        {
            throw new MyException("OTRO ERROR MAS", DateTime.Now);
        }
        #endregion
    }
}
