<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewData))
        Me.txtClosingPrice = New System.Windows.Forms.TextBox()
        Me.txtDaysUntil = New System.Windows.Forms.TextBox()
        Me.txtNumLikes = New System.Windows.Forms.TextBox()
        Me.btnInsertData = New System.Windows.Forms.Button()
        Me.MasterDataSet = New Project390.masterDataSet()
        Me.RegressionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegressionTableAdapter = New Project390.masterDataSetTableAdapters.RegressionTableAdapter()
        Me.TableAdapterManager = New Project390.masterDataSetTableAdapters.TableAdapterManager()
        Me.RegressionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegressionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBackToRegressionExample = New System.Windows.Forms.Button()
        Me.btnShowDataTester = New System.Windows.Forms.Button()
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegressionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegressionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegressionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtClosingPrice
        '
        Me.txtClosingPrice.BackColor = System.Drawing.Color.Khaki
        Me.txtClosingPrice.Location = New System.Drawing.Point(669, 95)
        Me.txtClosingPrice.Name = "txtClosingPrice"
        Me.txtClosingPrice.Size = New System.Drawing.Size(135, 22)
        Me.txtClosingPrice.TabIndex = 0
        '
        'txtDaysUntil
        '
        Me.txtDaysUntil.BackColor = System.Drawing.Color.Khaki
        Me.txtDaysUntil.Location = New System.Drawing.Point(669, 148)
        Me.txtDaysUntil.Name = "txtDaysUntil"
        Me.txtDaysUntil.Size = New System.Drawing.Size(135, 22)
        Me.txtDaysUntil.TabIndex = 1
        '
        'txtNumLikes
        '
        Me.txtNumLikes.BackColor = System.Drawing.Color.Khaki
        Me.txtNumLikes.Location = New System.Drawing.Point(669, 204)
        Me.txtNumLikes.Name = "txtNumLikes"
        Me.txtNumLikes.Size = New System.Drawing.Size(135, 22)
        Me.txtNumLikes.TabIndex = 2
        '
        'btnInsertData
        '
        Me.btnInsertData.BackColor = System.Drawing.Color.Khaki
        Me.btnInsertData.Location = New System.Drawing.Point(560, 279)
        Me.btnInsertData.Name = "btnInsertData"
        Me.btnInsertData.Size = New System.Drawing.Size(157, 76)
        Me.btnInsertData.TabIndex = 6
        Me.btnInsertData.Text = "Insert"
        Me.btnInsertData.UseVisualStyleBackColor = False
        '
        'MasterDataSet
        '
        Me.MasterDataSet.DataSetName = "masterDataSet"
        Me.MasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegressionBindingSource
        '
        Me.RegressionBindingSource.DataMember = "Regression"
        Me.RegressionBindingSource.DataSource = Me.MasterDataSet
        '
        'RegressionTableAdapter
        '
        Me.RegressionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RegressionTableAdapter = Me.RegressionTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project390.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegressionBindingNavigator
        '
        Me.RegressionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegressionBindingNavigator.BindingSource = Me.RegressionBindingSource
        Me.RegressionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegressionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegressionBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RegressionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegressionBindingNavigatorSaveItem})
        Me.RegressionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegressionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegressionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegressionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegressionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegressionBindingNavigator.Name = "RegressionBindingNavigator"
        Me.RegressionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegressionBindingNavigator.Size = New System.Drawing.Size(985, 27)
        Me.RegressionBindingNavigator.TabIndex = 8
        Me.RegressionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'RegressionBindingNavigatorSaveItem
        '
        Me.RegressionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegressionBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegressionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegressionBindingNavigatorSaveItem.Name = "RegressionBindingNavigatorSaveItem"
        Me.RegressionBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.RegressionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Khaki
        Me.btnShow.Location = New System.Drawing.Point(560, 444)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(157, 71)
        Me.btnShow.TabIndex = 9
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(0, 30)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(424, 308)
        Me.ListBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(489, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Closing Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(459, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Days Until New Years"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(489, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Twitter Likes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(487, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(332, 32)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Insert and Show New Data"
        '
        'btnBackToRegressionExample
        '
        Me.btnBackToRegressionExample.BackColor = System.Drawing.Color.Wheat
        Me.btnBackToRegressionExample.Location = New System.Drawing.Point(0, 545)
        Me.btnBackToRegressionExample.Name = "btnBackToRegressionExample"
        Me.btnBackToRegressionExample.Size = New System.Drawing.Size(175, 71)
        Me.btnBackToRegressionExample.TabIndex = 15
        Me.btnBackToRegressionExample.Text = "Previous Page"
        Me.btnBackToRegressionExample.UseVisualStyleBackColor = False
        '
        'btnShowDataTester
        '
        Me.btnShowDataTester.BackColor = System.Drawing.Color.Wheat
        Me.btnShowDataTester.Location = New System.Drawing.Point(810, 545)
        Me.btnShowDataTester.Name = "btnShowDataTester"
        Me.btnShowDataTester.Size = New System.Drawing.Size(175, 71)
        Me.btnShowDataTester.TabIndex = 16
        Me.btnShowDataTester.Text = "Next Page"
        Me.btnShowDataTester.UseVisualStyleBackColor = False
        '
        'AddNewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.BackgroundImage = Global.Project390.My.Resources.Resources.pf_location1
        Me.ClientSize = New System.Drawing.Size(985, 615)
        Me.Controls.Add(Me.btnShowDataTester)
        Me.Controls.Add(Me.btnBackToRegressionExample)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.RegressionBindingNavigator)
        Me.Controls.Add(Me.btnInsertData)
        Me.Controls.Add(Me.txtNumLikes)
        Me.Controls.Add(Me.txtDaysUntil)
        Me.Controls.Add(Me.txtClosingPrice)
        Me.Name = "AddNewData"
        Me.Text = "AddNewData"
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegressionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegressionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegressionBindingNavigator.ResumeLayout(False)
        Me.RegressionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtClosingPrice As TextBox
    Friend WithEvents txtDaysUntil As TextBox
    Friend WithEvents txtNumLikes As TextBox
    Friend WithEvents btnInsertData As Button
    Friend WithEvents MasterDataSet As masterDataSet
    Friend WithEvents RegressionBindingSource As BindingSource
    Friend WithEvents RegressionTableAdapter As masterDataSetTableAdapters.RegressionTableAdapter
    Friend WithEvents TableAdapterManager As masterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegressionBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RegressionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnShow As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBackToRegressionExample As Button
    Friend WithEvents btnShowDataTester As Button
End Class
