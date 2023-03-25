using System;

namespace Prakticheskaya_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IHello> myHello = new List<IHello>();

            myHello.Add(new Russian());
            myHello.Add(new English());
            myHello.Add(new Spanish());

            foreach (IHello hello in myHello)
            {
                hello.SayHello();
            }

            Console.ReadKey(true);
        }
    }
    interface IHello
    {
        void SayHello();
    }

    class Russian : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Spanish : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hola");
        }
    }
}