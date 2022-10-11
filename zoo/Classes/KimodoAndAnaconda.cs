namespace Zoo.Classes
{
  public class KimodoDragon : Reptile
  {
    public override string Name { get; set; }
    public override string Food { get; set; }
    public KimodoDragon(string name, string eats)
    {
      Name = name;
      Food = eats;
    }
    public override string TypeOfAnimal { get; set; } = "kimodo dragon";
    public override bool WouldMakeAGoodPet { get; set; } = false;
    public override bool hasLegs { get; set; } = true;
    public override bool getsHateBecauseOfBiblicalImplications { get; set; } = false;
    public override void Introduction()
    {
      Console.WriteLine($"Hello! My name is {Name}! I'm a {TypeOfAnimal} and I like to eat {Food}!");
    }
  }

  public class Anaconda : Reptile
  {
    public override string Name { get; set; }
    public override string Food { get; set; }
    public Anaconda(string name, string eats)
    {
      Name = name;
      Food = eats;
    }
    public override string TypeOfAnimal { get; set; } = "anaconda";
    public override bool WouldMakeAGoodPet { get; set; } = false;
    public override bool hasLegs { get; set; } = false;
    public override bool getsHateBecauseOfBiblicalImplications { get; set; } = true;
    public override void Introduction()
    {
      Console.WriteLine($"Hello! My name is {Name}! I'm a {TypeOfAnimal} and I like to eat {Food}!");
    }
  }
}