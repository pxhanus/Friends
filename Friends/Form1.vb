Public Class Form1

    Private Sub btnGetInfo_Click(sender As Object, e As EventArgs) Handles btnGetInfo.Click
        Dim friendName As String = Me.txtFriendName.Text

        Select Case friendName.ToUpper
            Case "SHANA"
                Call SHANAInfo()
            Case "LUIZ"
                Call LUIZInfo()
            Case "CRIS"
                Call CRISInfo()
            Case Else
                MessageBox.Show("Sorry, no information available.")
        End Select
    End Sub
    Sub SHANAInfo()
        Me.picFriendPhoto.Image = My.Resources.ResourceManager.GetObject("shana")
        Me.lblFriendInfo.Text = "Shana's birthday is June 24. Her favorite animal is" & _
        " the turtle, her favorite color is blue, and she likes to play tennis."
    End Sub
    Sub LUIZInfo()
        Me.picFriendPhoto.Image = My.Resources.ResourceManager.GetObject("luiz")
        Me.lblFriendInfo.Text = "Luiz's birthday is August 21. His favorite animal is" & _
        " the tigar, his favorite color is green, and he likes to do gymnastics."
    End Sub
    Sub CRISInfo()
        Me.picFriendPhoto.Image = My.Resources.ResourceManager.GetObject("cris")
        Me.lblFriendInfo.Text = "Cris' birthday is September 20. His favorite animal is" & _
        " any kind of bird, his favorite color is red, and she likes to play the guitar."
    End Sub
End Class
