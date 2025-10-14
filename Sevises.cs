using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programflyt
{
    public class Sevises : Program
    {
        public int InputNumber { get; set; }

        public Sevises(int inputNumber)
        {
            InputNumber = Math.Clamp(inputNumber, 0, 10);
        }
    }
}
