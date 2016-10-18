using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    class Program
    {
        static void Main()
        {   
            /*
            //LanzarError(); Como no esta en ningun try no se captura el error y se tilda la ejecucion 
            //Escribimos lo que pueda dar error
            try
            {
                LanzarError();//Lanza el error, lo captura el try y lo manda al catch, salteandose el metodo Operar
                Operar();
            }
            //Se ejecutara si ocurre el error en el try
            catch (FormatException Ex)
            {

                Console.WriteLine("Error de Formato");
                Console.WriteLine(Ex.Message);
            }
            catch (DivideByZeroException Ex)
            {
                Console.WriteLine("Divide por Cero");
                Console.WriteLine(Ex.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("General");
                Console.WriteLine(Ex.Message);
            }*/

            Carrera NuevaCarrera = new Carrera("FIFA");
            Auto Auto1= new Auto("FIAT", 4);
            Auto Auto2 = new Auto("CHEVROLET", 4);
            Auto Auto3 = new Auto("DASD", 4);
            Auto Auto4 = new Auto("ACEW", 4);
            Auto1.ListaDeRuedas.Add(new Rueda("dasd"));
            Auto1.ListaDeRuedas.Add(new Rueda("eqwe"));
            Auto1.ListaDeRuedas.Add(new Rueda("gfdr"));
            Auto1.ListaDeRuedas.Add(new Rueda("mkls"));

            Auto2.ListaDeRuedas.Add(new Rueda("gsda"));
            Auto2.ListaDeRuedas.Add(new Rueda("gdsd"));
            Auto2.ListaDeRuedas.Add(new Rueda("bftg"));
            Auto2.ListaDeRuedas.Add(new Rueda("ptgf"));

            Auto3.ListaDeRuedas.Add(new Rueda("qret"));
            Auto3.ListaDeRuedas.Add(new Rueda("bgdx"));
            Auto3.ListaDeRuedas.Add(new Rueda("puhf"));
            Auto3.ListaDeRuedas.Add(new Rueda("xvds"));

            Auto4.ListaDeRuedas.Add(new Rueda("asqw"));
            Auto4.ListaDeRuedas.Add(new Rueda("uynl"));
            Auto4.ListaDeRuedas.Add(new Rueda("czxa"));
            Auto4.ListaDeRuedas.Add(new Rueda("xgrw"));

            NuevaCarrera.ListaDeAutos.Add(Auto1);
            NuevaCarrera.ListaDeAutos.Add(Auto2);
            NuevaCarrera.ListaDeAutos.Add(Auto3);
            NuevaCarrera.ListaDeAutos.Add(Auto4);
            try
            {
                NuevaCarrera.CorrerCarrera();
            }
            catch (PinchaduraExcepcion Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            catch (AutoExcepcion Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            catch (MiExcepcion Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Console.ReadKey();
        }


        /*public static void Operar() 
        {
            string dato;
            int numero;
            try
            {
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                numero = numero / numero;
            }
            catch (Exception Ex)
            {
                //Operaciones para guardar informacion de la excepcion
                throw new Exception("Se quedo sin internet.");
            }
        }
        public static void LanzarError() 
        {
            throw new Exception("Se quedo sin memoria RAM.");
        }*/
    }
    
}
