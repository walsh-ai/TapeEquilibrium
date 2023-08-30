// Top level statements
// Test solution 
using System.Globalization;

int[] arr = {3, 1, 2, 4, 3}; 
Console.WriteLine($"Result: {MinimumDifference(arr)}");

public static partial class Program {
    public static int MinimumDifference(int[] arr) {
        int[] sums  = new int[(arr.Length - 1)];

        // Sum the whole array
        int arrSum = 0;
        for (int i = 0; i < arr.Length; i++) {
            arrSum += arr[i];
        }

        // Produce the left hand sums 
        int minDiff = arrSum; 
        int runningSum = 0; 
        for (int i = 0; i < (arr.Length - 1); i++) {
            runningSum += arr[i];
            minDiff = 
                Math.Min(minDiff, (Math.Abs(runningSum - (arrSum - runningSum))));
        }

        return minDiff;
    }
}