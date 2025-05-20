using System;

class Bowler{
    public void Role ()=> Console.WriteLine("I can bowl");
}

class PaceBowler:Bowler{
    public void Type ()=> Console.WriteLine("I can bowl yorker");
}

class Printing{
    public static void Main(){
        Bowler Starc = new Bowler();
        Console.WriteLine("Iam Mitchel Starc, ");
        Starc.Role();
        PaceBowler Bumrah = new PaceBowler();
        Console.WriteLine("Iam Jasprit Bumrah, ");
        Bumrah.Role();
        Console.WriteLine("and ");
        Bumrah.Type();
    }
}