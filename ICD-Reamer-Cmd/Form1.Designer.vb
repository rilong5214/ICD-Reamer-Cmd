<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlcHole
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
        Me.YobiBox = New System.Windows.Forms.RichTextBox()
        Me.DpBox = New System.Windows.Forms.RichTextBox()
        Me.PeneBox = New System.Windows.Forms.RichTextBox()
        Me.ItaBox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'YobiBox
        '
        Me.YobiBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YobiBox.Location = New System.Drawing.Point(209, 27)
        Me.YobiBox.MaxLength = 3
        Me.YobiBox.Multiline = False
        Me.YobiBox.Name = "YobiBox"
        Me.YobiBox.Size = New System.Drawing.Size(91, 33)
        Me.YobiBox.TabIndex = 0
        Me.YobiBox.Text = ""
        '
        'DpBox
        '
        Me.DpBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DpBox.Location = New System.Drawing.Point(209, 67)
        Me.DpBox.Multiline = False
        Me.DpBox.Name = "DpBox"
        Me.DpBox.Size = New System.Drawing.Size(92, 33)
        Me.DpBox.TabIndex = 1
        Me.DpBox.Text = ""
        '
        'PeneBox
        '
        Me.PeneBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeneBox.Location = New System.Drawing.Point(210, 144)
        Me.PeneBox.MaxLength = 1
        Me.PeneBox.Multiline = False
        Me.PeneBox.Name = "PeneBox"
        Me.PeneBox.Size = New System.Drawing.Size(91, 34)
        Me.PeneBox.TabIndex = 3
        Me.PeneBox.Text = ""
        '
        'ItaBox
        '
        Me.ItaBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItaBox.Location = New System.Drawing.Point(210, 106)
        Me.ItaBox.MaxLength = 1
        Me.ItaBox.Multiline = False
        Me.ItaBox.Name = "ItaBox"
        Me.ItaBox.Size = New System.Drawing.Size(91, 32)
        Me.ItaBox.TabIndex = 2
        Me.ItaBox.Text = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(140, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Place"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "呼び（Φ6，Φ7）"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "穴深さ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "板厚検知"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "貫通"
        '
        'FrmPlcHole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 254)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PeneBox)
        Me.Controls.Add(Me.ItaBox)
        Me.Controls.Add(Me.DpBox)
        Me.Controls.Add(Me.YobiBox)
        Me.Name = "FrmPlcHole"
        Me.Text = "リーマ穴配置"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YobiBox As RichTextBox
    Friend WithEvents DpBox As RichTextBox
    Friend WithEvents PeneBox As RichTextBox
    Friend WithEvents ItaBox As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
