using System;
public class Lab1{
    public static void Main()
    {
        int[] numbers={5,10,11,6,8,9};
        int maxNumbers= FindMaximumNumber(numbers);
        Console.WriteLine("The Maximum number is: "+maxNumber);
    }
     
     static int FindMaximumNumber(int[] numbers){
        int maxNumbers= numbers[0];
        for(int i=1;i<numbers.Length; i++){
            if (numbers[i]>maxNumbers)
            {
                maxNumbers = numbers[i];
            }
        }
        return maxNumbers;
     }}