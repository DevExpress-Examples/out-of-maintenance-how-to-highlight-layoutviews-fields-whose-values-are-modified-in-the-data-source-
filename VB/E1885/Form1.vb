Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Diagnostics
Imports DevExpress.XtraGrid.Views.Layout.Events
Imports DevExpress.XtraGrid.Views.Layout

Namespace E1885
	Partial Public Class Form1
		Inherits XtraForm
		Private rnd As New Random()
		Private cache As New Dictionary(Of String, Timer)()
		Private regular As Font
		Private modified As Font

		Public Sub New()
			InitializeComponent()
			CreateData()
			regular = layoutView1.Appearance.FieldValue.Font
			modified = New Font(layoutView1.Appearance.FieldValue.Font, FontStyle.Bold)
			timer1.Start()
		End Sub

		Private Sub CreateData()
			For i As Integer = 0 To 9
				dataTable1.Rows.Add(rnd.Next(100).ToString(), rnd.Next(100).ToString())
			Next i
		End Sub

		Private Sub OnBindingSourceListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles bindingSource1.ListChanged
			If e.ListChangedType = ListChangedType.ItemChanged Then
				Dim key As String = String.Format("{0}|{1}", e.NewIndex, e.PropertyDescriptor.Name)
				Dim timer As Timer
				If cache.ContainsKey(key) Then
					timer = cache(key)
					timer.Stop()
					timer.Start()
				Else
					timer = New Timer()
					timer.Interval = 1000
					timer.Tag = key
					AddHandler timer.Tick, AddressOf OnCacheExpired
					timer.Start()
					cache.Add(key, timer)
				End If
			End If
		End Sub

		Private Sub OnTimerClick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			dataTable1.Rows(rnd.Next(dataTable1.Rows.Count))(rnd.Next(2)) = rnd.Next(100).ToString()
		End Sub

		Private Sub OnCacheExpired(ByVal sender As Object, ByVal e As EventArgs)
			Dim timer As Timer = CType(sender, Timer)
			Dim key As String = CStr(timer.Tag)
			cache.Remove(key)
			timer.Dispose()
			Dim positionData() As String = key.Split("|"c)
			Dim rowHandle As Integer = layoutView1.GetRowHandle(Integer.Parse(positionData(0)))
			layoutView1.RefreshRow(rowHandle)
		End Sub

		Private Sub OnLayoutViewCustomFieldValueStyle(ByVal sender As Object, ByVal e As LayoutViewFieldValueStyleEventArgs) Handles layoutView1.CustomFieldValueStyle
			Dim view As LayoutView = CType(sender, LayoutView)
			Dim sourceIndex As Integer = view.GetDataSourceRowIndex(e.RowHandle)
			Dim key As String = String.Format("{0}|{1}", sourceIndex, e.Column.FieldName)
			If cache.ContainsKey(key) Then
				e.Appearance.Font = modified
			Else
				e.Appearance.Font = regular
			End If
		End Sub

		Private Overloads Sub OnFormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
			modified.Dispose()
			modified = Nothing
		End Sub
	End Class
End Namespace