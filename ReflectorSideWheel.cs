using System;

namespace Enigma
{
    public class ReflectorSideWheel : Wheel
    {
        public ReflectorSideWheel()
        {
            Configure();
        }
        public override void Configure()
        {
            _rotateOn = 25*25;

            for (int i = 0; i < _length; i ++)
            {
                _input[i] = i;
            }

            _output[0] = 20;
            _output[1] = 17;
            _output[2] = 0;
            _output[3] = 5;
            _output[4] = 22;
            _output[5] = 13;
            _output[6] = 1;
            _output[7] = 15;
            _output[8] = 7;
            _output[9] = 2;
            _output[10] = 25;
            _output[11] = 18;
            _output[12] = 8;
            _output[13] = 19;
            _output[14] = 3;
            _output[15] = 21;
            _output[16] = 23;
            _output[17] = 16;
            _output[18] = 4;
            _output[19] = 24;
            _output[20] = 6;
            _output[21] = 9;
            _output[22] = 12;
            _output[23] = 10;
            _output[24] = 14;
            _output[25] = 11;
        }
    } 
}