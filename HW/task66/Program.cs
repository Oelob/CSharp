namespace Name

{
    class Program
    {
        static void Main()
        {

            /*
            Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            M = 1; N = 15 -> 120
            M = 4; N = 8. -> 30
            */

            Console.Clear();



            Console.WriteLine("Введите число M ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число N ");
            int n = int.Parse(Console.ReadLine());

            int GetSum(int num1, int num2)
            {
                if (num1 > num2) return 0;
                else return num1 + GetSum(num1 + 1, num2);
            }

            Console.WriteLine(GetSum(m, n));
            Console.Clear();
            
        }
    }
}
