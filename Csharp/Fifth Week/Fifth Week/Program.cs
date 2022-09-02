/**
 * @file ProblemThree.cs
 * @author Amir khaksar (ah_khaksar@yahoo.com)
 * @brief count letters
 * @version 0.1.0
 * @date 2022-09-2
 * @id 2code2
 * @Compailer dot net
 * @copyright Copyright (c) 2022
 *
 */


using System;

namespace Fifth_Week
{
    internal class Program
    {
        public static void Swap(int[] array, int firstIndex, int secondIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        public static void Sort(int[] endTimes, int[] startTimes)
        {
            for (int i = 0; i < endTimes.Length; i++)
            {
                for (int j = 0; j < endTimes.Length - i - 1; j++)
                {
                    if (endTimes[i] > endTimes[j + 1])
                    {
                        Swap(endTimes, j, j + 1);
                        Swap(startTimes, j, j + 1);
                    }
                }
            }
        }

        private static void Main(string[] args)
        {
            int Input = Convert.ToInt16(Console.ReadLine());
            int[] StartTimes = new int[Input];
            for (int i = 0; i < Input; i++)
            {
                StartTimes[i] = Convert.ToInt16(Console.Read());
            }
            int[] EndTimes = new int[Input];
            for (int i = 0; i < Input; i++)
            {
                EndTimes[i] = Convert.ToInt16(Console.Read());
            }
            Sort(EndTimes, StartTimes);
            int sum = 1;
            int j = 0;
            for (int i = 0; i < Input; i++)
            {
                if (EndTimes[j] < StartTimes[i])
                {
                    j = i;
                    sum++;
                }
            }
            Console.Write(sum);
        }
    }
}
