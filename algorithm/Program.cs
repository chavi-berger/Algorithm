namespace algorithm
{
    internal class Program
    {
        public static int Q1(int[] nums)
        {
            if (nums == null || nums.Length == 0) 
                return 0;
            int maxSum = nums[0];
            int currentSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {              
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }

        public static int Q3(LinkedList<int> list)
        {
            if (list == null || list.Count == 0)
                return 0;
            List<int> tails = new List<int>();
            foreach (int val in list)
            {
                int idx = tails.BinarySearch(val);
                if (idx >= 0)
                    while (idx < tails.Count && tails[idx] == val)
                        idx++;
                else
                    idx = ~idx;
                if (idx == tails.Count)
                    tails.Add(val);
                else
                    tails[idx] = val;
            }
            return list.Count - tails.Count;
        }

        public static int Q4(int[] arr,int X)
        {
            int count = 0, currentSum = 0;
            Dictionary<int, int> prefixSums = new Dictionary<int, int>();
            prefixSums.Add(0, 1);
            foreach (int num in arr)
            {
                currentSum += num;                
                if (prefixSums.ContainsKey(currentSum - X))                
                    count += prefixSums[currentSum - X];                               
                if (prefixSums.ContainsKey(currentSum))               
                    prefixSums[currentSum]++;                
                else                
                    prefixSums.Add(currentSum, 1);                
            }
            return count;
        }

        //Q5
        //Result= max(N - T, N - S)+1

        // Explanation: We want to find the worst-case scenario, which is picking all the eggs
        // that might be missing one of the items (either missing a toy or missing a sticker).
        // To ensure we have both, we take the maximum between the number of eggs without  a toy (N-T) and the number of eggs without a sticker (N-S).
        // We then add 1 to that number to guarantee that the next egg must contain
        // the missing type.
        static void Main(string[] args)
        {
           
        }
    }
}
