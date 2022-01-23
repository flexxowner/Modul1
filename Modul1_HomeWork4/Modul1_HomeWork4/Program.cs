using System;

namespace Modul1_HomeWork4
{
    class Program
    {
        private static void GetArray(ref int[] mainArray)
        {
            Random random = new Random();
            for (int i = 0; i < mainArray.Length; i++)
            {
                mainArray[i] = random.Next(1, 26);
            }

            return;
        }

        static void Main(string[] args)
        {
            int k = 0, l = 0;
            Console.WriteLine("Input array lenght:");
            int lengh = Convert.ToInt32(Console.ReadLine());
            if (lengh == 0)
            {
                Console.WriteLine("Error, invalid array lenght");
                Console.WriteLine("Try again:");
                lengh = Convert.ToInt32(Console.ReadLine());
            }

            int[] mainArray = new int[lengh];
            string letters = "0abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("First array:");

            GetArray(ref mainArray);
            var array = string.Join(" ", mainArray);
            Console.WriteLine(array);
            Console.WriteLine("--------------------------------------------------------------");

            // Переписываем из главного массива четные значения в первым массив, нечетные - во второй. Пустые места заполняем 0
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < mainArray.Length; i++)
            {
                if (mainArray[i] % 2 == 0)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }

            dynamic[] evenArray = new dynamic[count1];
            dynamic[] oddArray = new dynamic[count2];

            for (int i = 0; i < mainArray.Length; i++)
            {
                if (mainArray[i] % 2 == 0)
                {
                    evenArray[k++] = mainArray[i];
                }
                else
                {
                    oddArray[l++] = mainArray[i];
                }
            }

            var stringEvenArray = string.Join(" ", evenArray);
            var stringOddArray = string.Join(" ", oddArray);
            Console.WriteLine("Even array:");
            Console.WriteLine(stringEvenArray);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Odd array:");
            Console.WriteLine(stringOddArray);
            Console.WriteLine("--------------------------------------------------------------");

            for (int i = 0; i < evenArray.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (evenArray[i] == j)
                    {
                        evenArray[i] = letters[j];
                    }
                }
            }

            stringEvenArray = string.Join(" ", evenArray);
            Console.WriteLine("Even array with letters:");
            Console.WriteLine(stringEvenArray);
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < oddArray.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (oddArray[i] == j)
                    {
                        oddArray[i] = letters[j];
                    }
                }
            }

            stringOddArray = string.Join(" ", oddArray);
            Console.WriteLine("Odd array with letters:");
            Console.WriteLine(stringOddArray);
            Console.WriteLine("--------------------------------------------------------------");
            if (stringEvenArray.Contains('a') || stringEvenArray.Contains('e') ||
                stringEvenArray.Contains('i') || stringEvenArray.Contains('d') || stringEvenArray.Contains('h') || stringEvenArray.Contains('j'))
            {
                stringEvenArray = stringEvenArray.Replace('a', 'A');
                stringEvenArray = stringEvenArray.Replace('e', 'E');
                stringEvenArray = stringEvenArray.Replace('i', 'I');
                stringEvenArray = stringEvenArray.Replace('d', 'D');
                stringEvenArray = stringEvenArray.Replace('h', 'H');
                stringEvenArray = stringEvenArray.Replace('j', 'J');
            }

            Console.WriteLine("Even array with upper chars:");
            Console.WriteLine(stringEvenArray);
            Console.WriteLine("--------------------------------------------------------------");
            if (stringOddArray.Contains('a') || stringOddArray.Contains('e') ||
    stringOddArray.Contains('i') || stringOddArray.Contains('d') || stringOddArray.Contains('h') || stringOddArray.Contains('j'))
            {
                stringOddArray = stringOddArray.Replace('a', 'A');
                stringOddArray = stringOddArray.Replace('e', 'E');
                stringOddArray = stringOddArray.Replace('i', 'I');
                stringOddArray = stringOddArray.Replace('d', 'D');
                stringOddArray = stringOddArray.Replace('h', 'H');
                stringOddArray = stringOddArray.Replace('j', 'J');
            }

            Console.WriteLine("Odd array with upper chars:");
            Console.WriteLine(stringOddArray);
            Console.WriteLine("--------------------------------------------------------------");
            int upcount1 = 0;
            int upcount2 = 0;
            for (int i = 0; i < stringEvenArray.Length; i++)
            {
                if (char.IsUpper(stringEvenArray[i]))
                {
                    upcount1++;
                }
            }

            for (int i = 0; i < stringOddArray.Length; i++)
            {
                if (char.IsUpper(stringOddArray[i]))
                {
                    upcount2++;
                }
            }

            if (upcount1 > upcount2)
            {
                Console.WriteLine("First array has more uppercase letters:");
                Console.WriteLine($"Number of uppercase letters for the first array: {upcount1}");
            }
            else if (upcount1 < upcount2)
            {
                Console.WriteLine("Second array has more uppercase letters:");
                Console.WriteLine($"Number of uppercase letters for the second array: {upcount2}");
            }
           else if (upcount1 == upcount2)
            {
                Console.WriteLine("The first array is equal to the second");
            }

            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
