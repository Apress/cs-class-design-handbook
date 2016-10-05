using System;

public class StringClass
{
    public static void Main()
    {
        // initialize at declaration
        string[] chapters = {"Managed heap", "Array handling", 
                             "Reference types", "Year 2000"};

        // initialize by element
        string[] sections = new string[8];
        sections[0] = "Value types";
        sections[1] = "Language features";
        sections[2] = "Implementing interfaces";

        // concatenate strings
        sections[3] = "User-defined " + sections[0];

        // copy elements between arrays
        chapters.CopyTo(sections, 4);

        // partial string sort
        Array.Sort(sections, 0, 4);

      // enumerate array
        foreach (string s in sections)

        {
            Console.WriteLine(s);
        }
    }
}
