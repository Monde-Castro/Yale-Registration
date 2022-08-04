Public Class Parttime

    Inherits Student
    Private HourlyTuition As Decimal

    Public Sub New(ByVal StudentsID As String,
                   ByVal strNames As String,
                   ByVal dtRegistration As String,
                   ByVal PartTimeAmount As Decimal)
        MyBase.New(StudentsID, strNames, dtRegistration)
        HourlyTuition = PartTimeAmount
    End Sub

    Public Overrides Function AmountPaidForTuition() As Decimal
        Dim parttimefee As Decimal
        parttimefee = HourlyTuition * 6
        Return parttimefee
    End Function
End Class
