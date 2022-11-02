Imports KoperasiEDC.ClsKoneksi
Public Class FrmMenu
    Private Sub LblPayment_Click(sender As Object, e As EventArgs) Handles lblPayment.Click
        FrmPayment.Show()

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim widthForm As Integer = Me.Width
        Dim heidhtForm As Integer = Me.Width

        Dim PanelHeaderheightForm As Integer = Me.PanelHeader.Height
        Dim PanelSidewidhtForm As Integer = Me.PanelSidebar.Width
        Dim PanelSideheightForm As Integer = Me.PanelSidebar.Height
        PanelHeader.Size = New Drawing.Size(widthForm - 70, PanelHeaderheightForm - 0)
        PanelSidebar.Size = New Drawing.Size(PanelSidewidhtForm - 0, heidhtForm - 120)

    End Sub

    Private Sub LblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Me.Dispose()
    End Sub
End Class
