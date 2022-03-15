using System;

namespace Enigma
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Service selectedService = Services.Determine(args);

            if (selectedService == Service.Encrypt)
            {

                System.Console.WriteLine("Please enter plaintext");
                string plainText = Console.ReadLine();
                
            
            }


        }
    }
}
