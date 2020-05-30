using System;

namespace DecoratorPatterns
{
    public class NormalDecorator : MessageDecorator
    {
        public NormalDecorator(Message message) : base(message)
        {
        }

        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Message.PrintMessage();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
