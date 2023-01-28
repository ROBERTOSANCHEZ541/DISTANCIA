<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalcula = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txty2 = New System.Windows.Forms.TextBox()
        Me.txty1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtx2 = New System.Windows.Forms.TextBox()
        Me.txtx1 = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcula
        '
        Me.btnCalcula.BackColor = System.Drawing.Color.White
        Me.btnCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalcula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcula.Location = New System.Drawing.Point(12, 359)
        Me.btnCalcula.Name = "btnCalcula"
        Me.btnCalcula.Size = New System.Drawing.Size(75, 26)
        Me.btnCalcula.TabIndex = 0
        Me.btnCalcula.Text = "Calcular"
        Me.btnCalcula.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(104, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Distancia entre dos puntos"
        '
        'txty2
        '
        Me.txty2.Location = New System.Drawing.Point(12, 134)
        Me.txty2.Multiline = True
        Me.txty2.Name = "txty2"
        Me.txty2.Size = New System.Drawing.Size(47, 23)
        Me.txty2.TabIndex = 3
        '
        'txty1
        '
        Me.txty1.Location = New System.Drawing.Point(12, 232)
        Me.txty1.Multiline = True
        Me.txty1.Name = "txty1"
        Me.txty1.Size = New System.Drawing.Size(47, 23)
        Me.txty1.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(230, 506)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(47, 22)
        Me.TextBox3.TabIndex = 7
        '
        'txtx2
        '
        Me.txtx2.Location = New System.Drawing.Point(269, 327)
        Me.txtx2.Multiline = True
        Me.txtx2.Name = "txtx2"
        Me.txtx2.Size = New System.Drawing.Size(47, 22)
        Me.txtx2.TabIndex = 6
        '
        'txtx1
        '
        Me.txtx1.Location = New System.Drawing.Point(126, 327)
        Me.txtx1.Multiline = True
        Me.txtx1.Name = "txtx1"
        Me.txtx1.Size = New System.Drawing.Size(47, 22)
        Me.txtx1.TabIndex = 8
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(83, 393)
        Me.txtD.Multiline = True
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(66, 20)
        Me.txtD.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Distancia:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.DDP.My.Resources.Resources.Captura_de_pantalla__1213_
        Me.PictureBox1.Location = New System.Drawing.Point(65, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 253)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "P1(x1,y1)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "P2(x2,y2)"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.DDP.My.Resources.Resources._3792081_broom_halloween_magic_witch_109049
        Me.PictureBox2.Location = New System.Drawing.Point(358, 388)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.DDP.My.Resources.Resources._5137894
        Me.ClientSize = New System.Drawing.Size(406, 434)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtx1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtx2)
        Me.Controls.Add(Me.txty1)
        Me.Controls.Add(Me.txty2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcula)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcula As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txty2 As TextBox
    Friend WithEvents txty1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtx2 As TextBox
    Friend WithEvents txtx1 As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
