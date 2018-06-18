using System;
using System.Collections.Generic;//for the Dictionary (hashmap)

/*
 * Problem:
 * Given an unsorted array of integers which has a number in the majority
 * (appears more than 50% in the array), write a method to find that number
 * 
 * e.g. int[] array = { 1, 3, 3, 4, 2, 3, 7, 3, 3 };
 * We would want the method to return 3 in this case as it appears 5/9 times.
 */


class Majority
{
    /*
     * Hashmap Solution
     * This solution uses a hashmap to solve the problem. The first loop
     * adds the unique integers in the array to the hashmap as keys and sets
     * the value to 1; integers that appear more than once get their value for
     * their corresponding key incremented. The second loop goes through each
     * key-value pair in the hashmap looking for the largest value and sets the
     * 'major' to be the key that is paired with the largest value.
     * 
     * If the array does not contain a majority, the method will return 0.
     * However, from the question assumption, we are given an input array
     * that contains a majority. If this were not the case, the way we
     * would handle this would be situational (e.g. throw error?, return an
     * arbitrary number and have a check for the number?, etc.)
     * 
     */

    static int GetMajority(int[] array){
        int major = 0;
        int length = array.Length;
        int half = length / 2;
        Dictionary<int, int> hashmap = new Dictionary<int, int>();

        //First loop
        for (int i = 0; i < length; i++){
            if (hashmap.ContainsKey(array[i])){
                hashmap[array[i]]++;
            }
            else{
                hashmap.Add(array[i], 1);
            }
        }

        //Second loop
        foreach (KeyValuePair<int, int> pair in hashmap){
            if (pair.Value > half){
                major = pair.Key;
            }
        }

        return major;
    }

    static void Main(){
        int[] array = { 1, 3, 3, 4, 2, 3, 7, 3, 3 };
        int[] array2 = { 3, 1, 324423262, 1, 1};
        int[] array3 = { 6543, 54633, 54363, 34315, 75324, 54633, 54633, 54633, 54633};
        int majorint;

        //we would want the method to return 3
        majorint = GetMajority(array);
        Console.WriteLine("The majority integer is: " + majorint);

        //we would want the method to return 1
        majorint = GetMajority(array2);
        Console.WriteLine("The majority integer is: " + majorint);

        //we would want the method to return 54633
        majorint = GetMajority(array3);
        Console.WriteLine("The majority integer is: " + majorint);
    }

}
