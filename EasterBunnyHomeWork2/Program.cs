using EasterBunnyHomeWork2.Decorator;
using EasterBunnyHomeWork2.Factory;
using EasterBunnyHomeWork2.Singleton;
using EasterBunnyHomeWork2.Strategy;
using System;
using static EasterBunnyHomeWork2.Decorator.ColoredEgg;
using static EasterBunnyHomeWork2.Strategy.BasketHiding;

namespace EasterBunnyHomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bunny = EasterBunny.Instance;
            var random = new Random();
            string[] eggTypes = { "кокоши", "щраусови", "динозавърски" };
            IHideStrategy[] hidingStrategies = { new BasketHiding(), new ForestHiding(), new BushHiding() };

            for (int i = 0; i < 8; i++)
            {
                var egg = EggFactory.CreateEgg(eggTypes[random.Next(eggTypes.Length)]);
                egg = random.Next(2) == 0 ? new ColoredEgg(egg) : new StickerEgg(egg);
                var hidingStrategy = hidingStrategies[random.Next(hidingStrategies.Length)];

                bunny.HideEgg(egg, hidingStrategy);
            }
        }
    }
}
