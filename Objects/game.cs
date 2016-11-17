using System.Collections.Generic;

namespace Pets.Objects
{
  public class Pet{
    private string _name;
    private int _food;
    private int _attention;
    private int _sleep;
    private int _dead;
    private int _id;
    private static List<Pet> _instances = new List<Pet> {};

    public Pet (string newName, int newFood=10, int newAttention=10, int newSleep=10, int newDead=1)
    {
      _name = newName;
      _food = newFood;
      _attention = newAttention;
      _sleep = newSleep;
      _dead = newDead;
      _instances.Add(this);
      _id = _instances.Count;
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
    public int GetId()
    {
      return _id;
    }

    public static List<Pet> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static TimePass()
    {
      _food -= 2;
      _attention -= 3;
      _sleep -= 1;
    }
  }
}
