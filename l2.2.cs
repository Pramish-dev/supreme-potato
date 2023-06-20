using System;
public class Stack
{
    private int[] items;
    private int top;

    public Stack(int size)
    {
        items = new int[size];
        top = -1;
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == items.Length - 1;
    }

    public void Push(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack Full!");
            return;
        }

        items[++top] = item;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack underflow");
            return -1;
        }

        return items[top--];
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }

        return items[top];
    }

    public static int Size(Stack stack)
    {
        return stack.top + 1;
    }

    // Method to reverse elements
     public static Stack Reverse(Stack stack)
     {
        // Create a temporary stack to hold reversed elements
        Stack temp = new Stack(stack.items.Length);

        while (!stack.IsEmpty())
        {
            // Pop an element from the original stack and push it onto the temporary stack
            temp.Push(stack.Pop());
        }

        return temp;
        
    }


    public static void Display(Stack stack)
    {
        if (stack.IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        Console.WriteLine("Stack elements:");
        for (int i = stack.top; i >= 0; i--)
        {
            Console.Write(stack.items[i]+" ");
        }
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Initialize a stack:");
        Stack stack = new Stack(10);
        Stack result = new Stack(10);
        Console.WriteLine("Input some elements onto the stack:");
        stack.Push(1);
        stack.Push(3);
        stack.Push(3);
        stack.Push(9);
        stack.Push(5);
        Stack.Display(stack);
        result = Stack.Reverse(stack);
        Console.WriteLine("\nReverse the elements of the said stack:");
        Stack.Display(result);
    }  
}