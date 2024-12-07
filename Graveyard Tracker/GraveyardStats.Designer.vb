<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraveyardStats
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
        GSBackButton = New Button()
        GSExitButton = New Button()
        GSCheckedList = New CheckedListBox()
        GSCNumUpDown1 = New NumericUpDown()
        GSPNLabel = New Label()
        GSCreaturesLabel = New Label()
        Label1 = New Label()
        GSCNumUpDown2 = New NumericUpDown()
        GSCNumUpDown3 = New NumericUpDown()
        GSCNumUpDown4 = New NumericUpDown()
        GSCNumUpDown5 = New NumericUpDown()
        GSCNumUpDown6 = New NumericUpDown()
        GSCNumUpDown7 = New NumericUpDown()
        GSCNumUpDown8 = New NumericUpDown()
        GSCNumUpDown9 = New NumericUpDown()
        GSTNumUpDown9 = New NumericUpDown()
        GSTNumUpDown8 = New NumericUpDown()
        GSTNumUpDown7 = New NumericUpDown()
        GSTNumUpDown6 = New NumericUpDown()
        GSTNumUpDown5 = New NumericUpDown()
        GSTNumUpDown4 = New NumericUpDown()
        GSTNumUpDown3 = New NumericUpDown()
        GSTNumUpDown2 = New NumericUpDown()
        GSTNumUpDown1 = New NumericUpDown()
        GSCNumUpDown10 = New NumericUpDown()
        GSTNumUpDown10 = New NumericUpDown()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        CType(GSCNumUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSCNumUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSCNumUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSCNumUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSCNumUpDown5, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSCNumUpDown6, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSCNumUpDown7, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSCNumUpDown8, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSCNumUpDown9, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown9, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown8, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown7, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown6, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown5, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSCNumUpDown10, ComponentModel.ISupportInitialize).BeginInit()
        CType(GSTNumUpDown10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GSBackButton
        ' 
        GSBackButton.BackColor = Color.Transparent
        GSBackButton.ForeColor = Color.Black
        GSBackButton.Location = New Point(149, 608)
        GSBackButton.Name = "GSBackButton"
        GSBackButton.Size = New Size(134, 45)
        GSBackButton.TabIndex = 0
        GSBackButton.Text = "Back"
        GSBackButton.UseVisualStyleBackColor = False
        ' 
        ' GSExitButton
        ' 
        GSExitButton.BackColor = Color.Transparent
        GSExitButton.ForeColor = Color.Black
        GSExitButton.Location = New Point(466, 608)
        GSExitButton.Name = "GSExitButton"
        GSExitButton.Size = New Size(123, 45)
        GSExitButton.TabIndex = 1
        GSExitButton.Text = "Exit"
        GSExitButton.UseVisualStyleBackColor = False
        ' 
        ' GSCheckedList
        ' 
        GSCheckedList.BackColor = Color.Black
        GSCheckedList.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GSCheckedList.ForeColor = Color.Lime
        GSCheckedList.FormattingEnabled = True
        GSCheckedList.Items.AddRange(New Object() {"Artifact", "Battle", "Creature", "Enchantment", "Instant", "Land", "Planeswalker", "Sorcery"})
        GSCheckedList.Location = New Point(244, 385)
        GSCheckedList.Name = "GSCheckedList"
        GSCheckedList.Size = New Size(259, 204)
        GSCheckedList.TabIndex = 2
        ' 
        ' GSCNumUpDown1
        ' 
        GSCNumUpDown1.BackColor = Color.Black
        GSCNumUpDown1.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown1.ForeColor = Color.Lime
        GSCNumUpDown1.Location = New Point(369, 47)
        GSCNumUpDown1.Name = "GSCNumUpDown1"
        GSCNumUpDown1.Size = New Size(72, 32)
        GSCNumUpDown1.TabIndex = 3
        GSCNumUpDown1.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown1.Visible = False
        ' 
        ' GSPNLabel
        ' 
        GSPNLabel.AutoSize = True
        GSPNLabel.BorderStyle = BorderStyle.Fixed3D
        GSPNLabel.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        GSPNLabel.Location = New Point(120, 9)
        GSPNLabel.Name = "GSPNLabel"
        GSPNLabel.Size = New Size(142, 27)
        GSPNLabel.TabIndex = 4
        GSPNLabel.Text = "Player:"
        ' 
        ' GSCreaturesLabel
        ' 
        GSCreaturesLabel.AutoSize = True
        GSCreaturesLabel.BorderStyle = BorderStyle.Fixed3D
        GSCreaturesLabel.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        GSCreaturesLabel.Location = New Point(304, 9)
        GSCreaturesLabel.Name = "GSCreaturesLabel"
        GSCreaturesLabel.Size = New Size(190, 27)
        GSCreaturesLabel.TabIndex = 5
        GSCreaturesLabel.Text = "Creatures"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(500, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 27)
        Label1.TabIndex = 6
        Label1.Text = "Total:"
        ' 
        ' GSCNumUpDown2
        ' 
        GSCNumUpDown2.BackColor = Color.Black
        GSCNumUpDown2.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown2.ForeColor = Color.Lime
        GSCNumUpDown2.Location = New Point(369, 79)
        GSCNumUpDown2.Name = "GSCNumUpDown2"
        GSCNumUpDown2.Size = New Size(72, 32)
        GSCNumUpDown2.TabIndex = 7
        GSCNumUpDown2.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown2.Visible = False
        ' 
        ' GSCNumUpDown3
        ' 
        GSCNumUpDown3.BackColor = Color.Black
        GSCNumUpDown3.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown3.ForeColor = Color.Lime
        GSCNumUpDown3.Location = New Point(369, 111)
        GSCNumUpDown3.Name = "GSCNumUpDown3"
        GSCNumUpDown3.Size = New Size(72, 32)
        GSCNumUpDown3.TabIndex = 8
        GSCNumUpDown3.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown3.Visible = False
        ' 
        ' GSCNumUpDown4
        ' 
        GSCNumUpDown4.BackColor = Color.Black
        GSCNumUpDown4.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown4.ForeColor = Color.Lime
        GSCNumUpDown4.Location = New Point(369, 143)
        GSCNumUpDown4.Name = "GSCNumUpDown4"
        GSCNumUpDown4.Size = New Size(72, 32)
        GSCNumUpDown4.TabIndex = 9
        GSCNumUpDown4.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown4.Visible = False
        ' 
        ' GSCNumUpDown5
        ' 
        GSCNumUpDown5.BackColor = Color.Black
        GSCNumUpDown5.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown5.ForeColor = Color.Lime
        GSCNumUpDown5.Location = New Point(369, 175)
        GSCNumUpDown5.Name = "GSCNumUpDown5"
        GSCNumUpDown5.Size = New Size(72, 32)
        GSCNumUpDown5.TabIndex = 10
        GSCNumUpDown5.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown5.Visible = False
        ' 
        ' GSCNumUpDown6
        ' 
        GSCNumUpDown6.BackColor = Color.Black
        GSCNumUpDown6.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown6.ForeColor = Color.Lime
        GSCNumUpDown6.Location = New Point(369, 207)
        GSCNumUpDown6.Name = "GSCNumUpDown6"
        GSCNumUpDown6.Size = New Size(72, 32)
        GSCNumUpDown6.TabIndex = 11
        GSCNumUpDown6.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown6.Visible = False
        ' 
        ' GSCNumUpDown7
        ' 
        GSCNumUpDown7.BackColor = Color.Black
        GSCNumUpDown7.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown7.ForeColor = Color.Lime
        GSCNumUpDown7.Location = New Point(369, 239)
        GSCNumUpDown7.Name = "GSCNumUpDown7"
        GSCNumUpDown7.Size = New Size(72, 32)
        GSCNumUpDown7.TabIndex = 12
        GSCNumUpDown7.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown7.Visible = False
        ' 
        ' GSCNumUpDown8
        ' 
        GSCNumUpDown8.BackColor = Color.Black
        GSCNumUpDown8.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown8.ForeColor = Color.Lime
        GSCNumUpDown8.Location = New Point(369, 271)
        GSCNumUpDown8.Name = "GSCNumUpDown8"
        GSCNumUpDown8.Size = New Size(72, 32)
        GSCNumUpDown8.TabIndex = 13
        GSCNumUpDown8.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown8.Visible = False
        ' 
        ' GSCNumUpDown9
        ' 
        GSCNumUpDown9.BackColor = Color.Black
        GSCNumUpDown9.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown9.ForeColor = Color.Lime
        GSCNumUpDown9.Location = New Point(369, 303)
        GSCNumUpDown9.Name = "GSCNumUpDown9"
        GSCNumUpDown9.Size = New Size(72, 32)
        GSCNumUpDown9.TabIndex = 14
        GSCNumUpDown9.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown9.Visible = False
        ' 
        ' GSTNumUpDown9
        ' 
        GSTNumUpDown9.BackColor = Color.Black
        GSTNumUpDown9.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown9.ForeColor = Color.Lime
        GSTNumUpDown9.Location = New Point(528, 303)
        GSTNumUpDown9.Name = "GSTNumUpDown9"
        GSTNumUpDown9.Size = New Size(72, 32)
        GSTNumUpDown9.TabIndex = 23
        GSTNumUpDown9.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown9.Visible = False
        ' 
        ' GSTNumUpDown8
        ' 
        GSTNumUpDown8.BackColor = Color.Black
        GSTNumUpDown8.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown8.ForeColor = Color.Lime
        GSTNumUpDown8.Location = New Point(528, 271)
        GSTNumUpDown8.Name = "GSTNumUpDown8"
        GSTNumUpDown8.Size = New Size(72, 32)
        GSTNumUpDown8.TabIndex = 22
        GSTNumUpDown8.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown8.Visible = False
        ' 
        ' GSTNumUpDown7
        ' 
        GSTNumUpDown7.BackColor = Color.Black
        GSTNumUpDown7.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown7.ForeColor = Color.Lime
        GSTNumUpDown7.Location = New Point(528, 239)
        GSTNumUpDown7.Name = "GSTNumUpDown7"
        GSTNumUpDown7.Size = New Size(72, 32)
        GSTNumUpDown7.TabIndex = 21
        GSTNumUpDown7.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown7.Visible = False
        ' 
        ' GSTNumUpDown6
        ' 
        GSTNumUpDown6.BackColor = Color.Black
        GSTNumUpDown6.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown6.ForeColor = Color.Lime
        GSTNumUpDown6.Location = New Point(528, 207)
        GSTNumUpDown6.Name = "GSTNumUpDown6"
        GSTNumUpDown6.Size = New Size(72, 32)
        GSTNumUpDown6.TabIndex = 20
        GSTNumUpDown6.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown6.Visible = False
        ' 
        ' GSTNumUpDown5
        ' 
        GSTNumUpDown5.BackColor = Color.Black
        GSTNumUpDown5.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown5.ForeColor = Color.Lime
        GSTNumUpDown5.Location = New Point(528, 175)
        GSTNumUpDown5.Name = "GSTNumUpDown5"
        GSTNumUpDown5.Size = New Size(72, 32)
        GSTNumUpDown5.TabIndex = 19
        GSTNumUpDown5.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown5.Visible = False
        ' 
        ' GSTNumUpDown4
        ' 
        GSTNumUpDown4.BackColor = Color.Black
        GSTNumUpDown4.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown4.ForeColor = Color.Lime
        GSTNumUpDown4.Location = New Point(528, 143)
        GSTNumUpDown4.Name = "GSTNumUpDown4"
        GSTNumUpDown4.Size = New Size(72, 32)
        GSTNumUpDown4.TabIndex = 18
        GSTNumUpDown4.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown4.Visible = False
        ' 
        ' GSTNumUpDown3
        ' 
        GSTNumUpDown3.BackColor = Color.Black
        GSTNumUpDown3.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown3.ForeColor = Color.Lime
        GSTNumUpDown3.Location = New Point(528, 111)
        GSTNumUpDown3.Name = "GSTNumUpDown3"
        GSTNumUpDown3.Size = New Size(72, 32)
        GSTNumUpDown3.TabIndex = 17
        GSTNumUpDown3.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown3.Visible = False
        ' 
        ' GSTNumUpDown2
        ' 
        GSTNumUpDown2.BackColor = Color.Black
        GSTNumUpDown2.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown2.ForeColor = Color.Lime
        GSTNumUpDown2.Location = New Point(528, 79)
        GSTNumUpDown2.Name = "GSTNumUpDown2"
        GSTNumUpDown2.Size = New Size(72, 32)
        GSTNumUpDown2.TabIndex = 16
        GSTNumUpDown2.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown2.Visible = False
        ' 
        ' GSTNumUpDown1
        ' 
        GSTNumUpDown1.BackColor = Color.Black
        GSTNumUpDown1.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown1.ForeColor = Color.Lime
        GSTNumUpDown1.Location = New Point(528, 47)
        GSTNumUpDown1.Name = "GSTNumUpDown1"
        GSTNumUpDown1.Size = New Size(72, 32)
        GSTNumUpDown1.TabIndex = 15
        GSTNumUpDown1.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown1.Visible = False
        ' 
        ' GSCNumUpDown10
        ' 
        GSCNumUpDown10.BackColor = Color.Black
        GSCNumUpDown10.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSCNumUpDown10.ForeColor = Color.Lime
        GSCNumUpDown10.Location = New Point(369, 335)
        GSCNumUpDown10.Name = "GSCNumUpDown10"
        GSCNumUpDown10.Size = New Size(72, 32)
        GSCNumUpDown10.TabIndex = 24
        GSCNumUpDown10.TextAlign = HorizontalAlignment.Center
        GSCNumUpDown10.Visible = False
        ' 
        ' GSTNumUpDown10
        ' 
        GSTNumUpDown10.BackColor = Color.Black
        GSTNumUpDown10.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold)
        GSTNumUpDown10.ForeColor = Color.Lime
        GSTNumUpDown10.Location = New Point(528, 335)
        GSTNumUpDown10.Name = "GSTNumUpDown10"
        GSTNumUpDown10.Size = New Size(72, 32)
        GSTNumUpDown10.TabIndex = 25
        GSTNumUpDown10.TextAlign = HorizontalAlignment.Center
        GSTNumUpDown10.Visible = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        TextBox1.Location = New Point(91, 49)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(207, 30)
        TextBox1.TabIndex = 26
        TextBox1.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        TextBox2.Location = New Point(91, 81)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(207, 30)
        TextBox2.TabIndex = 27
        TextBox2.Visible = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(91, 113)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(207, 30)
        TextBox3.TabIndex = 28
        TextBox3.Visible = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(91, 145)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(207, 30)
        TextBox4.TabIndex = 29
        TextBox4.Visible = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(91, 177)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(207, 30)
        TextBox5.TabIndex = 30
        TextBox5.Visible = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(91, 209)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(207, 30)
        TextBox6.TabIndex = 31
        TextBox6.Visible = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(91, 241)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(207, 30)
        TextBox7.TabIndex = 32
        TextBox7.Visible = False
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(91, 273)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(207, 30)
        TextBox8.TabIndex = 33
        TextBox8.Visible = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox9.Location = New Point(91, 305)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(207, 30)
        TextBox9.TabIndex = 34
        TextBox9.Visible = False
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox10.Location = New Point(91, 337)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(207, 30)
        TextBox10.TabIndex = 35
        TextBox10.Visible = False
        ' 
        ' GraveyardStats
        ' 
        AutoScaleDimensions = New SizeF(27F, 34F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(704, 681)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(GSTNumUpDown10)
        Controls.Add(GSCNumUpDown10)
        Controls.Add(GSTNumUpDown9)
        Controls.Add(GSTNumUpDown8)
        Controls.Add(GSTNumUpDown7)
        Controls.Add(GSTNumUpDown6)
        Controls.Add(GSTNumUpDown5)
        Controls.Add(GSTNumUpDown4)
        Controls.Add(GSTNumUpDown3)
        Controls.Add(GSTNumUpDown2)
        Controls.Add(GSTNumUpDown1)
        Controls.Add(GSCNumUpDown9)
        Controls.Add(GSCNumUpDown8)
        Controls.Add(GSCNumUpDown7)
        Controls.Add(GSCNumUpDown6)
        Controls.Add(GSCNumUpDown5)
        Controls.Add(GSCNumUpDown4)
        Controls.Add(GSCNumUpDown3)
        Controls.Add(GSCNumUpDown2)
        Controls.Add(Label1)
        Controls.Add(GSCreaturesLabel)
        Controls.Add(GSPNLabel)
        Controls.Add(GSCNumUpDown1)
        Controls.Add(GSCheckedList)
        Controls.Add(GSExitButton)
        Controls.Add(GSBackButton)
        Font = New Font("Engravers MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Lime
        Margin = New Padding(12, 7, 12, 7)
        Name = "GraveyardStats"
        Text = "GraveyardStats"
        CType(GSCNumUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(GSCNumUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(GSCNumUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(GSCNumUpDown4, ComponentModel.ISupportInitialize).EndInit()
        CType(GSCNumUpDown5, ComponentModel.ISupportInitialize).EndInit()
        CType(GSCNumUpDown6, ComponentModel.ISupportInitialize).EndInit()
        CType(GSCNumUpDown7, ComponentModel.ISupportInitialize).EndInit()
        CType(GSCNumUpDown8, ComponentModel.ISupportInitialize).EndInit()
        CType(GSCNumUpDown9, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown9, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown8, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown7, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown6, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown5, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown4, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(GSCNumUpDown10, ComponentModel.ISupportInitialize).EndInit()
        CType(GSTNumUpDown10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GSBackButton As Button
    Friend WithEvents GSExitButton As Button
    Friend WithEvents GSCheckedList As CheckedListBox
    Friend WithEvents GSCNumUpDown1 As NumericUpDown
    Friend WithEvents GSPNLabel As Label
    Friend WithEvents GSCreaturesLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GSCNumUpDown2 As NumericUpDown
    Friend WithEvents GSCNumUpDown3 As NumericUpDown
    Friend WithEvents GSCNumUpDown4 As NumericUpDown
    Friend WithEvents GSCNumUpDown5 As NumericUpDown
    Friend WithEvents GSCNumUpDown6 As NumericUpDown
    Friend WithEvents GSCNumUpDown7 As NumericUpDown
    Friend WithEvents GSCNumUpDown8 As NumericUpDown
    Friend WithEvents GSCNumUpDown9 As NumericUpDown
    Friend WithEvents GSTNumUpDown9 As NumericUpDown
    Friend WithEvents GSTNumUpDown8 As NumericUpDown
    Friend WithEvents GSTNumUpDown7 As NumericUpDown
    Friend WithEvents GSTNumUpDown6 As NumericUpDown
    Friend WithEvents GSTNumUpDown5 As NumericUpDown
    Friend WithEvents GSTNumUpDown4 As NumericUpDown
    Friend WithEvents GSTNumUpDown3 As NumericUpDown
    Friend WithEvents GSTNumUpDown2 As NumericUpDown
    Friend WithEvents GSTNumUpDown1 As NumericUpDown
    Friend WithEvents GSCNumUpDown10 As NumericUpDown
    Friend WithEvents GSTNumUpDown10 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
End Class
