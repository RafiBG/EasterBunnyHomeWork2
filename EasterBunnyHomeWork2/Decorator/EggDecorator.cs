using EasterBunnyHomeWork2.Factory;

namespace EasterBunnyHomeWork2.Decorator
{
    public abstract class EggDecorator : Egg
    {
        public Egg _egg;
        public string Decoration { get; set; }

        public EggDecorator(Egg egg)
        {
            _egg = egg;
        }

        public override string ToString()
        {
            return $"{Decoration} {_egg.ToString()}";
        }
    }

    public class ColoredEgg : EggDecorator
    {
        public ColoredEgg(Egg egg) : base(egg)
        {
            {
                Decoration = "оцветено";
            }
        }

        public class StickerEgg : EggDecorator
        {
            public StickerEgg(Egg egg) : base(egg)
            {
                Decoration = "облепялоно";
            }
        }
    }
}
