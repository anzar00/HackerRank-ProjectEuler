/*
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of a given number N?
Input Format
First line contains T, the number of test cases. This is followed by T lines each
containing an integer N.
Constraints
- 1 <= T <= 10
- 10 <= N <= 1012
Output Format
For each test case, display the largest prime factor of N.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            long max = 0;
            while (n % 2 == 0) {
                max = 2;
                n /= 2;
            }
            for (long i = 3; i <= Math.Sqrt(n); i += 2) {
                while (n % i == 0) {
                    max = i;
                    n /= i;
                }
            }
            if (n > 2) {
                max = n;
            }
            Console.WriteLine(max);
        }
    }
}