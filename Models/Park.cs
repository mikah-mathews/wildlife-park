namespace ParkTracker
{
  class Animals
  {
    private string _name;
    private int _age;
    private string _species;
    private string _sex;
    private string _diet;
    private string _environment;

    public Animals(string name, int age, string species, string sex, string diet, string environment)
    {
      _name = name;
      _age = age;
      _species = species;
      _sex = sex;
      _diet = diet;
      _environment = environment;
    }

    public string GetName()
    {
      return _name;
    }

    public int GetAge()
    {
      return _age;
    }

    public string GetSpecies()
    {
      return _species;
    }

    public string GetSex()
    {
      return _sex;
    }

    public string GetDiet()
    {
      return _diet;
    }

    public string GetEnvironment()
    {
      return _environment;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public void SetAge(int age)
    {
      _age = age;
    }

    public void SetSpecies(string species)
    {
      _species = species;
    }

    public void SetSex(string sex)
    {
      _sex = sex;
    }

    public void SetDiet(string diet)
    {
      _diet = diet;
    }

    public void SetEnvironment(string environment)
    {
      _environment = environment;
    }
  }
}