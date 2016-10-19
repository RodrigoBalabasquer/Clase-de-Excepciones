using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujeo_De_Excepciones
{
    public class Auto
    {
        public string Marca;
        public int Numero;
        public Auto() 
        {

        }
        #region 1)
        public Auto(string Marca, int Numero)
        {
            this.Marca = Marca;
            this.Numero = Numero;
            throw new AutoException("ERROR", DateTime.Now,this);
        }
        public void MalAuto() 
        {
            try
            {
                Auto OtroAuto = new Auto("Chevrolet", 2015);
            }
            catch (AutoException EX)
            {

                throw new MyException("OTRO ERROR", DateTime.Now, EX);
            }
        }
        #endregion
        #region 2)
        public void MalFuncionamiento()
        {
            try
            {
                Auto.Mal(this);
            }
            catch (AutoException EX)
            {

                throw new MyException("OTRO ERROR", DateTime.Now, EX);
            }
        }
        public static void Mal(Auto auto) 
        {
            throw new AutoException("ERROR", DateTime.Now, auto);
        }
        #endregion
        #region 3)
        public Auto(int Numero, string Marca)
        {
            this.Marca = Marca;
            this.Numero = Numero;
            try
            {
                Auto.mal(this);
            }
            catch (AutoException EX)
            {

                throw new MyException("OTRO ERROR MAS", DateTime.Now,EX);
            }
        }
        public static void mal(Auto auto)
        {
            try
            {
                auto.malFuncionamiento();
            }
            catch (AutoException EX)
            {

                throw new AutoException("OTRO ERROR", DateTime.Now,auto,EX);
            }
        }
        public void malFuncionamiento()
        {
            throw new AutoException("ERROR", DateTime.Now, this);
        }
        #endregion
    }
}
