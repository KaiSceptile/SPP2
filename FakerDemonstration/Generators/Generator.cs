using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerDemonstration.Generators
{
    public abstract class Generator : IGenerator
    {
        protected int ConstSize = 10;

        protected readonly Random Random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

        protected Generator()
        {

        }
        public abstract object Generate(GeneratorContext context);
        public new abstract string GetType();
    }
}
