using ZooSimulator.Abstract;

namespace ZooSimulator
{
    public static class Zoo
    {
        public static void Swim(params ISwimable[] swimables)
        {
            foreach (var swimable in swimables)
            {
                swimable.Swim();
            }
        }
    }
}
