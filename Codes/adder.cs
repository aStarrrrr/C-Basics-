using System;
class adder{
    static void Main(){
        Console.Write("Enter the first operand - ");
        int op1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second second operand - ");
        int op2 = Convert.ToInt32(Console.ReadLine());
        int sum = op1 + op2;
        Console.WriteLine("The sum of these operands are - " +sum);
    }
}