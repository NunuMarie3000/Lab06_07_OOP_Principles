using Zoo.Interfaces;

namespace Zoo.Classes
{
  public class Lion : Mammal, ICharacter
  {
    public string whatAmIFrom { get; set; }
    public string faveReference { get; set; }
    public void CharacterIntro()
    {
      Console.WriteLine($"{Sound}! I'm {Name} from {whatAmIFrom}\n{faveReference}!");
    }
    public override string Name { get; set; }
    public override string Food { get; set; }
    public Lion(string from, string quote, string name, string food)
    {
      Name = name;
      Food = food;
      whatAmIFrom = from;
      faveReference = quote;
    }
    public override void Introduction()
    {
      Console.WriteLine($"Hello! My name is {Name}! I'm a {TypeOfAnimal} and I like to eat {Food}!");
    }
    public override string Sound { get; set; } = "roar";
    public override string TypeOfAnimal { get; set; } = "lion";

    public override bool WouldMakeAGoodPet { get; set; } = false;
    public override bool hasFur { get; set; } = true;
    public override string Color { get; set; } = "tan";
    public override bool isEndangered { get; set; } = false;
  }

  public class Panda : Mammal, ICharacter, IEndangered
  {
    public override bool isEndangered { get; set; } = true;
    public string whatAmIFrom { get; set; }
    public string faveReference { get; set; }
    public void CharacterIntro()
    {
      Console.WriteLine($"{Sound}! I'm {Name} from {whatAmIFrom}\n{faveReference}!");
    }
    public override string Name { get; set; }
    public override string Food { get; set; }
    public Panda(string from, string quote, string name, string food)
    {
      Name = name;
      Food = food;
      whatAmIFrom = from;
      faveReference = quote;
    }
    public override void Introduction()
    {
      Console.WriteLine($"Hello! My name is {Name}! I'm a {TypeOfAnimal} and I like to eat {Food}!");
    }
    public override string Sound { get; set; } = null;
    public override string TypeOfAnimal { get; set; } = "panda";

    public override bool WouldMakeAGoodPet { get; set; } = false;
    public override bool hasFur { get; set; } = true;
    public override string Color { get; set; } = "black and white";
    public string eyesOfTheAngel()
    {
      return "*sarah mclaughlin singing*\nIn the eeeeyes offf the AaAaangel...Hi, I'm Sarah McLaughlin and for just $15 dollars an hour, you can help save this endangered species...";
    }
    public string whyEndangered()
    {
      return "Because humans keep destroying my home!!!";
    }
    public int leftInTheWorld { get; set; } = 1864;
  }
}