using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerDemonstration.Generators.ScalarValues
{
    public class IntGenerator : Generator
    {
        public IntGenerator()
        {

        }

        public override object Generate(GeneratorContext context)
        {
            return Random.Next(int.MinValue, int.MaxValue);
        }

        public override string GetType()
        {
            return typeof(int).ToString();
        }
    }
}
