using System;

[Flags]
enum Permit : byte
{
  Create = 0x01,
  Read   = 0x02,
  Update = 0x04,
  Delete = 0x08
}
class TestBitFlag
{
  static void Main()
  {
    Permit perm1 = Permit.Create;
    Console.WriteLine(perm1.ToString());
    Permit perm = Permit.Create | Permit.Read;
    Console.WriteLine(perm.ToString());
    perm |= Permit.Delete;
    Console.WriteLine(perm.ToString());
  }
}

