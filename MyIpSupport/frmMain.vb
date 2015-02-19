Imports System.Net
Imports System.Net.Sockets

Public Class frmMain
    Private Sub btnClose_Click (ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Function IPAddress() As String
        Dim host As IPHostEntry
        Dim localIP As String = "Error"
        host = Dns.GetHostEntry (Dns.GetHostName())
        For Each ip As IPAddress In host.AddressList
            If ip.AddressFamily = AddressFamily.InterNetwork Then
                'Console.WriteLine (ip.ToString())
                If ip.ToString = "127.0.0.1" Then
                    localIP = "Loopback Error"
                Else
                    localIP = ip.ToString()
                    Exit For
                End If
            End If
        Next
        Return localIP
    End Function

    Private Sub frmMain_Load (ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lblIP.Text = IPAddress()
    End Sub

    Private Sub PictureBox1_Click (ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox1.Click
        Process.Start ("http://meamod.com")
    End Sub
End Class
