namespace zoo_unitTest;

public class Zoo_UnitTest
{
    [Fact]
    public void WouldPenguinMakeAGoodPet_ShouldReturnFalse()
    {
        Penguin test = new Penguin("testy", "bytes");
        Assert.Equal(false, test.WouldMakeAGoodPet);
    }
    [Fact]
    public void doesLionHaveFur_ShouldReturnTrue()
    {
        Lion test = new Lion("testy", "meat");
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
        Panda po = new Panda("Po", "dumplings");
        Assert.Equal("Po", po.Name);
    }
    [Fact]
    public void WhatDoIEat_ShouldReturnFood()
    {
        Panda po = new Panda("Po", "dumplings");
        Assert.Equal("dumplings", po.Food);
    }
}