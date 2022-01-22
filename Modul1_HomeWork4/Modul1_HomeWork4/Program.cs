using System;

namespace Modul1_HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengh1;
            int k = 0, l = 0;  
            Random random = new Random();
            Console.WriteLine("Input array lenght:");
            lengh1 = Convert.ToInt32(Console.ReadLine());
            int[] mainArray = new int[lengh1];
            dynamic[] evenArray = new dynamic[lengh1];
            int[] oddArray = new int[lengh1];
            string letters = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            var lettersArray = letters.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("First array:");

            for (int i = 1; i < mainArray.Length; i++)
            {
                mainArray[i] = random.Next(1, 26);
            }
            var array = string.Join(" ", mainArray);
            Console.WriteLine(array);
            
            // Переписываем из главного массива четные значения в первым массив, нечетные - во второй. Пустые места заполняем 0
            for (int i = 1; i < mainArray.Length; i++)
            {
                if ( mainArray[i] % 2 == 0)
                {
                    evenArray[k++] = mainArray[i];
                }
                else
                {
                    oddArray[l++] = mainArray[i];
                }
            }
            while (k < mainArray.Length)
            {
                evenArray[k++] = 0;
            }
            while (l < mainArray.Length)
            {
                oddArray[l++] = 0;
            }
            var stringEvenArray = string.Join(" ", evenArray);
            var stringOddArray = string.Join(" ", oddArray);
            Console.WriteLine("Even array:");
            Console.WriteLine(stringEvenArray);

            Console.WriteLine("Odd array:");
            Console.WriteLine(stringOddArray);

            

            for (int i = 1; i < lettersArray.Length; i++)
            {
                for (int j = 1; j < evenArray.Length; j++)
                {
                    if (j == i)
                    {
                        evenArray[j] = lettersArray[i];
                    }
                }
            }
            stringEvenArray = string.Join(" ", evenArray);
            Console.WriteLine("Even array with letters:");
            Console.WriteLine(stringEvenArray);

        }
    }
}
