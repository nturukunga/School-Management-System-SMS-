<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginfrm))
        SgnInLbl = New Label()
        LogIcon = New PictureBox()
        ExitBtn = New Button()
        LoginBtn = New Button()
        Panel2 = New Panel()
        TxtPassword = New TextBox()
        PassIcon = New PictureBox()
        Panel1 = New Panel()
        TxtUsername = New TextBox()
        UsrIcon = New PictureBox()
        CType(LogIcon, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PassIcon, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(UsrIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SgnInLbl
        ' 
        SgnInLbl.AutoSize = True
        SgnInLbl.BackColor = Color.Black
        SgnInLbl.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SgnInLbl.ForeColor = SystemColors.ButtonFace
        SgnInLbl.Location = New Point(370, 230)
        SgnInLbl.Name = "SgnInLbl"
        SgnInLbl.Size = New Size(81, 28)
        SgnInLbl.TabIndex = 14
        SgnInLbl.Text = "Sign In"
        ' 
        ' LogIcon
        ' 
        LogIcon.Image = CType(resources.GetObject("LogIcon.Image"), Image)
        LogIcon.Location = New Point(301, 54)
        LogIcon.Name = "LogIcon"
        LogIcon.Size = New Size(217, 162)
        LogIcon.SizeMode = PictureBoxSizeMode.StretchImage
        LogIcon.TabIndex = 13
        LogIcon.TabStop = False
        ' 
        ' ExitBtn
        ' 
        ExitBtn.BackColor = Color.Red
        ExitBtn.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ExitBtn.Location = New Point(301, 509)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(217, 55)
        ExitBtn.TabIndex = 12
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = False
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.Black
        LoginBtn.FlatAppearance.BorderColor = Color.Red
        LoginBtn.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginBtn.ForeColor = SystemColors.ButtonFace
        LoginBtn.Location = New Point(301, 448)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(217, 55)
        LoginBtn.TabIndex = 11
        LoginBtn.Text = "Log In"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(TxtPassword)
        Panel2.Controls.Add(PassIcon)
        Panel2.Location = New Point(236, 354)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(329, 67)
        Panel2.TabIndex = 10
        ' 
        ' TxtPassword
        ' 
        TxtPassword.BackColor = Color.Gold
        TxtPassword.BorderStyle = BorderStyle.None
        TxtPassword.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPassword.Location = New Point(65, 18)
        TxtPassword.Multiline = True
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"
        TxtPassword.Size = New Size(258, 31)
        TxtPassword.TabIndex = 4
        ' 
        ' PassIcon
        ' 
        PassIcon.Image = CType(resources.GetObject("PassIcon.Image"), Image)
        PassIcon.Location = New Point(4, 6)
        PassIcon.Name = "PassIcon"
        PassIcon.Size = New Size(58, 54)
        PassIcon.SizeMode = PictureBoxSizeMode.StretchImage
        PassIcon.TabIndex = 3
        PassIcon.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(TxtUsername)
        Panel1.Controls.Add(UsrIcon)
        Panel1.Location = New Point(236, 281)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(329, 67)
        Panel1.TabIndex = 9
        ' 
        ' TxtUsername
        ' 
        TxtUsername.BackColor = Color.Gold
        TxtUsername.BorderStyle = BorderStyle.None
        TxtUsername.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtUsername.Location = New Point(65, 19)
        TxtUsername.Multiline = True
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(258, 31)
        TxtUsername.TabIndex = 3
        ' 
        ' UsrIcon
        ' 
        UsrIcon.Image = CType(resources.GetObject("UsrIcon.Image"), Image)
        UsrIcon.Location = New Point(4, 6)
        UsrIcon.Name = "UsrIcon"
        UsrIcon.Size = New Size(58, 54)
        UsrIcon.SizeMode = PictureBoxSizeMode.StretchImage
        UsrIcon.TabIndex = 3
        UsrIcon.TabStop = False
        ' 
        ' Loginfrm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(800, 619)
        Controls.Add(SgnInLbl)
        Controls.Add(LogIcon)
        Controls.Add(ExitBtn)
        Controls.Add(LoginBtn)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Loginfrm"
        Text = "LOGIN"
        CType(LogIcon, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PassIcon, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UsrIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SgnInLbl As Label
    Friend WithEvents LogIcon As PictureBox
    Friend WithEvents ExitBtn As Button
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents PassIcon As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents UsrIcon As PictureBox

End Class
