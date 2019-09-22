using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] mas = new int[10];
                Console.WriteLine("Введите десять чисел");
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write("{0}-е число: ", i + 1);
                    mas[i] = int.Parse(Console.ReadLine());
                }

                int temp;
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Вывод отсортированного массива");
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine(mas[i]);
                }
                Console.ReadLine();
        }
    }
}
