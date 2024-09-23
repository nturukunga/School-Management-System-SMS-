<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        LblName = New Label()
        Lbl2 = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Location = New Point(0, 247)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(825, 100)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(442, 35)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 53)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(121, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(53, 53)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(501, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 25)
        Label1.TabIndex = 1
        Label1.Text = "+254716369996"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(180, 49)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(237, 25)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "munenehowell3@gmail.com"
        ' 
        ' LblName
        ' 
        LblName.Font = New Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblName.Location = New Point(255, 61)
        LblName.Name = "LblName"
        LblName.Size = New Size(353, 59)
        LblName.TabIndex = 1
        LblName.Text = "ANGAZA DAIMA"
        ' 
        ' Lbl2
        ' 
        Lbl2.Font = New Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl2.Location = New Point(255, 110)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New Size(353, 59)
        Lbl2.TabIndex = 2
        Lbl2.Text = "Portal"
        Lbl2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' splash
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(824, 347)
        Controls.Add(Lbl2)
        Controls.Add(LblName)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "splash"
        ShowIcon = False
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblName As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Timer1 As Timer
End Class
