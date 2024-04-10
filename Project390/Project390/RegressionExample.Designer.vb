<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegressionExample
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegressionExample))
        Me.ProjectDataSet = New Project390.projectDataSet()
        Me.PlanetFitnessDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanetFitnessDataTableAdapter = New Project390.projectDataSetTableAdapters.PlanetFitnessDataTableAdapter()
        Me.TableAdapterManager = New Project390.projectDataSetTableAdapters.TableAdapterManager()
        Me.PlanetFitnessDataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PlanetFitnessDataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MasterDataSet = New Project390.masterDataSet()
        Me.RegressionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegressionTableAdapter = New Project390.masterDataSetTableAdapters.RegressionTableAdapter()
        Me.TableAdapterManager1 = New Project390.masterDataSetTableAdapters.TableAdapterManager()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanetFitnessDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanetFitnessDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanetFitnessDataBindingNavigator.SuspendLayout()
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegressionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "projectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanetFitnessDataBindingSource
        '
        Me.PlanetFitnessDataBindingSource.DataMember = "PlanetFitnessData"
        Me.PlanetFitnessDataBindingSource.DataSource = Me.ProjectDataSet
        '
        'PlanetFitnessDataTableAdapter
        '
        Me.PlanetFitnessDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.arrayTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.COURSETableAdapter = Nothing
        Me.TableAdapterManager.Customer_TTableAdapter = Nothing
        Me.TableAdapterManager.GRADE_REPORTTableAdapter = Nothing
        Me.TableAdapterManager.Order_Line_TTableAdapter = Nothing
        Me.TableAdapterManager.Order_TTableAdapter = Nothing
        Me.TableAdapterManager.PlanetFitnessDataTableAdapter = Me.PlanetFitnessDataTableAdapter
        Me.TableAdapterManager.PREREQUISITETableAdapter = Nothing
        Me.TableAdapterManager.Product_Line_TTableAdapter = Nothing
        Me.TableAdapterManager.Product_TTableAdapter = Nothing
        Me.TableAdapterManager.SECTIONTableAdapter = Nothing
        Me.TableAdapterManager.STUDENTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project390.projectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PlanetFitnessDataBindingNavigator
        '
        Me.PlanetFitnessDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlanetFitnessDataBindingNavigator.BindingSource = Me.PlanetFitnessDataBindingSource
        Me.PlanetFitnessDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlanetFitnessDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlanetFitnessDataBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PlanetFitnessDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlanetFitnessDataBindingNavigatorSaveItem})
        Me.PlanetFitnessDataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlanetFitnessDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlanetFitnessDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlanetFitnessDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlanetFitnessDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlanetFitnessDataBindingNavigator.Name = "PlanetFitnessDataBindingNavigator"
        Me.PlanetFitnessDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlanetFitnessDataBindingNavigator.Size = New System.Drawing.Size(1065, 27)
        Me.PlanetFitnessDataBindingNavigator.TabIndex = 0
        Me.PlanetFitnessDataBindingNavigator.Text = "BindingNavigator1"
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
        'PlanetFitnessDataBindingNavigatorSaveItem
        '
        Me.PlanetFitnessDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlanetFitnessDataBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlanetFitnessDataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlanetFitnessDataBindingNavigatorSaveItem.Name = "PlanetFitnessDataBindingNavigatorSaveItem"
        Me.PlanetFitnessDataBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.PlanetFitnessDataBindingNavigatorSaveItem.Text = "Save Data"
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.RegressionTableAdapter = Me.RegressionTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Project390.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(62, 432)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(275, 196)
        Me.ListBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(601, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Multi-Variable Regression Results"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Wheat
        Me.Button1.Location = New System.Drawing.Point(440, 551)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 77)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Next Page"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Khaki
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(62, 101)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(914, 226)
        Me.ListBox2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(696, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Calculations for b1, b2, a"
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(701, 432)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(275, 196)
        Me.ListBox3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Backend Calculations:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Wheat
        Me.Button2.Location = New System.Drawing.Point(449, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 85)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Load :D"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.Wheat
        Me.btnReload.Location = New System.Drawing.Point(981, 651)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(84, 29)
        Me.btnReload.TabIndex = 10
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'RegressionExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(1065, 681)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PlanetFitnessDataBindingNavigator)
        Me.Name = "RegressionExample"
        Me.Text = "RegressionExample"
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanetFitnessDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanetFitnessDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanetFitnessDataBindingNavigator.ResumeLayout(False)
        Me.PlanetFitnessDataBindingNavigator.PerformLayout()
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegressionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProjectDataSet As projectDataSet
    Friend WithEvents PlanetFitnessDataBindingSource As BindingSource
    Friend WithEvents PlanetFitnessDataTableAdapter As projectDataSetTableAdapters.PlanetFitnessDataTableAdapter
    Friend WithEvents TableAdapterManager As projectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanetFitnessDataBindingNavigator As BindingNavigator
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
    Friend WithEvents PlanetFitnessDataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents MasterDataSet As masterDataSet
    Friend WithEvents RegressionBindingSource As BindingSource
    Friend WithEvents RegressionTableAdapter As masterDataSetTableAdapters.RegressionTableAdapter
    Friend WithEvents TableAdapterManager1 As masterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnReload As Button
End Class
