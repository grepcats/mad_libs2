namespace MadLibs.Models
{
  public class WordVariables
  {
    private string _name;
    private string _adverb;
    private string _nouns;
    private string _vehicle;
    private string _animal;
    private string _nouns2;

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetAdverb()
    {
      return _adverb;
    }

    public void SetAdverb(string newAdverb)
    {
      _adverb = newAdverb;
    }

    public string GetNouns()
    {
      return _nouns;
    }

    public void SetNouns(string newNouns)
    {
      _nouns = newNouns;
    }

    // private string _vehicle;
    // private string _animal;
    // private string _noun;

    public string GetVehicle()
    {
      return _vehicle;
    }

    public void SetVehicle(string newVehicle)
    {
      _vehicle = newVehicle;
    }

    public string GetAnimal()
    {
      return _animal;
    }

    public void SetAnimal(string newAnimal)
    {
      _animal = newAnimal;
    }

    public string GetNouns2()
    {
      return _nouns2;
    }

    public void SetNouns2(string newNouns2)
    {
      _nouns2 = newNouns2;
    }
  }

}
