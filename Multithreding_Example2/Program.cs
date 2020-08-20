using System;
using System.Threading;

namespace Multithreding_Example2
{
    class Program
    {
        private static bool run = true; 
        static void Main(string[] args)
        {
            var m = 0;
            var x = 0;

            //Creamos el hilo y lo arrancamos
            //Thread miHilo = new Thread(Mensaje);
            //miHilo.Start();

            //Aqui estamos creand multiples hilos
            for (x = 0; x < 8; x++)
            {
                Thread miHilo = new Thread(MensajeM);
                miHilo.Start(x);
            }

            while (run)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hilo principal{0}", m);
                m++;
                if (m == 2500) 
                {
                    run = false;
                }
            }
            Console.ReadKey();
        }

        static void Mensaje()
        {
            var n = 0;
            while (run)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hilo principal{0}", n);
                n++;
            }
        }

        static void MensajeM(object o)
        {
            var n = 0;
            while (run)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hilo secundario{0} - {1}", o, n);
                n++;
            }
        }
    }
}
