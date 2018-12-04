using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Without using integer libraries in python or .Net, directly applying the summation algorithm with sum and carrie.
//Just create a text file and copy the large number into it, the algorithm applies mid school summation method without storing the datas in very large adresses. The result will be stored in a linked list.
namespace PEuler13
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = 50;
            int numbers = 100;
            string line;
            string[] T = new string[numbers]; //100
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\mberk\Documents\test.txt");//Change this to your file position
            int i = 0;
            while ((line = file.ReadLine()) != null)
            {     
                T[i] = line;
                i++;            
            }        
            file.Close();
            List<int> num = new List<int>();
            int sum = 0; int carrie = 0; int j = 1;
            while (j <= digits) //50
            {
                for (int n = 0; n < numbers; n++) //100
                {
                    sum = sum + (int)Char.GetNumericValue(T[n].ElementAt(T[n].Length - j));
                }
                    int temp = sum + carrie;
                if (j == digits) //50
                    sum = carrie + sum;
                else
                    sum = (carrie + sum) % 10;
                    carrie = temp / 10;             
                num.Insert(0, sum);
                sum = 0;
                j++;
            }
            foreach (int m in num)
            {
                Console.WriteLine(m);
            }
            System.Console.ReadLine();
        }
    }
}
