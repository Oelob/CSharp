namespace Name
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            // Создаем массив строк

            string[] OriginalMass(int length)
            {
                string[] Mass = new string [length];
                int i = 0;
                while (i < length)
                {
                    Console.WriteLine("Введите строку массива ");
                    Mass[i] = Console.ReadLine();
                    i++;
                } 
                return Mass;
              
            }
            
            string[] GetNewMass(string[] array)
            {
                string[] Mass = new string [0];
                char temp;
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    // temp = char.Parse(array[i]);
                    if (array[i].Length < 4)
                    {
                        Mass[j] = array[i];
                    }

                }
                return Mass;
            }
            
            Console.WriteLine("Введите размер массива: ");
            string[] FirstMass = OriginalMass(int.Parse(Console.ReadLine()));
            Console.WriteLine($"[|{String.Join("| |", FirstMass)}|]");
            
        }
    }
}
