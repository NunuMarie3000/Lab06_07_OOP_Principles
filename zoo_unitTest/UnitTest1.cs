using Zoo.Interfaces;

namespace zoo_unitTest;

public class Zoo_UnitTest
{
  [Fact]
  public void WouldPenguinMakeAGoodPet_ShouldReturnFalse()
  {
    Penguin test = new Penguin("the zoo", "let me out the zoo", "testy", "fish");
    Assert.Equal(false, test.WouldMakeAGoodPet);
  }
  [Fact]
  public void doesLionHaveFur_ShouldReturnTrue()
  {
    Lion test = new Lion("the zoo", "let me out the zoo", "testy", "fish");
    Assert.Equal(true, test.hasFur);
  }
  [Fact]
  public void TypeOfAnimal_ShouldReturnKimodoDragon()
  {
    KimodoDragon test = new KimodoDragon("Kimmy", "people");
    Assert.Equal("kimodo dragon", test.TypeOfAnimal);
  }
  [Fact]
  public void getsHateBecauseOfBiblicalImplications_ShouldReturnTrue()
  {
    Anaconda test = new Anaconda("anna", "eggs");
    Assert.Equal(true, test.getsHateBecauseOfBiblicalImplications);
  }
  [Fact]
  public void WhatsMyName_ShouldReturnName()
  {
    Panda po = new Panda("Kung Foo Panda", "Skadoosh", "Po", "dumplings");
    Assert.Equal("Po", po.Name);
  }
  [Fact]
  public void WhatDoIEat_ShouldReturnFood()
  {
    Panda po = new Panda("Kung Foo Panda", "Skadoosh", "Po", "dumplings");
    Assert.Equal("dumplings", po.Food);
  }
  [Fact]
  public void eyesOfTheAngel_ShouldReturnEyesOfTheAngel()
  {
    KimodoDragon kimmy = new KimodoDragon("kimmy", "meat");

    string expected = "*sarah mclaughlin singing*\nIn the eeeeyes offf the AaAaangel...Hi, I'm Sarah McLaughlin and for just $15 dollars an hour, you can help save this endangered species...";

    string actual = kimmy.eyesOfTheAngel();

    Assert.Equal(expected, actual);
  }
  [Fact]
  public void isEndangered_ShouldReturnIsEndangered()
  {
    bool expected = false;
    Anaconda nicki = new Anaconda("Nicki", "bars");

    Assert.Equal(expected, nicki.isEndangered);
  }
  [Fact]
  public void faveReference_ShouldReturnFavReference()
  {
    Penguin skipper = new Penguin("Madagascar", "Kowalski! Go", "Skipper", "sushi");
    string expected = "Kowalski! Go";
    string actual = skipper.faveReference;
    
    Assert.Equal(expected, actual);
  }
  [Fact]
  public void leftInTheWorld_ShouldReturnIntLeftInTheWorld()
  {
    KimodoDragon kimmy = new KimodoDragon("kimmy", "meat");

    string expected = "Because humans keep destroying my home!!!";

    string actual = kimmy.whyEndangered();

    Assert.Equal(expected, actual);
  }
}