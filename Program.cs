using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Trenirovka
{
    class Calculator
    {
        public double Fold(double x, double y)
        {
            return x + y;
        }

        public double Subtraction(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            if (x == 0)
            {
                Console.WriteLine("Ошибка!Делениие на ноль.");
                return double.NaN;
            }
            return x / y;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();

                Console.WriteLine("Введите первое число:....");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число:....");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выберите операцию (+, -, *, /) ");
                string operation = Console.ReadLine();

                double result;

                switch (operation)
                {
                    case "+":
                        result = calculator.Fold(num1, num2);
                        break;
                    case "-":
                        result = calculator.Subtraction(num1, num2);
                        break;
                    case "*":
                        result = calculator.Multiply(num1, num2);
                        break;
                    case "/":
                        result = calculator.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Такой операции нет.");
                        return;
                }
                Console.WriteLine("Результат действия: " + result);
            }
        }
    }
}







