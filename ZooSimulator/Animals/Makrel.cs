using System;
using ZooSimulator.Abstract;

namespace ZooSimulator.Animals
{
    public class Makrel : Fish, ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("fish is swimming");
        }
    }
}
