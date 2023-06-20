using System;
public class Lab1{
    public static void Main(){
        int num;
        Console.Write("Check whether the given number is even, odd or zero");
        Console.Write("\n\n");
        Console.Write("Input an integer: ");
        num= Convert.ToInt32(Console.ReadLine());
        if(num==0){
            Cosole.Write("Number is zero");
        }
        else if(num%2==0){
            Cosnole.Write("Number is even");
        }
        else{
            Console.Write("Number is odd");
        }
    }
}