// https://leetcode.com/problems/move-zeroes/
/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
Note that you must do this in-place without making a copy of the array.

Example 1:
    Input: nums = [0,1,0,3,12]
    Output: [1,3,12,0,0]

Example 2:
    Input: nums = [0]
    Output: [0]

Constraints:
    1 <= nums.length <= 104
    -231 <= nums[i] <= 231 - 1

Follow up: Could you minimize the total number of operations done?
*/
public class Solution {
    public void MoveZeroes(int[] nums) {
        //  input
        //  [0,1,0,3,12]
        //  output
        //  [1,3,12,0,0]
        
        // Solution 1
        //          p = 3
        //  [1,3,12,3,12] = size
        //               c = 1; c < size; 
        //                 nums[c] > 0
        //                   nums[p] = nums[c] 
        //                   p++
        // [1,3,12,0,0]
        //         c=p ; c<size 
        //             nums[c] = 0

            int p = 0;
            for(int c = 0; c < nums.Length; c++){
                if(nums[c] != 0){
                    nums[p] = nums[c];
                    p++;
                }
            }
            if(p>0){
                for(int c = p; c < nums.Length; c++){
                    nums[c] = 0;
                }    
            }
        
        // Solution 2
        //          p=2
        //          j = 3
        //  [1,3,12,0,0] = size
        //   c=size-1; c>=0; c--;
        //     nums[c] == 0
        //       j=c; j<size-p; j++
        //         nums[j] == nums[j+1]
        //       p++
        
            // int p = 0; 
            // for(int c = nums.Length-1; c>=0; c--){
            //     if(nums[c]==0){
            //         for(int j = c; j<nums.Length-p; j++){
            //             nums[j] = nums[j+1];
            //         }
            //         p++;
            //     }
            // }
    }
}