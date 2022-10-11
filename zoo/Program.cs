using Zoo.Classes;

namespace Zoo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("I'm building a zoo!");
      Lion leo = new Lion("Leo", "meat");
      leo.Introduction();
      leo.WhatDoesTheAnimalSay();

      Panda po = new Panda("Po", "dumplings");
      po.Introduction();
      Console.WriteLine(po.Color);
      Penguin kowalski = new Penguin("Kowalski", "sushi");
      kowalski.WhatDoesTheAnimalSay();
      kowalski.WhereDoILive();
    }
  }
}
