using System;
using System.Collections;
using System.Collections.Generic;
using FakerDemonstration.Generators;
using FakerDemonstration.DTO;

namespace FakerDemonstration
{
    internal static class MainApp
    {
        private static void Main(string[] args)
        {

            Faker faker = new Faker();

            var foo = faker.Create<Foo>();

        }

    }
}
