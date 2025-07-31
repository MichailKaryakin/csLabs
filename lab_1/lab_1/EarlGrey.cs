using System;

namespace lab_1
{
    public sealed class EarlGrey : Tea
    {
        private bool milk;
        private bool microwaved;
        private readonly string name;
        static private int delay;

        public int LeafThicknessAcceptable { get; set; } = 7;

        public new static void getClassName()
        {
            Console.WriteLine("child class name: EarlGrey");
            Tea.getClassName();
        }

        public bool qualityControl()
        {
            return LeafThickness <= LeafThicknessAcceptable;
        }

        public string Country { get; }

        public int Concentration { get; }

        public int Volume { get; }

        public void brewAndDrink()
        {
            if (microwaved)
            {
                microwaved = false;
                Console.WriteLine("Вы выпили разогретый чай, фу...");
                return;
            }

            if (!milk)
            {
                Console.WriteLine("Эрл грей заварен и выпит");
                return;
            }

            milk = false;
            Console.WriteLine("Эрл грей c молоком уже был заварен, теперь он выпит");
        }

        public void brewWithMilk()
        {
            milk = true;
            Console.WriteLine("Эрл грей с молоком заварен, выпейте");
        }

        public void microwave()
        {
            microwaved = true;
            Console.WriteLine("Кто греет чай в микроволновке? Ну ладно...");
        }

        public override string ToString()
        {
            return string.Format(
                "Привет, {4}! Страна: {0}, концентрация бергамота: {1}, дата изготовления: {2}, объём: {3}",
                Country, Concentration, Date, Volume, name);
        }

        public static void adviceEarlGrey()
        {
            Console.WriteLine("Добавьте лимон");
        }

        public EarlGrey()
        {
        }

/*
        public EarlGrey(string name, int leafThickness) : base(leafThickness)
        {
            this.name = name;
            delay += 1;
        }
*/

/*
        public EarlGrey(string name, int concentration, string country, int leafThickness) : base(leafThickness)
        {
            delay += 1;
            this.name = name;
            Concentration = concentration;
            Country = country;
        }
*/

        public EarlGrey(string name, int concentration, string country, int date, int volume, int leafThickness)
            : base(leafThickness)
        {
            delay += 1;
            this.name = name;
            Concentration = concentration;
            Country = country;
            Date = date;
            Volume = volume;
        }

        public override object getObject()
        {
            return this;
        }

        public static void fiveOСlock()
        {
            if (delay != 2)
            {
                Console.WriteLine("Не время для five o'clock");
                return;
            }

            delay = 0;
            Console.WriteLine("five o'clock");
        }
    }
}
