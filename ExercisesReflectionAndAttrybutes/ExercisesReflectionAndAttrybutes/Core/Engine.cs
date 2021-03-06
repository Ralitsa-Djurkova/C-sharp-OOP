﻿using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpretator;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpretator = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                string inputData = Console.ReadLine();
                string result = this.commandInterpretator.Read(inputData);
                Console.WriteLine(result);
            }
        }
    }
}
