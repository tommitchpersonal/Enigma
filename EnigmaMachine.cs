using System;

namespace Enigma
{
    public class EnigmaMachine
    {
        private InputSideWheel _inputSideWheel;
        private MiddleWheel _middleWheel;
        private ReflectorSideWheel _reflectorSideWheel;
        
        private static string[] _alphabet = new[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        
        public EnigmaMachine()
        {
            _inputSideWheel = new InputSideWheel();
            _middleWheel = new MiddleWheel();
            _reflectorSideWheel = new ReflectorSideWheel();
        }
        
        public string EncryptString(string plainText)
        {
            string[] plainTextArray = Variables.ConvertStringToStringArray(plainText);
            int plainTextLength = plainTextArray.Length;
            string[] cipherTextArray = new string[plainTextLength];

            int counter = 0;
            
            foreach (string letter in plainTextArray)
            {
                if (letter == " ")
                {
                    cipherTextArray[counter] = letter;
                }
                else
                {
                    cipherTextArray[counter] = EncryptSingleCharacter(letter);
                }

                counter ++;
            }

            string cipherText = Variables.ConvertStringArrayToString(cipherTextArray);
            return cipherText;
        }

        public int MapTextToInteger(string character)
        {
            string lowerCaseChar = character.ToLower();
            for (int i = 0; i < _alphabet.Length; i++)
            {
                if (lowerCaseChar == _alphabet[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public string MapIntegerToText(int characterAsInteger)
        {
            return _alphabet[characterAsInteger];
        }

        public string EncryptSingleCharacter(string character)
        {
            int characterAsInteger0 = MapTextToInteger(character);
            int characterAsInteger1 = _inputSideWheel.MapOutward(characterAsInteger0);
            int characterAsInteger2 = _middleWheel.MapOutward(characterAsInteger1);
            int characterAsInteger3 = _reflectorSideWheel.MapOutward(characterAsInteger2);
            int characterAsInteger4 = Reflector.Reflect(characterAsInteger3);
            int characterAsInteger5 = _reflectorSideWheel.MapReturn(characterAsInteger4);
            int characterAsInteger6 = _middleWheel.MapReturn(characterAsInteger5);
            int characterAsInteger7 = _inputSideWheel.MapReturn(characterAsInteger6); 
            return MapIntegerToText(characterAsInteger7);
        }
    }
}