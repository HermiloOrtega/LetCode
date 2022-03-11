// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/

// Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.
// After doing so, return the array.

// Example 1:
    // Input: arr = [17,18,5,4,6,1]
    // Output: [18,6,6,6,1,-1]
    // Explanation: 
    // - index 0 --> the greatest element to the right of index 0 is index 1 (18).
    // - index 1 --> the greatest element to the right of index 1 is index 4 (6).
    // - index 2 --> the greatest element to the right of index 2 is index 4 (6).
    // - index 3 --> the greatest element to the right of index 3 is index 4 (6).
    // - index 4 --> the greatest element to the right of index 4 is index 5 (1).
    // - index 5 --> there are no elements to the right of index 5, so we put -1.

// Example 2:
    // Input: arr = [400]
    // Output: [-1]
    // Explanation: There are no elements to the right of index 0.

// Constraints: 
    //     1 <= arr.length <= 104
    //     1 <= arr[i] <= 105

public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
        // arr.Lengtj < 2 
            // arr[0] = -1
            // return arr;
        
        // mv = 18
        //   i  < .Length - 1 
        // [17,  18,  5,  4,  6,  1] .Length
        //   mv = 0
        //       mv=j>mv?j+1:mv   | j=i+1 ; j < arr.Length ; i++
        //   i = mv
        // i[.Length-1] = -1
        
        if(arr.Length<2){
            arr[0] = -1;
            return arr;
        }
        
        int mv = 0; 
        for(int i = 0; i<arr.Length-1; i++){
            mv = 0;
            for(int j=i+1; j<arr.Length; j++){
                mv=(arr[j]>mv)?arr[j]:mv;
            }
            arr[i] = mv;
        }
        arr[arr.Length-1] = -1;
        
        return arr;
    }
}
