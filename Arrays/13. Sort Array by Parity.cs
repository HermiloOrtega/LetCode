// https://leetcode.com/problems/sort-array-by-parity/

// Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
// Return any array that satisfies this condition.

// Example 1:
    // Input: nums = [3,1,2,4]
    // Output: [2,4,3,1]
    // Explanation: The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.

// Example 2:
    // Input: nums = [0]
    // Output: [0]

// Constraints:
    //     1 <= nums.length <= 5000
    //     0 <= nums[i] <= 5000

public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        //                    i%2==0 
        // [2  ,  4  |  3  ,  1  ]
        //              p
        
        //                    i%2==0 
        // [4  ,  2  ,  3  ,  1  ]
        //        p
        
        int p = 0;
        for(int i=0; i<nums.Length; i++){
            if(nums[i]%2==0){
                int backup = nums[p];
                nums[p] = nums[i];
                nums[i] = backup;
                p++;
            }
        }
        return nums;
    }
}