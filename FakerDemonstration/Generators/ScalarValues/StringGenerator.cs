using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerDemonstration.Generators.ScalarValues
{
    public class StringGenerator : Generator
    {
        public StringGenerator()
        {

        }

        public override object Generate(GeneratorContext context)
        {
            var size = Random.Next(1, 10);
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < size; i++)
                stringBuilder.Append((char)Random.Next());

            return stringBuilder.ToString();
        }

        public override string GetType()
        {
            return typeof(string).ToString();
        }
    }
}
