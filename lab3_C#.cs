                                        ///////////////////////////////
                                        //������������ ������ �3.//////
                                        //�������./////////////////////
                                        //������� �6///////////////////
                                        ///////////////////////////////

/*
� ����� � �������� ����-������. ����������� ����������� ��� ������������� �������, ������� ��� ���� ������ �������� ����������
������������ ������������ ������ �. ������ ������� � ���� a, ������������� ��������� �������: �������� �2 (��. ������������ ������ �2), 
���������� �� ������ �������� �������. � ��������� ������� �� ����� �������� �������. ��� ������ ������������ ���� foreach.
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
            Console.Title = "������������ ������ �3";
            B x = new B(3, 4, 0);
            foreach (int element in x.arr)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
