<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnIntArray = New System.Windows.Forms.Button()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.btnstrArray = New System.Windows.Forms.Button()
        Me.btnTimesTable = New System.Windows.Forms.Button()
        Me.txtMultiplier = New System.Windows.Forms.TextBox()
        Me.Multiplier = New System.Windows.Forms.Label()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnIntArray
        '
        Me.btnIntArray.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntArray.Location = New System.Drawing.Point(27, 101)
        Me.btnIntArray.Name = "btnIntArray"
        Me.btnIntArray.Size = New System.Drawing.Size(134, 47)
        Me.btnIntArray.TabIndex = 0
        Me.btnIntArray.Text = "IntArray"
        Me.btnIntArray.UseVisualStyleBackColor = True
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.Location = New System.Drawing.Point(403, 101)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(239, 212)
        Me.lstBox.TabIndex = 1
        '
        'btnstrArray
        '
        Me.btnstrArray.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstrArray.Location = New System.Drawing.Point(27, 171)
        Me.btnstrArray.Name = "btnstrArray"
        Me.btnstrArray.Size = New System.Drawing.Size(140, 47)
        Me.btnstrArray.TabIndex = 2
        Me.btnstrArray.Text = "StringArray"
        Me.btnstrArray.UseVisualStyleBackColor = True
        '
        'btnTimesTable
        '
        Me.btnTimesTable.Location = New System.Drawing.Point(27, 249)
        Me.btnTimesTable.Name = "btnTimesTable"
        Me.btnTimesTable.Size = New System.Drawing.Size(140, 47)
        Me.btnTimesTable.TabIndex = 3
        Me.btnTimesTable.Text = "Button1"
        Me.btnTimesTable.UseVisualStyleBackColor = True
        '
        'txtMultiplier
        '
        Me.txtMultiplier.Location = New System.Drawing.Point(125, 323)
        Me.txtMultiplier.Name = "txtMultiplier"
        Me.txtMultiplier.Size = New System.Drawing.Size(100, 20)
        Me.txtMultiplier.TabIndex = 4
        '
        'Multiplier
        '
        Me.Multiplier.AutoSize = True
        Me.Multiplier.Location = New System.Drawing.Point(24, 326)
        Me.Multiplier.Name = "Multiplier"
        Me.Multiplier.Size = New System.Drawing.Size(47, 13)
        Me.Multiplier.TabIndex = 5
        Me.Multiplier.Text = "multiplier"
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(125, 350)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(100, 20)
        Me.txtStart.TabIndex = 6
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(125, 377)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtEnd.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "end"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.Multiplier)
        Me.Controls.Add(Me.txtMultiplier)
        Me.Controls.Add(Me.btnTimesTable)
        Me.Controls.Add(Me.btnstrArray)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.btnIntArray)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIntArray As Button
    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnstrArray As Button
    Friend WithEvents btnTimesTable As Button
    Friend WithEvents txtMultiplier As TextBox
    Friend WithEvents Multiplier As Label
    Friend WithEvents txtStart As TextBox
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
