using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {

        static Queue<string> toll = new Queue<string>();

        static void Main(string[] args)
        {
            #region Stack
            //var browse = new Browse();
            //browse.NavigateTo("google.com");
            //browse.NavigateTo("caelum.com.br");
            //browse.NavigateTo("alura.com.br");

            //browse.ReturnPage();
            //browse.ReturnPage();
            //browse.ReturnPage();
            //browse.ReturnPage();
            //browse.ReturnPage();

            //browse.NextPage();
            //browse.NextPage();
            //browse.NextPage();
            //browse.NextPage();
            //browse.NextPage();

            //browse.ReturnPage();
            //browse.ReturnPage();
            //browse.ReturnPage();
            //browse.ReturnPage();
            //browse.ReturnPage();
            #endregion

            #region Queue


            TollEnqueue("Van");
            TollEnqueue("Kombi");
            TollEnqueue("Guincho");
            TollEnqueue("Pickup");
            TollDequeue();
            TollDequeue();
            TollDequeue();
            TollDequeue();
            TollDequeue();


            #endregion


            Console.ReadKey();

        }

        private static void TollDequeue()
        {
            
            if (toll.Any())
            {
                if (toll.Peek() == "Guincho")
                {
                    Console.WriteLine($"Guincho is making payment");
                }
                Console.WriteLine("_________________________");
                string vehicle = toll.Dequeue();
                Console.WriteLine($"Dequeue: {vehicle}");
                PrintQueue();
            }
            else
            {
                Console.WriteLine("The toll is empty");
            }
        }


        private static void TollEnqueue(string vehicle)
        {
            Console.WriteLine("=======================");
            toll.Enqueue(vehicle);
            Console.WriteLine($"Into in queue: {vehicle}");
            Console.WriteLine(".......................");
            Console.WriteLine($"Queue:");
            PrintQueue();
        }

        private static void PrintQueue()
        {
            foreach (var item in toll)
            {
                Console.WriteLine(item);
            }
        }
    }
}
