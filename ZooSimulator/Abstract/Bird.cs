using System;

namespace ZooSimulator.Abstract
{
    public class Bird : Animal
    {
        private string name;
        public Bird(string name)
        {
            this.name = name;
        }
        public virtual void Fly()
        {
            Console.WriteLine($"{GetType().Name} is flying");
        }
    }
}
