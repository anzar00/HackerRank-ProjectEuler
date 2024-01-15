/*

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below N.

Input Format

First line contains T that denotes the number of test cases. This is followed by T lines, each containing an integer, N.

Constraints

1 <= T <= 10^5
1 <= N <= 10^9

Output Format

For each test case, print an integer that denotes the sum of all the multiples of 3 or 5 below N.

*/

public class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long sum = 0;
            long n3 = (n - 1) / 3;
            long n5 = (n - 1) / 5;
            long n15 = (n - 1) / 15;
            sum = 3 * (n3 * (n3 + 1) / 2) + 5 * (n5 * (n5 + 1) / 2) - 15 * (n15 * (n15 + 1) / 2);
            Console.WriteLine(sum);
        }
    }
}