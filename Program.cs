using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //just comment
            Console.Write("Enter a Integer :");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0, temp = 0;
            int OrginalNum = n;

            while (n != 0)
            {
                r = n % 10;
                temp = temp * 10 + r;
                n = n / 10;
            }
            if (OrginalNum==temp)
            {
                Console.WriteLine("#### Palindrome ####");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}

