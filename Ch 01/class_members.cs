// class_members.cs

class MyClass
{
    // field (usually private, for encapsulation)
    private int aField;

    // property (usually public, for ease of use)
    public int aProperty
    {
        get { return aField; }
        set { aField = value; }
    }

    // constant (class-wide, read-only field)
    public const int aConstant = 43;

    // delegate (defines a method signature)
    public delegate void ADelegate(int aParameter);

    // event (to alert event receiver objects)
    public event ADelegate AnEvent;

    // method
    public void AMethod()
    {
        // method implementation code
    }

    // instance constructor (to initialize new objects)
    public MyClass(int aValue)
    {
        aField = aValue;
    }

    // destructor method (to tidy up unmanaged resources)
    ~MyClass()
    {
        // finalization code
    }

    // nested class definition
    private class aNestedClass
    {
        // class definition
    }
}
