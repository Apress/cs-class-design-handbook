// created on 12/24/2002 at 10:56 AM
using System;
using System.Collections;

public class Person
{
  string name;
  short age;

  public Person(string name, short age)
  {
    this.name = name;
    this.age = age;
  }

  public string Name
  {
    get { return name;  }
    set { name = value; }
  }

  public short Age
  {
    get { return age;  }
    set { age = value; }
  }
}

public class Authors
{
  private ArrayList persons = new ArrayList();

  public Person this [int index]
  { get { return ((Person)persons[index]); } }

  public Person this [string name]
  {
    get
    {
      foreach(Person person in persons)
      {
        if (person.Name == name)
          return person;
      }
      return (Person)persons[0];
    }
  }

  public void Add(Person person)
  { persons.Add(person); }

  public void Remove(Person person)
  { persons.Remove(person); }

  public int Count { get { return persons.Count; } }
}

public class OverloadedIndexer
{
  static void Main()
  {
    Authors authors = new Authors();
    authors.Add(new Person("James", 31));
    authors.Add(new Person("Roger", 21));
    authors.Add(new Person("Ben", 21));
    authors.Add(new Person("Richard", 21));
    authors.Add(new Person("Teun", 21));

    Person author = authors["James"];
    Console.WriteLine(author.Name + " - " + author.Age.ToString());
    author.Age = 21;
    author = authors["James"];
    Console.WriteLine(author.Name + " - " + author.Age.ToString());
  }
}
