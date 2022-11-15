using System;

namespace FakerDemonstration
{
    public class CycleDependencyException : Exception
    {
        public CycleDependencyException(string message) : base(message)
        {

        }

    }
}