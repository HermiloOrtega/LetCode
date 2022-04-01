# What is an Array
- An Array is a collection of items. The items could be integers, strings, DVDs, games, books—anything really. The items are stored in neighboring (contiguous) memory locations. Because they're stored together, checking through the entire collection of items is straightforward.

- The two most primitive Array operations are writing elements into them, and reading elements from them. All other Array operations are built on top of these two primitive operations.

- The Array's capacity must be decided when the Array is created. The capacity cannot be changed later. , The other definition of length is the number of items, currently in the Array. 

<br>

# Inserting Items into an Array
- Basic Array Operations: Insert, Delete, Search

<br>

### Inserting at the End of an Array
- we know the index of the last element of the Array, as we've kept track of it in our length variable. All we need to do for inserting an element at the end is to assign the new element to one index past the current last element.

```java
// Declare an integer array of 6 elements
int[] intArray = new int[6];
int length = 0;

// Add 3 elements to the Array
for (int i = 0; i < 3; i++) {
    intArray[length] = i;
    length++;
}

// Insert a new element at the end of the Array. Again,
// it's important to ensure that there is enough space
// in the array for inserting a new element.
intArray[length] = 10;
length++;
```
<br>

### Inserting at the Start of an Array
- we'll need to shift all other elements in the Array to the right by one index to create space for the new element. 

- In terms of time complexity analysis, this is a linear time complexity: O(N)O(N)O(N), where NNN is the length of the Array.

```java
// First, we will have to create space for a new element.
// We do that by shifting each element one index to the right.
// This will firstly move the element at index 3, then 2, then 1, then finally 0.
// We need to go backwards to avoid overwriting any elements.
for (int i = 3; i >= 0; i--) {
    intArray[i + 1] = intArray[i];
}

// Now that we have created space for the new element,
// we can insert it at the beginning.
intArray[0] = 20;
```

<br>

### Inserting anywhere in the Array
- we first need to shift all the elements from that index onwards one position to the right. Once the space is created for the new element, we proceed with the insertion. 

```java
// Say we want to insert the element at index 2.
// First, we will have to create space for the new element.
for (int i = 4; i >= 2; i--)
{
    // Shift each element one position to the right.
    intArray[i + 1] = intArray[i];
}

// Now that we have created space for the new element,
// we can insert it at the required index.
intArray[2] = 30;
```

<br>

# Deleting items from an Array

### Deleting from the End of an Array
- we don't actually need to free up any space. Simply overwriting the value at a certain index deletes the element at that index.

```java
// Deletion from the end is as simple as reducing the length
// of the array by 1.
length--;
```

### Deleting from the Start of an Array
- we will shift the element at index 1 one step to the left. 

```java
// Starting at index 1, we shift each element one position
// to the left.
for (int i = 1; i < length; i++) {
    // Shift each element one position to the left
    int_array[i - 1] = int_array[i];
}

// Note that it's important to reduce the length of the array by 1.
// Otherwise, we'll lose consistency of the size. This length
// variable is the only thing controlling where new elements might
// get added.
length--;
```

### Deleting from anywhere in the Array
- the empty space created by the deleted item will need to be filled. Each of the elements to the right of the index we're deleting at will get shifted to the left by one.

```java
// Say we want to delete the element at index 1
for (int i = 2; i < length; i++) {
    // Shift each element one position to the left
    int_array[i - 1] = int_array[i];
}

// Again, the length needs to be consistent with the current
// state of the array.
length--;
```

<br>

# Searching for items in an Array
### Linear Search
- we can check every element in the Array. We continue checking elements until we find the element we're looking for, or we reach the end of the Array.

```java
public class ArraySearch {
    public static void main(String args[]) {
        // Declare a new array of 6 elements
        int[] array = new int[6];

        // Variable to keep track of the length of the array
        int length = 0;

        // Iterate through the 6 indexes of the Array.
        for (int i = 0; i < 6; i++) {
            // Add a new element and increment the length as well
            array[length++] = i;
        }

        // Print out the results of searching for 4 and 30.
        System.out.println("Does the array contain the element 4? - " + ArraySearch.linearSearch(array, length, 4));
        System.out.println("Does the array contain the element 30? - " + ArraySearch.linearSearch(array, length, 30));
        
        // Does the array contain the element 4? - true
        // Does the array contain the element 30? - false
    }
    public static boolean linearSearch(int[] array, int length, int element) {
        // Check for edge cases
        if (array == null || length == 0) {
            return false;
        }

        // Check each element starting from the first one
        for (int i = 0; i < length; i++) {
            // We found the element at index i, so return true.
            if (array[i] == element) {
                return true;
            }
        }

        // We didn't find the element in the array.
        return false;
    }
}
```

### Binary Search 
- If the elements in the Array are in sorted order, then we can use binary search.

- we repeatedly look at the middle element in the Array, and determine whether the element we're looking for must be to the left, or to the right. Each time we do this, we're able to halve the number of elements we still need to search, making binary search a lot faster than linear search!

- The downside of binary search though is that it only works if the data is sorted.

<br>

# In-Place Operations
- In-place Array operations help to reduce space complexity, and so are a class of techniques that pretty much everybody encounters regularly in interviews.

- An important difference for in-place vs not in-place is that in-place modifies the input Array. This means that other functions can no longer access the original data, because it has been overwritten.

```java
public int[] squareEven(int[] array, int length) {
  // Check for edge cases.
  if (array == null) {
    return array;
  }
  // Iterate through the original array.
  for(int i = 0; i < length; i++) {
    // If the index is an even number, then we need to square the element
    // and replace the original value in the Array.
    if (i % 2 == 0) {
      array[i] *= array[i];
    }
    // Notice how we don't need to do *anything* for the odd indexes? :-)
  }
  // We just return the original array. Some problems on leetcode require you
  // to return it, and other's dont.
  return array;
}
```

- Implementing this requires the use of the two-pointer technique. This is where we iterate over the Array in two different places at the same time.

    Read all the elements like we did before, to identify the duplicates. We call this our readPointer.
    Keep track of the next position in the front to write the next unique element we've found. We call this our writePointer.

```java
public int removeDuplicates(int[] nums) {
        
  // Check for edge cases.
  if (nums == null) {
      return 0;
  }
  
  // Use the two pointer technique to remove the duplicates in-place.
  // The first element shouldn't be touched; it's already in its correct place.
  int writePointer = 1;
  // Go through each element in the Array.
  for (int readPointer = 1; readPointer < nums.length; readPointer++) {
      // If the current element we're reading is *different* to the previous
      // element...
      if (nums[readPointer] != nums[readPointer - 1]) {
          // Copy it into the next position at the front, tracked by writePointer.
          nums[writePointer] = nums[readPointer];
          // And we need to now increment writePointer, because the next element
          // should be written one space over.
          writePointer++;
      }
  }
  
  // This turns out to be the correct length value.
  return writePointer;
}
```