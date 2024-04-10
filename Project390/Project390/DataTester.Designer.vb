<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataTester
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBackToAddNewData = New System.Windows.Forms.Button()
        Me.regressionListbox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.btnCalculateY = New System.Windows.Forms.Button()
        Me.lblYValue = New System.Windows.Forms.ListBox()
        Me.chartRegression = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chartRegression, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hypothetical Regression Values"
        '
        'btnBackToAddNewData
        '
        Me.btnBackToAddNewData.BackColor = System.Drawing.Color.Wheat
        Me.btnBackToAddNewData.Location = New System.Drawing.Point(-2, 610)
        Me.btnBackToAddNewData.Name = "btnBackToAddNewData"
        Me.btnBackToAddNewData.Size = New System.Drawing.Size(175, 71)
        Me.btnBackToAddNewData.TabIndex = 16
        Me.btnBackToAddNewData.Text = "Previous Page"
        Me.btnBackToAddNewData.UseVisualStyleBackColor = False
        '
        'regressionListbox
        '
        Me.regressionListbox.BackColor = System.Drawing.Color.Khaki
        Me.regressionListbox.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regressionListbox.FormattingEnabled = True
        Me.regressionListbox.ItemHeight = 15
        Me.regressionListbox.Location = New System.Drawing.Point(13, 108)
        Me.regressionListbox.Name = "regressionListbox"
        Me.regressionListbox.Size = New System.Drawing.Size(380, 124)
        Me.regressionListbox.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 32)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Current Regression Formula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(316, 32)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Calculate Hypothetical Y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "User X1 (Days Until):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "User X2 (End Prices):"
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(192, 346)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(121, 22)
        Me.txtX1.TabIndex = 22
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(192, 384)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(121, 22)
        Me.txtX2.TabIndex = 23
        '
        'btnCalculateY
        '
        Me.btnCalculateY.BackColor = System.Drawing.Color.Wheat
        Me.btnCalculateY.Location = New System.Drawing.Point(319, 346)
        Me.btnCalculateY.Name = "btnCalculateY"
        Me.btnCalculateY.Size = New System.Drawing.Size(112, 60)
        Me.btnCalculateY.TabIndex = 24
        Me.btnCalculateY.Text = "Test Values"
        Me.btnCalculateY.UseVisualStyleBackColor = False
        '
        'lblYValue
        '
        Me.lblYValue.BackColor = System.Drawing.Color.Khaki
        Me.lblYValue.FormattingEnabled = True
        Me.lblYValue.ItemHeight = 16
        Me.lblYValue.Location = New System.Drawing.Point(12, 441)
        Me.lblYValue.Name = "lblYValue"
        Me.lblYValue.Size = New System.Drawing.Size(381, 132)
        Me.lblYValue.TabIndex = 25
        '
        'chartRegression
        '
        Me.chartRegression.BackColor = System.Drawing.Color.PaleVioletRed
        ChartArea3.Name = "ChartArea1"
        Me.chartRegression.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Legend3.Title = "Linear Regression Graph"
        Me.chartRegression.Legends.Add(Legend3)
        Me.chartRegression.Location = New System.Drawing.Point(481, 120)
        Me.chartRegression.Name = "chartRegression"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Planet Fitness Data"
        Me.chartRegression.Series.Add(Series3)
        Me.chartRegression.Size = New System.Drawing.Size(531, 428)
        Me.chartRegression.TabIndex = 26
        Me.chartRegression.Text = "Chart1"
        '
        'DataTester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.Project390.My.Resources.Resources.tester_gradient
        Me.ClientSize = New System.Drawing.Size(1105, 680)
        Me.Controls.Add(Me.chartRegression)
        Me.Controls.Add(Me.lblYValue)
        Me.Controls.Add(Me.btnCalculateY)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.regressionListbox)
        Me.Controls.Add(Me.btnBackToAddNewData)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataTester"
        Me.Text = "DataTester"
        CType(Me.chartRegression, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBackToAddNewData As Button
    Friend WithEvents regressionListbox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents btnCalculateY As Button
    Friend WithEvents lblYValue As ListBox
    Friend WithEvents chartRegression As DataVisualization.Charting.Chart
End Class
