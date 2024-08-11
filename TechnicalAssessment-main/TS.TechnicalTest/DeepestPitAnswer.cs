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

            int R = Q;

            // Move R forward as long as we are going uphill (i.e., strictly increasing sequence).
            while (R < points.Length && points[R] > points[R - 1])
            {
                R++;
            }

            // If R did not move or we don't have a valid uphill, skip this iteration.
            if (R == Q + 1) continue;

            // Calculate the drop from P to Q
            int dropFromPToQ = points[P] - points[Q - 1];

            // Calculate the rise from Q to R
            int riseFromQToR = points[R - 1] - points[Q - 1];

            // Determine the depth of the pit as the smaller of the drop and the rise
            int depth = Math.Min(dropFromPToQ, riseFromQToR);

            // Update maxDepth to be the maximum depth found so far
            maxDepth = Math.Max(maxDepth, depth);
        }

        return maxDepth;
    }
}
