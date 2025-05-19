using System;
class dayPrinter{
    static void Main(){
        Console.WriteLine("Day printing console \n");
        Console.Write("Enter the number to print the day \n");
        int day = Convert.ToInt32(Console.ReadLine());
        switch(day){
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Teusday");
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
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Not a valid input!");
                break;
        }
    }
}