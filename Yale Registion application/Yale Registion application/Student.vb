Public Class Student
    Private StudentID As String
    Private Name As String
    Private RegistrationPlace As String

    Public Sub New(ByVal StudentsID As String,
                   ByVal strNames As String,
                   ByVal dtRegistration As String)
        StudentID = StudentsID
        Name = strNames
        RegistrationPlace = dtRegistration
    End Sub

    Public Property intStudentsID() As String
        Get
            intStudentsID = StudentID
        End Get
        Set(ByVal intStudentID As String)
            StudentID = intStudentID
        End Set
    End Property

    Public Property strNames() As String
        Get
            Return Name
        End Get
        Set(ByVal Names As String)
            Name = Names
        End Set
    End Property

    Public Property dtRegistration() As String
        Get
            Return RegistrationPlace
        End Get
        Set(ByVal dtRegistions As String)
            RegistrationPlace = dtRegistions
        End Set
    End Property

    Public Overridable Function AmountPaidForTuition() As Decimal

    End Function

End Class
