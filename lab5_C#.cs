                        /////////////////////////////
                        //ЛАБОРАТОРНАЯ РАБОТА №5.////
                        //Переопределение операций.//
                        //Вариант №6.////////////////
                        /////////////////////////////

/*
  Для класса В переопределить операции согласно варианту (см. вариант в таблице 3).
  В основной программе продемонстрировать использование переопределенных операций.
  Вариант - true, false, ! (логическое НЕ).
*/

using System;
using System.Collections.Generic;
using System.Text;

class B
{
    public int x, y;
    public B() 
    { 
        x = y = 0;
    }
    public B(int i, int j) //Инициализация переменных
    {
        x = i;
        y = j;
    }
    //Перегружаем оператор true
    public static bool operator true(B op)
    {
        if ((op.x != 0) || (op.y != 0)) //Если хоть что-то не равно нулю
        {
            return true;

        }
        else
            return false;
    }
    //Перегружаем оператор false
    public static bool operator false(B op)
    {
        if ((op.x == 0) && (op.y == 0)) //Если все равны нулю
        {
            return true;
        }
        else
            return false;
    }
    //Перегрузка оператора !
    public static bool operator !(B op)
    {
        if( (op.x != 0) || (op.y != 0) ) //Если хотя бы один не равен 0
        {
            return true;
        }
        else
            return false;
    }
}


namespace sharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            B a = new B(1, 1);
            B b = new B(0, 0);
            B c = new B(0, 0);

            Console.Write("a = ");
            Console.WriteLine(a.x + "," + a.y);
            Console.Write("b = ");
            Console.WriteLine(b.x + "," + b.y);
            Console.Write("c = ");
            Console.WriteLine(c.x + "," + c.y);
            //Console.WriteLine(!true);
            //Console.WriteLine(!false);
            if (a) Console.WriteLine("a - это ИСТИНА.");
              else Console.WriteLine("a - это ЛОЖЬ.");
            if (b) Console.WriteLine("b - это ИСТИНА.");
              else Console.WriteLine("b - это ЛОЖЬ.");
            if (c) Console.WriteLine("c - это ИСТИНА.");
              else Console.WriteLine("c - это ЛОЖЬ.");
            Console.ReadKey();
        }
    }
}
