using System;

namespace Enigma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try {
                System.Console.WriteLine("Please enter input text");
                string plainText = Console.ReadLine();

                EnigmaMachine enigmaMachine = new EnigmaMachine();
                string cipherText = enigmaMachine.EncryptString(plainText);

                System.Console.WriteLine("Output text: " + cipherText);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
    }
}
