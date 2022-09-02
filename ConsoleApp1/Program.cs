using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpaceX;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raceta myRocket = new Raceta();
            myRocket.Start();

            IlonMask ilonMask = new IlonMask();

        }
    }
}
