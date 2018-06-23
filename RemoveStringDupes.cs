using System;
using System.Collections.Generic;//for the Dictionary (hashmap)
using System.Text;//for StringBuilder

/*
 * Problem:
 * Write a method that takes an input string and outputs a string with all the
 * duplicate characters removed.
 * 
 * e.g. string input = "aaaaaabbbb"
 * We would want the method to return just "ab"
 */

class RemoveStringDupe{
    static string RemoveDuplicates(string str){
        Dictionary<char, int> list = new Dictionary<char, int>();
        StringBuilder builder = new StringBuilder();
        string output;

        foreach(char c in str){
            if (!list.ContainsKey(c)){
                list.Add(c, 1);
            }
        }

        foreach(KeyValuePair<char, int> pair in list){
            builder.Append(pair.Key);
        }

        output = builder.ToString();
        return output;
    }

    static void Main()
    {
        string input = "aaaaaabbbb";
        string output;
        output = RemoveDuplicates(input);

        Console.WriteLine("The input " + input + " without duplicates is: " + output);
    }
}