namespace DecoratorPatterns
{
    //Structural Pattern

    public abstract class Message : IMessage
    {
        protected readonly string Text; //Um membro protegido é acessível dentro de sua classe e por instâncias da classe derivada.

        protected Message(string text)
        {
            Text = text;
        }

        abstract public void PrintMessage();
    }
}

