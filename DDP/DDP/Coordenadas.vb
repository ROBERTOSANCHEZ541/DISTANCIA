Public Class Coordenadas
    'clase padre
    Private X1 As Double
    Private X2 As Double
    Private Y1 As Double
    Private Y2 As Double

    Public Sub New(X1 As Double, X2 As Double, Y1 As Double, Y2 As Double)
        Me.X1 = X1
        Me.X2 = X2
        Me.Y1 = Y1
        Me.Y2 = Y2
    End Sub

    Public Property CoordX1() As Double
        Get
            Return X1
        End Get
        Set(value As Double)
            X1 = value
        End Set
    End Property

    Public Property CoordX2() As Double
        Get
            Return X2
        End Get
        Set(value As Double)
            X2 = value
        End Set
    End Property

    Public Property CoordY1() As Double
        Get
            Return Y1
        End Get
        Set(value As Double)
            Y1 = value
        End Set
    End Property

    Public Property CoordY2() As Double
        Get
            Return Y2
        End Get
        Set(value As Double)
            Y2 = value
        End Set
    End Property

    Public Event Load(sender As Object, e As EventArgs)
End Class
