using System;
using System.Collections.Generic;//for the Dictionary (hashmap)

/*
 * Problem:
 * If we list all the natural numbers below 10 that are multiples of 3 or 5,
 * we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all
 * the multiples of 3 or 5 below 1000.
 * 
 * source: https://projecteuler.net/problem=1
 */

class Multiples3and5
{

    //Current Solution adds multiples to a hashmap and sums the multiples. Could be improved. 
    //Will add further explanation/optimizations in future.

    static void GetMultiples(int bar, int[] numbers, Dictionary<int, int> multiplelist){
        foreach (int num in numbers) {
            for (int i = 1; i < bar; i++){
                int current = num * i;
                if (current >= bar){
                    break;
                }
                if (!multiplelist.ContainsKey(current)){
                    multiplelist.Add(current, current);
                }
            }
        }
    }

    static int SumMultiples(Dictionary<int, int> multiplelist){
        int sum = 0; 
        foreach (KeyValuePair<int, int> pair in multiplelist){
            sum += pair.Key;
        }
        return sum;
    }

    static void Main(){
        int bar = 1000;
        int[] numbers = { 3, 5 };
        int sum = 0;
        Dictionary<int, int> multiplelist = new Dictionary<int, int>();

        GetMultiples(bar, numbers, multiplelist);
        sum = SumMultiples(multiplelist);
        Console.WriteLine("The sum is " + sum);
    }
        
}