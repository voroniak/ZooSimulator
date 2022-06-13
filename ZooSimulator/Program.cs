using System;
using ZooSimulator.Animals;

namespace ZooSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo.Swim(
                new Penguin(),
                new Penguin(),
                new Makrel(),
                new Salmon()
                );
            Console.WriteLine();
            Parrot parrot = new Parrot();
            Chicken chicken = new Chicken();
            Penguin penguin = new Penguin();
            parrot.Fly();
            chicken.Fly();
            penguin.Fly();
        }
    }
}
