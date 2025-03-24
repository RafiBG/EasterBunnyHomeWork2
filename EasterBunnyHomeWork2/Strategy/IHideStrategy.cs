using EasterBunnyHomeWork2.Factory;
using System;

namespace EasterBunnyHomeWork2.Strategy
{
    public interface IHideStrategy
    {
        void Hide(Egg egg);
    }

    public class BasketHiding : IHideStrategy
    {
        public void Hide(Egg egg)
        {
            Console.WriteLine($"Заека скрил {egg} яйце в кошницата.");
        }

        public class ForestHiding : IHideStrategy
        {
            public void Hide(Egg egg)
            {
                Console.WriteLine($"Заека скрил {egg} яйце в гората.");
            }
        }
        public class BushHiding : IHideStrategy
        {
            public void Hide(Egg egg)
            {
                Console.WriteLine($"Заека скрил {egg} яйце под храст.");
            }
        }
    }
}
