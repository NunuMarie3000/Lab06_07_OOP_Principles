namespace Zoo.Classes
{
  public class Lion : Mammal
  {
    public override string Name { get; set;}
    public override string Food { get; set; }
    public Lion(string name, string food)
    {
      Name = name;
      Food = food;
    }
    public override void Introduction()
    {
      Console.WriteLine($"Hello! My name is {Name}! I'm a {TypeOfAnimal} and I like to eat {Food}!");
    }
    public override string Sound { get; set; } = "roar";
    public override string TypeOfAnimal { get; set; } = "lion";

    public override bool WouldMakeAGoodPet { get; set; } = false;
    public override bool hasFur { get; set; } = true;
    public override string Color { get; set;} = "tan";
  }

  public class Panda : Mammal
  {
    public override string Name { get; set;}
    public override string Food { get; set; }
    public Panda(string name, string food)
    {
      Name = name;
      Food = food;
    }
    public override void Introduction()
    {
      Console.WriteLine($"Hello! My name is {Name}! I'm a {TypeOfAnimal} and I like to eat {Food}!");
    }
    public override string Sound { get; set; } = null;
    public override string TypeOfAnimal { get; set; } = "panda";

    public override bool WouldMakeAGoodPet { get; set; } = false;
    public override bool hasFur { get; set; } = true;
    public override string Color { get; set;} = "black and white";
  } 

  
}