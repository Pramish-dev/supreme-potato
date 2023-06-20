using System;
public class Lab1{
    public static void Main(){
        int num;
        Console.Write("Check whether the given number is even or odd: ");
        Console.Write("\n\n");
        Console.Write("Input an integer: ");
        num= Convert.ToInt32(Console.ReadLine());
        if(num%2==0){
            Console.Write("Number is Even");
        }
        else{
            Console.Write("Number is odd");
        }
    }
}