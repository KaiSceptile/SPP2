using System;
using FakerDemonstration.Generators;

namespace CharGenerator
{
    public class CharGenerator : Generator
    {
        public CharGenerator()
        {

        }

        public override object Generate(GeneratorContext context)
        {
            return Convert.ToChar(Random.Next(char.MinValue, char.MaxValue));

        }

        public override string GetType()
        {
            return typeof(char).ToString();
        }
    }
}