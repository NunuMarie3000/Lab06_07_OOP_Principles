using Zoo.Interfaces;

namespace Zoo.Classes
{
  public class Penguin : Animal, ICharacter
  {
    public override bool isEndangered { get; set; } = false;
    public override string Food { get; set; }
    public override string Name { get; set; }
    public Penguin(string from, string quote, string name, string food)
    {
      whatAmIFrom = from;
      faveReference = quote;
      Name = name;
      Food = food;
    }
    public string whatAmIFrom { get; set; }
    public string faveReference { get; set; }
    public void CharacterIntro()
    {
      Console.WriteLine($"Hey, I'm {Name} the penguin from {whatAmIFrom}.\n{faveReference}!");
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