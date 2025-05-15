using System;
class Calculator
{
    static void Main()
    {
        Console.Write("Enter the first operand \n");
        double op1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the operator( + , - , / , * ) \n");
        char op = Convert.ToChar(Console.ReadLine());
        
        Console.Write("Enter the second operand \n");
        double op2 = Convert.ToDouble(Console.ReadLine());
        
        double result = 0;
        
        switch(op)
        {
            case '+':
            result = op1 + op2;
            break;
            
            case '-':
            result = op1 - op2;
            break;
            
            case '*':
            result = op1 * op2;
            break;
            
            case '/':
            result = op1 / op2;
            break;
        }
        
        Console.WriteLine("The result of the operation is : " + result);
    }
}