namespace Zoo.Classes
{
  public class Penguin : Animal
  {
    public override string Food { get; set; }
    public override string Name { get; set; }
    public Penguin(string name, string food)
    {
      Name = name;
      Food = food;
    }
    public override void Introduction()
    {
      Console.WriteLine($"Hello! My name is {Name}! I'm a {TypeOfAnimal} and I like to eat {Food}!");
    }
    public override string TypeOfAnimal { get; set; } = "penguin";
    public override bool WouldMakeAGoodPet { get; set; } = false;
    public override string Sound { get; set; } = "eek";
    public override void WhereDoILive()
    {
      Console.WriteLine("I live at the zoo :(\nFree me!");
    }
  }
}