namespace RemoveDuplicatesFromSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] nums = { 1, 1, 1,2, 3,3 };
           RemoveDuplicates(nums);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int i = 1;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i - 1] != nums[j])
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }
    }
}