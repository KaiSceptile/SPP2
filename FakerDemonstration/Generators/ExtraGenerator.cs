using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerDemonstration.Generators
{
    public class ExtraGenerator : IGenerator
    {
        public object Generate(GeneratorContext context)
        {
            return 101;
        }

        public new string GetType()
        {
            return typeof(string).ToString();
        }
    }
}
