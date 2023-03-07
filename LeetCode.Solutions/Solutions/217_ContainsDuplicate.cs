namespace LeetCode.Solutions.Solutions;

public class ContainsDuplicate
{
    public bool ContainsDuplicateNum(int[] nums)
    {
        // Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        HashSet<int> dupes = new();
        foreach (int num in nums)
        {
            if (dupes.Contains(num)) return true;

            dupes.Add(num);
        }

        return false;
    }
}