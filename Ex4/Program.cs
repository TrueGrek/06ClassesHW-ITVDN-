using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        { 

            int[] a = { 3,2,1,0 };
            a.SortUp();
            foreach(int i in a)
                Console.Write("{0} ",i);
        }
    }

    static class Extend
    {
        static public void SortUp(this int[] array) // метод разширения (Extension Methods) 
        {                                           //Метод выполняет сортировку пузырьками 
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[i] > array[j])
                    {
                        int x = array[j];
                        array[j] = array[i];
                        array[i] = x;
                    }

                }
            }
        }
    }
}
