// Top level statements
// Test solution 
using System.Globalization;

int[] arr = {3, 1, 2, 4, 3}; 
Console.WriteLine($"Result: {MinimumDifference(arr)}");

public static partial class Program {
    /// <summary>
    /// Find the minimum difference possible between the sums of two
    /// non-empty sub arrays of the given array. 
    /// In this solution, the sum of elements of the argument array is 
    /// calculated.
    /// The left hand sum from the first index (0) for each possible 
    /// partition is calculated, and the right hand sum is taken as the
    /// difference between the left hand sum and the total sum. 
    /// The minimum difference is updated on each iteration and returned. 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int MinimumDifference(int[] arr) {
        int[] sums  = new int[(arr.Length - 1)];

        // Sum the whole array
        int arrSum = 0;
        for (int i = 0; i < arr.Length; i++) {
            arrSum += arr[i];
        }

        // Produce the left hand sums 
        // The corresponding right hand sum (rhs) is:
        //      rhs = total_sum - lhs
        // If abs(lhs - rhs) < minimum_difference then update difference 
        int minDiff = arrSum; 
        int lhs = 0; 
        for (int i = 0; i < (arr.Length - 1); i++) {
            lhs += arr[i];
            minDiff = 
                Math.Min(minDiff, (Math.Abs(lhs - (arrSum - lhs))));
        }

        return minDiff;
    }
}