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
        Me.components = New System.ComponentModel.Container()
        Me.btnDiag = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnAcross = New System.Windows.Forms.Button()
        Me.tmrAcross = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDiag = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.picAnimate = New System.Windows.Forms.PictureBox()
        Me.picMove = New System.Windows.Forms.PictureBox()
        CType(Me.picAnimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDiag
        '
        Me.btnDiag.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDiag.Location = New System.Drawing.Point(0, 526)
        Me.btnDiag.Name = "btnDiag"
        Me.btnDiag.Size = New System.Drawing.Size(748, 23)
        Me.btnDiag.TabIndex = 0
        Me.btnDiag.Text = "Move Diagnal"
        Me.btnDiag.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDown.Location = New System.Drawing.Point(0, 503)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(748, 23)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = "Move Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnAcross
        '
        Me.btnAcross.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAcross.Location = New System.Drawing.Point(0, 480)
        Me.btnAcross.Name = "btnAcross"
        Me.btnAcross.Size = New System.Drawing.Size(748, 23)
        Me.btnAcross.TabIndex = 2
        Me.btnAcross.Text = "Move Across"
        Me.btnAcross.UseVisualStyleBackColor = True
        '
        'tmrAcross
        '
        Me.tmrAcross.Interval = 20
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 20
        '
        'tmrDiag
        '
        Me.tmrDiag.Interval = 20
        '
        'tmrAnimate
        '
        Me.tmrAnimate.Enabled = True
        '
        'picAnimate
        '
        Me.picAnimate.Image = Global.Animate.My.Resources.Resources.Wave00
        Me.picAnimate.Location = New System.Drawing.Point(187, 211)
        Me.picAnimate.Name = "picAnimate"
        Me.picAnimate.Size = New System.Drawing.Size(272, 220)
        Me.picAnimate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAnimate.TabIndex = 4
        Me.picAnimate.TabStop = False
        '
        'picMove
        '
        Me.picMove.Image = Global.Animate.My.Resources.Resources.picCar
        Me.picMove.Location = New System.Drawing.Point(480, 12)
        Me.picMove.Name = "picMove"
        Me.picMove.Size = New System.Drawing.Size(256, 104)
        Me.picMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMove.TabIndex = 3
        Me.picMove.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 549)
        Me.Controls.Add(Me.picAnimate)
        Me.Controls.Add(Me.picMove)
        Me.Controls.Add(Me.btnAcross)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnDiag)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picAnimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDiag As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnAcross As System.Windows.Forms.Button
    Friend WithEvents tmrAcross As System.Windows.Forms.Timer
    Friend WithEvents tmrDown As System.Windows.Forms.Timer
    Friend WithEvents tmrDiag As System.Windows.Forms.Timer
    Friend WithEvents picMove As System.Windows.Forms.PictureBox
    Friend WithEvents picAnimate As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAnimate As System.Windows.Forms.Timer

End Class
