// https://leetcode.com/problems/max-consecutive-ones/
/*

Given a binary array nums, return the maximum number of consecutive 1's in the array.

 

Example 1:

Input: nums = [1,1,0,1,1,1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.

Example 2:

Input: nums = [1,0,1,1,0,1]
Output: 2

 

Constraints:

    1 <= nums.length <= 105
    nums[i] is either 0 or 1.



*/
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int counter =0;
        int max = 0;
        for(int i= 0; i<nums.Length; i++){
            counter++;
            if(nums[i]==0) counter =0;
            max = (counter >= max) ? counter : max; 
        }
        return max;
    }
}