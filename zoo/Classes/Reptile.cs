namespace Zoo.Classes
{
  public abstract class Reptile : Animal
  {
    public override void WhereDoILive()
    {
      Console.WriteLine("I live at the zoo :(\nFree me!");
    }
    public abstract bool hasLegs { get; set; }
    public abstract bool getsHateBecauseOfBiblicalImplications { get; set; }
    public override void WhatDoesTheAnimalSay()
    {
      base.WhatDoesTheAnimalSay();
    }
    public override string Sound { get; set; } = "ssssthsss";

  }
}