Public Class Report

    Public Sub New(ByVal reportID As Integer, ByVal scoutID As Integer, ByVal fixtureID As Integer, ByVal playerID As Integer, ByVal reportDate As Date)

        _ReportID = reportID
        _ScoutID = scoutID
        _FixtureID = fixtureID
        _PlayerID = playerID
        _ReportDate = reportDate

    End Sub

    Private _ReportID As Integer = 0
    Private _ScoutID As Integer = 0
    Private _FixtureID As Integer = 0
    Private _PlayerID As Integer = 0
    Private _ReportDate As Date = Nothing

    Private _PositionPlayed As String = ""
    Private _PreferredFoot As String = ""
    Private _Comments As String = ""
    Private _MonitorStatus As String = ""

    Private _Crossing As Integer = 0
    Private _Dribbling As Integer = 0
    Private _Finishing As Integer = 0
    Private _BallControl As Integer = 0
    Private _Passing As Integer = 0
    Private _HeadingAccuracy As Integer = 0
    Private _Marking As Integer = 0
    Private _Tackling As Integer = 0
    Private _Aggression As Integer = 0
    Private _Positioning As Integer = 0
    Private _Anticipation As Integer = 0
    Private _Composure As Integer = 0
    Private _Vision As Integer = 0
    Private _Teamwork As Integer = 0
    Private _WorkRate As Integer = 0
    Private _Pace As Integer = 0
    Private _Balance As Integer = 0
    Private _Jumping As Integer = 0
    Private _Strength As Integer = 0
    Private _Stamina As Integer = 0
    Private _Overall As Integer = 0

    '*************************************************************************ID's
    Public Property ReportID() As Integer
        Get
            Return _ReportID
        End Get
        Set(ByVal value As Integer)
            _ReportID = value
        End Set
    End Property

    Public Property ScoutID() As Integer
        Get
            Return _ScoutID
        End Get
        Set(ByVal value As Integer)
            _ScoutID = value
        End Set
    End Property

    Public Property FixtureID() As Integer
        Get
            Return _FixtureID
        End Get
        Set(ByVal value As Integer)
            _FixtureID = value
        End Set
    End Property

    'Public ReadOnly Property FixtureTeams() As String
    '    Get
    '        Return FixtureID  'Need to get the two teams involved in the fixture, based on the FixtureID
    '    End Get
    'End Property

    Public Property PlayerID() As Integer
        Get
            Return _PlayerID
        End Get
        Set(ByVal value As Integer)
            _PlayerID = value
        End Set
    End Property

    Public Property ReportDate() As Date
        Get
            Return _ReportDate
        End Get
        Set(ByVal value As Date)
            _ReportDate = value
        End Set
    End Property

    '*************************************************************************General Information
    Public Property PositionPlayed() As String
        Get
            Return _PositionPlayed
        End Get
        Set(ByVal value As String)
            _PositionPlayed = value
        End Set
    End Property

    Public Property PreferredFoot() As String
        Get
            Return _PreferredFoot
        End Get
        Set(ByVal value As String)
            _PreferredFoot = value
        End Set
    End Property

    Public Property Comments() As String
        Get
            Return _Comments
        End Get
        Set(ByVal value As String)
            _Comments = value
        End Set
    End Property

    Public Property MonitorStatus() As String
        Get
            Return _MonitorStatus
        End Get
        Set(ByVal value As String)
            _MonitorStatus = value
        End Set
    End Property

    '*************************************************************************Attributes
    Public Property Crossing() As Integer
        Get
            Return _Crossing
        End Get
        Set(ByVal value As Integer)
            _Crossing = value
        End Set
    End Property

    Public Property Dribbling() As Integer
        Get
            Return _Dribbling
        End Get
        Set(ByVal value As Integer)
            _Dribbling = value
        End Set
    End Property

    Public Property Finishing() As Integer
        Get
            Return _Finishing
        End Get
        Set(ByVal value As Integer)
            _Finishing = value
        End Set
    End Property

    Public Property BallControl() As Integer
        Get
            Return _BallControl
        End Get
        Set(ByVal value As Integer)
            _BallControl = value
        End Set
    End Property

    Public Property Passing() As Integer
        Get
            Return _Passing
        End Get
        Set(ByVal value As Integer)
            _Passing = value
        End Set
    End Property

    Public Property HeadingAccuracy() As Integer
        Get
            Return _HeadingAccuracy
        End Get
        Set(ByVal value As Integer)
            _HeadingAccuracy = value
        End Set
    End Property

    Public Property Marking() As Integer
        Get
            Return _Marking
        End Get
        Set(ByVal value As Integer)
            _Marking = value
        End Set
    End Property

    Public Property Tackling() As Integer
        Get
            Return _Tackling
        End Get
        Set(ByVal value As Integer)
            _Tackling = value
        End Set
    End Property

    Public Property Aggression() As Integer
        Get
            Return _Aggression
        End Get
        Set(ByVal value As Integer)
            _Aggression = value
        End Set
    End Property

    Public Property Positioning() As Integer
        Get
            Return _Positioning
        End Get
        Set(ByVal value As Integer)
            _Positioning = value
        End Set
    End Property

    Public Property Anticipation() As Integer
        Get
            Return _Anticipation
        End Get
        Set(ByVal value As Integer)
            _Anticipation = value
        End Set
    End Property

    Public Property Composure() As Integer
        Get
            Return _Composure
        End Get
        Set(ByVal value As Integer)
            _Composure = value
        End Set
    End Property

    Public Property Vision() As Integer
        Get
            Return _Vision
        End Get
        Set(ByVal value As Integer)
            _Vision = value
        End Set
    End Property

    Public Property Teamwork() As Integer
        Get
            Return _Teamwork
        End Get
        Set(ByVal value As Integer)
            _Teamwork = value
        End Set
    End Property

    Public Property WorkRate() As Integer
        Get
            Return _WorkRate
        End Get
        Set(ByVal value As Integer)
            _WorkRate = value
        End Set
    End Property

    Public Property Pace() As Integer
        Get
            Return _Pace
        End Get
        Set(ByVal value As Integer)
            _Pace = value
        End Set
    End Property

    Public Property Balance() As Integer
        Get
            Return _Balance
        End Get
        Set(ByVal value As Integer)
            _Balance = value
        End Set
    End Property

    Public Property Jumping() As Integer
        Get
            Return _Jumping
        End Get
        Set(ByVal value As Integer)
            _Jumping = value
        End Set
    End Property

    Public Property Strength() As Integer
        Get
            Return _Strength
        End Get
        Set(ByVal value As Integer)
            _Strength = value
        End Set
    End Property

    Public Property Stamina() As Integer
        Get
            Return _Stamina
        End Get
        Set(ByVal value As Integer)
            _Stamina = value
        End Set
    End Property

    Public Property Overall() As Integer
        Get
            Return _Overall
        End Get
        Set(ByVal value As Integer)
            _Overall = value
        End Set
    End Property

End Class
