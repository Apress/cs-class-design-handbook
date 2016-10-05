// created on 12/23/2002 at 7:33 PM
using System;

public class Person
{
  private string name;

  public Person(string Name)
  { name = Name; }

  public string Name { get { return name; } }
}

public class Authors
{
  private Person[] persons = new Person[5];

  public Person this [int index]
  {
    get { return persons[index];  }
    set { persons[index] = value; }
  }
}

public class SingleIndexer
{
  static void Main()
  {
    Authors authors = new Authors();
    authors[0] = new Person("James");
    authors[1] = new Person("Roger");
    authors[2] = new Person("Ben");
    authors[3] = new Person("Richard");
    authors[4] = new Person("Teun");

    for(int i=0; i<5; i++)
      Console.WriteLine(authors[i].Name);
  }
} 
