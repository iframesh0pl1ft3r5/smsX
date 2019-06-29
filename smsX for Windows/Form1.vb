Imports Clockwork
Imports System.Net
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        'The following code will try to send an sms to the number given in Totextbox, using the API Key given in MaterialSingleLineTextField1.
        If MaterialRadioButton1.Checked = True Then

            Try
                Dim api As Clockwork.API = New Clockwork.API(MaterialSingleLineTextField1.Text)
                Dim sms As Clockwork.SMS = New Clockwork.SMS()
                sms.From = Fromtextbox.Text
                sms.To = Totextbox.Text
                sms.Message = Messagebox.Text

                Dim result As SMSResult = api.Send(sms)

                If (result.Success) Then
                    Windows.Forms.MessageBox.Show("Yay!, Success. Result ID: " + result.ID)
                Else
                    Windows.Forms.MessageBox.Show("Error: " + result.ErrorMessage)
                End If

            Catch ex As APIException
                ' You'll get an API exception for errors 
                ' such as wrong key
                Windows.Forms.MessageBox.Show("API Exception: " + ex.Message)
            Catch ex As WebException
                'Web exceptions mean you couldn't reach the mediaburst server
                Windows.Forms.MessageBox.Show("Web Exception: " + ex.Message)
            Catch ex As ArgumentException
                ' Argument exceptions are thrown for missing parameters,
                ' such as forgetting to set the username
                Windows.Forms.MessageBox.Show("Argument Exception: " + ex.Message)
            Catch ex As Exception
                ' Something else went wrong, the error message should help
                Windows.Forms.MessageBox.Show("Unknown Exception: " + ex.Message)
            End Try
        Else

            ' Find your Account Sid and Auth Token at twilio.com/console
            TwilioClient.Init(MaterialSingleLineTextField1.Text, MaterialSingleLineTextField2.Text)

            Dim toNumber = New PhoneNumber(Totextbox.Text)
            Dim message = MessageResource.Create(
                toNumber, from:=New PhoneNumber(Fromtextbox.Text),
                body:=Messagebox.Text)
            Windows.Forms.MessageBox.Show("Sent!: " + message.Sid)


        End If


    End Sub

    ' Opens Form2 (Twilio voice/vid client)
    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Form2.Show()
    End Sub

    Private Sub MaterialRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton2.CheckedChanged
        MaterialSingleLineTextField1.Hint = "Account SID"
        MaterialSingleLineTextField2.Visible = True
        MaterialSingleLineTextField1.Clear()
        MaterialSingleLineTextField2.Clear()
        MaterialLabel3.Visible = False

    End Sub

    Private Sub MaterialRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton1.CheckedChanged
        MaterialSingleLineTextField1.Hint = "API Key"
        MaterialSingleLineTextField2.Visible = False
        MaterialSingleLineTextField2.Clear()
        MaterialSingleLineTextField1.Clear()
        MaterialLabel3.Visible = True

    End Sub
End Class
