using System;

namespace StartbuzzCoffe
{
    class Program
    {
        static void Main(string[] args)
        {
            var expresso = new Expresso("Este café é o expresso, maravilhoso");
            Console.WriteLine(expresso.ObterDescricao());
            Console.WriteLine(expresso.Valor().ToString("C"));


        }
    }
}
