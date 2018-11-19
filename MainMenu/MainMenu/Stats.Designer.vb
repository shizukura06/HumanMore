<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stats
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.str = New System.Windows.Forms.Label()
        Me.agi = New System.Windows.Forms.Label()
        Me.int = New System.Windows.Forms.Label()
        Me.wp = New System.Windows.Forms.Label()
        Me.elem = New System.Windows.Forms.Label()
        Me.skills = New System.Windows.Forms.Label()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gru = New System.Windows.Forms.DataGridView()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Strength:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Agility:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(12, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Intelligence:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(326, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Will Power:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(326, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Element:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(326, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Skills"
        '
        'str
        '
        Me.str.AutoSize = True
        Me.str.BackColor = System.Drawing.Color.Transparent
        Me.str.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.str.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.str.Location = New System.Drawing.Point(177, 9)
        Me.str.Name = "str"
        Me.str.Size = New System.Drawing.Size(22, 23)
        Me.str.TabIndex = 7
        Me.str.Text = "0"
        '
        'agi
        '
        Me.agi.AutoSize = True
        Me.agi.BackColor = System.Drawing.Color.Transparent
        Me.agi.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.agi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.agi.Location = New System.Drawing.Point(177, 83)
        Me.agi.Name = "agi"
        Me.agi.Size = New System.Drawing.Size(22, 23)
        Me.agi.TabIndex = 8
        Me.agi.Text = "0"
        '
        'int
        '
        Me.int.AutoSize = True
        Me.int.BackColor = System.Drawing.Color.Transparent
        Me.int.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.int.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.int.Location = New System.Drawing.Point(177, 162)
        Me.int.Name = "int"
        Me.int.Size = New System.Drawing.Size(22, 23)
        Me.int.TabIndex = 9
        Me.int.Text = "0"
        '
        'wp
        '
        Me.wp.AutoSize = True
        Me.wp.BackColor = System.Drawing.Color.Transparent
        Me.wp.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.wp.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.wp.Location = New System.Drawing.Point(489, 9)
        Me.wp.Name = "wp"
        Me.wp.Size = New System.Drawing.Size(22, 23)
        Me.wp.TabIndex = 10
        Me.wp.Text = "0"
        '
        'elem
        '
        Me.elem.AutoSize = True
        Me.elem.BackColor = System.Drawing.Color.Transparent
        Me.elem.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.elem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.elem.Location = New System.Drawing.Point(489, 83)
        Me.elem.Name = "elem"
        Me.elem.Size = New System.Drawing.Size(22, 23)
        Me.elem.TabIndex = 11
        Me.elem.Text = "0"
        '
        'skills
        '
        Me.skills.AutoSize = True
        Me.skills.BackColor = System.Drawing.Color.Transparent
        Me.skills.Font = New System.Drawing.Font("TechnicBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.skills.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.skills.Location = New System.Drawing.Point(489, 162)
        Me.skills.Name = "skills"
        Me.skills.Size = New System.Drawing.Size(22, 23)
        Me.skills.TabIndex = 12
        Me.skills.Text = "0"
        '
        'gru
        '
        Me.gru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gru.Location = New System.Drawing.Point(515, 279)
        Me.gru.Name = "gru"
        Me.gru.Size = New System.Drawing.Size(240, 150)
        Me.gru.TabIndex = 13
        Me.gru.Visible = False
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MainMenu.My.Resources.Resources._10715_naruto
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(527, 293)
        Me.Controls.Add(Me.gru)
        Me.Controls.Add(Me.skills)
        Me.Controls.Add(Me.elem)
        Me.Controls.Add(Me.wp)
        Me.Controls.Add(Me.int)
        Me.Controls.Add(Me.agi)
        Me.Controls.Add(Me.str)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Stats"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Stats"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents str As System.Windows.Forms.Label
    Friend WithEvents agi As System.Windows.Forms.Label
    Friend WithEvents int As System.Windows.Forms.Label
    Friend WithEvents wp As System.Windows.Forms.Label
    Friend WithEvents elem As System.Windows.Forms.Label
    Friend WithEvents skills As System.Windows.Forms.Label
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gru As System.Windows.Forms.DataGridView
End Class
