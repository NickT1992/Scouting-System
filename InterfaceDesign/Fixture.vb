Public Class Fixture

    Private _FixtureID As Integer = 0
    Private _HomeTeamID As Integer = 0
    Private _AwayTeamID As Integer = 0
    Private _Result As String = ""
    Private _Venue As String = ""
    Private _WeatherConditions As String = ""
    'Private _ReportID As Integer = 0
    'Private _ReportDate As Date = Nothing

    Public Sub New(ByVal _FixtureID As Integer)
        _FixtureID = FixtureID
    End Sub

    Public Property FixtureID() As Integer
        Get
            Return _FixtureID
        End Get
        Set(ByVal value As Integer)
            _FixtureID = value
        End Set
    End Property

    Public Property HomeTeamID() As Integer
        Get
            Return _HomeTeamID
        End Get
        Set(ByVal value As Integer)
            _HomeTeamID = value
        End Set
    End Property

    Public Property AwayTeamID() As Integer
        Get
            Return _AwayTeamID
        End Get
        Set(ByVal value As Integer)
            _AwayTeamID = value
        End Set
    End Property

    Public Property Result() As String
        Get
            Return _Result
        End Get
        Set(ByVal value As String)
            _Result = value
        End Set
    End Property

    Public Property Venue() As String
        Get
            Return _Venue
        End Get
        Set(ByVal value As String)
            _Venue = value
        End Set
    End Property

    Public Property WeatherConditions() As String
        Get
            Return _WeatherConditions
        End Get
        Set(ByVal value As String)
            _WeatherConditions = value
        End Set
    End Property

    'Public Property ReportID() As Integer
    '    Get
    '        Return _ReportID
    '    End Get
    '    Set(ByVal value As Integer)
    '        _ReportID = value
    '    End Set
    'End Property

    'Public Property ReportDate() As Date
    '    Get
    '        Return _ReportDate
    '    End Get
    '    Set(ByVal value As Date)
    '        _ReportDate = value
    '    End Set
    'End Property

End Class
