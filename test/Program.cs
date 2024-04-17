using System;

namespace SelectionSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] randArray = new int[n];
            Random r = new Random();

            Console.WriteLine("Tablica przed sortowaniem: ");
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = r.Next(1, 100);
                Console.Write(randArray[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < randArray.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < randArray.Length; j++)
                {
                    if (randArray[j] < randArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = randArray[minIndex];
                randArray[minIndex] = randArray[i];
                randArray[i] = temp;
            }

            Console.WriteLine("Tablica po sortowaniu: ");
            for (int i = 0; i < randArray.Length; i++)
            {
                Console.Write(randArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
