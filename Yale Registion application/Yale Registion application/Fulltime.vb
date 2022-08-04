Public Class Fulltime

    Inherits Student
    Private Annualfee As Decimal

    Public Sub New(ByVal StudentsID As String,
                   ByVal strNames As String,
                   ByVal dtRegistration As String,
                   ByVal Annualfees As Decimal)
        MyBase.New(StudentsID, strNames, dtRegistration)
        Annualfee = Annualfee
    End Sub


    Public Property Annualfees() As Decimal
        Get
            Return Annualfee
        End Get
        Set(ByVal AnnualFes As Decimal)
            Annualfee = AnnualFes
        End Set
    End Property

    Public Overrides Function AmountPaidForTuition() As Decimal
        Dim FullTimeFees As Decimal
        FullTimeFees = Annualfee * 2
        Return FullTimeFees
    End Function


End Class
