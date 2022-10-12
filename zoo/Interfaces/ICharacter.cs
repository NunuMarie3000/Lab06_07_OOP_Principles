namespace Zoo.Interfaces 
{
  public interface ICharacter
  {
    string whatAmIFrom { get; set; }
    string faveReference { get; set; }
    void CharacterIntro();
  }
}