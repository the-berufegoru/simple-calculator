<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnPeriod = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblDot = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lsbScreen = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Palatino Linotype", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(24, 0)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(317, 49)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "Simple Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEqual)
        Me.GroupBox1.Controls.Add(Me.btnPeriod)
        Me.GroupBox1.Controls.Add(Me.btnZero)
        Me.GroupBox1.Controls.Add(Me.btnFive)
        Me.GroupBox1.Controls.Add(Me.btnSeven)
        Me.GroupBox1.Controls.Add(Me.btnEight)
        Me.GroupBox1.Controls.Add(Me.btnFour)
        Me.GroupBox1.Controls.Add(Me.btnOne)
        Me.GroupBox1.Controls.Add(Me.btnSubtraction)
        Me.GroupBox1.Controls.Add(Me.btnTwo)
        Me.GroupBox1.Controls.Add(Me.btnDivision)
        Me.GroupBox1.Controls.Add(Me.btnMultiply)
        Me.GroupBox1.Controls.Add(Me.btnNine)
        Me.GroupBox1.Controls.Add(Me.btnAddition)
        Me.GroupBox1.Controls.Add(Me.btnThree)
        Me.GroupBox1.Controls.Add(Me.btnSix)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.lblDot)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 341)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnEqual
        '
        Me.btnEqual.BackColor = System.Drawing.Color.Green
        Me.btnEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnEqual.Location = New System.Drawing.Point(270, 211)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(75, 124)
        Me.btnEqual.TabIndex = 43
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'btnPeriod
        '
        Me.btnPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod.Location = New System.Drawing.Point(182, 290)
        Me.btnPeriod.Name = "btnPeriod"
        Me.btnPeriod.Size = New System.Drawing.Size(75, 45)
        Me.btnPeriod.TabIndex = 42
        Me.btnPeriod.Text = "."
        Me.btnPeriod.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnZero.Location = New System.Drawing.Point(6, 290)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(162, 45)
        Me.btnZero.TabIndex = 41
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnFive.Location = New System.Drawing.Point(93, 148)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(75, 45)
        Me.btnFive.TabIndex = 40
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnSeven
        '
        Me.btnSeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnSeven.Location = New System.Drawing.Point(3, 75)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(75, 45)
        Me.btnSeven.TabIndex = 39
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnEight.Location = New System.Drawing.Point(93, 75)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(75, 45)
        Me.btnEight.TabIndex = 38
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnFour.Location = New System.Drawing.Point(3, 148)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(75, 45)
        Me.btnFour.TabIndex = 37
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnOne.Location = New System.Drawing.Point(3, 217)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(75, 45)
        Me.btnOne.TabIndex = 36
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnSubtraction.Location = New System.Drawing.Point(267, 18)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(75, 45)
        Me.btnSubtraction.TabIndex = 35
        Me.btnSubtraction.Text = "-"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnTwo.Location = New System.Drawing.Point(93, 217)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(75, 45)
        Me.btnTwo.TabIndex = 34
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnDivision.Location = New System.Drawing.Point(93, 16)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(75, 45)
        Me.btnDivision.TabIndex = 33
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnMultiply.Location = New System.Drawing.Point(182, 16)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 45)
        Me.btnMultiply.TabIndex = 32
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnNine.Location = New System.Drawing.Point(182, 75)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(75, 45)
        Me.btnNine.TabIndex = 31
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnAddition
        '
        Me.btnAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddition.Location = New System.Drawing.Point(270, 69)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(75, 124)
        Me.btnAddition.TabIndex = 30
        Me.btnAddition.Text = "+"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnThree.Location = New System.Drawing.Point(182, 217)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(75, 45)
        Me.btnThree.TabIndex = 28
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnSix
        '
        Me.btnSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnSix.Location = New System.Drawing.Point(182, 148)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(75, 45)
        Me.btnSix.TabIndex = 27
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.Location = New System.Drawing.Point(5, 18)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 45)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "DEL"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblDot
        '
        Me.lblDot.AutoSize = True
        Me.lblDot.Location = New System.Drawing.Point(205, 308)
        Me.lblDot.Name = "lblDot"
        Me.lblDot.Size = New System.Drawing.Size(10, 13)
        Me.lblDot.TabIndex = 25
        Me.lblDot.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(205, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "."
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape10, Me.LineShape6, Me.LineShape9, Me.LineShape7, Me.LineShape8, Me.LineShape3, Me.LineShape4, Me.LineShape5})
        Me.ShapeContainer2.Size = New System.Drawing.Size(342, 322)
        Me.ShapeContainer2.TabIndex = 16
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape10
        '
        Me.LineShape10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape10.BorderWidth = 2
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 2
        Me.LineShape10.X2 = 356
        Me.LineShape10.Y1 = 48
        Me.LineShape10.Y2 = 48
        '
        'LineShape6
        '
        Me.LineShape6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape6.BorderWidth = 2
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = -1
        Me.LineShape6.X2 = 253
        Me.LineShape6.Y1 = 115
        Me.LineShape6.Y2 = 115
        '
        'LineShape9
        '
        Me.LineShape9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape9.BorderWidth = 2
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 173
        Me.LineShape9.X2 = 172
        Me.LineShape9.Y1 = 2
        Me.LineShape9.Y2 = 325
        '
        'LineShape7
        '
        Me.LineShape7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape7.BorderWidth = 2
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 79
        Me.LineShape7.X2 = 80
        Me.LineShape7.Y1 = -7
        Me.LineShape7.Y2 = 259
        '
        'LineShape8
        '
        Me.LineShape8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape8.BorderWidth = 2
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 262
        Me.LineShape8.X2 = 263
        Me.LineShape8.Y1 = -5
        Me.LineShape8.Y2 = 329
        '
        'LineShape3
        '
        Me.LineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = -307
        Me.LineShape3.X2 = 609
        Me.LineShape3.Y1 = 328
        Me.LineShape3.Y2 = 328
        '
        'LineShape4
        '
        Me.LineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = -1
        Me.LineShape4.X2 = 253
        Me.LineShape4.Y1 = 261
        Me.LineShape4.Y2 = 261
        '
        'LineShape5
        '
        Me.LineShape5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.LineShape5.BorderWidth = 2
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = -284
        Me.LineShape5.X2 = 632
        Me.LineShape5.Y1 = 185
        Me.LineShape5.Y2 = 185
        '
        'lsbScreen
        '
        Me.lsbScreen.FormattingEnabled = True
        Me.lsbScreen.Location = New System.Drawing.Point(0, 78)
        Me.lsbScreen.Name = "lsbScreen"
        Me.lsbScreen.Size = New System.Drawing.Size(372, 56)
        Me.lsbScreen.TabIndex = 3
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(375, 493)
        Me.Controls.Add(Me.lsbScreen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTitle)
        Me.Name = "Calculator"
        Me.Text = "Simple Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblDot As System.Windows.Forms.Label
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnPeriod As System.Windows.Forms.Button
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnSeven As System.Windows.Forms.Button
    Friend WithEvents btnEight As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnSubtraction As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnDivision As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnNine As System.Windows.Forms.Button
    Friend WithEvents btnAddition As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnSix As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents lsbScreen As System.Windows.Forms.ListBox


    Private Sub txtTitle_Click(sender As Object, e As EventArgs) Handles txtTitle.Click

    End Sub
End Class
