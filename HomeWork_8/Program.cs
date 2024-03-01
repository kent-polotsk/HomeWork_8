using System.Text;
using HomeWork_8;

using Plane = HomeWork_8.Plane;

public static class IntExtension
{
    public static int MaxValueOfArray(this int[] array)
    {
        return array.Max();
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        ConsoleKeyInfo key;
        string? input;

        do
        {
            do//---------------------------1------------------------------
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Задание 1: private переменная класса");
                Console.ResetColor();

                Item item = new Item();
                Console.WriteLine("Выводим значение после срабатывания конструктора по умолчанию: " + item.GetName());
                Console.Write("Введите присваиваемое значение: ");
                input = Console.ReadLine();
                item.SetName(input);
                Console.WriteLine("Присваиваем значение " + input + "  Результат: " + item.GetName());
                Console.Write("Введите присваиваемое значение: ");
                input = Console.ReadLine();
                item.SetName(input);
                Console.WriteLine("Присваиваем значение " + input + "  Результат: " + item.GetName());

                Console.WriteLine("Для продолжения нажмите любую кнопку, для повтора задания нажмите y, для выхода из программы нажмите Esc");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Escape) Environment.Exit(0);
                Console.Clear();
            } while (key.Key == ConsoleKey.Y);


            do//---------------------------2------------------------------
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Задание 2: транспорт");
                Console.ResetColor();
                Car car1 = new Car();
                Car car2 = new Car(8);
                Car car3 = new Car("Грузовой", 6, "дизель");

                car1.Move();
                Console.WriteLine();
                car2.Move();
                Console.WriteLine();
                car1.Move();
                Console.WriteLine();
                car3.Move();
                Console.WriteLine();
                car1.Move();
                Console.WriteLine();
                car1.Stop();
                Console.WriteLine();
                car2.Stop();
                Console.WriteLine();
                car2.Stop();
                Console.WriteLine();
                car3.Stop();

                Plane plane1 = new Plane();
                Plane plane2 = new Plane("Грузовой", 8, "авиатопливо");
                Plane plane3 = new Plane(12);
                plane1.Stop();
                Console.WriteLine();
                plane1.Move();
                Console.WriteLine();
                plane2.Move();
                Console.WriteLine();
                plane2.Move();
                Console.WriteLine();
                plane3.Move();
                Console.WriteLine();
                plane1.Stop();
                Console.WriteLine();
                plane1.Stop();
                Console.WriteLine();
                plane3.Stop();
                Console.WriteLine();
                plane2.Stop();

                Console.WriteLine("Для продолжения нажмите любую кнопку, для повтора задания нажмите y, для выхода из программы нажмите Esc");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Escape) Environment.Exit(0);
                Console.Clear();
            } while (key.Key == ConsoleKey.Y);


            do//---------------------------3------------------------------
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Задание 3: метод расширение класса int");
                Console.ResetColor();
                Console.WriteLine("Массив:");

                int[] array1 = new int[30];
                Random rand = new Random();
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rand.Next(-1000, 1000);
                    Console.Write(array1[i] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine($"Максимальное значение из массива: {array1.ArrMaxValue()}");
                Console.WriteLine("Для продолжения нажмите любую кнопку, для повтора задания нажмите y, для выхода из программы нажмите Esc");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Escape) Environment.Exit(0);
                Console.Clear();
            } while (key.Key == ConsoleKey.Y);


            //---------------------------4------------------------------

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Задание 4: класс Bag");
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string guide = "\bUser Guide\n1 - Open Bag\t3 - Add random item\t5 - Extract item\n2 - Close Bag\t4 - Add item manually\t6 - Print bag content\n7 - Show Guide\tESC - Stop";
            Console.WriteLine(guide);
            Console.ResetColor();
            Random random = new Random();
            Bag _bag = new Bag();
            do
            {
                key = Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(" ");
                Console.SetCursorPosition(0, Console.CursorTop);
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        {
                            break;
                        }
                    case ConsoleKey.D1:
                        {
                            _bag.OpenBag();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            _bag.CloseBag();
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            _bag.AddItem(new Item("Item" + random.Next(100)));
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            _bag.AddItem();
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            Item outItem = _bag.ExtractItem();
                            if (outItem != null)
                                Console.WriteLine($"Item : " + outItem.GetName() + " has been extracted");
                            break;
                        }
                    case ConsoleKey.D6:
                        {
                            _bag.Print();
                            break;
                        }
                    case ConsoleKey.D7:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(guide);
                            Console.ResetColor();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            } while (key.Key != ConsoleKey.Escape);
            Console.Write("1");
            Console.Write("Для перезапуска программы нажмите любую кнопку, для выхода из программы нажмите Esc :");
            key = Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
        } while (key.Key != ConsoleKey.Escape);
    }
}