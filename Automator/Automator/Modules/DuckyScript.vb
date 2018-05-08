Imports System.Text.RegularExpressions

Public Class DuckyScript

    Private _DefaultDelay As Integer
    Private _Body As String

    ''' <summary>
    ''' Define how long (milliseconds) to wait between each subsequent command.
    ''' Default is 100ms.
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DefaultDelay As Integer
        Get
            Return _DefaultDelay
        End Get
    End Property

    ''' <summary>
    ''' Return Ducky Script string.
    ''' </summary>
    ''' <returns>Ducky Script string</returns>
    Public ReadOnly Property Body As String
        Get
            Return _Body
        End Get
    End Property

    ''' <summary>
    ''' Create a new instance of Ducky Script
    ''' </summary>
    Public Sub New()
        _DefaultDelay = 100
    End Sub

    ''' <summary>
    ''' Create a new instance of Ducky Script from a Ducky Script string.
    ''' </summary>
    ''' <param name="DuckyString">Ducky Script string</param>
    Public Sub New(ByVal DuckyString As String)
        FromDuckyScriptString(DuckyString)
    End Sub

    ''' <summary>
    ''' Load a Ducky Script string.
    ''' </summary>
    ''' <param name="DuckyString">Ducky Script string</param>
    Public Sub FromDuckyScriptString(ByVal DuckyString As String)
        _Body = DuckyString
        Dim co As MatchCollection = New Regex("").Matches(DuckyString)
        If co.Count > 1 Then
            Throw New MultipleDefaultDelayDefinedException("Multiple default delay defined.")
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' Convert Ducky Script into Digispark code.
    ''' </summary>
    ''' <returns>Digispark code</returns>
    Public Function ToDigispark() As String
        Return Nothing
    End Function

    ''' <summary>
    ''' Return Ducky Script string.
    ''' </summary>
    ''' <returns>Ducky Script string</returns>
    Public Overrides Function ToString() As String
        Return _Body
    End Function

    ''' <summary>
    ''' Exception: Multiple DEFAULTDELAY defind in Ducky Script.
    ''' </summary>
    Public Class MultipleDefaultDelayDefinedException : Inherits ApplicationException
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    ''' <summary>
    ''' Exception: Syntax error in Ducky Script.
    ''' </summary>
    Public Class SyntaxErrorException : Inherits ApplicationException
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    ''' <summary>
    ''' Exception: No arguments specified after statement.
    ''' </summary>
    Public Class NullArgumentsException : Inherits ApplicationException
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

End Class
