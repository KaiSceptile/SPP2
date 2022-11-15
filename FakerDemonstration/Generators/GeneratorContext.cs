using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerDemonstration.Generators
{
    public class GeneratorContext
    {
        public Faker Faker { get; }
        public Type Type { get; }

        public GeneratorContext(Faker faker, Type type)
        {
            Faker = faker;
            Type = type;
        }
    }
}
