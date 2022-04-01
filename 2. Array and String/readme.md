# Introductions to Aray
- An array is a basic data structure to store a collection of elements sequentially. But elements can be accessed randomly since each element in the array can be identified by an array index.

- An array can have one or more dimensions.

- an array has a fixed capacity and we need to specify the size of the array when we initialize it.

<br>

# Introduction to 2D Array
- a two-dimensional array also consists of a sequence of elements. But the elements can be laid out in a rectangular grid rather than a line.


```java
// "static void main" must be defined in a public class.
public class Main {
    private static void printArray(int[][] a) {
        for (int i = 0; i < a.length; ++i) {
            System.out.println(a[i]);
        }
        for (int i = 0; i < a.length; ++i) {
            for (int j = 0; a[i] != null && j < a[i].length; ++j) {
                System.out.print(a[i][j] + " ");
            }
            System.out.println();
        }
    }
    public static void main(String[] args) {
        System.out.println("Example I:");
        int[][] a = new int[2][5];
        printArray(a);
        System.out.println("Example II:");
        int[][] b = new int[2][];
        printArray(b);
        System.out.println("Example III:");
        b[0] = new int[3];
        b[1] = new int[5];
        printArray(b);
    }
}
```

### Dyamic 2D Array
- Similar to the one-dimensional dynamic array, we can also define a dynamic two-dimensional array. Actually, it can be just a nested dynamic array. You can try it out by yourself.

<br>

# Introduction to String
- A string is actually an array of unicode characters.

### Compare Function
- Can we use "==" to compare two strings?
- Does the language support operator overloading?

```java
// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        // initialize
        String s1 = "Hello World";
            System.out.println("s1 is \"" + s1 + "\"");
        String s2 = s1;
            System.out.println("s2 is another reference to s1.");
        String s3 = new String(s1);
            System.out.println("s3 is a copy of s1.");
        // compare using '=='
            System.out.println("Compared by '==':");
        // true since string is immutable and s1 is binded to "Hello World"
            System.out.println("s1 and \"Hello World\": " + (s1 == "Hello World"));
        // true since s1 and s2 is the reference of the same object
            System.out.println("s1 and s2: " + (s1 == s2));
        // false since s3 is refered to another new object
            System.out.println("s1 and s3: " + (s1 == s3));
        // compare using 'equals'
            System.out.println("Compared by 'equals':");
            System.out.println("s1 and \"Hello World\": " + s1.equals("Hello World"));
            System.out.println("s1 and s2: " + s1.equals(s2));
            System.out.println("s1 and s3: " + s1.equals(s3));
        // compare using 'compareTo'
            System.out.println("Compared by 'compareTo':");
            System.out.println("s1 and \"Hello World\": " + (s1.compareTo("Hello World") == 0));
            System.out.println("s1 and s2: " + (s1.compareTo(s2) == 0));
            System.out.println("s1 and s3: " + (s1.compareTo(s3) == 0));
    }
}
```

### Immuable or Mutable
- Immutable means that you can't change the content of the string once it's initialized
- You can determinate if the string is mutable or immutable by testing the modification operation

```java
// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        String s1 = "Hello World";
        s1[5] = ',';
        System.out.println(s1);
    }
}
```
- If you want your string to be mutable, there are some substitutions:
1. If you did want your string to be mutable, you can convert it to a char array.

```java
// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        String s = "Hello World";
        char[] str = s.toCharArray();
        str[5] = ',';
        System.out.println(str);
    }
}
```

2. If you have to concatenate strings often, it will be better to use some other data structures like StringBuilder. The below code runs in O(n) complexity

```java
// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        int n = 10000;
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < n; i++) {
            str.append("hello");
        }
        String s = str.toString();
    }
}
```

### Extra Operations
```java
// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        String s1 = "Hello World";
        // 1. concatenate
            s1 += "!";
            System.out.println(s1);
        // 2. find
            System.out.println("The position of first 'o' is: " + s1.indexOf('o'));
            System.out.println("The position of last 'o' is: " + s1.lastIndexOf('o'));
        // 3. get substring
            System.out.println(s1.substring(6, 11));
    }
}
```

<br>

# Two-Pointer Technique
- 

<br>

```java

```
