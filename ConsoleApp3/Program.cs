using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

namespace Kvadrokopter
{
    namespace Sensoru
    {
        class Axelerometr : Mozg.PoliotnuiController
        {

        }
    }

    namespace Mozg
    {
        namespace Mozg
        {
            class PoliotnuiController
            {

            }
        }

        class PoliotnuiController
        {

        }
    }

    namespace DvigatelnaiaOsnova
    {
        namespace Motoru
        {
            namespace Propleru
            {
                class Propeleru
                {
                    Propeleru myProp = new Propeleru();
                    Motoru myMt = new Motoru();
                    Osnova myOsn = new Osnova();
                    Body Body = new Body();
                }
            }

            class Motoru
            {
                //Propeleru myProp = new Propeleru();
                Motoru myMt = new Motoru();
                Osnova myOsn = new Osnova();
                Body Body = new Body();
            }
        }

        class Osnova
        {
            //Propeleru myProp = new Propeleru();
            //Motoru myMt = new Motoru();
            Osnova myOsn = new Osnova();
            Body myBody = new Body();
        }
    }

    class Body
    {
        //Propeleru myProp = new Propeleru();
        //Motoru myMt = new Motoru();
        //Osnova myOsn = new Osnova();
        Body myBody = new Body();
    }
}
