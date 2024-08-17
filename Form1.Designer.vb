<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.txtOutputFile = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(36, 24)
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.Size = New System.Drawing.Size(684, 23)
        Me.txtInputFile.TabIndex = 0
        Me.txtInputFile.Text = "C:\Users\Kearney\Documents\StTammany\2024-08-01-St Tammany.csv"
        '
        'txtOutputFile
        '
        Me.txtOutputFile.Location = New System.Drawing.Point(36, 63)
        Me.txtOutputFile.Name = "txtOutputFile"
        Me.txtOutputFile.Size = New System.Drawing.Size(686, 23)
        Me.txtOutputFile.TabIndex = 1
        Me.txtOutputFile.Text = "C:\Users\Kearney\Documents\StTammany\Output.csv"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(37, 103)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(127, 103)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 147)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtOutputFile)
        Me.Controls.Add(Me.txtInputFile)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInputFile As TextBox
    Friend WithEvents txtOutputFile As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents btnClose As Button
End Class
