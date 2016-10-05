// created on 12/24/2002 at 10:41 AM
using System;

namespace indexer_single_cs
{
  public struct Person
  {
    string name;

    public Person(string Name)
    {
      name = Name;
    }

    public string Name { get { return name; } }
  }

  public class Authors
  {
    Person[] persons = new Person[5];

    [System.Runtime.CompilerServices.IndexerName("Person")]
    public Person this [int index]
    {
      get { return persons[index];  }
      set { persons[index] = value; }
    }
  }
}
public class SingleIndexer
{
  static void Main()
  {
  }
} 

