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
        lblStringSalary = New Label()
        txtInput = New TextBox()
        txtSalary = New TextBox()
        btnDisplaySalary = New Button()
        SuspendLayout()
        ' 
        ' lblStringSalary
        ' 
        lblStringSalary.AutoSize = True
        lblStringSalary.Location = New Point(225, 133)
        lblStringSalary.Name = "lblStringSalary"
        lblStringSalary.Size = New Size(49, 20)
        lblStringSalary.TabIndex = 0
        lblStringSalary.Text = "Salary"' 
        ' txtInput
        ' 
        txtInput.Location = New Point(300, 126)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(125, 27)
        txtInput.TabIndex = 1
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(225, 177)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(200, 27)
        txtSalary.TabIndex = 2
        ' 
        ' btnDisplaySalary
        ' 
        btnDisplaySalary.Location = New Point(225, 232)
        btnDisplaySalary.Name = "btnDisplaySalary"
        btnDisplaySalary.Size = New Size(200, 29)
        btnDisplaySalary.TabIndex = 3
        btnDisplaySalary.Text = "Display Salary"
        btnDisplaySalary.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDisplaySalary)
        Controls.Add(txtSalary)
        Controls.Add(txtInput)
        Controls.Add(lblStringSalary)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStringSalary As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents btnDisplaySalary As Button
End Class
