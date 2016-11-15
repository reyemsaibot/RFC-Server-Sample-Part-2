Public Class NCoServer

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        With My.Settings
            .RfcProgramId = txtProgramID.Text
            .RfcGatewayHost = txtGatewayHost.Text
            .RfcGatewayService = txtGatewayService.Text
            .RfcIdleTimeout = txtIdleTimeout.Text

            .RfcMessageServer = txtMessageServerHost.Text
            .RfcMessageServerService = txtMessageServerService.Text
            .RfcMessageServerSystemID = txtMessageServerSystemId.Text

            .RfcLanguage = txtLanguage.Text
            .RfcPassword = txtPassword.Text
            .RfcUser = txtUser.Text

            .RfcRegistrationCount = txtRegistrationCount.Text
            My.Settings.Save()
        End With
    End Sub

    Private Sub NCoServer_Load(sender As Object, e As EventArgs) Handles Me.Load
        With My.Settings
            txtProgramID.Text = .RfcProgramId
            txtGatewayHost.Text = .RfcGatewayHost
            txtGatewayService.Text = .RfcGatewayService
            txtIdleTimeout.Text = .RfcIdleTimeout

            txtMessageServerHost.Text = .RfcMessageServer
            txtMessageServerService.Text = .RfcMessageServerService
            txtMessageServerSystemId.Text = .RfcMessageServerSystemID

            txtLanguage.Text = .RfcLanguage
            txtPassword.Text = .RfcPassword
            txtUser.Text = .RfcUser

            txtRegistrationCount.Text = .RfcRegistrationCount
        End With
    End Sub
End Class
