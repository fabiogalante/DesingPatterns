using System;

namespace DecoratorPatterns
{
    public class ErrorDecorator : MessageDecorator
    {
        public ErrorDecorator(Message message) : base(message)
        {
        }

        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Message.PrintMessage();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}