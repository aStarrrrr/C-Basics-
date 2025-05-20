using System;

class Dummy{
    public virtual void Printing() => Console.WriteLine("Iam Abhinand Shaji");
}

class CBI:Dummy{
    public override void Printing() => Console.WriteLine("Iam Astar");
}

class Processing{
    public static void Main(string[] args){
        CBI dm = new CBI();
        dm.Printing();
    }
}