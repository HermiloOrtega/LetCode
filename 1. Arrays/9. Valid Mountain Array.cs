// https://leetcode.com/problems/valid-mountain-array
/*
Given an array of integers arr, return true if and only if it is a valid mountain array.
Recall that arr is a mountain array if and only if:
    arr.length >= 3
    There exists some i with 0 < i < arr.length - 1 such that:
        arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
        arr[i] > arr[i + 1] > ... > arr[arr.length - 1]

Example 1:
    Input: arr = [2,1]
    Output: false

Example 2:
    Input: arr = [3,5,5]
    Output: false

Example 3:
    Input: arr = [0,3,2,1]
    Output: true

Constraints:
    1 <= arr.length <= 104
    0 <= arr[i] <= 104


*/
public class Solution {
    public bool ValidMountainArray(int[] arr) {
        
        // if arr.Length < 3 ? false;
        
        // [2,  1] L=2 ? false
        
        //      c < l - 1
        // [3,  5,  5] l
        //          n
        // c == n ? false 
        // c < n ? continue : false;
        // true
        
        // up = true
        //          c < l - 1
        // [0,  3,  2,  1]  = l
        //              n < l
        // c == n ? false
        // up == true
            // c < n ? continue : 
                // up = false ;
        // up == false
            // c > n ? continue : false
        
        // up = true
        //  c < l - 1
        // [4,  3,  2,  1]  = l
        //      n < l
        // c == n ? false
        // up == true
            // c < n ? continue : 
                // if c == 0 : false
                // else : up = false ;
        // up == false
            // c > n ? continue : false
        
        // up = true
        //          c < l - 1
        // [1,  2,  3,  4]  = l
        //              n < l
        // c == n ? false
        // up == true
            // c < n ? continue : 
                // if c == 0 : false
                // else : up = false ;
        // up == false
            // c > n ? continue : false
        
        bool up = true;
        int l = arr.Length;
        
        if(l<3)return false;
        
        for(int i = 0; i < l-1; i++){
            if(arr[i]==arr[i+1]) return false;
            if(up == true){
                if(arr[i]<arr[i+1]) {
                    if((i+1)==(l-1)) return false;
                    else continue;
                }
                else{
                    if(i==0) return false;
                    else up = false;
                }
            }else{
                if(arr[i]>arr[i+1]) continue;
                else return false;
            }
        }
        return true;
    }
}