using System;
using System.Net;
using System.Linq;

class Program
{
    // public bool IsFinished()
    // {
        
    // }
    // public void HideWords()
    // {

    // }
    static void Main(string[] args)
    {
        
        // public List<string> s = new List<string>();
        string filePath = @"C:\Users\trifo\Documents\GitHub\CSE210\prove\Develop03\lds-scriptures.csv";
        string[] lines = File.ReadLines(filePath).ToArray();
        foreach (string line in lines)
        {
            string[] values = line.Split(",");
            Console.WriteLine(string.Join(" ", values));
        }


    }
}
