using System;

namespace Enigma
{
    public class InputSideWheel : Wheel
    {
        public InputSideWheel()
        {
            Configure();
        }
        
        public override void Configure()
        {
            _rotateOn = 1;
            ConfigureInputs();
            _output = new[] {
                11,
                18,
                6,
                19,
                15,
                5,
                21,
                1,
                17,
                25,
                10,
                9,
                3,
                20,
                12,
                16,
                14,
                13,
                0,
                7,
                23,
                22,
                24,
                2,
                8,
                4
            };
        }
    } 
}