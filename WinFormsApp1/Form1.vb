Public Class Form1
    Dim St_number(9) As String
    Dim St_Name(9) As String
    Dim Mid_score(9) As Single
    Dim Fin_score(9) As Single
    Dim Final_mark(9) As String
    Dim Result(9) As String
    Dim I As Integer = 0
    Dim pass As Integer
    Dim fail As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        St_Name(I) = TextBox1.Text
        Mid_score(I) = TextBox2.Text
        Fin_score(I) = TextBox3.Text
        St_number(I) = TextBox4.Text
        Final_mark(I) = (Fin_score(I) * 60) / 100 + (Mid_score(I) * 40) / 100
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        If Final_mark(I) >= 50 Then
            Result(I) = "Pass"
            Me.pass += 1
        Else
            Result(I) = "Failed"
            Me.fail += 1
        End If

        TextBox5.Text = Me.pass
        TextBox6.Text = Me.fail

        I += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        For I = 0 To I - 1
            ListBox1.Items.Add(St_number(I) & vbTab & St_Name(I) & vbTab & Mid_score(I) & vbTab & Fin_score(I) & vbTab & Final_mark(I))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        For I = 0 To I - 1
            ListBox1.Items.Add(St_number(I) & vbTab & St_Name(I))
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        For I = 0 To I - 1
            ListBox1.Items.Add(St_Name(I) & vbTab & Result(I))
        Next
    End Sub

End Class
