// this is where i'll make my first class, the one my others will extend
namespace Zoo.Classes
{
  public abstract class Animal
  {
    // an animal has what?
    public abstract string Name { get; set; }
    public abstract void Introduction ();
    public abstract string TypeOfAnimal { get; set; }
    public abstract string Food { get; set; }
    public abstract bool WouldMakeAGoodPet { get; set; }
    public abstract void WhereDoILive();
    public virtual void WhatDoesTheAnimalSay()
    {
      Console.WriteLine($"I like to say {Sound}! {Sound}, {Sound}, {Sound}!");
    }
    public abstract string Sound { get; set; }
  }
}