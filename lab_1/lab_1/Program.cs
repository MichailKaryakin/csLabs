using System;
using System.Collections.Generic;

namespace lab_1
{
    static class Program
    {
        private static void Main()
        {
            Console.WriteLine("введите номер задания");
            int user_choice = Int32.Parse(Console.ReadLine() ?? string.Empty);

            switch (user_choice)
            {
                case 1:
                    Menu1();
                    break;
                case 2:
                    Menu2();
                    break;
                case 3:
                    Menu3();
                    break;
            }
        }

        private static void advice(ITea tea)
        {
            Type type = tea.GetType();

            if (type == typeof(EarlGrey))
            {
                EarlGrey.adviceEarlGrey();
            }

            if (type == typeof(Oolong))
            {
                Oolong.adviceOolong();
            }

            if (type == typeof(MilkOolong))
            {
                MilkOolong.adviceMilkOolong();
            }

            if (type == typeof(EnglishBreakfast))
            {
                EnglishBreakfast.adviceEnglishBreakfast();
            }

            if (type != typeof(AbkhazianTea)) return;
            AbkhazianTea.adviceAbkhazianTea();
        }

        private static void Menu1()
        {
            bool exit = false;
            bool set = false;

            EarlGrey earlGrey = new EarlGrey();

            while (!exit)
            {
                Console.WriteLine(
                    "1 - задание параметров, 2 - вывод свойств, 3 - статический метод, 4 - выполнение методов, 5 - выход");
                int user_choice = Int32.Parse(Console.ReadLine() ?? string.Empty);
                if (user_choice == 1)
                {
                    Console.WriteLine("введите имя поставщика");
                    string name = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("введите страну производства");
                    string country = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("введите год производства");
                    int date = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine("введите объём");
                    int volume = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine("введите концентрацию бергамота");
                    int concentration = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine("введите толщину листа");
                    int leafThickness = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    earlGrey = new EarlGrey(name, concentration, country, date, volume, leafThickness);
                    Console.WriteLine("введите приемлемую толщину листа");
                    int leafThicknessAcceptable = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    earlGrey.LeafThicknessAcceptable = leafThicknessAcceptable;
                    set = true;
                }
                else if (user_choice == 2 & set)
                {
                    Console.WriteLine("концентрация бергамота: " + earlGrey.Concentration);
                    Console.WriteLine("страна производства: " + earlGrey.Country);
                    Console.WriteLine("год производства: " + earlGrey.Date);
                    Console.WriteLine("объём: " + earlGrey.Volume);
                    Console.WriteLine("приемлемая толщина листа: " + earlGrey.LeafThicknessAcceptable);
                }
                else if (user_choice == 3 & set)
                {
                    Console.WriteLine("выполнение статического метода:");
                    EarlGrey.fiveOСlock();
                }
                else if (user_choice == 4 & set)
                {
                    bool back = false;

                    while (!back)
                    {
                        Console.WriteLine(
                            "1 - приготовить с молоком, 2 - приготовить и выпить, 3 - перегрузка ToString," +
                            " 4 - контроль качества, 5 - совет, 6 - пожелания, 7 - разгореть чай, 8 - назад");
                        int user_choice_1 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                        switch (user_choice_1)
                        {
                            case 1:
                                Console.WriteLine("приготовить с молоком:");
                                earlGrey.brewWithMilk();
                                break;
                            case 2:
                                Console.WriteLine("приготовить и выпить:");
                                earlGrey.brewAndDrink();
                                break;
                            case 3:
                                Console.WriteLine("перегрузка ToString:");
                                Console.WriteLine(earlGrey.ToString());
                                break;
                            case 4:
                                Console.WriteLine("контроль качества:");
                                Console.WriteLine(earlGrey.qualityControl()
                                    ? "контроль пройден"
                                    : "контроль не пройден");
                                break;
                            case 5:
                                Console.WriteLine("совет эрл грей:");
                                EarlGrey.adviceEarlGrey();
                                break;
                            case 6:
                                Console.WriteLine("пожелания:");
                                Tea.goodWishes();
                                break;
                            case 7:
                                Console.WriteLine("разогреть чай:");
                                earlGrey.microwave();
                                break;
                            case 8:
                                back = true;
                                break;
                        }
                    }
                }
                else if (user_choice == 5)
                {
                    exit = true;
                }
            }
        }

        private static void Menu2()
        {
            bool exit = false;
            bool set = false;

            EarlGrey earlGrey = new EarlGrey();
            Oolong oolong = new Oolong();
            MilkOolong milkOolong = new MilkOolong();
            EnglishBreakfast englishBreakfast = new EnglishBreakfast();

            while (!exit)
            {
                Console.WriteLine(
                    "1 - задание свойств объектов, 2 - вывод свойств объекта, 3 - выполнение методов объекта," +
                    " 4 - вывод имени класса объекта, 5 - выход");
                int user_choice = Int32.Parse(Console.ReadLine() ?? string.Empty);
                if (user_choice == 1)
                {
                    bool back = false;
                    bool set1 = false, set2 = false, set3 = false, set4 = false;

                    while (!back)
                    {
                        Console.WriteLine(
                            "1 - Эрл Грей, 2 - Улун, 3 - Молочный Улун, 4 - Инглиш Брекфаст, 5 - назад");
                        int user_choice_1 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                        switch (user_choice_1)
                        {
                            case 1:
                            {
                                Console.WriteLine("введите имя поставщика");
                                string name = Console.ReadLine() ?? string.Empty;
                                Console.WriteLine("введите страну производства");
                                string country = Console.ReadLine() ?? string.Empty;
                                Console.WriteLine("введите год производства");
                                int date = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                Console.WriteLine("введите объём");
                                int volume = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                Console.WriteLine("введите концентрацию бергамота");
                                int concentration = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                Console.WriteLine("введите толщину листа");
                                int leafThickness = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                earlGrey = new EarlGrey(name, concentration, country, date, volume, leafThickness);
                                Console.WriteLine("введите приемлемую толщину листа");
                                int leafThicknessAcceptable = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                earlGrey.LeafThicknessAcceptable = leafThicknessAcceptable;
                                set1 = true;
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine("введите приемлемую толщину листа");
                                int leafThicknessAcceptable = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                oolong.LeafThicknessAcceptable = leafThicknessAcceptable;
                                Console.WriteLine("введите рекомендуемую выдержку");
                                int recommendedAging = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                oolong.RecommendedAging = recommendedAging;
                                Console.WriteLine("введите год производства");
                                int date = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                oolong.Date = date;
                                set2 = true;
                                break;
                            }
                            case 3:
                            {
                                Console.WriteLine("введите приемлемую толщину листа");
                                int leafThicknessAcceptable = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                oolong.LeafThicknessAcceptable = leafThicknessAcceptable;
                                Console.WriteLine("введите содержание молока");
                                int milkConcentration = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                milkOolong.MilkConcentration = milkConcentration;
                                Console.WriteLine("введите год производства");
                                int date = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                milkOolong.Date = date;
                                set3 = true;
                                break;
                            }
                            case 4:
                            {
                                Console.WriteLine("введите приемлемую толщину листа");
                                int leafThicknessAcceptable = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                englishBreakfast.LeafThicknessAcceptable = leafThicknessAcceptable;
                                Console.WriteLine("введите процент частоты от примесей");
                                int purity = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                englishBreakfast.Purity = purity;
                                Console.WriteLine("введите год производства");
                                int date = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                englishBreakfast.Date = date;
                                set4 = true;
                                break;
                            }
                        }

                        if (user_choice_1 != 5) continue;
                        if (!(set1 & set2 & set3 & set4)) continue;
                        set = true;
                        back = true;
                    }
                }
                else if (user_choice == 2 & set)
                {
                    bool back = false;

                    while (!back)
                    {
                        Console.WriteLine(
                            "1 - Эрл Грей, 2 - Улун, 3 - Молочный Улун, 4 - Инглиш Брекфаст, 5 - назад");
                        int user_choice_2 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                        switch (user_choice_2)
                        {
                            case 1:
                                Console.WriteLine("концентрация бергамота: " + earlGrey.Concentration);
                                Console.WriteLine("страна производства: " + earlGrey.Country);
                                Console.WriteLine("год производства: " + earlGrey.Date);
                                Console.WriteLine("объём: " + earlGrey.Volume);
                                Console.WriteLine("приемлемая толщина листа: " + earlGrey.LeafThicknessAcceptable);
                                break;
                            case 2:
                                Console.WriteLine("выдержка: " + oolong.RecommendedAging);
                                Console.WriteLine("приемлемая толщина листа: " + oolong.LeafThicknessAcceptable);
                                Console.WriteLine("год производства: " + oolong.Date);
                                break;
                            case 3:
                                Console.WriteLine("выдержка: " + milkOolong.RecommendedAging);
                                Console.WriteLine("содержание молока: " + milkOolong.MilkConcentration);
                                Console.WriteLine("приемлемая толщина листа: " + milkOolong.LeafThicknessAcceptable);
                                Console.WriteLine("год производства: " + milkOolong.Date);
                                break;
                            case 4:
                                Console.WriteLine("процент чистоты от примесей: " + englishBreakfast.Purity);
                                Console.WriteLine("приемлемая толщина листа: "
                                                  + englishBreakfast.LeafThicknessAcceptable);
                                Console.WriteLine("год производства: " + englishBreakfast.Date);
                                break;
                            case 5:
                                back = true;
                                break;
                        }
                    }
                }
                else if (user_choice == 3 & set)
                {
                    bool back = false;

                    while (!back)
                    {
                        Console.WriteLine(
                            "1 - Эрл Грей, 2 - Улун, 3 - Молочный Улун, 4 - Инглиш Брекфаст, 5 - назад");
                        int user_choice_3 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                        switch (user_choice_3)
                        {
                            case 1:
                            {
                                bool back_1 = false;

                                while (!back_1)
                                {
                                    Console.WriteLine(
                                        "1 - приготовить с молоком, 2 - приготовить и выпить," +
                                        " 3 - перегрузка ToString, 4 - контроль качества, 5 - совет," +
                                        " 6 - пожелания, 7 - разгореть чай, 8 - назад");
                                    int user_choice_3_1 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                                    switch (user_choice_3_1)
                                    {
                                        case 1:
                                            Console.WriteLine("приготовить с молоком:");
                                            earlGrey.brewWithMilk();
                                            break;
                                        case 2:
                                            Console.WriteLine("приготовить и выпить:");
                                            earlGrey.brewAndDrink();
                                            break;
                                        case 3:
                                            Console.WriteLine("перегрузка ToString:");
                                            Console.WriteLine(earlGrey.ToString());
                                            break;
                                        case 4:
                                        {
                                            Console.WriteLine("контроль качества:");
                                            Console.WriteLine(earlGrey.qualityControl()
                                                ? "контроль пройден"
                                                : "контроль не пройден");

                                            break;
                                        }
                                        case 5:
                                            Console.WriteLine("совет эрл грей:");
                                            EarlGrey.adviceEarlGrey();
                                            break;
                                        case 6:
                                            Console.WriteLine("пожелания:");
                                            Tea.goodWishes();
                                            break;
                                        case 7:
                                            Console.WriteLine("разогреть чай:");
                                            earlGrey.microwave();
                                            break;
                                        case 8:
                                            back_1 = true;
                                            break;
                                    }
                                }

                                Console.WriteLine("выполнение статического метода:");
                                EarlGrey.fiveOСlock();
                                break;
                            }
                            case 2:
                            {
                                bool back_2 = false;

                                while (!back_2)
                                {
                                    Console.WriteLine(
                                        "1 - пожелания, 2 - совет, 3 - контроль качества, 4 - назад");
                                    int user_choice_3_2 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                                    switch (user_choice_3_2)
                                    {
                                        case 1:
                                            Console.WriteLine("пожелания:");
                                            Tea.goodWishes();
                                            break;
                                        case 2:
                                            Console.WriteLine("совет:");
                                            Oolong.adviceOolong();
                                            break;
                                        case 3:
                                            Console.WriteLine("контроль качества:");
                                            Console.WriteLine(oolong.qualityControl()
                                                ? "контроль пройден"
                                                : "контроль не пройден");
                                            break;
                                        case 4:
                                            back_2 = true;
                                            break;
                                    }
                                }

                                break;
                            }
                            case 3:
                            {
                                bool back_3 = false;

                                while (!back_3)
                                {
                                    Console.WriteLine(
                                        "1 - пожелания, 2 - совет, 3 - контроль качества, 4 - назад");
                                    int user_choice_3_3 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                                    switch (user_choice_3_3)
                                    {
                                        case 1:
                                            Console.WriteLine("пожелания:");
                                            Tea.goodWishes();
                                            break;
                                        case 2:
                                            Console.WriteLine("совет:");
                                            MilkOolong.adviceMilkOolong();
                                            break;
                                        case 3:
                                        {
                                            Console.WriteLine("контроль качества:");
                                            Console.WriteLine(milkOolong.qualityControl()
                                                ? "контроль пройден"
                                                : "контроль не пройден");

                                            break;
                                        }
                                        case 4:
                                            back_3 = true;
                                            break;
                                    }
                                }

                                break;
                            }
                            case 4:
                            {
                                bool back_4 = false;

                                while (!back_4)
                                {
                                    Console.WriteLine(
                                        "1 - пожелания, 2 - совет, 3 - контроль качества, 4 - назад");
                                    int user_choice_3_4 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                                    switch (user_choice_3_4)
                                    {
                                        case 1:
                                            Console.WriteLine("пожелания:");
                                            Tea.goodWishes();
                                            break;
                                        case 2:
                                            Console.WriteLine("совет:");
                                            EnglishBreakfast.adviceEnglishBreakfast();
                                            break;
                                        case 3:
                                        {
                                            Console.WriteLine("контроль качества:");
                                            Console.WriteLine(englishBreakfast.qualityControl()
                                                ? "контроль пройден"
                                                : "контроль не пройден");

                                            break;
                                        }
                                        case 4:
                                            back_4 = true;
                                            break;
                                    }
                                }

                                break;
                            }
                            case 5:
                                back = true;
                                break;
                        }
                    }
                }
                else if (user_choice == 4 & set)
                {
                    bool back = false;

                    while (!back)
                    {
                        Console.WriteLine(
                            "1 - Эрл Грей, 2 - Улун, 3 - Молочный Улун, 4 - Инглиш Брекфаст, 5 - назад");
                        int user_choice_4 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                        switch (user_choice_4)
                        {
                            case 1:
                                EarlGrey.getClassName();
                                break;
                            case 2:
                                Oolong.getClassName();
                                break;
                            case 3:
                                MilkOolong.getClassName();
                                break;
                            case 4:
                                EnglishBreakfast.getClassName();
                                break;
                            case 5:
                                back = true;
                                break;
                        }
                    }
                }
                else if (user_choice == 5)
                {
                    exit = true;
                }
            }
        }

        private static void Menu3()
        {
            List<ITea> teas = new List<ITea>();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine(
                    "1 - добавление объекта, 2 - вывод свойств, 3 - выполнение методов," +
                    " 4 - вывод объектов, 5 - выполнение функции, 6 - выход");
                int user_choice_3 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                if (user_choice_3 == 1)
                {
                    bool back = false;

                    while (!back)
                    {
                        Console.WriteLine(
                            "1 - Эрл Грей, 2 - Улун, 3 - Молочный Улун," +
                            " 4 - Инглиш Брекфаст, 5 - Абхазский чай, 6 - назад");
                        int user_choice_2 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                        switch (user_choice_2)
                        {
                            case 1:
                            {
                                Console.WriteLine("введите имя поставщика");
                                string name = Console.ReadLine() ?? string.Empty;
                                Console.WriteLine("введите страну производства");
                                string country = Console.ReadLine() ?? string.Empty;
                                Console.WriteLine("введите год производства");
                                int date = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                Console.WriteLine("введите объём");
                                int volume = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                Console.WriteLine("введите концентрацию бергамота");
                                int concentration = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                Console.WriteLine("введите толщину листа");
                                int leafThickness = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                teas.Add(new EarlGrey(name, concentration, country, date, volume, leafThickness));
                                break;
                            }
                            case 2:
                            {
                                Oolong oolong = new Oolong();
                                Console.WriteLine("введите приемлемую толщину листа");
                                int leafThicknessAcceptable = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                oolong.LeafThicknessAcceptable = leafThicknessAcceptable;
                                Console.WriteLine("введите рекомендуемую выдержку");
                                int recommendedAging = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                oolong.RecommendedAging = recommendedAging;
                                Console.WriteLine("введите год производства");
                                int date = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                oolong.Date = date;
                                teas.Add(oolong);
                                break;
                            }
                            case 3:
                            {
                                MilkOolong milkOolong = new MilkOolong();
                                Console.WriteLine("введите приемлемую толщину листа");
                                int leafThicknessAcceptable = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                milkOolong.LeafThicknessAcceptable = leafThicknessAcceptable;
                                Console.WriteLine("введите содержание молока");
                                int milkConcentration = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                milkOolong.MilkConcentration = milkConcentration;
                                Console.WriteLine("введите год производства");
                                int date = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                milkOolong.Date = date;
                                teas.Add(milkOolong);
                                break;
                            }
                            case 4:
                            {
                                EnglishBreakfast englishBreakfast = new EnglishBreakfast();
                                Console.WriteLine("введите приемлемую толщину листа");
                                int leafThicknessAcceptable = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                englishBreakfast.LeafThicknessAcceptable = leafThicknessAcceptable;
                                Console.WriteLine("введите процент частоты от примесей");
                                int purity = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                englishBreakfast.Purity = purity;
                                Console.WriteLine("введите год производства");
                                int date = Int32.Parse(Console.ReadLine() ?? string.Empty);
                                englishBreakfast.Date = date;
                                teas.Add(englishBreakfast);
                                break;
                            }
                            case 5:
                            {
                                AbkhazianTea abkhazianTea = new AbkhazianTea();
                                Console.WriteLine("оцените вкус");
                                abkhazianTea.flavour = Console.ReadLine();
                                Console.WriteLine("введите год производства");
                                teas.Add(abkhazianTea);
                                break;
                            }
                            case 6:
                                back = true;
                                break;
                        }
                    }
                }

                if (user_choice_3 == 2 & teas.Count > 0)
                {
                    Console.WriteLine("введите номер объекта в списке");
                    int number = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Type type = teas[number].GetType();
                    if (type == typeof(EarlGrey))
                    {
                        EarlGrey earlGrey = (EarlGrey) teas[number].getObject();
                        Console.WriteLine("концентрация бергамота: " + earlGrey.Concentration);
                        Console.WriteLine("страна производства: " + earlGrey.Country);
                        Console.WriteLine("год производства: " + earlGrey.Date);
                        Console.WriteLine("объём: " + earlGrey.Volume);
                        Console.WriteLine("приемлемая толщина листа: " + earlGrey.LeafThicknessAcceptable);
                    }

                    if (type == typeof(Oolong))
                    {
                        Oolong oolong = (Oolong) teas[number].getObject();
                        Console.WriteLine("рекомендуемая выдержка: " + oolong.RecommendedAging);
                        Console.WriteLine("год производства: " + oolong.Date);
                        Console.WriteLine("приемлемая толщина листа: " + oolong.LeafThicknessAcceptable);
                    }

                    if (type == typeof(MilkOolong))
                    {
                        MilkOolong milkOolong = (MilkOolong) teas[number].getObject();
                        Console.WriteLine("рекомендуемая выдержка: " + milkOolong.RecommendedAging);
                        Console.WriteLine("год производства: " + milkOolong.Date);
                        Console.WriteLine("содержание молока: " + milkOolong.MilkConcentration);
                        Console.WriteLine("приемлемая толщина листа: " + milkOolong.LeafThicknessAcceptable);
                    }

                    if (type == typeof(EnglishBreakfast))
                    {
                        EnglishBreakfast englishBreakfast = (EnglishBreakfast) teas[number].getObject();
                        Console.WriteLine("процент чистоты от примесей: " + englishBreakfast.Purity);
                        Console.WriteLine("год производства: " + englishBreakfast.Date);
                        Console.WriteLine("приемлемая толщина листа: " + englishBreakfast.LeafThicknessAcceptable);
                    }

                    if (type == typeof(AbkhazianTea))
                    {
                        AbkhazianTea abkhazianTea = (AbkhazianTea) teas[number].getObject();
                        Console.WriteLine("описание вкуса: " + abkhazianTea.flavour);
                    }
                }

                if (user_choice_3 == 3 & teas.Count > 0)
                {
                    Console.WriteLine("введите номер объекта в списке");
                    int number = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Type type = teas[number].GetType();
                    if (type == typeof(EarlGrey))
                    {
                        EarlGrey earlGrey = (EarlGrey) teas[number].getObject();

                        bool back_1 = false;

                        while (!back_1)
                        {
                            Console.WriteLine(
                                "1 - приготовить с молоком, 2 - приготовить и выпить, 3 - перегрузка ToString," +
                                " 4 - контроль качества, 5 - совет, 6 - пожелания, 7 - разгореть чай, 8 - назад");
                            int user_choice_3_1 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                            switch (user_choice_3_1)
                            {
                                case 1:
                                    Console.WriteLine("приготовить с молоком:");
                                    earlGrey.brewWithMilk();
                                    break;
                                case 2:
                                    Console.WriteLine("приготовить и выпить:");
                                    earlGrey.brewAndDrink();
                                    break;
                                case 3:
                                    Console.WriteLine("перегрузка ToString:");
                                    Console.WriteLine(earlGrey.ToString());
                                    break;
                                case 4:
                                    Console.WriteLine("контроль качества:");
                                    Console.WriteLine(
                                        earlGrey.qualityControl() ? "контроль пройден" : "контроль не пройден");
                                    break;
                                case 5:
                                    Console.WriteLine("совет эрл грей:");
                                    EarlGrey.adviceEarlGrey();
                                    break;
                                case 6:
                                    Console.WriteLine("пожелания:");
                                    Tea.goodWishes();
                                    break;
                                case 7:
                                    Console.WriteLine("разогреть чай:");
                                    earlGrey.microwave();
                                    break;
                                case 8:
                                    back_1 = true;
                                    break;
                            }
                        }

                        Console.WriteLine("выполнение статического метода:");
                        EarlGrey.fiveOСlock();
                    }

                    if (type == typeof(Oolong))
                    {
                        Oolong oolong = (Oolong) teas[number].getObject();

                        bool back_2 = false;

                        while (!back_2)
                        {
                            Console.WriteLine(
                                "1 - пожелания, 2 - совет, 3 - контроль качества, 4 - назад");
                            int user_choice_3_2 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                            switch (user_choice_3_2)
                            {
                                case 1:
                                    Console.WriteLine("пожелания:");
                                    Tea.goodWishes();
                                    break;
                                case 2:
                                    Console.WriteLine("совет:");
                                    Oolong.adviceOolong();
                                    break;
                                case 3:
                                    Console.WriteLine("контроль качества:");
                                    Console.WriteLine(oolong.qualityControl()
                                        ? "контроль пройден"
                                        : "контроль не пройден");
                                    break;
                                case 4:
                                    back_2 = true;
                                    break;
                            }
                        }
                    }

                    if (type == typeof(MilkOolong))
                    {
                        MilkOolong milkOolong = (MilkOolong) teas[number].getObject();

                        bool back_3 = false;

                        while (!back_3)
                        {
                            Console.WriteLine(
                                "1 - пожелания, 2 - совет, 3 - контроль качества, 4 - назад");
                            int user_choice_3_3 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                            switch (user_choice_3_3)
                            {
                                case 1:
                                    Console.WriteLine("пожелания:");
                                    Tea.goodWishes();
                                    break;
                                case 2:
                                    Console.WriteLine("совет:");
                                    MilkOolong.adviceMilkOolong();
                                    break;
                                case 3:
                                    Console.WriteLine("контроль качества:");
                                    Console.WriteLine(milkOolong.qualityControl()
                                        ? "контроль пройден"
                                        : "контроль не пройден");
                                    break;
                                case 4:
                                    back_3 = true;
                                    break;
                            }
                        }
                    }

                    if (type == typeof(EnglishBreakfast))
                    {
                        EnglishBreakfast englishBreakfast = (EnglishBreakfast) teas[number].getObject();

                        bool back_4 = false;

                        while (!back_4)
                        {
                            Console.WriteLine(
                                "1 - пожелания, 2 - совет, 3 - контроль качества, 4 - назад");
                            int user_choice_3_4 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                            switch (user_choice_3_4)
                            {
                                case 1:
                                    Console.WriteLine("пожелания:");
                                    Tea.goodWishes();
                                    break;
                                case 2:
                                    Console.WriteLine("совет:");
                                    EnglishBreakfast.adviceEnglishBreakfast();
                                    break;
                                case 3:
                                {
                                    Console.WriteLine("контроль качества:");
                                    Console.WriteLine(englishBreakfast.qualityControl()
                                        ? "контроль пройден"
                                        : "контроль не пройден");

                                    break;
                                }
                                case 4:
                                    back_4 = true;
                                    break;
                            }
                        }
                    }

                    if (type == typeof(AbkhazianTea))
                    {
                        bool back_5 = false;

                        while (!back_5)
                        {
                            Console.WriteLine(
                                "1 - пожелания, 2 - совет, 3 - контроль качества, 4 - назад");
                            int user_choice_3_4 = Int32.Parse(Console.ReadLine() ?? string.Empty);

                            switch (user_choice_3_4)
                            {
                                case 1:
                                    Console.WriteLine("пожелания:");
                                    AbkhazianTea.goodWishes();
                                    break;
                                case 2:
                                    Console.WriteLine("совет:");
                                    AbkhazianTea.adviceAbkhazianTea();
                                    break;
                                case 3:
                                    Console.WriteLine("контроль качества:");
                                    Console.WriteLine(AbkhazianTea.qualityControl()
                                        ? "контроль пройден"
                                        : "контроль не пройден");
                                    break;
                                case 4:
                                    back_5 = true;
                                    break;
                            }
                        }
                    }
                }

                if (user_choice_3 == 4 & teas.Count > 0)
                {
                    int i = 0;
                    foreach (var x in teas)
                    {
                        string className = "none";

                        Type type = x.GetType();

                        if (type == typeof(EarlGrey))
                        {
                            className = "EarlGrey";
                        }

                        if (type == typeof(Oolong))
                        {
                            className = "Oolong";
                        }

                        if (type == typeof(MilkOolong))
                        {
                            className = "MilkOolong";
                        }

                        if (type == typeof(EnglishBreakfast))
                        {
                            className = "EnglishBreakfast";
                        }

                        if (type == typeof(AbkhazianTea))
                        {
                            className = "AbkhazianTea";
                        }

                        Console.WriteLine("объект номер " + i);
                        Console.WriteLine("название класса: " + className);
                        i++;
                    }
                }

                if (user_choice_3 == 5 & teas.Count > 0)
                {
                    Console.WriteLine("введите номер объекта в списке");
                    int number = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    advice(teas[number]);
                }

                if (user_choice_3 == 6)
                {
                    exit = true;
                }
            }
        }
    }
}
