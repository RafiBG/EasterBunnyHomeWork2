using EasterBunnyHomeWork2.Factory;
using EasterBunnyHomeWork2.Strategy;

namespace EasterBunnyHomeWork2.Singleton
{
    public class EasterBunny
    {
        private static EasterBunny _instance;
        public static EasterBunny Instance => _instance ??= new EasterBunny();

        public  void HideEgg(Egg eggs, IHideStrategy hideStrategy)
        {
            hideStrategy.Hide(eggs);
        }
    }
}
