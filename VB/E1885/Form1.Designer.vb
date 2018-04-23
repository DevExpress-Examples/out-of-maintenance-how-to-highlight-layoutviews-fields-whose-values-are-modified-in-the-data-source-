Imports Microsoft.VisualBasic
Imports System
Namespace E1885
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colColumn2 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bindingSource1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(943, 622)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
'			Me.bindingSource1.ListChanged += New System.ComponentModel.ListChangedEventHandler(Me.OnBindingSourceListChanged);
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Column2"
			' 
			' layoutView1
			' 
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colColumn1, Me.colColumn2})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
'			Me.layoutView1.CustomFieldValueStyle += New DevExpress.XtraGrid.Views.Layout.Events.LayoutViewFieldValueStyleEventHandler(Me.OnLayoutViewCustomFieldValueStyle);
			' 
			' colColumn1
			' 
			Me.colColumn1.Caption = "Column1"
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.LayoutViewField = Me.layoutViewField_colColumn1
			Me.colColumn1.Name = "colColumn1"
			' 
			' layoutViewField_colColumn1
			' 
			Me.layoutViewField_colColumn1.EditorPreferredWidth = 147
			Me.layoutViewField_colColumn1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colColumn1.Name = "layoutViewField_colColumn1"
			Me.layoutViewField_colColumn1.Size = New System.Drawing.Size(207, 26)
			Me.layoutViewField_colColumn1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colColumn1.TextSize = New System.Drawing.Size(45, 20)
			' 
			' colColumn2
			' 
			Me.colColumn2.Caption = "Column2"
			Me.colColumn2.FieldName = "Column2"
			Me.colColumn2.LayoutViewField = Me.layoutViewField_colColumn2
			Me.colColumn2.Name = "colColumn2"
			' 
			' layoutViewField_colColumn2
			' 
			Me.layoutViewField_colColumn2.EditorPreferredWidth = 147
			Me.layoutViewField_colColumn2.Location = New System.Drawing.Point(0, 26)
			Me.layoutViewField_colColumn2.Name = "layoutViewField_colColumn2"
			Me.layoutViewField_colColumn2.Size = New System.Drawing.Size(207, 26)
			Me.layoutViewField_colColumn2.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colColumn2.TextSize = New System.Drawing.Size(45, 20)
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "layoutViewCard1"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colColumn1, Me.layoutViewField_colColumn2})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' timer1
			' 
			Me.timer1.Interval = 500
'			Me.timer1.Tick += New System.EventHandler(Me.OnTimerClick);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(943, 622)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.FormClosed += New System.Windows.Forms.FormClosedEventHandler(Me.OnFormClosed);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colColumn1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colColumn2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private WithEvents layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private colColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colColumn2 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private layoutViewField_colColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard

	End Class
End Namespace

