<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NCoServer
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
        Me.txtProgramID = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtGatewayHost = New System.Windows.Forms.TextBox()
        Me.txtGatewayService = New System.Windows.Forms.TextBox()
        Me.txtIdleTimeout = New System.Windows.Forms.TextBox()
        Me.txtMessageServerService = New System.Windows.Forms.TextBox()
        Me.txtMessageServerHost = New System.Windows.Forms.TextBox()
        Me.txtMessageServerSystemId = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.txtRegistrationCount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program ID"
        '
        'txtProgramID
        '
        Me.txtProgramID.Location = New System.Drawing.Point(225, 9)
        Me.txtProgramID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProgramID.Name = "txtProgramID"
        Me.txtProgramID.Size = New System.Drawing.Size(276, 26)
        Me.txtProgramID.TabIndex = 1
        Me.txtProgramID.Text = "STFC_CONNECTION"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(401, 489)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 32)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gateway Host"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gateway Service"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 325)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 203)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Message Server Service"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 237)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Message Server Host"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 393)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Language"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 359)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 114)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Idle Timeout"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 271)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 18)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Message Server System ID"
        '
        'txtGatewayHost
        '
        Me.txtGatewayHost.Location = New System.Drawing.Point(225, 43)
        Me.txtGatewayHost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGatewayHost.Name = "txtGatewayHost"
        Me.txtGatewayHost.Size = New System.Drawing.Size(276, 26)
        Me.txtGatewayHost.TabIndex = 13
        '
        'txtGatewayService
        '
        Me.txtGatewayService.Location = New System.Drawing.Point(225, 77)
        Me.txtGatewayService.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGatewayService.Name = "txtGatewayService"
        Me.txtGatewayService.Size = New System.Drawing.Size(276, 26)
        Me.txtGatewayService.TabIndex = 14
        Me.txtGatewayService.Text = "SAPGW00"
        '
        'txtIdleTimeout
        '
        Me.txtIdleTimeout.Location = New System.Drawing.Point(225, 111)
        Me.txtIdleTimeout.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdleTimeout.Name = "txtIdleTimeout"
        Me.txtIdleTimeout.Size = New System.Drawing.Size(276, 26)
        Me.txtIdleTimeout.TabIndex = 15
        Me.txtIdleTimeout.Text = "1200"
        '
        'txtMessageServerService
        '
        Me.txtMessageServerService.Location = New System.Drawing.Point(225, 200)
        Me.txtMessageServerService.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMessageServerService.Name = "txtMessageServerService"
        Me.txtMessageServerService.Size = New System.Drawing.Size(276, 26)
        Me.txtMessageServerService.TabIndex = 17
        '
        'txtMessageServerHost
        '
        Me.txtMessageServerHost.Location = New System.Drawing.Point(225, 234)
        Me.txtMessageServerHost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMessageServerHost.Name = "txtMessageServerHost"
        Me.txtMessageServerHost.Size = New System.Drawing.Size(276, 26)
        Me.txtMessageServerHost.TabIndex = 18
        '
        'txtMessageServerSystemId
        '
        Me.txtMessageServerSystemId.Location = New System.Drawing.Point(225, 268)
        Me.txtMessageServerSystemId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMessageServerSystemId.Name = "txtMessageServerSystemId"
        Me.txtMessageServerSystemId.Size = New System.Drawing.Size(276, 26)
        Me.txtMessageServerSystemId.TabIndex = 19
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(225, 322)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(276, 26)
        Me.txtUser.TabIndex = 20
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(225, 356)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(276, 26)
        Me.txtPassword.TabIndex = 21
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(225, 390)
        Me.txtLanguage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(276, 26)
        Me.txtLanguage.TabIndex = 22
        Me.txtLanguage.Text = "EN"
        '
        'txtRegistrationCount
        '
        Me.txtRegistrationCount.Location = New System.Drawing.Point(225, 424)
        Me.txtRegistrationCount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegistrationCount.Name = "txtRegistrationCount"
        Me.txtRegistrationCount.Size = New System.Drawing.Size(276, 26)
        Me.txtRegistrationCount.TabIndex = 25
        Me.txtRegistrationCount.Text = "5"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 427)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Registration Count"
        '
        'NCoServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 534)
        Me.Controls.Add(Me.txtRegistrationCount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtMessageServerSystemId)
        Me.Controls.Add(Me.txtMessageServerHost)
        Me.Controls.Add(Me.txtMessageServerService)
        Me.Controls.Add(Me.txtIdleTimeout)
        Me.Controls.Add(Me.txtGatewayService)
        Me.Controls.Add(Me.txtGatewayHost)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txtProgramID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NCoServer"
        Me.Text = "NCo 3 RFC Server Sample Part 2 Tobias Meyer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProgramID As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtGatewayHost As System.Windows.Forms.TextBox
    Friend WithEvents txtGatewayService As System.Windows.Forms.TextBox
    Friend WithEvents txtIdleTimeout As System.Windows.Forms.TextBox
    Friend WithEvents txtMessageServerService As System.Windows.Forms.TextBox
    Friend WithEvents txtMessageServerHost As System.Windows.Forms.TextBox
    Friend WithEvents txtMessageServerSystemId As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLanguage As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistrationCount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
