Public Class Form1

    Dim v(5) As Integer
    Dim w(5) As Integer
    Dim x(10) As Integer
    Dim b As Integer
    Dim random As New Random
    Dim cadena As String
    Dim res As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Randomize()
        For b = 0 To 4
            v(b) = random.Next(0, 9)
            w(b) = random.Next(0, 9)

            cadena = (cadena & " lo que hay dentro de v " & v(b) & " lo que hay dentro de w " & w(b))
        Next
        cadena = (cadena & vbNewLine)
        For b = 0 To 9

            res = b Mod 2

            If res = 0 Then

                x(b) = v(b)

            Else

                x(b) = w(b)

            End If

            cadena = (cadena & x(b) & "")
        Next

        TextBox1.Text = cadena

    End Sub
End Class
