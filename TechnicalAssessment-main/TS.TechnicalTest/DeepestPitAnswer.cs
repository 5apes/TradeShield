namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        // innitial depth and response if array is empty
        int maxDepth = -1;

        //looping from P = 0 to P = points.Length - 3, ensuring that there's room for Q and R within the array.
        for (int P = 0; P < points.Length - 2; P++)
        {
            // Initialize Q to be the next element after P.
            int Q = P + 1;

            // Move Q forward as long as we are going downhill (i.e., strictly decreasing sequence).
            while (Q < points.Length - 1 && points[Q] < points[Q - 1])
            {
                Q++;
            }

            // If Q did not move (P + 1) or has reached the end of the array, skip this iteration.
            if (Q == P + 1 || Q == points.Length - 1) continue;
        }

        return maxDepth;
    }
}
