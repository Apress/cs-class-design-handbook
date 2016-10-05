// created on 12/24/2002 at 10:29 AM

using System;
using System.Collections;


public class Person
{
  private string name;

  public Person(string Name)
  { name = Name; }

  public string Name { get { return name; } }
}

public class Authors
{
  private ArrayList persons = new ArrayList();

  public Person this [int index]
  {
    get { return ((Person)persons[index]); }
    set { persons[index] = value;          }
  }

  public void Add(Person person)
  { persons.Add(person); }

  public void Remove(Person person)
  { persons.Remove(person); }

  public int Count { get { return persons.Count; } }
}


public class SingleIndexer
{
  static void Main()
  {
    Authors authors = new Authors();
    authors.Add(new Person("James"));
    authors.Add(new Person("Roger"));
    authors.Add(new Person("Ben"));
    authors.Add(new Person("Richard"));
    authors.Add(new Person("Teun"));

    for(int i=0; i<authors.Count; i++)
      Console.WriteLine(authors[i].Name);
  }
} 
