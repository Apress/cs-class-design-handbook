Public Class TempConverter
  Public Shared Function CelsiusToFahr(ByVal C As Double) As Double
    Return (C * 9.0 / 5.0) + 32
  End Function

  Public Shared Function FahrToCelsius(ByVal F As Double) As Double
    Return (F - 32) * 5.0 / 9.0
  End Function
End Class
