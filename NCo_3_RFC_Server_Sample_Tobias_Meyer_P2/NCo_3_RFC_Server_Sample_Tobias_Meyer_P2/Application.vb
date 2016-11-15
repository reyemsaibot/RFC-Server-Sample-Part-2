
Imports System.IO
Imports System.Threading
Imports SAP.Middleware.Connector

Module Application
    Public Sub Main()
        Dim args() As String = Environment.GetCommandLineArgs()
        If args.Length > 0 And String.Equals(args(1).ToUpper, "-R") Then
            Dim remoteServer As RfcServer
            Dim parameters As New RfcConfigParameters()
            parameters(RfcConfigParameters.Name) = "NCO_SERVER"
            Dim repository As String

            With My.Settings

                If String.IsNullOrEmpty(.RfcProgramId) OrElse String.IsNullOrEmpty(.RfcGatewayHost) OrElse String.IsNullOrEmpty(.RfcGatewayService) OrElse String.IsNullOrEmpty(.RfcIdleTimeout) OrElse String.IsNullOrEmpty(.RfcLanguage) OrElse String.IsNullOrEmpty(.RfcPassword) OrElse String.IsNullOrEmpty(.RfcUser) OrElse String.IsNullOrEmpty(.RfcRegistrationCount) Then
                    MessageBox.Show("Please fill all necessary fields!", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                parameters(RfcConfigParameters.ProgramID) = .RfcProgramId
                parameters(RfcConfigParameters.GatewayHost) = .RfcGatewayHost
                parameters(RfcConfigParameters.GatewayService) = .RfcGatewayService
                parameters(RfcConfigParameters.ConnectionIdleTimeout) = .RfcIdleTimeout


                parameters(RfcConfigParameters.MessageServerHost) = .RfcMessageServer
                parameters(RfcConfigParameters.MessageServerService) = .RfcMessageServerService()
                parameters(RfcConfigParameters.SystemID) = .RfcMessageServerSystemID
                parameters(RfcConfigParameters.User) = .RfcUser
                parameters(RfcConfigParameters.Password) = .RfcPassword
                parameters(RfcConfigParameters.Language) = .RfcLanguage
                parameters(RfcConfigParameters.RegistrationCount) = .RfcRegistrationCount

            End With

            remoteServer = RfcServerManager.GetServer(parameters, New Type() {GetType(ServerFunction)})

            repository = CStr(My.Resources.ResourceManager.GetObject("repo"))
            Dim fileFunc As New StringReader(repository)
            Dim rfcRepository As New RfcCustomRepository
            rfcRepository.Load(fileFunc)
            remoteServer.Repository = rfcRepository
            
            remoteServer.Start()
            Thread.Sleep(400000)
        Else
          Dim server As New NCoServer
            server.ShowDialog()
        End If
    End Sub

End Module


