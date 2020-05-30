namespace DecoratorPatterns
{
    public abstract class MessageDecorator : IMessage
    {
        protected readonly Message Message;

        protected MessageDecorator(Message message)
        {
            Message = message;
        }

        public abstract void PrintMessage();
    }
}

