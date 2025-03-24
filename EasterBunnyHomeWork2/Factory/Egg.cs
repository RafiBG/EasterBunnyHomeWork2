namespace EasterBunnyHomeWork2.Factory
{
    public abstract class Egg
    {
        public string EggType { get; set; }
        public override string ToString()
        {
            return EggType = $"{EggType}";
        }
    }

    public class ChickenEgg : Egg 
    {
        public ChickenEgg() 
        {
            EggType = "кокоши";
        }
    }
    public class OstrichEgg : Egg
    {
        public OstrichEgg()
        {
            EggType = "щраусово";
        }
    }
    public class DinoSaurEgg : Egg
    {
        public DinoSaurEgg()
        {
            EggType = "динозавърско";
        }
    }

    public static class EggFactory
    {
        public static Egg CreateEgg(string type)
        {
            return type switch
            {
                "кокоши" => new ChickenEgg(),
                "щраусови" => new OstrichEgg(),
                "динозавърски" => new DinoSaurEgg(),
            };
        }
    }
}
