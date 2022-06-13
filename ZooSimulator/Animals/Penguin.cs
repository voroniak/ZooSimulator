using System;
using ZooSimulator.Abstract;

namespace ZooSimulator.Animals
{
    public class Penguin : Bird, ISwimable
    {
        public Penguin() : base("Penguin")
        {

        }

        public void Swim()
        {
            Console.WriteLine("penguin is swimming");
        }

        public override void Fly()
        {
            Console.WriteLine("Penguin cannot fly");
        }
    }
}
