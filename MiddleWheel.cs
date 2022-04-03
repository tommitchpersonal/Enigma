using System;

namespace Enigma
{
    public class MiddleWheel : Wheel
    {   

        public MiddleWheel()
        {
            Configure();
        }

        public override void Configure()
        {
            _rotateOn = 25;

            ConfigureInputs();

            _output = new[] {
                11,
                22,
                21,
                20,
                10,
                9,
                13,
                19,
                23,
                16,
                17,
                5,
                4,
                3,
                0,
                24,
                2,
                18,
                15,
                12,
                6,
                7,
                8,
                25,
                1,
                14,
            };
        }
    }
}