using System;
using ZooSimulator.Abstract;

namespace ZooSimulator.Animals
{
    public class Salmon : Fish, ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("fish is swimming");
        }
    }
}
