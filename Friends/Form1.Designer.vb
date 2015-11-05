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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblFriendInfo = New System.Windows.Forms.Label()
        Me.picFriendPhoto = New System.Windows.Forms.PictureBox()
        Me.txtFriendName = New System.Windows.Forms.TextBox()
        Me.btnGetInfo = New System.Windows.Forms.Button()
        CType(Me.picFriendPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(17, 34)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(145, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the first name of friend: "
        '
        'lblFriendInfo
        '
        Me.lblFriendInfo.Location = New System.Drawing.Point(17, 76)
        Me.lblFriendInfo.Name = "lblFriendInfo"
        Me.lblFriendInfo.Size = New System.Drawing.Size(226, 100)
        Me.lblFriendInfo.TabIndex = 1
        '
        'picFriendPhoto
        '
        Me.picFriendPhoto.Location = New System.Drawing.Point(249, 76)
        Me.picFriendPhoto.Name = "picFriendPhoto"
        Me.picFriendPhoto.Size = New System.Drawing.Size(100, 100)
        Me.picFriendPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFriendPhoto.TabIndex = 2
        Me.picFriendPhoto.TabStop = False
        '
        'txtFriendName
        '
        Me.txtFriendName.Location = New System.Drawing.Point(168, 31)
        Me.txtFriendName.Name = "txtFriendName"
        Me.txtFriendName.Size = New System.Drawing.Size(100, 20)
        Me.txtFriendName.TabIndex = 3
        '
        'btnGetInfo
        '
        Me.btnGetInfo.Location = New System.Drawing.Point(274, 29)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnGetInfo.TabIndex = 4
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 198)
        Me.Controls.Add(Me.btnGetInfo)
        Me.Controls.Add(Me.txtFriendName)
        Me.Controls.Add(Me.picFriendPhoto)
        Me.Controls.Add(Me.lblFriendInfo)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Friends"
        CType(Me.picFriendPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblFriendInfo As System.Windows.Forms.Label
    Friend WithEvents picFriendPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents txtFriendName As System.Windows.Forms.TextBox
    Friend WithEvents btnGetInfo As System.Windows.Forms.Button

End Class
