Imports System.Data.SqlClient
Public Class AddNewData
    Inherits System.Windows.Forms.Form
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Private Sub AddNewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterDataSet.Regression' table. You can move, or remove it, as needed.
        Me.RegressionTableAdapter.Fill(Me.MasterDataSet.Regression)

    End Sub

    Private Sub RegressionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegressionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegressionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MasterDataSet)

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        myConn = New SqlConnection("Data Source=MATTHEW-1006147\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        ' Clear the ListBox before adding new items
        ListBox1.Items.Clear()

        ' Add a header row
        ListBox1.Items.Add("Y".PadRight(12) & "X1".PadRight(12) & "X2".PadRight(10))

        ' Variables to Store Data from the Regression Table
        Dim closingPrice As Double
        Dim daysToNewYears As Integer
        Dim numLikes As Integer

        ' Create Commands
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "EXEC SelectAllFromRegression"

        ' Open Connection
        myConn.Open()
        myReader = myCmd.ExecuteReader

        While myReader.Read()
            ' Read values as double from the reader
            Dim yValue As Double = CDbl(myReader("y"))
            Dim x1Value As Double = CDbl(myReader("x1"))
            Dim x2Value As Double = CDbl(myReader("x2"))

            ' Create a formatted string with fixed width for each value
            Dim row As String = $"{yValue,-10:F2}{x1Value,-10:F2}{x2Value,-10:F2}"
            ListBox1.Items.Add(row)
        End While
    End Sub

    Private Sub btnInsertData_Click(sender As Object, e As EventArgs) Handles btnInsertData.Click
        myConn = New SqlConnection("Data Source=MATTHEW-1006147\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        ' Variables to Store Data from the Regression Table
        Dim closingPrice As Double
        Dim daysToNewYears As Integer
        Dim numLikes As Integer

        ' Set Textbox Values equal to Declared Variables
        closingPrice = CDbl(txtClosingPrice.Text)
        daysToNewYears = CInt(txtDaysUntil.Text)
        numLikes = CDbl(txtNumLikes.Text)

        'Create SQL Commands to be executed
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "EXEC sp_InsertNewDay " & closingPrice & ", " & daysToNewYears & ", " & numLikes
        MessageBox.Show(myCmd.CommandText)

        ' Open Connection
        myConn.Open()
        myReader = myCmd.ExecuteReader

    End Sub
    '----------------------------------------------------------------------------------------------------------------------
    'Add code to move between pages
    Private parentForm As RegressionExample
    Public Sub New(parent As RegressionExample)
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        parentForm = parent
    End Sub
    Private Sub btnBackToRegressionExample_Click(sender As Object, e As EventArgs) Handles btnBackToRegressionExample.Click
        parentForm.Show() ' Show the original form
        Me.Close() ' Close the current form
    End Sub

    Private Sub btnShowDataTester_Click(sender As Object, e As EventArgs) Handles btnShowDataTester.Click
        ' Retrieve parameters from parentForm (RegressionExample)
        Dim a As Double = parentForm.a
        Dim b1 As Double = parentForm.b1
        Dim b2 As Double = parentForm.b2

        ' Pass parameters to DataTester
        Dim dataTesterForm As New DataTester(parentForm)
        dataTesterForm.Show()
        Me.Close() ' Close the current form
        dataTesterForm.DisplayRegressionFormula(a, b1, b2)
    End Sub
End Class