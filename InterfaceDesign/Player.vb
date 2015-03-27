Public Class Player

    Private _PlayerID As Integer = 0
    Private _PlayerFirstName As String = ""
    Private _PlayerLastName As String = ""
    Private _DOB As Date = Nothing
    Private _Age As Integer = 0
    Private _PlaceOfBirth As String = ""
    Private _PlayerImage As Byte() = Nothing
    Private _ClubID As Integer = 0
    Private _ClubName As String = ""

    Public Sub New(ByVal playerID As Integer)

        _PlayerID = playerID

    End Sub

    Public Property PlayerID() As Integer
        Get
            Return _PlayerID
        End Get
        Set(ByVal value As Integer)
            _PlayerID = value
        End Set
    End Property

    Public Property PlayerFirstName() As String
        Get
            Return _PlayerFirstName
        End Get
        Set(ByVal value As String)
            _PlayerFirstName = value
        End Set
    End Property

    Public Property PlayerLastName() As String
        Get
            Return _PlayerLastName
        End Get
        Set(ByVal value As String)
            _PlayerLastName = value
        End Set
    End Property

    Public ReadOnly Property PlayerFullName() As String
        Get
            Return PlayerFirstName & " " & PlayerLastName
        End Get
    End Property

    Public Property DOB() As Date
        Get
            Return _DOB
        End Get
        Set(ByVal value As Date)
            _DOB = value
        End Set
    End Property

    Public Property Age() As Integer
        Get
            Return _Age
        End Get
        Set(ByVal value As Integer)
            _Age = value
        End Set
    End Property

    Public Property PlaceOfBirth() As String
        Get
            Return _PlaceOfBirth
        End Get
        Set(ByVal value As String)
            _PlaceOfBirth = value
        End Set
    End Property

    Public Property PlayerImage As Byte()
        Get
            Return _PlayerImage
        End Get
        Set(ByVal value As Byte())
            _PlayerImage = value
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
