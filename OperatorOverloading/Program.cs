using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{

    class ThreeD
    {
        int x, y, z;
        public ThreeD()
        {
            x = y = z = 0;
        }

        public ThreeD(int a , int b , int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public static ThreeD operator +(ThreeD one , ThreeD two)
        {
            int x1 = one.x + two.x;
            int y1 = one.y + two.y;
            int z1 = one.z + two.z;
            return (new ThreeD(x1,y1,z1));
        }

        public static ThreeD operator -(ThreeD one, ThreeD two)
        {
            int x1 = one.x - two.x;
            int y1 = one.y - two.y;
            int z1 = one.z - two.z;
            return (new ThreeD(x1, y1, z1));
        }
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ThreeD obj1 = new ThreeD(1,2,3);
            ThreeD obj2 = new ThreeD(10, 20, 30);
            ThreeD Sumobj = obj1 + obj2;
            ThreeD Diffobj = obj1 - obj2;
            obj1.Show();
            obj2.Show();
            Sumobj.Show();
            Diffobj.Show();
            Console.Read();
        }
    }
}
