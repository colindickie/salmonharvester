Public Class machinelog
    'Set number of indices recorded in 'Function index' below
    Public Const maxindex = 15
    Public Class plcrecord

        Private _id As Integer
        Private _name As String
        Private _value As Integer
        Private _address As String
        Private _num As Integer


        Property max As Integer
            Get
                Return _num
            End Get
            Set(value As Integer)
                _num = value
            End Set
        End Property


        Property id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Property name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Property Value As Integer
            Get
                Return _value
            End Get
            Set(value As Integer)
                _value = value
            End Set
        End Property

        Property address As String
            Get
                Return _address
            End Get
            Set(value As String)
                _address = value
            End Set
        End Property

        Sub New(newname, newvalue, newaddress)
            _num = _num + 1
            Me.name = newname
            Me.Value = newvalue
            Me.address = newaddress

        End Sub
        Sub New()
            Me.name = ""
            Me.Value = 99
            Me.address = ""
        End Sub
    End Class
    Private _machineid As String
    Private _gateclosedelay As plcrecord
    Private _hammerdelay As plcrecord
    Private _knifedelay As plcrecord
    Private _knifetime As plcrecord
    Private _lifttime As plcrecord
    Private _gateopendelay As plcrecord
    Private _daycounter As plcrecord
    Private _lifecounterl As plcrecord
    Private _lifecounterh As plcrecord
    Private _maintrigger As plcrecord
    Private _tailtrigger As plcrecord
    Private _liftcount As plcrecord
    Private _bellycount As plcrecord
    Private _autooverride As plcrecord
    Private _overridewait As plcrecord

    Property machineid As String
        Get
            Return _machineid
        End Get
        Set(value As String)
            _machineid = value
        End Set
    End Property

    Property gateclosedelay As plcrecord
        Get
            Return _gateclosedelay
        End Get
        Set(value As plcrecord)
            _gateclosedelay = value
        End Set
    End Property

    Property hammerdelay As plcrecord
        Get
            Return _hammerdelay
        End Get
        Set(value As plcrecord)
            _hammerdelay = value
        End Set
    End Property

    Property knifedelay As plcrecord
        Get
            Return _knifedelay
        End Get
        Set(value As plcrecord)
            _knifedelay = value
        End Set
    End Property

    Property knifetime As plcrecord
        Get
            Return _knifetime
        End Get
        Set(value As plcrecord)
            _knifetime = value
        End Set
    End Property
    Property lifttime As plcrecord
        Get
            Return _lifttime
        End Get
        Set(value As plcrecord)
            _lifttime = value
        End Set
    End Property
    Property gateopendelay As plcrecord
        Get
            Return _gateopendelay
        End Get
        Set(value As plcrecord)
            _gateopendelay = value
        End Set
    End Property
    Property daycounter As plcrecord
        Get
            Return _daycounter
        End Get
        Set(value As plcrecord)

            _daycounter = value
        End Set
    End Property
    Property lifecountl As plcrecord
        Get
            Return _lifecounterl
        End Get
        Set(value As plcrecord)
            _lifecounterl = value
        End Set
    End Property
    Property lifecounth As plcrecord
        Get
            Return _lifecounterh
        End Get
        Set(value As plcrecord)
            _lifecounterh = value
        End Set
    End Property
    Property tailtrigcount As plcrecord
        Get
            Return _tailtrigger
        End Get
        Set(value As plcrecord)
            _tailtrigger = value
        End Set
    End Property
    Property maintrigcount As plcrecord
        Get
            Return _maintrigger
        End Get
        Set(value As plcrecord)
            _maintrigger = value
        End Set
    End Property
    Property liftcount As plcrecord
        Get
            Return _liftcount
        End Get
        Set(value As plcrecord)
            _liftcount = value
        End Set
    End Property
    Property bellycount As plcrecord
        Get
            Return _bellycount
        End Get
        Set(value As plcrecord)
            _bellycount = value
        End Set
    End Property

    Property autooverride As plcrecord
        Get
            Return _autooverride
        End Get
        Set(value As plcrecord)
            _autooverride = value
        End Set
    End Property

    Property overridewait As plcrecord
        Get
            Return _overridewait
        End Get
        Set(value As plcrecord)
            _overridewait = value
        End Set
    End Property


    Function index(ByVal i As Int32) As plcrecord
        Select Case i
            Case 1
                Return _daycounter
            Case 2
                Return _lifecounterl
            Case 3
                Return _lifecounterh
            Case 4
                Return _maintrigger
            Case 5
                Return _tailtrigger
            Case 6
                Return _liftcount
            Case 7
                Return _bellycount
            Case 8
                Return _gateclosedelay
            Case 9
                Return _hammerdelay
            Case 10
                Return _knifedelay
            Case 11
                Return _knifetime
            Case 12
                Return _lifttime
            Case 13
                Return _gateopendelay
            Case 14
                Return _overridewait
            Case 15
                Return _autooverride
            Case Else
                Return Nothing

                'When addind new indicies remember to update 'maxindex' constant above
        End Select



    End Function
    Sub New()
        _daycounter = New plcrecord
        Me.machineid = ""
        Me.daycounter = New plcrecord("DayCounter", 0, "C5:0")
        Me.lifecountl = New plcrecord("LifeCounterL", 0, "C5:1")
        Me.lifecounth = New plcrecord("LifeCounterH", 0, "C5:2")
        Me.maintrigcount = New plcrecord("MainTrigger", 0, "C5:3")
        Me.tailtrigcount = New plcrecord("TailTrigger", 0, "C5:4")
        Me.liftcount = New plcrecord("LiftCount", 0, "C5:5")
        Me.bellycount = New plcrecord("BellyCount", 0, "C5:6")
        Me.gateclosedelay = New plcrecord("GateCloseDelay", 0, "T4:7")
        Me.hammerdelay = New plcrecord("HammerDelay", 0, "T4:0")
        Me.knifedelay = New plcrecord("KnifeDelay", 0, "T4:1")
        Me.knifetime = New plcrecord("KnifeTime", 0, "T4:2")
        Me.lifttime = New plcrecord("LiftTime", 0, "T4:3")
        Me.gateopendelay = New plcrecord("GateOpenDelay", 0, "T4:4")
        Me.autooverride = New plcrecord("AutoOverride", 0, "B3:3")
        Me.overridewait = New plcrecord("OverrideWait", 0, "T4:6")

    End Sub



End Class
