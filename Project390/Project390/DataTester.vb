Public Class DataTester
    Private a As Double
    Private b1 As Double
    Private b2 As Double
    Private parentForm As RegressionExample

    ' Modified constructor to accept RegressionExample reference
    Public Sub New(parent As RegressionExample)
        InitializeComponent()
        parentForm = parent
    End Sub

    ' Display the Regression Analysis Formula
    Public Sub DisplayRegressionFormula(ca As Double, cb1 As Double, cb2 As Double)
        ' Store the coefficients for later use
        a = ca
        b1 = cb1
        b2 = cb2

        ' Display the Regression Formula
        Dim formula As String = "The regression analysis is Y' = " &
                                Math.Round(a, 3).ToString() &
                                " + " & Math.Round(b1, 4).ToString() &
                                " X1 + " & Math.Round(b2, 4).ToString() & " X2"
        regressionListbox.Items.Add(formula)
    End Sub

    Private Sub btnBackToAddNewData_Click(sender As Object, e As EventArgs) Handles btnBackToAddNewData.Click
        ' Close the current form
        Me.Close()
        ' Open the AddNewData form, passing the RegressionExample reference
        Dim addNewDataForm As New AddNewData(parentForm)
        addNewDataForm.Show()
    End Sub

    Private Sub btnCalculateY_Click(sender As Object, e As EventArgs) Handles btnCalculateY.Click
        Try
            Dim x1 As Double = Double.Parse(txtX1.Text)
            Dim x2 As Double = Double.Parse(txtX2.Text)

            ' Calculate Y using saved regression values
            Dim yValue As Double = a + (b1 * x1) + (b2 * x2)

            'Display
            lblYValue.Items.Add("Calculated Y' = " & yValue.ToString())

            ' Update the chart
            UpdateRegressionChart()

            ' Add a red dot to the chart at the (x1, yValue) position
            AddDataPointToChart(x1, yValue)
        Catch ex As Exception
            MessageBox.Show("Error: Please enter actual numbers Bozo >:(")
        End Try
    End Sub

    'Method to add a data point to the chart
    Private Sub AddDataPointToChart(x As Double, y As Double)
        If chartRegression.Series.Count > 0 Then
            ' Assuming the first series is your regression line
            Dim pointSeries As New System.Windows.Forms.DataVisualization.Charting.Series("Point")
            pointSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
            pointSeries.Color = Color.Red
            pointSeries.Points.AddXY(x, y)
            chartRegression.Series.Add(pointSeries)
        End If
    End Sub

    Public Sub UpdateRegressionChart()
        ' Clear existing series
        chartRegression.Series.Clear()

        ' Add things to Chart Regression
        Dim regressionSeries As New System.Windows.Forms.DataVisualization.Charting.Series("Regression")
        regressionSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line

        ' Add Points to the Series
        For i As Integer = 0 To 21
            Dim x As Double = i
            Dim y As Double = a + (b1 * x) + (b2 * x) ' Use regression formula here
            regressionSeries.Points.AddXY(x, y)
        Next

        chartRegression.Series.Add(regressionSeries)
    End Sub
End Class