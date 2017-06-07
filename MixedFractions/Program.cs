using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> outputs = new List<string>();

            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int numerator = int.Parse(inputs[0]);
                int denominator = int.Parse(inputs[1]);

                if (numerator == 0 && denominator == 0)
                {
                    break;
                }               

                outputs.Add($"{numerator/denominator} {numerator % denominator} / {denominator}");
            }

            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }
        }
    }
}
