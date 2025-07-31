using System;
using System.Collections.Generic;
using System.IO;

namespace lab_2
{
    static class Program
    {
        private static readonly List<Enrolee> Enrolees = new List<Enrolee>();

        private static string path;

        private static void SetFile()
        {
            Console.WriteLine("Введите имя файла:");
            var filename = Console.ReadLine();
            path = @"C:\Users\micha\Documents\programming\code\cs\labs\lab_2\lab_2\" + filename + ".txt";

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            using var file = new StreamReader(path, System.Text.Encoding.Default);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                String[] words = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Enrolee enrolee = new Enrolee
                {
                    name = words[0],
                    english = Convert.ToInt32(words[1]),
                    russian = Convert.ToInt32(words[2]),
                    math = Convert.ToInt32(words[3])
                };
                Enrolees.Add(enrolee);
            }
        }

        private static void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(
                    "1 - отображение содержимого, 2 - добавление нового элемента, 3 - удаление элемента, " +
                    "4 - корректировка элемента, 5 - сортировка, 6 - доп. пункты, 7 - выход");
                int user_choice = Int32.Parse(Console.ReadLine() ?? string.Empty);

                if (user_choice == 1)
                {
                    Console.WriteLine("{0, 10} |{1, 15} |{2, 15} |{3, 15}", "Фамилия", "Английский", "Русский",
                        "Математика");
                    for (int i = 0; i < Enrolees.Count; i++)
                    {
                        Console.WriteLine("{0, 10} |{1, 15} |{2, 15} |{3, 15}",
                            Enrolees[i].name, Enrolees[i].english, Enrolees[i].russian, Enrolees[i].math);
                    }
                }
                else if (user_choice == 2)
                {
                    Enrolee enrolee = new Enrolee();
                    Console.WriteLine("введите фамилию");
                    enrolee.name = Console.ReadLine();
                    Console.WriteLine("введите балл по английскому языку");
                    enrolee.english = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine("введите балл по русскому языку");
                    enrolee.russian = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine("введите балл по математике");
                    enrolee.math = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine("1 - в начало, 2 - по индексу");
                    int user_choice_1 = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    if (user_choice_1 == 1)
                    {
                        Enrolees.Insert(0, enrolee);
                    }
                    else if (user_choice_1 == 2)
                    {
                        Console.WriteLine("введите позицию");
                        int position = Int32.Parse(Console.ReadLine() ?? string.Empty);
                        while (position > Enrolees.Count + 1 || position <= 0)
                        {
                            Console.WriteLine("введите позицию");
                            position = Int32.Parse(Console.ReadLine() ?? string.Empty);
                        }

                        Enrolees.Insert(position - 1, enrolee);
                    }
                }
                else if (user_choice == 3)
                {
                    Console.WriteLine("введите позицию");
                    int position = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    while (position > Enrolees.Count || position <= 0)
                    {
                        Console.WriteLine("введите позицию");
                        position = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    }

                    Enrolee temp = Enrolees[position - 1];
                    Enrolees.Remove(temp);
                }
                else if (user_choice == 4)
                {
                    Console.WriteLine("введите позицию");
                    int position = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    while (position > Enrolees.Count || position <= 0)
                    {
                        Console.WriteLine("введите позицию");
                        position = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    }

                    Enrolee temp = Enrolees[position - 1];
                    Enrolees.Remove(temp);

                    Enrolee enrolee = new Enrolee();
                    Console.WriteLine("введите фамилию");
                    enrolee.name = Console.ReadLine();
                    Console.WriteLine("введите балл по английскому языку");
                    enrolee.english = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine("введите балл по русскому языку");
                    enrolee.russian = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine("введите балл по математике");
                    enrolee.math = Int32.Parse(Console.ReadLine() ?? string.Empty);

                    Enrolees.Insert(position - 1, enrolee);
                }
                else if (user_choice == 5)
                {
                    Enrolees.Sort();
                }
                else if (user_choice == 6)
                {
                    int passSum = 0;
                    int passEng = 0;
                    int passRus = 0;
                    int passMat = 0;

                    bool set = false;
                    bool back = false;
                    while (!back)
                    {
                        Console.WriteLine(
                            "1 - задать проходную сумму и минимальный балл, " +
                            "2 - абитуриенты с наибольшей суммой баллов, 3 - не прошедшие абитуриенты, 4 - назад");
                        int user_choice_2 = Int32.Parse(Console.ReadLine() ?? string.Empty);
                        if (user_choice_2 == 1)
                        {
                            Console.WriteLine("введите проходную сумму баллов");
                            passSum = Int32.Parse(Console.ReadLine() ?? string.Empty);
                            Console.WriteLine("введите минимальный балл по английскому");
                            passEng = Int32.Parse(Console.ReadLine() ?? string.Empty);
                            Console.WriteLine("введите минимальный балл по русскому");
                            passRus = Int32.Parse(Console.ReadLine() ?? string.Empty);
                            Console.WriteLine("введите минимальный балл по математике");
                            passMat = Int32.Parse(Console.ReadLine() ?? string.Empty);
                            set = true;
                        }
                        else if (user_choice_2 == 2 && set)
                        {
                            List<int> bestEnrolees = new List<int>();
                            int maxScore = 0;
                            for (int i = 0; i < Enrolees.Count; i++)
                            {
                                int sum = Enrolees[i].english + Enrolees[i].math + Enrolees[i].russian;
                                if (sum > maxScore)
                                {
                                    maxScore = sum;
                                    bestEnrolees.Clear();
                                    bestEnrolees.Add(i);
                                }
                                else if (sum == maxScore)
                                {
                                    bestEnrolees.Add(i);
                                }
                            }

                            Console.WriteLine("{0, 10} |{1, 15} |{2, 15} |{3, 15}", "Фамилия", "Английский", "Русский",
                                "Математика");
                            for (int i = 0; i < Enrolees.Count; i++)
                            {
                                bool output = false;
                                foreach (var t in bestEnrolees)
                                {
                                    if (i == t)
                                    {
                                        output = true;
                                    }
                                }

                                if (output)
                                {
                                    Console.WriteLine("{0, 10} |{1, 15} |{2, 15} |{3, 15}",
                                        Enrolees[i].name, Enrolees[i].english, Enrolees[i].russian, Enrolees[i].math);
                                }
                            }
                        }
                        else if (user_choice_2 == 3 && set)
                        {
                            Console.WriteLine("{0, 10} |{1, 15} |{2, 15} |{3, 15}", "Фамилия", "Английский", "Русский",
                                "Математика");
                            for (int i = 0; i < Enrolees.Count; i++)
                            {
                                int sum = Enrolees[i].english + Enrolees[i].math + Enrolees[i].russian;
                                bool output = (sum < passSum || Enrolees[i].english < passEng ||
                                               Enrolees[i].russian < passRus || Enrolees[i].math < passMat);

                                if (output)
                                {
                                    Console.WriteLine("{0, 10} |{1, 15} |{2, 15} |{3, 15}",
                                        Enrolees[i].name, Enrolees[i].english, Enrolees[i].russian, Enrolees[i].math);
                                }
                            }
                        }
                        else if (user_choice_2 == 4 && set)
                        {
                            back = true;
                        }
                    }
                }
                else if (user_choice == 7)
                {
                    exit = true;
                }
            }
        }

        private static void GetFile()
        {
            FileStream fs = File.Open(path, FileMode.Open, FileAccess.ReadWrite);
            fs.SetLength(0);
            fs.Close();

            StreamWriter file = new StreamWriter(path);

            for (int i = 0; i < Enrolees.Count; i++)
            {
                file.WriteLine(Enrolees[i].name + ' ' + Enrolees[i].english + ' ' + Enrolees[i].russian + ' ' +
                               Enrolees[i].math);
            }

            file.Close();
        }

        private static void Main()
        {
            SetFile();
            Menu();
            GetFile();
        }
    }
}
