Imports System.CodeDom

Public Class Form1
    'GH stands for GraveyardHome because I am too lazy for typing that shit out every time I make a new statement.
    Private Sub GHExitButton_Click(sender As Object, e As EventArgs) Handles GHExitButton.Click
        'Exits application
        Application.Exit()
    End Sub
    Private Sub GHContinueButton_Click(sender As Object, e As EventArgs) Handles GHContinueButton.Click
        'Attempts to open PlayerNames page for user to enter names of players in their game based on number selected in the NumbBox
        GraveyardStats.Show()
        Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class