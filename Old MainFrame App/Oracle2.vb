Public Class Oracle2

    ' From https://stackoverflow.com/questions/4630825/capture-function-keys-f1-f12-in-vb-net
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData

            Case Keys.Space
                FillTextBox()

            Case Keys.F5
                MessageBox.Show("Record:" & vbCrLf & txtName.Text & vbCrLf & "Updated", "Skynet Systems")
                Application.Exit()


            Case Else
                Return MyBase.ProcessCmdKey(msg, keyData)

        End Select

        Return True
    End Function

    Protected Sub FillTextBox()
        Select Case Me.ActiveControl.Name
            Case NameOf(txtName)
                txtName.Text = "Charles ""Scaley"" Sterling"
            Case NameOf(txtAddress1)
                txtAddress1.Text = "In a Fishing Boat"
            Case NameOf(txtAddress2)
                txtAddress2.Text = "Somewhere off the"
            Case NameOf(txtCity)
                txtCity.Text = "GOLD COAST"
            Case NameOf(txtState)
                txtState.Text = "QLD"
            Case NameOf(txtZip)
                txtZip.Text = "4217"
        End Select
        Me.GetNextControl(Me.ActiveControl, True)?.Select()
        DirectCast(Me.ActiveControl, TextBox).Select(DirectCast(Me.ActiveControl, TextBox).Text.Length + 1, 1)
    End Sub
End Class