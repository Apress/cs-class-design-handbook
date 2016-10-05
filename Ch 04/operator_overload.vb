Imports System

Module CalculateBonus

  Sub Main()
    Dim emp As New Employee()
    Dim bonus As New Bonus()

    emp.Name = "James"
    emp.Salary = 8000

    bonus.Amount = 1000

    emp = Employee.op_Addition(emp, bonus)

    Console.WriteLine(emp.Name + " - " + emp.Salary.ToString())

  End Sub

End Module
