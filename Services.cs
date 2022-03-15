using System;

namespace Enigma
{
    public class Services
    {
        public static Service Determine(string[] args)
        {
            if (args.Length != 1 || (args[0] != "--encrypt" && args[0]!= "--decrypt" && args[0] != "--configure"))
            {
                System.Console.WriteLine("Unclear which service you require. Options are:");
                System.Console.WriteLine("--encrypt");
                System.Console.WriteLine("--decrypt");
                System.Console.WriteLine("--configure");

                return Service.Undefined;
            }
            else if (args[0] == "--encrypt")
            {
                return Service.Encrypt;
            }
            else if (args[0] == "--decrypt")
            {
                return Service.Decrypt;
            }
            else
            {
                return Service.Configure;
            }
        
        }
    }

    public enum Service
        {
            Encrypt,
            Decrypt,
            Configure,
            Undefined
        }
}