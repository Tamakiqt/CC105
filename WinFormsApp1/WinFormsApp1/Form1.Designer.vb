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
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        Login = New Button()
        txtPassword = New TextBox()
        Label3 = New Label()
        Student = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Imprint MT Shadow", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(891, 370)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 33)
        Label1.TabIndex = 0
        Label1.Text = "Admin Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(752, 447)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(849, 447)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(273, 31)
        txtUsername.TabIndex = 2
        ' 
        ' Login
        ' 
        Login.Location = New Point(891, 563)
        Login.Name = "Login"
        Login.Size = New Size(151, 35)
        Login.TabIndex = 3
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(849, 501)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(273, 31)
        txtPassword.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(752, 504)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' Student
        ' 
        Student.Location = New Point(891, 614)
        Student.Name = "Student"
        Student.Size = New Size(151, 35)
        Student.TabIndex = 6
        Student.Text = "Student"
        Student.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 1024)
        Controls.Add(Student)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(Login)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Student As Button

End Class
