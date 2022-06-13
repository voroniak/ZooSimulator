using System;
using ZooSimulator.Abstract;

namespace ZooSimulator.Animals
{
    public class Chicken : Bird
    {
        public Chicken() : base("Chicken")
        {

        }

        
        public override void Fly()
        {
            base.Fly();

            Console.WriteLine("but not far");
        }
    }
}
