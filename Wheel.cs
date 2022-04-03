using System;

namespace Enigma
{
    public abstract class Wheel
    {
        protected static int _length = 26;
        protected int[] _input = new int[_length];
        protected int[] _output = new int[_length];
        protected int _rotateOn;
        protected int _count = 0;

        public abstract void Configure();
        
        public int MapOutward(int input)
        {
            for (int i = 0; i < _length; i++)
            {
                if (_input[i] == input)
                {
                    int outputIndex = _output[i];
                    return outputIndex;
                }
            }

            return 0;
        }

        public int MapReturn(int input)
        {
            for (int i = 0; i < _length; i++)
            {
                if (_output[i] == input)
                {
                    int outputIndex = _input[i];

                    _count++;

                    if (_count >= _rotateOn)
                    {
                        Rotate();
                        _count = 0;
                    }

                    return outputIndex;
                }
            }

            return 0;
        }

        public void Rotate()
        {
            int[] newOutput = new int[_length];

            for (int i = 0; i < _length - 1; i++)
            {
                newOutput[i + 1] = _output[i];
            }
            newOutput[0] = _output[_length - 1];
            _output = newOutput;
        }

        public void ConfigureInputs()
        {
            int count = 0;
            
            foreach (int position in _input)
            {
                _input[count] = count;
                count++;
            }
        }
    }
}

