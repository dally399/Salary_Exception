Imports System.Runtime.Serialization

Public Class Form1
    Private Sub btnDisplaySalary_Click(sender As Object, e As EventArgs) Handles btnDisplaySalary.Click

        Dim Amount As Double

        Try
            Amount = txtInput.Text
            txtSalary.Text = "Your amount is: " & Amount.ToString("c")

        Catch
            txtSalary.Text = "Enter salary as a number"

        End Try


    End Sub
End Class
