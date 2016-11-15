Imports SAP.Middleware.Connector

Public Class ServerFunction
    <RfcServerFunction(Name:="STFC_CONNECTION")> _
    Public Sub STFC_CONNECTION(myServerContext As RfcServerContext, myFunction As IRfcFunction)

        Console.WriteLine("System attributes: " & myServerContext.SystemAttributes.ToString)

        myFunction.SetValue("ECHOTEXT", myFunction.GetString("REQUTEXT"))
        myFunction.SetValue("RESPTEXT", "Hello from a NCo 3.0 RFC Server")
    End Sub
End Class
