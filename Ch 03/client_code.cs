// created on 11/28/2002 at 5:47 PM
public class MathsClass
{
  public int Multiply(int a, int b)
  {
    return (a * b);
  }
}
public class ClientCode
{
  private void CallMultiply()
  {
    MathsClass mc = new MathsClass();
    mc.Multiply(21, 2);
  }
}
