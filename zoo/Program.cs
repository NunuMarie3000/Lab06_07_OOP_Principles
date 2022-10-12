using Zoo.Classes;

namespace Zoo
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("I'm building a zoo!");
      // Lion leo = new Lion("Leo", "meat");
      // leo.Introduction();
      // leo.WhatDoesTheAnimalSay();

      // Panda po = new Panda("Po", "dumplings");
      // po.Introduction();
      // Console.WriteLine(po.Color);
      // Penguin kowalski = new Penguin();
      // kowalski.Name = "Kowalski";
      // kowalski.Food = "sushi";
      // kowalski.WhatDoesTheAnimalSay();
      // kowalski.WhereDoILive();
      // Console.WriteLine(kowalski.Name);

      Penguin skipper = new Penguin("Madagascar", "Kowalski! Go", "Skipper", "sushi");
      skipper.CharacterIntro();

      Lion alex = new Lion("Madagascar", "I'm Alex...The Lion", "Alex", "steak");
      alex.CharacterIntro();
    }
  }
}
