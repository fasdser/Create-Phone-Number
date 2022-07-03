using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] array = {1,2, 3,4,5,6,7,8,9,0};
            CreatePhoneNumber(array);
            Console.WriteLine(CreatePhoneNumber(array));
            Console.ReadLine();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static string CreatePhoneNumber(int[] numbers)
        {
             int[] array = numbers;
            if (array.Length >= 11)
                return "Заданное значение массива вне его границы";

           

            return string.Format($"({array[0]}{array[1]}{array[2]}) {array[3]}{array[4]}{array[5]}-{array[6]}{array[7]}{array[8]}{array[9]}");
          
            // Крутой вариант, того же самого.
            // return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}
