public class Person
{
  private string m_name;

  public string Name
  {
    get
    {
      return m_name;
    }
    set
    {
      m_name = value;
    }
  }
}

public class SimpleScalarProperty
{
	static void Main(string[] args)
	{
		Person person = new Person();
 		person.Name = "James";
  		System.Console.WriteLine(person.Name);

	}
}
