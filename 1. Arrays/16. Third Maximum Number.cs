// https://leetcode.com/problems/third-maximum-number/
/*
Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

Example 1:
    Input: nums = [3,2,1]
    Output: 1
    Explanation:
    The first distinct maximum is 3.
    The second distinct maximum is 2.
    The third distinct maximum is 1.

Example 2:
    Input: nums = [1,2]
    Output: 2
    Explanation:
    The first distinct maximum is 2.
    The second distinct maximum is 1.
    The third distinct maximum does not exist, so the maximum (2) is returned instead.

Example 3:
    Input: nums = [2,2,3,1]
    Output: 1
    Explanation:
    The first distinct maximum is 3.
    The second distinct maximum is 2 (both 2's are counted together since they have the same value).
    The third distinct maximum is 1.

Constraints:
    1 <= nums.length <= 104
    -231 <= nums[i] <= 231 - 1

Follow up: Can you find an O(n) solution?
*/
public class Solution {
    public int ThirdMax(int[] nums) {
        //    7 > fm = 5
        //      > sm = 3
        //      > tm = 2
        //        fm = (nums[i]>=fm) ? nums[i] : 
        //             sm = (nums[i]>=sm) ? nums[i] : 
        //                  tm = (nums[i]>=tm) ? nums[i] : continue; 
        //                         nums[i]
        // [  5  ,  3  ,  1  ,  2  ,  7  ,  1  ]
        
        // int fm=0, sm=0, tm=0;
        // for(int i=0; i<nums.Length; i++){
        //     if((nums[i] != fm)&& (nums[i] != sm) && (nums[i] != tm)){
        //              if(nums[i]>=fm) {
        //              tm = sm;
        //              sm = fm;
        //              fm = nums[i];
        //          }
        //     else if(nums[i]>=sm) {
        //             tm = sm;
        //             sm = nums[i];  
        //          }
        //     else if(nums[i]>=tm) {
        //              tm = nums[i];
        //          }
        //     }
        // }
        // if(tm==0) tm=fm;
        // return tm;
        
        // [1,2,-2147483648]
        //                
        // [-2147483648,1,2]
        
        int fm=0,sm=0,tm=0;
        bool fmb=false,smb=false,tmb=false;
        Array.Sort(nums);
        for(int i=nums.Length-1; i>=0; i--){
            if(tmb==true){
                break;
            }else if(fmb==false){
                fm=nums[i];
                fmb=true;
            }else if(smb==false){
                if(nums[i]!=fm){
                    sm=nums[i];
                    smb=true;
                }
            }else if(tmb==false){
                if(nums[i]!=sm){
                    tm=nums[i];  
                    tmb=true;
                }
            }
        }
        if(tm==0&&tmb==false) tm=fm;
        return tm;
    }
}