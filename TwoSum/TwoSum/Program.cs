using System.Runtime.Versioning;

public class Solution
{
    public static void Main()
    {
        Solution solution = new Solution();
        int[] nums = { 3, 2, 4 };
        Console.WriteLine(solution.TwoSum(nums, 6));
    }
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i <= nums.Length; i++)
        {
            int aux = target - nums[i];
            int index = Array.IndexOf(nums, aux);
            if (index != -1 && index != i)
            {
                result[0] = i;
                result[1] = index;
                break;
            }
        }
        return result;
    }
}