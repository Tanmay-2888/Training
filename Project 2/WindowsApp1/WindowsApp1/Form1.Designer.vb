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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.btnwrite = New System.Windows.Forms.Button()
        Me.btnread = New System.Windows.Forms.Button()
        Me.btnfolder = New System.Windows.Forms.Button()
        Me.btnfile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Dept If"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dept Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dept Location"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(178, 41)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(131, 20)
        Me.txtId.TabIndex = 3
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(178, 101)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(131, 20)
        Me.txtname.TabIndex = 4
        '
        'txtlocation
        '
        Me.txtlocation.Location = New System.Drawing.Point(178, 174)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(131, 20)
        Me.txtlocation.TabIndex = 5
        '
        'btnwrite
        '
        Me.btnwrite.Location = New System.Drawing.Point(116, 245)
        Me.btnwrite.Name = "btnwrite"
        Me.btnwrite.Size = New System.Drawing.Size(82, 24)
        Me.btnwrite.TabIndex = 6
        Me.btnwrite.Text = "Write"
        Me.btnwrite.UseVisualStyleBackColor = True
        '
        'btnread
        '
        Me.btnread.Location = New System.Drawing.Point(249, 245)
        Me.btnread.Name = "btnread"
        Me.btnread.Size = New System.Drawing.Size(82, 24)
        Me.btnread.TabIndex = 7
        Me.btnread.Text = "Read"
        Me.btnread.UseVisualStyleBackColor = True
        '
        'btnfolder
        '
        Me.btnfolder.Location = New System.Drawing.Point(411, 39)
        Me.btnfolder.Name = "btnfolder"
        Me.btnfolder.Size = New System.Drawing.Size(82, 24)
        Me.btnfolder.TabIndex = 8
        Me.btnfolder.Text = "Create Folder"
        Me.btnfolder.UseVisualStyleBackColor = True
        '
        'btnfile
        '
        Me.btnfile.Location = New System.Drawing.Point(411, 101)
        Me.btnfile.Name = "btnfile"
        Me.btnfile.Size = New System.Drawing.Size(82, 24)
        Me.btnfile.TabIndex = 9
        Me.btnfile.Text = "Create File"
        Me.btnfile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnfile)
        Me.Controls.Add(Me.btnfolder)
        Me.Controls.Add(Me.btnread)
        Me.Controls.Add(Me.btnwrite)
        Me.Controls.Add(Me.txtlocation)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents btnwrite As Button
    Friend WithEvents btnread As Button
    Friend WithEvents btnfolder As Button
    Friend WithEvents btnfile As Button
End Class
