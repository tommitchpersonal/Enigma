using System;

namespace Enigma
{
    public static class Reflector
    {
        private const int _alphabetSize = 25; // 26-1, starts with 0

        public static int Reflect(int input)
        {
            return _alphabetSize - input;
        }
    }
}