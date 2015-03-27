Public Class Club

    Public Sub New(ByVal clubID As Integer, ByVal clubName As String)

        _ClubID = clubID
        _ClubName = clubName

    End Sub

    Private _ClubID As Integer = 0
    Private _ClubName As String = ""

    Public Property ClubID() As Integer
        Get
            Return _ClubID
        End Get
        Set(ByVal value As Integer)
            _ClubID = value
        End Set
    End Property

    Public Property ClubName() As String
        Get
            Return _ClubName
        End Get
        Set(ByVal value As String)
            _ClubName = value
        End Set
    End Property

End Class
