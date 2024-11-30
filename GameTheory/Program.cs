using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTheory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string[] ops = { "6", "3", "C", "D", "+" };
            foreach (string i in ops)
            {
                char c = i[0];
                if(c>='0' && c<='9')
                {
                    list.Add(c-'0');
                }
                else if(c=='C')
                {
                    list.Remove(list[list.Count-1]);
                }
                else if(c=='D')
                {
                    list.Add(2*list[list.Count - 1]);
                }
                else if(c=='+')
                {
                    int num1 = list[list.Count-1];
                    int num2= list[list.Count-2];   
                    list.Add(num1+num2);
                }
            }
            int sum = 0;
            foreach (int i in list)
            {
                //Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
