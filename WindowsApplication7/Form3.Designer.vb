﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.FormSkin1 = New FileOrganizingTool.FormSkin()
        Me.MdLabel1 = New FileOrganizingTool.MDLabel()
        Me.MdButton2 = New FileOrganizingTool.MDButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.MdButton2)
        Me.FormSkin1.Controls.Add(Me.MdLabel1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.LightTheme = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.MDColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(407, 261)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "TheMovingTool"
        '
        'MdLabel1
        '
        Me.MdLabel1.AutoSize = True
        Me.MdLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MdLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.MdLabel1.ForeColor = System.Drawing.Color.White
        Me.MdLabel1.Location = New System.Drawing.Point(12, 108)
        Me.MdLabel1.Name = "MdLabel1"
        Me.MdLabel1.Size = New System.Drawing.Size(373, 75)
        Me.MdLabel1.TabIndex = 0
        Me.MdLabel1.Text = "made by Ammar Dabaan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "github.com/ammardab3an/TheMovingTool" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ammar.dabaan99@gmail." & _
    "com"
        '
        'MdButton2
        '
        Me.MdButton2.BackColor = System.Drawing.Color.Transparent
        Me.MdButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MdButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MdButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MdButton2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MdButton2.Location = New System.Drawing.Point(340, 12)
        Me.MdButton2.Name = "MdButton2"
        Me.MdButton2.Rounded = False
        Me.MdButton2.Size = New System.Drawing.Size(55, 26)
        Me.MdButton2.TabIndex = 24
        Me.MdButton2.Text = "Exit"
        Me.MdButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 261)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As FileOrganizingTool.FormSkin
    Friend WithEvents MdLabel1 As FileOrganizingTool.MDLabel
    Friend WithEvents MdButton2 As FileOrganizingTool.MDButton
End Class
