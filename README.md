In C#, structures (also known as structs) are value types that can encapsulate related data members. They are similar to classes but have some key differences:

1. **Value Type**: Structs are value types, meaning they are stored on the stack (or inline when contained within another struct or class), unlike classes which are reference types and are stored on the heap.

2. **Lightweight**: Structs are typically used for small data structures that contain few data members. They are lightweight compared to classes, which makes them suitable for scenarios where performance is critical.

3. **No Inheritance**: Structs cannot inherit from other structs or classes, and they cannot be used as a base for other types. They also cannot inherit from interfaces but can implement them.

4. **No Default Constructor**: Structs do not have a default constructor (a constructor with no parameters) implicitly provided by the compiler. However, you can define your own constructors.

5. **Stack Allocation**: Since structs are value types and stored on the stack (or inline), they are not subject to garbage collection like classes. This can lead to performance benefits in certain scenarios.

Here's a simple example of a struct in C#:

```csharp
using System;

public struct Point
{
    public int X;
    public int Y;

    // Custom constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method to display the coordinates
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(10, 20);
        p1.Display(); // Output: X = 10, Y = 20

        // Since structs are value types, p2 will be a copy of p1
        Point p2 = p1;
        p2.X = 100; // Modify the copy
        p1.Display(); // Output: X = 10, Y = 20
        p2.Display(); // Output: X = 100, Y = 20
    }
}
```

In the example above, `Point` is a struct representing a 2D point with `X` and `Y` coordinates. It demonstrates how to define a custom constructor and a method within a struct, as well as how structs behave as value types when copied.
