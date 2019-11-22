using System;
using System.Net;
using System.Net.Http;

namespace Test


{
    public class Rates
    {
        public double USD { get; set; }
    }

    public class RootObject
    {
        public Rates rates { get; set; }
        public string @base { get; set; }
        public string date { get; set; }
    }
}

namespace ConsoleApp5
{
    class Program
    {
        public static string USD2 { get; private set; }

        static void Main(string[] args)
        {

            Console.Write("Hoeveel euro:");
            decimal bedrag = Convert.ToDecimal(Console.ReadLine());
            try
            {
                Console.WriteLine(Wisselkoers.EuroDollarKoers(bedrag));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uw heeft geen internet");
            }
            Console.ReadLine();
        }
    }
}