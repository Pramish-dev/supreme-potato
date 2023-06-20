using System;
public class Lab1{
    public static void Main(){
        int day_count;
        Console.Write("enter any number from 1 to 7 to know day: ");
        day_count= Convert.ToInt32(Console.ReadLine());
        switch(day_count)
        {
            case 1:
               Console.WriteLine("Sunday");
               break;
            case 2:
               Console.WriteLine("Monday");
               break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                 Console.WriteLine("Wednesday");
                 break;
            case 5:
                 Console.WriteLine("Thursday");
                 break;
            case 6:
                 Console.WriteLine("Friday");
                 break;
            case 7:
                 Console.WriteLine("Sturday");
                 break;
            default:
               Console.WriteLine("Please enter number from 1 to 7 only ");
               break;

        }
    }
}