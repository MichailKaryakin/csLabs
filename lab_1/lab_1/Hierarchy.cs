using System;

namespace lab_1
{
    abstract public class Tea : ITea
    {
        public int Date { get; set; }

        protected int LeafThickness { get; } = 7;

        protected static void getClassName()
        {
            Console.WriteLine("parent class name: Tea");
        }

        protected Tea(int leafThickness)
        {
            LeafThickness = leafThickness;
        }

        protected Tea()
        {
        }

        public static void goodWishes()
        {
            Console.WriteLine("Хорошего чаепития!");
        }

        public virtual object getObject()
        {
            return this;
        }
    }

    public class Oolong : Tea
    {
        public int LeafThicknessAcceptable { get; set; } = 3;

        public int RecommendedAging { get; set; } = 10;

        public virtual bool qualityControl()
        {
            return (LeafThickness <= LeafThicknessAcceptable) & (2021 - RecommendedAging > Date);
        }

        public new static void getClassName()
        {
            Console.WriteLine("child class name: Oolong");
            Tea.getClassName();
        }

        public override object getObject()
        {
            return this;
        }

/*
        protected Oolong(int leafThickness, int date) : base(leafThickness)
        {
            this.Date = date;
        }
*/

        public static void adviceOolong()
        {
            Console.WriteLine("Для лучшего вкуса не используйте сахар");
        }
    }

    public class MilkOolong : Oolong
    {
        public new int LeafThicknessAcceptable { get; set; } = 2;

        public int MilkConcentration { get; set; } = 8;

        public new static void getClassName()
        {
            Console.WriteLine("child class name: MilkOolong");
            Oolong.getClassName();
        }

/*
        public MilkOolong(int leafThickness, int date) : base(leafThickness, date)
        {
            this.Date = date;
        }
*/

        public override bool qualityControl()
        {
            return (LeafThickness <= LeafThicknessAcceptable) &
                   (MilkConcentration > 6 & MilkConcentration < 10);
        }

        public override object getObject()
        {
            return this;
        }

        public static void adviceMilkOolong()
        {
            adviceOolong();
            Console.WriteLine("Вслушайтесь в аромат, прежде чем начнёте пить");
        }
    }

    public sealed class EnglishBreakfast : Tea
    {
        public int LeafThicknessAcceptable { get; set; } = 5;

        public int Purity { get; set; } = 94;

        public new static void getClassName()
        {
            Console.WriteLine("child class name: EnglishBreakfast");
            Tea.getClassName();
        }

/*
        public EnglishBreakfast(int leafThickness, int date) : base(leafThickness)
        {
            this.Date = date;
        }
*/

        public bool qualityControl()
        {
            return (LeafThickness <= LeafThicknessAcceptable) &
                   (Purity > 90);
        }

        public override object getObject()
        {
            return this;
        }

        public static void adviceEnglishBreakfast()
        {
            Console.WriteLine("Добавьте ровно полторы ложки сахара");
        }
    }
}
