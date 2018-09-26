
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace OptProgressControl
    Partial Public Class Rueda_de_carga
        Inherits UserControl

        Private Const DEFAULT_INTERVAL As Integer = 60
        Private ReadOnly DEFAULT_TICK_COLOR As Color = Color.FromArgb(58, 58, 58)
        Private Const DEFAULT_TICK_WIDTH As Integer = 2
        Private Const MINIMUM_INNER_RADIUS As Integer = 4
        Private Const MINIMUM_OUTER_RADIUS As Integer = 8
        Private MINIMUM_CONTROL_SIZE As Size = New Size(28, 28)
        Private Const MINIMUM_PEN_WIDTH As Integer = 2

        Public Enum Direction
            CLOCKWISE
            ANTICLOCKWISE
        End Enum

        Private m_Interval As Integer
        Private m_Pen As Pen = Nothing
        Private m_CentrePt As PointF = New PointF()
        Private m_InnerRadius As Integer = 0
        Private m_OuterRadius As Integer = 0
        Private m_StartAngle As Integer = 0
        Private m_AlphaStartValue As Integer = 0
        Private m_SpokesCount As Integer = 0
        Private m_AngleIncrement As Integer = 0
        Private m_AlphaDecrement As Integer = 0
        Private m_Timer As Timer = Nothing

        Public Property Interval As Integer
            Get
                Return m_Interval
            End Get
            Set(ByVal value As Integer)

                If value > 0 Then
                    m_Interval = value
                Else
                    m_Interval = DEFAULT_INTERVAL
                End If
            End Set
        End Property

        Public Property TickColor As Color
        Public Property Rotation As Direction

        Public Property StartAngle As Integer
            Get
                Return m_StartAngle
            End Get
            Set(ByVal value As Integer)
                m_StartAngle = value
            End Set
        End Property

        Public Sub New()
            Me.DoubleBuffered = True
            'InitializeComponent()
            Me.BackColor = Color.Transparent
            Me.TickColor = DEFAULT_TICK_COLOR
            Me.MinimumSize = MINIMUM_CONTROL_SIZE
            Me.Interval = DEFAULT_INTERVAL
            Me.Rotation = Direction.CLOCKWISE
            Me.StartAngle = 270
            m_SpokesCount = 12
            m_AlphaStartValue = 255
            m_AngleIncrement = CInt((360 / m_SpokesCount))
            m_AlphaDecrement = CInt(((m_AlphaStartValue - 15) / m_SpokesCount))
            m_Pen = New Pen(TickColor, DEFAULT_TICK_WIDTH)
            m_Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round
            m_Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round
            m_Timer = New Timer()
            m_Timer.Interval = Me.Interval
            AddHandler m_Timer.Tick, New EventHandler(AddressOf OnTimerTick)
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If Rotation = Direction.CLOCKWISE Then
                m_StartAngle += m_AngleIncrement
                If m_StartAngle >= 360 Then m_StartAngle = 0
            ElseIf Rotation = Direction.ANTICLOCKWISE Then
                m_StartAngle -= m_AngleIncrement
                If m_StartAngle <= -360 Then m_StartAngle = 0
            End If

            Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
            Dim alpha As Integer = m_AlphaStartValue
            Dim angle As Integer = m_StartAngle
            Dim width As Integer = If((Me.Width < Me.Height), Me.Width, Me.Height)
            m_CentrePt = New PointF(Me.Width / 2, Me.Height / 2)
            m_Pen.Width = CInt((width / 15))
            If m_Pen.Width < MINIMUM_PEN_WIDTH Then m_Pen.Width = MINIMUM_PEN_WIDTH
            m_InnerRadius = CInt((width * (140 / CSng(800))))
            If m_InnerRadius < MINIMUM_INNER_RADIUS Then m_InnerRadius = MINIMUM_INNER_RADIUS
            m_OuterRadius = CInt((width * (250 / CSng(800))))
            If m_OuterRadius < MINIMUM_OUTER_RADIUS Then m_OuterRadius = MINIMUM_OUTER_RADIUS

            For i As Integer = 0 To m_SpokesCount - 1
                Dim pt1 As PointF = New PointF(m_InnerRadius * CSng(Math.Cos(ConvertDegreesToRadians(angle))), m_InnerRadius * CSng(Math.Sin(ConvertDegreesToRadians(angle))))
                Dim pt2 As PointF = New PointF(m_OuterRadius * CSng(Math.Cos(ConvertDegreesToRadians(angle))), m_OuterRadius * CSng(Math.Sin(ConvertDegreesToRadians(angle))))
                pt1.X += m_CentrePt.X
                pt1.Y += m_CentrePt.Y
                pt2.X += m_CentrePt.X
                pt2.Y += m_CentrePt.Y
                m_Pen.Color = Color.FromArgb(alpha, Me.TickColor)
                e.Graphics.DrawLine(m_Pen, pt1, pt2)

                If Rotation = Direction.CLOCKWISE Then
                    angle -= m_AngleIncrement
                ElseIf Rotation = Direction.ANTICLOCKWISE Then
                    angle += m_AngleIncrement
                End If

                alpha -= m_AlphaDecrement
            Next
        End Sub

        Private Function ConvertDegreesToRadians(ByVal degrees As Integer) As Double
            Return ((Math.PI / CDbl(180)) * degrees)
        End Function

        Public Sub Start()
            If m_Timer IsNot Nothing Then
                m_Timer.Interval = Me.Interval
                m_Timer.Enabled = True
            End If
        End Sub

        Public Sub [Stop]()
            If m_Timer IsNot Nothing Then
                m_Timer.Enabled = False
            End If
        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'CircularProgressControl
            '
            Me.Name = "CircularProgressControl"
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace

