using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CommandLine
{
    internal class Program
    {
        /// <summary>
        /// This example uses the Microsoft.Extensions.Configuration.CommandLine package to retrieve
        /// the command line arguments.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // setup more meaningful names for the parameters
            // using a mapping structure.
            var mappings = new Dictionary<string, string>
            {
                {"-f", "first"},
                {"-s", "second"},
                {"-t", "third"}
            };

            // get command line arguments and build configuration
            var builder = new ConfigurationBuilder().AddCommandLine(args, mappings);
            var config = builder.Build();

            // access the configuration using the meaningful names...
            string first = config["first"];
            string second = config["second"];
            string third = config["third"];

            Console.WriteLine($"First = {first}");
            Console.WriteLine($"Second = {second}");
            Console.WriteLine($"Third = {third}");
        }
    }
}
