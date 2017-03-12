
Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter a message to spam!")
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        Timer2.Interval = 1

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SendKeys.Send("{ENTER}")
        SendKeys.Send(TextBox1.Text)
        SendKeys.Send("{ENTER}")

    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://hackforums.net/member.php?action=profile&uid=1512695")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("This Program was designed for Bonk.io in mind. It was crudely programed by Leroy Jethro Gibbs.")
    End Sub

    Private Sub HowItWorksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowItWorksToolStripMenuItem.Click
        MsgBox("Type your message into the messagebox. Then press Start. After pressing start, ensure you only click the window you want the send the spam messages too. For Bonk.io. Make sure the game is loaded and you are in either a lobby or a match. After pressing start and clicking on the window, you should see your messages spam. If it doesn't spam, just press enter and it should start.")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Dim die As Boolean
        Dim crash As Boolean


        die = GetAsyncKeyState(Keys.Escape)
        crash = GetAsyncKeyState(Keys.RShiftKey)

        If die = True Then

            Button2.PerformClick()
        ElseIf crash = True Then

            Button1.PerformClick()


        End If
    End Sub



    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()

    End Sub

    Private Sub HFThreadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HFThreadToolStripMenuItem.Click
        Process.Start("https://hackforums.net/showthread.php?tid=5572984")
    End Sub
End Class
