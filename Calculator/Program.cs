using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = '�';
            while (again == '�')
            {
                double a;
                double b;
                double total;
                char oper;

                Console.WriteLine("������� ������ �����:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("������� ��������:");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("������� ������ �����:");
                b = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("C���� " + a + " � " + b + " ����� " + total + ".");
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("�������� " + a + " � " + b + " ����� " + total + ".");
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("��������� " + a + " �� " + b + " ����� " + total + ".");
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("������� " + a + " �� " + b + " ����� " + total + ".");
                }
                else
                {
                    Console.WriteLine("����������� ��������.");
                }
                Console.WriteLine("�� ������ ���������� ������ � �������������? (�/�)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
� 2022 GitHub, Inc.
Terms
Privacy
S