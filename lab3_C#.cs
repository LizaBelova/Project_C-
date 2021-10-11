                                        ///////////////////////////////
                                        //ЛАБОРАТОРНАЯ РАБОТА №3.//////
                                        //Массивы./////////////////////
                                        //Вариант №6///////////////////
                                        ///////////////////////////////

/*
В класс В добавить поле-массив. Разработать конструктор для инициализации массива, который при своём вызове передает управление
собственному конструктору класса В. Размер массива – поле a, инициализация элементов массива: свойство с2 (см. лабораторную работу №2), 
умноженное на индекс элемента массива. В программе вывести на экран элементы массива. Для вывода использовать цикл foreach.
*/
using System;
namespace sharp3
{
    public class A
    {
        public int a, b;
        public A(int x, int y)
        {
            a = x;
            b = y;
        }
    }
    public class B : A
    {
        public int[] arr;
        public int d;
        public B(int x, int y, int z) : base(x, y)
        {
            d = z;
            arr = new int[a];
            for (int i = 0; i < a; i++)
            {
                arr[i] = c2 * i;
            }
        }
        public int c2
        {
            get
            {
                if (a >= b)
                {
                    d = a - b;
                }
                else d = a + b;
                return d;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Title = "Лабораторная работа №3";
            B x = new B(3, 4, 0);
            foreach (int element in x.arr)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
