// Mammal class will extend animal
namespace Zoo.Classes
{
  public abstract class Mammal : Animal
  {
    
    public virtual bool hasFur { get; set; } = true;
    public override void WhereDoILive()
    {
      Console.WriteLine("I live at the zoo :(\nFree me!");
    }
    public abstract string Color { get; set; }
    
  }
}