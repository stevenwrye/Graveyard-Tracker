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
        components = New ComponentModel.Container()
        GHCountNumBox = New NumericUpDown()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        GHPlayerCountLabel = New Label()
        GHDescLabel = New Label()
        GHContinueButton = New Button()
        GHExitButton = New Button()
        CType(GHCountNumBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GHCountNumBox
        ' 
        GHCountNumBox.BackColor = Color.Black
        GHCountNumBox.Cursor = Cursors.Hand
        GHCountNumBox.Font = New Font("Engravers MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GHCountNumBox.ForeColor = Color.Lime
        GHCountNumBox.Location = New Point(487, 239)
        GHCountNumBox.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        GHCountNumBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        GHCountNumBox.Name = "GHCountNumBox"
        GHCountNumBox.Size = New Size(80, 41)
        GHCountNumBox.TabIndex = 0
        GHCountNumBox.TextAlign = HorizontalAlignment.Center
        GHCountNumBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' GHPlayerCountLabel
        ' 
        GHPlayerCountLabel.AutoSize = True
        GHPlayerCountLabel.BorderStyle = BorderStyle.Fixed3D
        GHPlayerCountLabel.Font = New Font("Engravers MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GHPlayerCountLabel.Location = New Point(153, 241)
        GHPlayerCountLabel.Name = "GHPlayerCountLabel"
        GHPlayerCountLabel.Size = New Size(328, 36)
        GHPlayerCountLabel.TabIndex = 2
        GHPlayerCountLabel.Text = "Player Count"
        ' 
        ' GHDescLabel
        ' 
        GHDescLabel.AutoSize = True
        GHDescLabel.BorderStyle = BorderStyle.Fixed3D
        GHDescLabel.Font = New Font("Engravers MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GHDescLabel.Location = New Point(42, 98)
        GHDescLabel.Name = "GHDescLabel"
        GHDescLabel.Size = New Size(623, 104)
        GHDescLabel.TabIndex = 3
        GHDescLabel.Text = "Graveyard Tracker" & vbCrLf & vbCrLf & "Select number of players:"
        GHDescLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GHContinueButton
        ' 
        GHContinueButton.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GHContinueButton.ForeColor = Color.Black
        GHContinueButton.Location = New Point(153, 326)
        GHContinueButton.Name = "GHContinueButton"
        GHContinueButton.Size = New Size(168, 38)
        GHContinueButton.TabIndex = 4
        GHContinueButton.Text = "Continue"
        GHContinueButton.UseVisualStyleBackColor = True
        ' 
        ' GHExitButton
        ' 
        GHExitButton.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GHExitButton.ForeColor = Color.Black
        GHExitButton.Location = New Point(431, 326)
        GHExitButton.Name = "GHExitButton"
        GHExitButton.Size = New Size(100, 38)
        GHExitButton.TabIndex = 5
        GHExitButton.Text = "EXIT"
        GHExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Desktop
        ClientSize = New Size(704, 681)
        Controls.Add(GHExitButton)
        Controls.Add(GHContinueButton)
        Controls.Add(GHDescLabel)
        Controls.Add(GHPlayerCountLabel)
        Controls.Add(GHCountNumBox)
        ForeColor = Color.Lime
        Name = "Form1"
        Text = "Graveyard Tracker"
        CType(GHCountNumBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GHCountNumBox As NumericUpDown
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GHPlayerCountLabel As Label
    Friend WithEvents GHDescLabel As Label
    Friend WithEvents GHContinueButton As Button
    Friend WithEvents GHExitButton As Button
End Class
