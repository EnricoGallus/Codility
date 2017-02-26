using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class Tape {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int right = A.Sum();
        int left = 0;
        int result = right;
        for (int i = 0; i < A.Length; i++)
        {
            left += A[i];
            right -= A[i];
            int calculation = Math.Abs(left - right);

            if (calculation < result)
            {
                result = calculation;
            }
        }

        return result;
    }
}