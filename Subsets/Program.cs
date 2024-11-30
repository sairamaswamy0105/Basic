//// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
//string inputString = "Sai";
//int length = 3;
//List<string> list = new List<string>();
//bool[] visited = new bool[inputString.Length];
//GenerateSubsets(inputString,"", length,list,visited);

//void GenerateSubsets(string inputString,string temp, int length, List<string> list, bool[] visited)
//{
//    if(length==0)
//    {
//        list.Add(temp);
//        Console.WriteLine(temp);
//        return;
//    }
//    int i = 0;
//    if(!visited[i] )
//    {

//    for (i = 0; i < inputString.Length; i++)
//    {
//        visited[i] = true;
//    GenerateSubsets(inputString, temp + inputString[i], length - 1, list,visited);
//        visited[i] = false;
//    }
//    }


//}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "Sai";
        int length = 3;
        List<string> list = new List<string>();
        bool[] visited = new bool[inputString.Length];
        GenerateSubsets(inputString, "", length, list, visited);

        foreach (var subset in list)
        {
            Console.WriteLine(subset);
        }
    }

    static void GenerateSubsets(string inputString, string temp, int length, List<string> list, bool[] visited)
    {
        if (length == 0)
        {
            list.Add(temp);
            return;
        }

        for (int i = 0; i < inputString.Length; i++)
        {
            if (!visited[i])
            {
                visited[i] = true;
                GenerateSubsets(inputString, temp + inputString[i], length - 1, list, visited);
                visited[i] = false;  // Backtrack
            }
        }
    }
}
