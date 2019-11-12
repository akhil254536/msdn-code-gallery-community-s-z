﻿Namespace ChatApp1._2.Forms
	Partial Public Class FrmLogin
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
			Me.label1 = New System.Windows.Forms.Label()
			Me.tbEmailAddress = New System.Windows.Forms.TextBox()
			Me.tbPassword = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.btnLogin = New System.Windows.Forms.Button()
			Me.llRegister = New System.Windows.Forms.LinkLabel()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(13, 13)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(76, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Email Address:"
			' 
			' tbEmailAddress
			' 
			Me.tbEmailAddress.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.tbEmailAddress.Location = New System.Drawing.Point(16, 29)
			Me.tbEmailAddress.Name = "tbEmailAddress"
			Me.tbEmailAddress.Size = New System.Drawing.Size(339, 20)
			Me.tbEmailAddress.TabIndex = 1
			Me.tbEmailAddress.Text = "myemail@email.com"
			' 
			' tbPassword
			' 
			Me.tbPassword.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.tbPassword.Location = New System.Drawing.Point(16, 77)
			Me.tbPassword.Name = "tbPassword"
			Me.tbPassword.PasswordChar = "*"c
			Me.tbPassword.Size = New System.Drawing.Size(339, 20)
			Me.tbPassword.TabIndex = 3
			Me.tbPassword.Text = "pass"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(13, 61)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(56, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Password:"
			' 
			' btnCancel
			' 
			Me.btnCancel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(16, 130)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(75, 23)
			Me.btnCancel.TabIndex = 4
			Me.btnCancel.Text = "Cancel"
			Me.btnCancel.UseVisualStyleBackColor = True
'			Me.btnCancel.Click += New System.EventHandler(Me.BtnCancelClick)
			' 
			' btnLogin
			' 
			Me.btnLogin.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.btnLogin.Location = New System.Drawing.Point(280, 130)
			Me.btnLogin.Name = "btnLogin"
			Me.btnLogin.Size = New System.Drawing.Size(75, 23)
			Me.btnLogin.TabIndex = 5
			Me.btnLogin.Text = "Login"
			Me.btnLogin.UseVisualStyleBackColor = True
'			Me.btnLogin.Click += New System.EventHandler(Me.BtnLoginClick)
			' 
			' llRegister
			' 
			Me.llRegister.AutoSize = True
			Me.llRegister.Location = New System.Drawing.Point(16, 104)
			Me.llRegister.Name = "llRegister"
			Me.llRegister.Size = New System.Drawing.Size(46, 13)
			Me.llRegister.TabIndex = 6
			Me.llRegister.TabStop = True
			Me.llRegister.Text = "Register"
'			Me.llRegister.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.LlRegisterLinkClicked)
			' 
			' FrmLogin
			' 
			Me.AcceptButton = Me.btnLogin
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(367, 165)
			Me.Controls.Add(Me.llRegister)
			Me.Controls.Add(Me.btnLogin)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.tbPassword)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.tbEmailAddress)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FrmLogin"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Login"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private tbEmailAddress As System.Windows.Forms.TextBox
		Private tbPassword As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents btnCancel As System.Windows.Forms.Button
		Private WithEvents btnLogin As System.Windows.Forms.Button
		Private WithEvents llRegister As System.Windows.Forms.LinkLabel
	End Class
End Namespace