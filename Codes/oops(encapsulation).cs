using System;
class Person
{
    private string name;

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return name;
    }
    
    public static void Main(string[] args){
        Person p = new Person();
        p.SetName("Abhi");
        Console.WriteLine(p.GetName());
    }
}
