using System;
public class Lab1{
    public static void main()
    {
        int num;
        Console.Write("Check whether the given number is positive");
        Console.Write("\n\n");
        Console.Write("Input an integer: ");
        num= Convert.ToInt32(Console.ReadLine());
        if(num>=0){
            Console.WriteLine("{0} is a positive number",num);
        }
    }
}