using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zayn.Progyliatsa.PoslednaiaKaplia pab = new Zayn.Progyliatsa.PoslednaiaKaplia();
            
            
            //Zayn.Progyliatsa.Podzemelie podzemelie = new Zayn.Progyliatsa.Podzemelie();



            Pab myPab = new Pab();
            Console.WriteLine(myPab);

            Console.ReadKey();
        }
    }

    class Pab : Zayn.Progyliatsa.PoslednaiaKaplia
    {
        public override string ToString()
        {
            return Lider;
        }
    }
}
