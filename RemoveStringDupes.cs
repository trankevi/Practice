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

    /*
     * Solution
     * 
     * This solution uses a hashmap to check for duplicates, along with a string
     * builder to create the new output string. The first loop goes through each
     * char in the input string, and checks if the hashmap contains a matching
     * key; if not, a new key-value pair is added to the hashmap (we could also
     * use this to count the number of occurences of the repeated letters, but 
     * the question does not ask us to do so, so I just put 1 in the value). 
     * 
     * Then, for each pair in the hashmap, the string will be built by appending
     * the key to the output string. Finally, we convert the builder to a string
     * by using the .ToString() method. 
     * 
     */


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