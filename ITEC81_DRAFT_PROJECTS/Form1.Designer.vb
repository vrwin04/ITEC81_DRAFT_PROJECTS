<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnLogIn = New Button()
        username_tb = New TextBox()
        password_tb = New TextBox()
        SuspendLayout()
        ' 
        ' btnLogIn
        ' 
        btnLogIn.Location = New Point(475, 368)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(199, 65)
        btnLogIn.TabIndex = 0
        btnLogIn.Text = "Log In"
        btnLogIn.UseVisualStyleBackColor = True
        ' 
        ' username_tb
        ' 
        username_tb.Location = New Point(517, 264)
        username_tb.Name = "username_tb"
        username_tb.Size = New Size(119, 27)
        username_tb.TabIndex = 2
        ' 
        ' password_tb
        ' 
        password_tb.Location = New Point(517, 308)
        password_tb.Name = "password_tb"
        password_tb.Size = New Size(119, 27)
        password_tb.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 720)
        Controls.Add(password_tb)
        Controls.Add(username_tb)
        Controls.Add(btnLogIn)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogIn As Button
    Friend WithEvents username_tb As TextBox
    Friend WithEvents password_tb As TextBox

End Class
