Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class TransPicBox
    Inherits PictureBox

    Public Enum ImageSizing
        None
        Stretch
        Scale
    End Enum

    Public Sub New()
        ' defaults for a new one
        MyBase.BackColor = Color.Transparent
        MyBase.InitialImage = Nothing
        MyBase.ErrorImage = Nothing
        MyBase.Image = Nothing

    End Sub

    Public Overloads Property Image As Image
        Get
            Return MyBase.Image
        End Get
        Set(value As Image)
            MyBase.Image = value
            InvalidateParent()
        End Set
    End Property

    Private imgSizing As ImageSizing = ImageSizing.None


    ' because the child control displays are interdependent
    ' tell the parent to update when some things change
    ' Image, Scaling, Border, Text, BackColor etc
    Private Sub InvalidateParent()
        Invalidate()
        If MyBase.Parent IsNot Nothing Then
            MyBase.Parent.Invalidate()
        End If
    End Sub

    ' since the display depends on ZOrder, provide
    ' a control method to alter it
    Public Sub MoveUpZOrder()
        ChangeZOrder(-1)
    End Sub

    Public Sub MoveDownZOrder()
        ChangeZOrder(+1)
    End Sub

    Private Sub ChangeZOrder(value As Int32)
        Dim ndx As Integer = Parent.Controls.GetChildIndex(Me)

        If ((ndx + value) >= 0) AndAlso ((ndx + value) < Me.Parent.Controls.Count) Then
            Me.Parent.Controls.SetChildIndex(Me, ndx + value)
        End If
    End Sub

    ' if you want to remove properties, this is how
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
    Public Shadows Property ErrorImage As Image

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        If MyBase.BackColor = Color.Transparent Then
            ' magic happens here!
            PaintSiblings(pevent)
        Else
            ' do nothing special when the backcolor is not Transparent
            MyBase.OnPaintBackground(pevent)
        End If

    End Sub


    Private Sub PaintSiblings(e As PaintEventArgs)
        ' need to access the parent' controls collection 
        If (Parent IsNot Nothing) Then
            Dim borderSize As Integer = 0
            Dim thisLeft As Single = -Left
            Dim thisTop As Single = -Top

            ' fix
            Select Case MyBase.BorderStyle
                Case BorderStyle.FixedSingle
                    borderSize = SystemInformation.BorderSize.Width
                Case BorderStyle.Fixed3D
                    borderSize = SystemInformation.Border3DSize.Width
            End Select

            ' Shift ClipBounds to form relative coords
            e.Graphics.TranslateTransform(thisLeft, thisTop)

            ' Get Parent to paint the part behind us:
            ' we cant know if thats been done or not
            Using pea As New PaintEventArgs(e.Graphics, e.ClipRectangle)
                InvokePaintBackground(Parent, pea)
                InvokePaint(Parent, pea)
            End Using

            ' shift back
            e.Graphics.TranslateTransform(-thisLeft, -thisTop)

            ' starting control index is...well, ours
            Dim startAt As Integer = Parent.Controls.GetChildIndex(Me)
            Dim ctl As Control

            ' Controls are in z-Order, so loop 
            ' thru the controls "behind" me
            For n As Int32 = Parent.Controls.Count - 1 To startAt + 1 Step -1
                ctl = Parent.Controls(n)

                ' skip if they are invisible, too small or do not overlap me
                If (ctl.Visible = False OrElse
                            ctl.Width = 0 OrElse
                            ctl.Height = 0 OrElse
                            Bounds.IntersectsWith(ctl.Bounds) = False) Then
                    Continue For
                Else

                    Using bmp As New Bitmap(ctl.Width, ctl.Height, e.Graphics)
                        ' draw this sibling to a bitmap
                        ctl.DrawToBitmap(bmp, New Rectangle(0, 0, ctl.Width, ctl.Height))

                        ' shift the orientation relative to sibling and draw it
                        thisLeft = ctl.Left - Left
                        thisTop = ctl.Top - Top

                        'offset, then draw the image, reset
                        e.Graphics.TranslateTransform(thisLeft - borderSize,
                                                thisTop - borderSize)
                        e.Graphics.DrawImageUnscaled(bmp,
                                                New Point(0, 0))
                        e.Graphics.TranslateTransform(-thisLeft + borderSize,
                                               -thisTop + borderSize)

                    End Using
                End If
            Next
        Else
            'not sure how this could happen
            Using br As New SolidBrush(MyBase.BackColor)
                e.Graphics.FillRectangle(br, ClientRectangle)
            End Using
        End If

    End Sub


    Private Function GetScaledWidth(h As Integer) As Integer
        Dim scale As Single = CSng(Image.Width / Image.Height)
        Return CInt(h * scale)
    End Function

    Private Function GetScaledHeight(w As Integer) As Integer
        Dim scale As Single = CSng(Image.Height / Image.Width)
        Return CInt(w * scale)
    End Function
End Class