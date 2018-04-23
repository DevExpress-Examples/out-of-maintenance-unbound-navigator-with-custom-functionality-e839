Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors

Namespace UnboundNavigator
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Implements INavigatableControl
		Private controlNavigator1 As DevExpress.XtraEditors.ControlNavigator
		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.controlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' controlNavigator1
			' 
			Me.controlNavigator1.Location = New System.Drawing.Point(8, 8)
			Me.controlNavigator1.Name = "controlNavigator1"
			Me.controlNavigator1.Size = New System.Drawing.Size(244, 21)
			Me.controlNavigator1.TabIndex = 0
			Me.controlNavigator1.Text = "controlNavigator1"
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.ItemHeight = 18
			Me.listBoxControl1.Location = New System.Drawing.Point(8, 48)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(245, 214)
			Me.listBoxControl1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(264, 274)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Controls.Add(Me.controlNavigator1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#Region "INavigatableControl Members"
		Public ReadOnly Property RecordCount() As Integer Implements INavigatableControl.RecordCount
			Get
				Return 0
			End Get
		End Property
		Public ReadOnly Property Position() As Integer Implements INavigatableControl.Position
			Get
				Return 0
			End Get
		End Property
		Public Sub AddNavigator(ByVal owner As INavigatorOwner) Implements INavigatableControl.AddNavigator
		End Sub
		Public Sub RemoveNavigator(ByVal owner As INavigatorOwner) Implements INavigatableControl.RemoveNavigator
		End Sub

		Public Function IsActionEnabled(ByVal type As NavigatorButtonType) As Boolean Implements INavigatableControl.IsActionEnabled
			' your code is here
			Return True
		End Function
		Public Sub DoAction(ByVal type As NavigatorButtonType) Implements INavigatableControl.DoAction
			' your code is here
			listBoxControl1.Items.Add(type.ToString())
			listBoxControl1.SelectedIndex = listBoxControl1.Items.Count - 1
		End Sub
		#End Region

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			controlNavigator1.NavigatableControl = Me
		End Sub
	End Class
End Namespace
