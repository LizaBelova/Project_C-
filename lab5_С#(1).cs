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
    //Перегрузка оператора true
    public static bool operator true(B op)
    {
        if ((op.x != 0) || (op.y != 0))
        {
            return true;

        }
        else
            return false;
    }
    //Перегрузка оператора false
    public static bool operator false(B op)
    {
        if ((op.x == 0) && (op.y == 0))
        {
            return true;
        }
        else
            return false;
    }
    //Перегрузка оператора !
    public static B operator !(B op)
    {
        op.x = -op.x;
        op.y = -op.y;
        return op;
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
            B c = new B(-34, 8);

            Console.Write("a = ");
            Console.WriteLine("(" + a.x + "," + a.y + ")");
            Console.Write("b = ");
            Console.WriteLine("(" + b.x + "," + b.y + ")");
            Console.Write("c = ");
            Console.WriteLine("(" + c.x + "," + c.y + ")");
            Console.WriteLine();
            if (a) Console.WriteLine("a - ИСТИНА");
            else   Console.WriteLine("a - ЛОЖЬ");
            if (b) Console.WriteLine("b - ИСТИНА");
            else   Console.WriteLine("b - ЛОЖЬ");
            c = !c;
            Console.WriteLine("c = (" + c.x + "," + c.y + ")");
            Console.ReadKey();
        }
    }
}
