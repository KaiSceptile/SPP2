using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerDemonstration.Generators.ScalarValues
{
    public class SingleGenerator : Generator
    {
        public SingleGenerator()
        {

        }

        public override object Generate(GeneratorContext context)
        {
            return (Single)Random.NextDouble();
        }

        public override string GetType()
        {
            return typeof(Single).ToString();
        }
    }
}
