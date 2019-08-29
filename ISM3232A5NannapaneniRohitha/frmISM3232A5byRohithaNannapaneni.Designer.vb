<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmISM3232A5byRohithaNannapaneni
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnComputeGrades = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Yu Gothic UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 75)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(459, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ISM 3232 Assignment 5 by Rohitha Nannapaneni"
        '
        'btnComputeGrades
        '
        Me.btnComputeGrades.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnComputeGrades.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeGrades.Location = New System.Drawing.Point(138, 170)
        Me.btnComputeGrades.Name = "btnComputeGrades"
        Me.btnComputeGrades.Size = New System.Drawing.Size(198, 63)
        Me.btnComputeGrades.TabIndex = 1
        Me.btnComputeGrades.Text = "Compute Grades"
        Me.btnComputeGrades.UseVisualStyleBackColor = False
        '
        'frmISM3232A5byRohithaNannapaneni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 337)
        Me.Controls.Add(Me.btnComputeGrades)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmISM3232A5byRohithaNannapaneni"
        Me.Text = "ISM 3232 Assignment 5 by Rohitha Nannapaneni"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnComputeGrades As Button
End Class
