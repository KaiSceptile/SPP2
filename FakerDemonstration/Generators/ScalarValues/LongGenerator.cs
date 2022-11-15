using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerDemonstration.Generators.ScalarValues
{
    public class LongGenerator : Generator
    {
        public LongGenerator()
        {

        }

        public override object Generate(GeneratorContext context)
        {
            long result = Random.Next(int.MinValue >> 32, int.MaxValue >> 32);

            result = (result << 32);
            result |= Random.Next(int.MinValue, int.MaxValue);

            return result;

        }

        public override string GetType()
        {
            return typeof(long).ToString();
        }
    }
}
