<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoDune = New System.Windows.Forms.RadioButton()
        Me.rdoLicorice = New System.Windows.Forms.RadioButton()
        Me.rdoPower = New System.Windows.Forms.RadioButton()
        Me.rdoKing = New System.Windows.Forms.RadioButton()
        Me.rdoCoda = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose And Vote"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdoDune
        '
        Me.rdoDune.AutoSize = True
        Me.rdoDune.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDune.Location = New System.Drawing.Point(136, 99)
        Me.rdoDune.Name = "rdoDune"
        Me.rdoDune.Size = New System.Drawing.Size(74, 24)
        Me.rdoDune.TabIndex = 2
        Me.rdoDune.TabStop = True
        Me.rdoDune.Text = "Dune"
        Me.rdoDune.UseVisualStyleBackColor = True
        '
        'rdoLicorice
        '
        Me.rdoLicorice.AutoSize = True
        Me.rdoLicorice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLicorice.Location = New System.Drawing.Point(136, 150)
        Me.rdoLicorice.Name = "rdoLicorice"
        Me.rdoLicorice.Size = New System.Drawing.Size(151, 24)
        Me.rdoLicorice.TabIndex = 3
        Me.rdoLicorice.TabStop = True
        Me.rdoLicorice.Text = "Licorice Pizza"
        Me.rdoLicorice.UseVisualStyleBackColor = True
        '
        'rdoPower
        '
        Me.rdoPower.AutoSize = True
        Me.rdoPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPower.Location = New System.Drawing.Point(136, 303)
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.Size = New System.Drawing.Size(176, 24)
        Me.rdoPower.TabIndex = 5
        Me.rdoPower.TabStop = True
        Me.rdoPower.Text = "Power of the Dog"
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'rdoKing
        '
        Me.rdoKing.AutoSize = True
        Me.rdoKing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoKing.Location = New System.Drawing.Point(136, 252)
        Me.rdoKing.Name = "rdoKing"
        Me.rdoKing.Size = New System.Drawing.Size(148, 24)
        Me.rdoKing.TabIndex = 6
        Me.rdoKing.TabStop = True
        Me.rdoKing.Text = "King Richards"
        Me.rdoKing.UseVisualStyleBackColor = True
        '
        'rdoCoda
        '
        Me.rdoCoda.AutoSize = True
        Me.rdoCoda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCoda.Location = New System.Drawing.Point(136, 201)
        Me.rdoCoda.Name = "rdoCoda"
        Me.rdoCoda.Size = New System.Drawing.Size(73, 24)
        Me.rdoCoda.TabIndex = 7
        Me.rdoCoda.TabStop = True
        Me.rdoCoda.Text = "Coda"
        Me.rdoCoda.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(468, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Vote"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(633, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Finish"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rdoCoda)
        Me.Controls.Add(Me.rdoKing)
        Me.Controls.Add(Me.rdoPower)
        Me.Controls.Add(Me.rdoLicorice)
        Me.Controls.Add(Me.rdoDune)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rdoDune As RadioButton
    Friend WithEvents rdoLicorice As RadioButton
    Friend WithEvents rdoPower As RadioButton
    Friend WithEvents rdoKing As RadioButton
    Friend WithEvents rdoCoda As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
