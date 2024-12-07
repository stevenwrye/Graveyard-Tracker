Imports System.ComponentModel

Public Class GraveyardStats
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property PlayerNames As PlayerNames ' Use the correct type

    Private Sub GraveyardStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim playerCount As Integer = Form1.GHCountNumBox.Value
        If playerCount = 1 Then
            GSCNumUpDown1.Visible = True
            GSTNumUpDown1.Visible = True
            TextBox1.Visible = True
        ElseIf playerCount = 2 Then
            GSCNumUpDown1.Visible = True
            GSCNumUpDown2.Visible = True
            GSTNumUpDown1.Visible = True
            GSTNumUpDown2.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
        ElseIf playerCount = 3 Then
            GSCNumUpDown1.Visible = True
            GSCNumUpDown2.Visible = True
            GSCNumUpDown3.Visible = True
            GSTNumUpDown1.Visible = True
            GSTNumUpDown2.Visible = True
            GSTNumUpDown3.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
        ElseIf playerCount = 4 Then
            GSCNumUpDown1.Visible = True
            GSCNumUpDown2.Visible = True
            GSCNumUpDown3.Visible = True
            GSCNumUpDown4.Visible = True
            GSTNumUpDown1.Visible = True
            GSTNumUpDown2.Visible = True
            GSTNumUpDown3.Visible = True
            GSTNumUpDown4.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
        ElseIf playerCount = 5 Then
            GSCNumUpDown1.Visible = True
            GSCNumUpDown2.Visible = True
            GSCNumUpDown3.Visible = True
            GSCNumUpDown4.Visible = True
            GSCNumUpDown5.Visible = True
            GSTNumUpDown1.Visible = True
            GSTNumUpDown2.Visible = True
            GSTNumUpDown3.Visible = True
            GSTNumUpDown4.Visible = True
            GSTNumUpDown5.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
        ElseIf playerCount = 6 Then
            GSCNumUpDown1.Visible = True
            GSCNumUpDown2.Visible = True
            GSCNumUpDown3.Visible = True
            GSCNumUpDown4.Visible = True
            GSCNumUpDown5.Visible = True
            GSCNumUpDown6.Visible = True
            GSTNumUpDown1.Visible = True
            GSTNumUpDown2.Visible = True
            GSTNumUpDown3.Visible = True
            GSTNumUpDown4.Visible = True
            GSTNumUpDown5.Visible = True
            GSTNumUpDown6.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
        ElseIf playerCount = 7 Then
            GSCNumUpDown1.Visible = True
            GSCNumUpDown2.Visible = True
            GSCNumUpDown3.Visible = True
            GSCNumUpDown4.Visible = True
            GSCNumUpDown5.Visible = True
            GSCNumUpDown6.Visible = True
            GSCNumUpDown7.Visible = True
            GSTNumUpDown1.Visible = True
            GSTNumUpDown2.Visible = True
            GSTNumUpDown3.Visible = True
            GSTNumUpDown4.Visible = True
            GSTNumUpDown5.Visible = True
            GSTNumUpDown6.Visible = True
            GSTNumUpDown7.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
        ElseIf playerCount = 8 Then
            GSCNumUpDown1.Visible = True
            GSCNumUpDown2.Visible = True
            GSCNumUpDown3.Visible = True
            GSCNumUpDown4.Visible = True
            GSCNumUpDown5.Visible = True
            GSCNumUpDown6.Visible = True
            GSCNumUpDown7.Visible = True
            GSCNumUpDown8.Visible = True
            GSTNumUpDown1.Visible = True
            GSTNumUpDown2.Visible = True
            GSTNumUpDown3.Visible = True
            GSTNumUpDown4.Visible = True
            GSTNumUpDown5.Visible = True
            GSTNumUpDown6.Visible = True
            GSTNumUpDown7.Visible = True
            GSTNumUpDown8.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
        ElseIf playerCount = 9 Then
            GSCNumUpDown1.Visible = True
            GSCNumUpDown2.Visible = True
            GSCNumUpDown3.Visible = True
            GSCNumUpDown4.Visible = True
            GSCNumUpDown5.Visible = True
            GSCNumUpDown6.Visible = True
            GSCNumUpDown7.Visible = True
            GSCNumUpDown8.Visible = True
            GSCNumUpDown9.Visible = True
            GSTNumUpDown1.Visible = True
            GSTNumUpDown2.Visible = True
            GSTNumUpDown3.Visible = True
            GSTNumUpDown4.Visible = True
            GSTNumUpDown5.Visible = True
            GSTNumUpDown6.Visible = True
            GSTNumUpDown7.Visible = True
            GSTNumUpDown8.Visible = True
            GSTNumUpDown9.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
        ElseIf playerCount = 10 Then
            GSCNumUpDown1.Visible = True
            GSCNumUpDown2.Visible = True
            GSCNumUpDown3.Visible = True
            GSCNumUpDown4.Visible = True
            GSCNumUpDown5.Visible = True
            GSCNumUpDown6.Visible = True
            GSCNumUpDown7.Visible = True
            GSCNumUpDown8.Visible = True
            GSCNumUpDown9.Visible = True
            GSCNumUpDown10.Visible = True
            GSTNumUpDown1.Visible = True
            GSTNumUpDown2.Visible = True
            GSTNumUpDown3.Visible = True
            GSTNumUpDown4.Visible = True
            GSTNumUpDown5.Visible = True
            GSTNumUpDown6.Visible = True
            GSTNumUpDown7.Visible = True
            GSTNumUpDown8.Visible = True
            GSTNumUpDown9.Visible = True
            GSTNumUpDown10.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = True
        End If
    End Sub



    Private Sub GSBackButton_Click(sender As Object, e As EventArgs) Handles GSBackButton.Click
        Form1.Visible = True
        Close()
    End Sub

    Private Sub GSExitButton_Click(sender As Object, e As EventArgs) Handles GSExitButton.Click
        Application.Exit()
    End Sub


End Class