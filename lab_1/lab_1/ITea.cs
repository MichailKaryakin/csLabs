using System;

namespace lab_1
{
    public interface ITea
    {
        object getObject();
    }

    class AbkhazianTea : ITea
    {
        public string flavour { get; set; } = "мерзость";

        public object getObject()
        {
            return this;
        }

        public static bool qualityControl()
        {
            return false;
        }

        public static void goodWishes()
        {
            Console.WriteLine("Не пейте это!");
        }

        public static void adviceAbkhazianTea()
        {
            Console.WriteLine("Никогда не пейте это!");
        }
    }
}
