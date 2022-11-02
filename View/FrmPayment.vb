Public Class FrmPayment
    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ClearData()
        txtBillingNo.Text = ""
        txtBillingDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")
        txtCardSN.Text = ""
        txtRefNo.Text = ""
        txtAmount.Text = ""
        txtInstallmentAmount.Text = "0"
        TxtTotInstallment.Text = "0"
        txtNPK.Text = ""
        txtCustName.Text = ""
        txtUnitBusiness.Text = ""
        txtPlafon.Text = "0"
        txtMemberID.Text = ""
        txtResignDate.Text = ""
        picCustPhoto.Image = Nothing
        lblMessage.Visible = False
        lblMessage2.Visible = False
        PBTapCard.Visible = False
        btnSubmit.Enabled = False
        btnRePrint.Enabled = False
        txtAmount.Enabled = False
        BtnCancel.Visible = False
        BtnCancel.Enabled = False
        cmbLoanPayment.Visible = False
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

    End Sub
End Class