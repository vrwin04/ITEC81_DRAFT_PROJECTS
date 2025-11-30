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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnLogIn = New Button()
        username_tb = New TextBox()
        password_tb = New TextBox()
        btnClose = New PictureBox()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogIn
        ' 
        btnLogIn.Location = New Point(531, 369)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(199, 65)
        btnLogIn.TabIndex = 0
        btnLogIn.Text = "Log In"
        btnLogIn.UseVisualStyleBackColor = True
        ' 
        ' username_tb
        ' 
        username_tb.Location = New Point(573, 265)
        username_tb.Name = "username_tb"
        username_tb.Size = New Size(119, 27)
        username_tb.TabIndex = 2
        ' 
        ' password_tb
        ' 
        password_tb.Location = New Point(573, 309)
        password_tb.Name = "password_tb"
        password_tb.Size = New Size(119, 27)
        password_tb.TabIndex = 3
        ' 
        ' btnClose
        ' 
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(1174, 39)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(32, 32)
        btnClose.SizeMode = PictureBoxSizeMode.AutoSize
        btnClose.TabIndex = 4
        btnClose.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 720)
        Controls.Add(btnClose)
        Controls.Add(password_tb)
        Controls.Add(username_tb)
        Controls.Add(btnLogIn)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogIn As Button
    Friend WithEvents username_tb As TextBox
    Friend WithEvents password_tb As TextBox
    Friend WithEvents btnClose As PictureBox

End Class
