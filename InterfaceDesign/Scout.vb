Public Class Scout

    Public Sub New(ByVal scoutID As Integer, ByVal scoutName As String)

        _ScoutID = scoutID
        _ScoutName = scoutName

    End Sub

    Private _ScoutID As Integer = 0
    Private _ScoutName As String = ""
    Private _ScoutFirstName As String = ""
    Private _ScoutLastName As String = ""
    Private _EmailAddress As String = ""
    Private _ScoutRole As String = ""
    Private _Username As String = ""
    Private _Password As String = ""
    Private _ClubID As Integer = 0
    Private _ClubName As String = ""

    Public Property ScoutID() As Integer
        Get
            Return _ScoutID
        End Get
        Set(ByVal value As Integer)
            _ScoutID = value
        End Set
    End Property

    Public Property ScoutFirstName() As String
        Get
            Return _ScoutFirstName
        End Get
        Set(ByVal value As String)
            _ScoutFirstName = value
        End Set
    End Property

    Public Property ScoutLastName() As String
        Get
            Return _ScoutLastName
        End Get
        Set(ByVal value As String)
            _ScoutLastName = value
        End Set
    End Property

    Public Property ScoutName() As String
        Get
            Return _ScoutName
        End Get
        Set(ByVal value As String)
            _ScoutName = value
        End Set
    End Property

    'Public ReadOnly Property ScoutName() As String
    '    Get
    '        Return ScoutFirstName & " " & ScoutLastName
    '    End Get
    'End Property

    Public Property EmailAddress() As String
        Get
            Return _EmailAddress
        End Get
        Set(ByVal value As String)
            _EmailAddress = value
        End Set
    End Property

    Public Property ScoutRole() As String
        Get
            Return _ScoutRole
        End Get
        Set(ByVal value As String)
            _ScoutRole = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return _Username
        End Get
        Set(ByVal value As String)
            _Username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

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
