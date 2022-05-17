Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b, c, t As Integer
        Dim menor, medio, mayor As String
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        For x = 1 To 3

            If a > b Then GoTo comparaab Else GoTo comparabc

comparaab:
            t = a
            a = b
            b = t
            GoTo comparabc

comparabc:
            If b > c Then GoTo calculo Else GoTo salir

calculo:
            t = b
            b = c
            c = t

salir:
        Next x
        GoTo imprime

imprime:
        menor = a.ToString()
        medio = b.ToString()
        mayor = c.ToString()
        TextBox4.Text = menor + " - " + medio + " - " + mayor
    End Sub
End Class
