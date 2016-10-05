using System;

public class Person
{
  private string name;
  private DateTime dob;
  private string emailAlias;
  private static string domain;

  public Person(string Name, DateTime dOB)
  {
    name = Name;
    dob = dOB;
  }

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

  public DateTime DOB 
  { 
    get
    {
      return dob;
    }
  }

  public string EmailAlias 
  {
    set
    {
     emailAlias = value;
    }
  }

  public static string Domain
  {
    get
    { 
      return domain;
    }
    set
    {
      domain = value;
    }
  }

  public string EmailAddress
  {
    get
    {
      return emailAlias + "@" + domain;
    }
  }
}

class ReadableAndWritable
{
  static void Main()
  {
    Person person = new Person("Steve", new DateTime(1972, 8, 22));

    person.EmailAlias = "Steve.S";
    Person.Domain = "AnotherCompany.com";

    Console.WriteLine("Name - " + person.Name);
    Console.WriteLine("DOB - " + person.DOB.ToShortDateString());
    Console.WriteLine("EMail Address - " + person.EmailAddress);
  }
}
