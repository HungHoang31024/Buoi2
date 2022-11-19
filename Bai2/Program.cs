using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            CIntArray intArray = new CIntArray(arr);
            Console.WriteLine("{0}", intArray);

            intArray = new CIntArray(30, 5);
            Console.WriteLine("{0}", intArray);

            intArray = new CIntArray(arr, 2, 4); // lấy từ vị trí thứ 2, lấy 4 số
            Console.WriteLine("{0}", intArray);

            Console.ReadLine();
        }
    }
}
