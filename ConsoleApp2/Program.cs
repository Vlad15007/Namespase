//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp2
{
    using Vselennaia.PlanetaZemlia.Kontinentu.Evropa.Stranu;
    using System;



    //using Okean = Vselennaia.PlanetaZemlia.Okeanu;

    internal class Program
    {
        static void Main(string[] args)
        {
            Ykraina moiaRodnaia = new Ykraina();
            moiaRodnaia.Culture = "вишиванка";


            Console.WriteLine(moiaRodnaia.Culture);

            //Okean.TihiOkean tihiOkean = new Okean.TihiOkean();

            Console.ReadKey();
        }
    }
}

namespace Vselennaia
{
    namespace PlanetaZemlia
    {
        namespace Kontinentu
        {
            namespace Evropa
            {
                namespace Stranu
                {
                    class Strana
                    {
                        public string Culture { get; set; }
                    }
                }
            }
            
            namespace UjnaiaAmerika
            {

            }

            namespace SevernaiaAmerika
            {

            }
        }

        namespace Okeanu
        {
            class TihiOkean
            {

            }
        }
    }

    namespace Upiter
    {

    }
}

