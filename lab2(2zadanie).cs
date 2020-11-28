using System;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(x, y);
            Console.WriteLine(rect.Area());
        }
        class Rectangle
        {
            private int a, b;
            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public void WriteAB()
            {
                Console.WriteLine("Длина a={0}", a);
                Console.WriteLine("Длина b={0}", b);
            }
            public int Perimeter()
            {
                return 2 * a + 2 * b;
            }
            public int Area()
            {
                return a * b;
            }
            public int A
            {
                get { return a; }
                set { a = value; }
            }
            public int B
            {
                get { return b; }
                set { b = value; }
            }
            public bool IsSquare
            {
                get { return a == b; }
            }
            public int this[int index]
            {
                get
                {
                    if (index == 0)
                        return a;
                    if (index == 1)
                        return b;

                    Console.WriteLine("Нtg {0}", index);
                    return -1;
                }
                set
                {
                    if (index == 0)
                        a = value;
                    if (index == 1)
                        b = value;
                    if (index != 0 && index != 1)
                        Console.WriteLine("Неверный индекс {0}", index);
                }
            }
            public static Rectangle operator ++(Rectangle r)
            {
                r.A++;
                r.B++;
                return r;
            }
            public static Rectangle operator --(Rectangle r)
            {
                r.A--;
                r.B--;
                return r;
            }
            public static bool operator false(Rectangle r)
            {
                if (!r.IsSquare)
                    return false;
                return true;
            }
            public static bool operator true(Rectangle r)
            {
                if (r.IsSquare)
                    return true;
                return false;
            }
            public static Rectangle operator *(Rectangle r, int v)
            {
                r.A *= v;
                r.B *= v;
                return r;
            }
            public static Rectangle operator *(int v, Rectangle r)
            {
                r.A *= v;
                r.B *= v;
                return r;
            }
            public static implicit operator string(Rectangle r)
            {   
                return r.A.ToString() + " " + r.B.ToString();
            }
            public static implicit operator Rectangle(string s)
            {
                string[] w = s.Split(' ');
                return new Rectangle(Convert.ToInt32(w[0]), Convert.ToInt32(w[1]));
            }
        }
    }
}
