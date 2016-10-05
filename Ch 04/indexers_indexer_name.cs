// created on 12/23/2002 at 7:57 PM
// created on 12/23/2002 at 7:33 PM
using System;

namespace indexer_single_cs
{
public struct Person
{
  private string name;

  public Person(string Name)
  { name = Name; }

  public string Name { get { return name; } }
}

public class Authors
{
  private Person[] persons = new Person[5];
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
