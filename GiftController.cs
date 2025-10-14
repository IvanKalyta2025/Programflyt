using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Programflyt
{
    public class GiftController
    {
        public class GiftClass
        {
            public static void Gift()
            {
                int inputNumber = Program.inputNumber;
                Sevises servis = new Sevises(inputNumber);
                if (servis.InputNumber <= 0)
                {
                    Console.WriteLine("Things are so bad... then we're firing you.");
                }
                else if (servis.InputNumber <= 5)
                {
                    Console.WriteLine("Here's your pie, go eat it.");
                }
                else if (servis.InputNumber <= 10)
                {
                    Console.WriteLine("You got extra work.");
                }
            }

        }
    }
}
