using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path="";
            
            Console.WriteLine("Enter number from 1-4\n1. To append to the File\n2. To Removes the string in the file\n3. Clear all the content in the file\n4.Delete the file");
            int num=Convert.ToInt32(Console.ReadLine());
            try
            {

                path = @"C:/Users/mithu/Desktop/StructuresInC#.txt";
                //string value = File.ReadAllText(path);
                //string updated = value;
                //Console.WriteLine(value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string temp = Input();
            string text = File.ReadAllText(path);
            switch (num)
            {
                    case 1:
                    Console.Write("Enter the string you want to append : ");
                    //string temp1= Input();
                    //string text1=File.ReadAllText(path);
                    text = text + temp;
                    File.WriteAllText(path, text);
                    break;
                    case 2:
                    Console.Write("Enter the string you want to delete : ");
                    temp= Input();
                    text = File.ReadAllText(path);
                    text=text.Replace(temp, string.Empty);
                    File.WriteAllText(path, text);
                    break;
                    case 3:
                    File.WriteAllText(path, "");
                    break; 
                    case 4:
                    File.Delete(path);
                    break;
                default:
                    Console.WriteLine("Enter the correct input");
                    break;

            }

            //Console.WriteLine(num);
            //Console.ReadKey();
        }
        public static string Input()
        {
            return Console.ReadLine();
        }
    }
}
