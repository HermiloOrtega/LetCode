// https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
/*

Given an array nums of integers, return how many of them contain an even number of digits.

 

Example 1:

Input: nums = [12,345,2,6,7896]
Output: 2
Explanation: 
12 contains 2 digits (even number of digits). 
345 contains 3 digits (odd number of digits). 
2 contains 1 digit (odd number of digits). 
6 contains 1 digit (odd number of digits). 
7896 contains 4 digits (even number of digits). 
Therefore only 12 and 7896 contain an even number of digits.

Example 2:

Input: nums = [555,901,482,1771]
Output: 1 
Explanation: 
Only 1771 contains an even number of digits.

 

Constraints:

    1 <= nums.length <= 500
    1 <= nums[i] <= 105



*/
public class Solution {
    public int FindNumbers(int[] nums) {
        int max = 0;
        for(int i = 0; i< nums.Length; i++){
 if(divide(nums[i],true) == true) max++;
        }
        return max;
    }
    public bool divide(int num, bool result){
        bool res = result;
        if(num < 10) return false;
        else if((num/10)<10) return res;
        else res = divide((num/10),!res);
        
        return res;
    }
}