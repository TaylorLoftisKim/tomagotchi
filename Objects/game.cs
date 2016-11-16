using System.Collections.Generic;

namespace Pets.Objects
{
  public class Pet{
    private string _name;
    private int _food;
    private int _attention;
    private int _sleep;
    private int _dead;
    private static List<Pet> _instances = new List<Pet> {};

    public Pet (string newName, int newFood=10, int newAttention=10, int newSleep=10, int newDead=10)
    {
      _name = newName;
      _food = newFood;
      _attention = newAttention;
      _sleep = newSleep;
      _dead = newDead;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetFood()
    {
      return _food;
    }
    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public int GetAttention()
    {
      return _attention;
    }
    public void SetAttention(int newAttention)
    {
      _attention = newAttention;
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public void SetSleep(int newSleep)
    {
      _sleep = newSleep;
    }
    public int GetDead()
    {
      return _dead;
    }
    public void SetDead(int newDead)
    {
    _dead = newDead;
    }

    public static List<Pet> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
