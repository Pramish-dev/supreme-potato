using System;
using System.Collection.Generic;
class Lab2{
    static void Main(){
        Queue<int> queue= new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(5);
        queue.Enqueue(15);
        queue.Enqueue(7);
        queue.Enqueue(3);

        Console.WriteLine("Original Queue: ");
        PrintQueue(queue);

        int maxElement =FindMaximumElement(queue);
        Console.WriteLine("Maximum Element: "+ maxElement);
    }
    static int FindMaximumElement(Queue<int>queue)
    {
        int maxElement= int.MinValue;
        foreach(int item in queue)
        {
            if(item>maxElement)
            {
                maxElement=item;
            }
        }
        return maxElement;
    }
    static void PrintQueue(Queue<int> queue)
    {
        foreach(int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}