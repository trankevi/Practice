using System;
using System.Linq; //for the array extension methods (.Where, .Sum)


/*
 * Problem:
 * Given an array of integers, write a method to find the sum of the even numbers
 * 
 * e.g. int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
 * We would want the method to return 20 for this given array.
 */

class Addition {
    //Standard Solution
    static int AddEvens(int[] array){
        int sum = 0;
        int length = array.Length;

        for (int i = 0; i < length; i++){
            if (array[i] % 2 == 0){
                sum += array[i];
            }
        }
        return sum;
    }

    //One Line Solution
    //solution using from,where,select keywords like an SQL-esque query and .Sum from Linq
    static int OneLineAddEvens(int[] array){
        return (from i in array where i % 2 == 0 select i).Sum();
    }

    //One Line Solution 2
    //solution using lambda expression and .Sum from Linq
    static int SecondOneLineAddEvens(int[] array){
        return array.Where(i => i % 2 == 0).Sum();
    }

    /*
     * Another consideration is possibility of overflow. We could cast the type from int
     * to long and have the solutions return a long instead, but in this case it is fine
     * because the numbers are tiny.
     * 
     * I was recently asked "what if we wanted the odd numbers?". We can just negate
     * the conditional in the standard or negate the 'where' conditional for the one-line
     * methods by changing the == to !=. 
     */

    static int AddOdds(int[] array)
    {
        int sum = 0;
        int length = array.Length;

        for (int i = 0; i < length; i++){
            if (array[i] % 2 != 0) {
                sum += array[i];
            }
        }
        return sum;
    }

    static int OneLineAddOdds(int[] array){
        return (from i in array where i % 2 != 0 select i).Sum();
    }

    static int SecondOneLineAddOdds(int[] array){
        return array.Where(i => i % 2 != 0).Sum();
    }

    static void Main(){
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sum = 0;

        //We are expecting 20 for the sum of evens, and 25 for the sum of odds
        sum = AddEvens(array);
        Console.WriteLine("Standard Solution: " + sum);
        sum = OneLineAddEvens(array);
        Console.WriteLine("One Line Solution 1: " + sum);
        sum = SecondOneLineAddEvens(array);
        Console.WriteLine("One Line Solution 2: " + sum);

        sum = AddOdds(array);
        Console.WriteLine("Odd Solution: " + sum);
        sum = OneLineAddOdds(array);
        Console.WriteLine("Odd Solution 2: " + sum);
        sum = SecondOneLineAddOdds(array);
        Console.WriteLine("Odd Solution 2: " + sum);
    }

}