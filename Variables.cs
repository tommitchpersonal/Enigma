using System;

namespace Enigma
{
    public static class Variables
    {
        public static string[] ConvertStringToStringArray(string inputString)
        {
            return inputString.ToCharArray().Select(c => c.ToString()).ToArray();
        }

        public static string ConvertStringArrayToString(string[] inputStringArray)
        {
            string outPutString = "";
            for (int i = 0; i < inputStringArray.Length; i++)
            {
                outPutString += inputStringArray[i];
            }

            return outPutString;
        }
    }
}