REM created on 12/24/2002 at 3:30 PM
using System;

public class Person
{
  private string name;

  public Person(string Name)
  { 
    name = Name;
  }

  public string Name 
  {
    get { return name; }
  }
}

public class Authors
{
  private Person[] persons = new Person[5];

  public Person this [int index]
  {
    get { return persons[index]; }
    set { persons[index] = value; }
  }
}

Module Module1
  Sub Main()

    Dim i As Integer
    Dim authors As New Authors()

    authors.Item(0) = New Person("James")
    authors.Item(1) = New Person("Roger")
    authors.Item(2) = New Person("Ben")
    authors.Item(3) = New Person("Richard")
    authors.Item(4) = New Person("Teun")

    For i = 0 To 4
      Console.WriteLine(authors.Item(i).Name)
    Next i

  End Sub
End Module
