// created on 12/23/2002 at 5:18 PM
using System;
public class Person
{
  private string name;

  public string Name
  {
    get
    { 
    	return name;
    }
    set
    {
    	name = value;
    }
  }
}

public class SimpleScalarProperty
{
  static void Main()
  {
    Person person = new Person();
    person.Name = "James";

    Console.WriteLine(person.Name);
  	
  	
  }
}
