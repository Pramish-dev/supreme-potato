using System;
public class Lab2{
    public static void Main()
    {
        Console.WriteLine("To print integers of array: ");
        int n;
        Console.WriteLine("Enter Value for n: ");
        n = Convert.ToInt32(Console.ReadLine());
        int [] arr= new int[n];
        Console.WriteLine("\n\n");
        int i;
        for(i=0; i<n;i++){
            Console.Write("element - {0} : ",i);
              arr[i] = Convert.ToInt32(Console.ReadLine());  
        }
         for(i=0; i<n;i++){
            Console.WriteLine("Numbers are: \n",arr[i]);
            Console.WriteLine("\n");
            }}}
        