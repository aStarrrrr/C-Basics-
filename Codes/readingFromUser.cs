using System;
class readFromUser{
    static void Main(){
        Console.Write("Enter the name - ");
        string uname = Convert.ToString(Console.ReadLine());
        Console.WriteLine("My name is " +uname+ ".");
    }
}