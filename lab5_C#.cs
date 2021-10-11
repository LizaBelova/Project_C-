                        /////////////////////////////
                        //������������ ������ �5.////
                        //��������������� ��������.//
                        //������� �6.////////////////
                        /////////////////////////////

/*
  ��� ������ � �������������� �������� �������� �������� (��. ������� � ������� 3).
  � �������� ��������� ������������������ ������������� ���������������� ��������.
  ������� - true, false, ! (���������� ��).
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
    public B(int i, int j) //������������� ����������
    {
        x = i;
        y = j;
    }
    //����������� �������� true
    public static bool operator true(B op)
    {
        if ((op.x != 0) || (op.y != 0)) //���� ���� ���-�� �� ����� ����
        {
            return true;

        }
        else
            return false;
    }
    //����������� �������� false
    public static bool operator false(B op)
    {
        if ((op.x == 0) && (op.y == 0)) //���� ��� ����� ����
        {
            return true;
        }
        else
            return false;
    }
    //���������� ��������� !
    public static bool operator !(B op)
    {
        if( (op.x != 0) || (op.y != 0) ) //���� ���� �� ���� �� ����� 0
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
            if (a) Console.WriteLine("a - ��� ������.");
              else Console.WriteLine("a - ��� ����.");
            if (b) Console.WriteLine("b - ��� ������.");
              else Console.WriteLine("b - ��� ����.");
            if (c) Console.WriteLine("c - ��� ������.");
              else Console.WriteLine("c - ��� ����.");
            Console.ReadKey();
        }
    }
}