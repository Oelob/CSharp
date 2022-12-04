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
                string[] Mass = Array.Empty<string>();
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    
                    if (array[i].Length < 4)
                    {
                        Array.Resize(ref Mass, Mass.Length +1);
                        Mass[j] = array[i];
                        j++;
                    }

                }
                return Mass;
            }
            
            Console.WriteLine("Введите размер массива: ");
            string[] FirstMass = OriginalMass(int.Parse(Console.ReadLine()));
            Console.WriteLine($"[|{String.Join("| |", FirstMass)}|]");
            string[] SortedMass = GetNewMass(FirstMass);
            Console.WriteLine($"[|{String.Join("| |", SortedMass)}|]");

                       
           
        }
    }
}

