namespace Trenirovka
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число 1");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выберите действие: \n1.Сложение(+) \n2.Вычитание(-) \n3.Умножение(*) \n4.Деление(/)");
                int number = Convert.ToInt32(Console.ReadLine());





                switch (number)
                {
                    case 1:
                        Console.WriteLine(x + y);
                        break;
                    case 2:
                        Console.WriteLine(x - y);
                        break;
                    case 3:
                        Console.WriteLine(x * y);
                        break;
                    case 4:
                        if (y == 0)
                        {
                            Console.WriteLine("Ошибка!");
                        }
                        else
                        {
                            Console.WriteLine(x / y);
                        }
                        break;
                    default:
                        Console.WriteLine("Такого действия нет.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}