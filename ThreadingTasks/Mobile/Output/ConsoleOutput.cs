﻿using System;

namespace Mobile.Output
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
