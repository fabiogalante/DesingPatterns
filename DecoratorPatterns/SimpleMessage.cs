﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatterns
{
    public class SimpleMessage : Message
    {
        public SimpleMessage(string text) : base(text) { }

        public override void PrintMessage()
        {
            Console.WriteLine(Text);
        }
    }
}
