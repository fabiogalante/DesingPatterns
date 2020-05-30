using System;
using System.Collections.Generic;

namespace DecoratorPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new List<IMessage>
            {
                new NormalDecorator(new SimpleMessage("First Message")),
                new NormalDecorator(new AlertMessage("Seccond Message with a beep!")),
                new ErrorDecorator(new AlertMessage("")) //Alert e Simple
            };
        }
    }
}
