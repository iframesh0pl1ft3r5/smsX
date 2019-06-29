Imports Clockwork
Imports System.Net
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs) Handles MaterialLabel2.Click

    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        TwilioClient.Init(accsid.Text, authtoken.Text)
        Dim [call] = CallResource.Create(url:=New Uri("http://demo.twilio.com/docs/voice.xml"), [to]:=New Twilio.Types.PhoneNumber(tonumber.Text), from:=New Twilio.Types.PhoneNumber(fromnumber.Text))
        Console.WriteLine([call].Sid)
        countw.Text = Date.Now.ToString("h:mm:ss tt")
    End Sub
End Class