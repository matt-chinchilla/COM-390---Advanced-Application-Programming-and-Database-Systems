Imports System.Data.SqlClient

Public Class RegressionExample
    Dim sumy_2, sumx1_2, sumx2_2 As Double
    Dim sumx1y, sumx2y, sumx1x2 As Double
    Public a, b1, b2 As Double
    Private dataTesterForm As DataTester

    'Connection Variables
    Public myConnect As SqlConnection  ' Make Connection Visible
    Public myCommand As SqlCommand
    Public myReader As SqlDataReader   ' Will Display Results
    Public results As String

    ' Declare arrays as fields of the class
    Dim Y() As Double
    Dim X1() As Double
    Dim X2() As Double
    Public Sub SomeMethodOrEventHandler()
        ' Call the method on the DataTester instance
        dataTesterForm.UpdateRegressionChart()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Goes to the Next Page
        Dim newForm As New AddNewData(Me) ' Pass "Me" as a reference
        newForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.RegressionTableAdapter.Fill(Me.MasterDataSet.Regression)
        LoadData()
        Main()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        ' Clear the contents of the ListBox controls
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        ' Reset the regression parameters and any other related variables
        a = 0
        b1 = 0
        b2 = 0
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "Data Source=MATTHEW-1006147\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"

        Using myConnect As New SqlConnection(connectionString)
            Dim query As String = "SelectAllFromRegression"

            Using myCommand As New SqlCommand(query, myConnect)
                myConnect.Open()
                Using myReader As SqlDataReader = myCommand.ExecuteReader()
                    Dim x1List As New List(Of Double)()
                    Dim yList As New List(Of Double)()
                    Dim x2List As New List(Of Double)()

                    While myReader.Read()
                        x1List.Add(CDbl(myReader("x1")))
                        yList.Add(CDbl(myReader("y")))
                        x2List.Add(CDbl(myReader("x2")))
                    End While

                    Dim N As Integer = x1List.Count

                    ' Initialize the arrays with the loaded data
                    ReDim Y(N - 1)
                    ReDim X1(N - 1)
                    ReDim X2(N - 1)

                    For i As Integer = 0 To N - 1
                        X1(i) = x1List(i)
                        Y(i) = yList(i)
                        X2(i) = x2List(i)
                    Next
                End Using
            End Using
        End Using
    End Sub


    Private Sub Main()
        Dim avgY, avgX1, avgX2 As Double
        Dim sumY, sumX1, sumX2 As Double
        Dim sumSQY, sumSQX1, sumSQX2 As Double
        Dim sumYX1, sumYX2, sumX1X2 As Double
        Dim N As Integer = Y.Length

        sumY = CalcSum(Y, True)
        sumX1 = CalcSum(X1)
        sumX2 = CalcSum(X2)

        avgY = CalcMean(sumY, N) ' Use N instead of Y.Length
        avgX1 = CalcMean(sumX1, N) ' Use N instead of X1.Length
        avgX2 = CalcMean(sumX2, N) ' Use N instead of X2.Length

        sumSQY = CalcSumOfSquares(Y)
        sumSQX1 = CalcSumOfSquares(X1)
        sumSQX2 = CalcSumOfSquares(X2)

        sumYX1 = CalcSumOfVar(Y, X1)
        sumYX2 = CalcSumOfVar(Y, X2)
        sumX1X2 = CalcSumOfVar(X1, X2)

        sumy_2 = sumSQY - (Math.Pow(sumY, 2) / N)
        sumx1_2 = sumSQX1 - (Math.Pow(sumX1, 2) / N)
        sumx2_2 = sumSQX2 - (Math.Pow(sumX2, 2) / N)
        sumx1y = sumYX1 - ((sumX1 * sumY) / N)
        sumx2y = sumYX2 - ((sumX2 * sumY) / N)
        sumX1X2 = sumX1X2 - ((sumX1 * sumX2) / N)

        ' utilize all of dem variables bb
        b1 = (sumx2_2 * sumx1y - sumX1X2 * sumx2y) / (sumx1_2 * sumx2_2 - sumX1X2 * sumX1X2)
        b2 = (sumx1_2 * sumx2y - sumX1X2 * sumx1y) / (sumx1_2 * sumx2_2 - sumX1X2 * sumX1X2)
        a = avgY - b1 * avgX1 - b2 * avgX2

        ListBox2.Items.Add("The value of N = " & N.ToString)
        ListBox2.Items.Add("b1= " & b1.ToString)
        ListBox2.Items.Add("b2= " & b2.ToString)
        ListBox2.Items.Add("a= " & a.ToString)
        ListBox2.Items.Add("The regression analysis is Y' = " & Math.Round(a, 3).ToString() & " + " & Math.Round(b1, 4).ToString() & " X1 + " & Math.Round(b2, 4).ToString() & " X2")

        ListBox3.Items.Add("∑Y = " & CalcSum(Y))
        ListBox3.Items.Add("∑X1 = " & CalcSum(X1))
        ListBox3.Items.Add("∑X2 = " & CalcSum(X2))
        ListBox3.Items.Add("∑Y^2 = " & CalcSumOfSquares(Y))
        ListBox3.Items.Add("∑X1^2 = " & CalcSumOfSquares(X1))
        ListBox3.Items.Add("∑X2^2 = " & CalcSumOfSquares(X2))
        ListBox3.Items.Add("∑X1 * ∑Y = " & CalcSumOfVar(Y, X1))
        ListBox3.Items.Add("∑X2 * ∑Y = " & CalcSumOfVar(Y, X2))
        ListBox3.Items.Add("∑X1 * ∑X2 = " & CalcSumOfVar(X1, X2))
        ListBox3.Items.Add("∑y^2 = " & sumSQY - (Math.Pow(sumY, 2) / N))
        ListBox3.Items.Add("∑x1^2 = " & sumSQX1 - (Math.Pow(sumX1, 2) / N))
        ListBox3.Items.Add("∑x2^2 = " & sumSQX2 - (Math.Pow(sumX2, 2) / N))
        ListBox3.Items.Add("∑x1 * ∑y = " & sumYX1 - ((sumX1 * sumY) / N))
        ListBox3.Items.Add("∑x2 * ∑y = " & sumYX2 - ((sumX2 * sumY) / N))
        ListBox3.Items.Add("∑x1 * ∑x2 = " & sumX1X2 - ((sumX1 * sumX2) / N))
        'ListBox3.Items.Add("∑")

        ' Create and show the DataTester form with regression results
        dataTesterForm = New DataTester(Me)
        dataTesterForm.DisplayRegressionFormula(a, b1, b2)
        dataTesterForm.UpdateRegressionChart()
        dataTesterForm.Show()
    End Sub

    Function CalcSum(ByVal array() As Double, Optional ByVal showDetails As Boolean = False) As Double
        Dim sum As Double = 0
        If showDetails Then
            ListBox1.Items.Add("∑Y calculation:") ' Adds the value each step
            For x = 0 To array.Length - 1
                sum += array(x)
                ListBox1.Items.Add("∑ @ " & x.ToString() & " = " & sum.ToString())
            Next
        Else
            For x = 0 To array.Length - 1
                sum += array(x)
            Next
        End If
        Return sum
    End Function

    Function CalcMean(ByVal sum As Double, ByVal N As Integer) As Double
        Dim avg As Double
        avg = sum / N
        Return avg
    End Function

    Function CalcSumOfSquares(ByVal array() As Double) As Double
        Dim sum As Double = 0
        For x = 0 To array.Length - 1
            sum += Math.Pow(array(x), 2)
        Next
        Return sum
    End Function

    Function CalcSumOfVar(ByVal Array1() As Double, ByVal Array2() As Double) As Double
        Dim sum As Double = 0
        For x = 0 To Array1.Length - 1
            sum += Array1(x) * Array2(x)
        Next
        Return sum
    End Function
End Class