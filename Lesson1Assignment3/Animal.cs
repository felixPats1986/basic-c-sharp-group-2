namespace Assignment3;

public abstract class Animal
{
    public string name { get; set; }

    public void SetName(string name)
    {
        this.name = name;
    }
    
    public string GetName()
    {
        return name;
    }

    public abstract void Eat();
}