Imports System.Data.SqlClient
Public Class Form1
    ' Initialize Variables
    Public myConnect As SqlConnection  ' Make Connection Visible
    Public myCommand As SqlCommand
    Public myReader As SqlDataReader   ' Will Display Results
    Public results As String

    Private Sub PlanetFitnessDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlanetFitnessDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanetFitnessDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.PlanetFitnessData' table. You can move, or remove it, as needed.
        Me.PlanetFitnessDataTableAdapter.Fill(Me.ProjectDataSet.PlanetFitnessData)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create a new instance of the RegressionExample form
        Dim regressionForm As New RegressionExample()

        ' Show the RegressionExample form as a new window
        regressionForm.Show()
    End Sub

End Class
