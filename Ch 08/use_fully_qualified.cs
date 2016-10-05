public class UseFullyQualified
{
    public static void Main()
    {
        MyNamespace1.MyClassA a = new MyNamespace1.MyClassA();
        MyNamespace1.MyNestedNamespace1.MyClassB b = 
            new MyNamespace1.MyNestedNamespace1.MyClassB();
        MyNamespace2.MyNestedNamespace2.MyClassC c = 
            new MyNamespace2.MyNestedNamespace2.MyClassC();
    }
}
