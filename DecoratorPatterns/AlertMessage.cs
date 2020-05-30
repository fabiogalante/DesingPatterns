using System;

namespace DecoratorPatterns
{
    public class AlertMessage : Message
    {
        public AlertMessage(string text) : base(text) { }

        public override void PrintMessage()
        {
            Console.Beep();
            Console.WriteLine(Text);
        }
    }
}