<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPayment))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMessage2 = New System.Windows.Forms.Label()
        Me.picCustPhoto = New System.Windows.Forms.PictureBox()
        Me.txtResignDate = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtPlafon = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtUnitBusiness = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtNPK = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.BtnScan = New System.Windows.Forms.Button()
        Me.txtInter = New System.Windows.Forms.TextBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.TxtTotInstallment = New System.Windows.Forms.TextBox()
        Me.TxtInterest = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.txtInstallmentAmount = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.cmbLoanPayment = New System.Windows.Forms.ComboBox()
        Me.PBTapCard = New System.Windows.Forms.ProgressBar()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.cmbTransType = New System.Windows.Forms.ComboBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtCardSN = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.txtBillingDate = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtBillingNo = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtTmp = New System.Windows.Forms.TextBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.PBLoading = New System.Windows.Forms.PictureBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCashierName = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.txtCashierID = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.txtMachineID = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnRePrint = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.picCustPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox4.SuspendLayout()
        CType(Me.PBLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Controls.Add(Me.BtnScan)
        Me.groupBox1.Controls.Add(Me.txtInter)
        Me.groupBox1.Controls.Add(Me.label19)
        Me.groupBox1.Controls.Add(Me.TxtTotInstallment)
        Me.groupBox1.Controls.Add(Me.TxtInterest)
        Me.groupBox1.Controls.Add(Me.label18)
        Me.groupBox1.Controls.Add(Me.txtInstallmentAmount)
        Me.groupBox1.Controls.Add(Me.label17)
        Me.groupBox1.Controls.Add(Me.cmbLoanPayment)
        Me.groupBox1.Controls.Add(Me.PBTapCard)
        Me.groupBox1.Controls.Add(Me.txtRefNo)
        Me.groupBox1.Controls.Add(Me.label12)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.cmbTransType)
        Me.groupBox1.Controls.Add(Me.lblMessage)
        Me.groupBox1.Controls.Add(Me.txtAmount)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtCardSN)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.btnPayment)
        Me.groupBox1.Controls.Add(Me.txtBillingDate)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtBillingNo)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtTmp)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(526, 401)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Payment"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.lblMessage2)
        Me.groupBox2.Controls.Add(Me.picCustPhoto)
        Me.groupBox2.Controls.Add(Me.txtResignDate)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.txtMemberID)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.txtPlafon)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.txtUnitBusiness)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.txtCustName)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.txtNPK)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Location = New System.Drawing.Point(6, 209)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(526, 196)
        Me.groupBox2.TabIndex = 2
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Customer Data"
        '
        'lblMessage2
        '
        Me.lblMessage2.AutoSize = True
        Me.lblMessage2.ForeColor = System.Drawing.Color.Red
        Me.lblMessage2.Location = New System.Drawing.Point(71, 172)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(163, 20)
        Me.lblMessage2.TabIndex = 27
        Me.lblMessage2.Text = "*Customer not eligible"
        '
        'picCustPhoto
        '
        Me.picCustPhoto.Location = New System.Drawing.Point(395, 19)
        Me.picCustPhoto.Name = "picCustPhoto"
        Me.picCustPhoto.Size = New System.Drawing.Size(113, 138)
        Me.picCustPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCustPhoto.TabIndex = 26
        Me.picCustPhoto.TabStop = False
        '
        'txtResignDate
        '
        Me.txtResignDate.Location = New System.Drawing.Point(74, 149)
        Me.txtResignDate.Name = "txtResignDate"
        Me.txtResignDate.ReadOnly = True
        Me.txtResignDate.Size = New System.Drawing.Size(303, 26)
        Me.txtResignDate.TabIndex = 24
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(6, 152)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(98, 20)
        Me.label10.TabIndex = 23
        Me.label10.Text = "Resign Date"
        '
        'txtMemberID
        '
        Me.txtMemberID.Location = New System.Drawing.Point(74, 123)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.ReadOnly = True
        Me.txtMemberID.Size = New System.Drawing.Size(303, 26)
        Me.txtMemberID.TabIndex = 22
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(6, 126)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(88, 20)
        Me.label9.TabIndex = 21
        Me.label9.Text = "Member ID"
        '
        'txtPlafon
        '
        Me.txtPlafon.Location = New System.Drawing.Point(74, 97)
        Me.txtPlafon.Name = "txtPlafon"
        Me.txtPlafon.ReadOnly = True
        Me.txtPlafon.Size = New System.Drawing.Size(303, 26)
        Me.txtPlafon.TabIndex = 20
        Me.txtPlafon.Text = "0"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 100)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(54, 20)
        Me.label8.TabIndex = 19
        Me.label8.Text = "Plafon"
        '
        'txtUnitBusiness
        '
        Me.txtUnitBusiness.Location = New System.Drawing.Point(74, 71)
        Me.txtUnitBusiness.Name = "txtUnitBusiness"
        Me.txtUnitBusiness.ReadOnly = True
        Me.txtUnitBusiness.Size = New System.Drawing.Size(303, 26)
        Me.txtUnitBusiness.TabIndex = 18
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(6, 74)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(76, 20)
        Me.label7.TabIndex = 17
        Me.label7.Text = "Company"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(74, 45)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(303, 26)
        Me.txtCustName.TabIndex = 16
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(6, 48)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(51, 20)
        Me.label6.TabIndex = 15
        Me.label6.Text = "Name"
        '
        'txtNPK
        '
        Me.txtNPK.Location = New System.Drawing.Point(74, 19)
        Me.txtNPK.Name = "txtNPK"
        Me.txtNPK.ReadOnly = True
        Me.txtNPK.Size = New System.Drawing.Size(303, 26)
        Me.txtNPK.TabIndex = 14
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(6, 22)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(35, 20)
        Me.label5.TabIndex = 13
        Me.label5.Text = "NIK"
        '
        'BtnScan
        '
        Me.BtnScan.Location = New System.Drawing.Point(424, 119)
        Me.BtnScan.Name = "BtnScan"
        Me.BtnScan.Size = New System.Drawing.Size(75, 82)
        Me.BtnScan.TabIndex = 27
        Me.BtnScan.Text = "Scan Barcode"
        Me.BtnScan.UseVisualStyleBackColor = True
        '
        'txtInter
        '
        Me.txtInter.Enabled = False
        Me.txtInter.Location = New System.Drawing.Point(329, 111)
        Me.txtInter.Name = "txtInter"
        Me.txtInter.Size = New System.Drawing.Size(48, 26)
        Me.txtInter.TabIndex = 26
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(199, 154)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(87, 20)
        Me.label19.TabIndex = 25
        Me.label19.Text = "Installment"
        '
        'TxtTotInstallment
        '
        Me.TxtTotInstallment.Enabled = False
        Me.TxtTotInstallment.Location = New System.Drawing.Point(260, 151)
        Me.TxtTotInstallment.Name = "TxtTotInstallment"
        Me.TxtTotInstallment.Size = New System.Drawing.Size(117, 26)
        Me.TxtTotInstallment.TabIndex = 24
        '
        'TxtInterest
        '
        Me.TxtInterest.Enabled = False
        Me.TxtInterest.Location = New System.Drawing.Point(260, 111)
        Me.TxtInterest.Name = "TxtInterest"
        Me.TxtInterest.Size = New System.Drawing.Size(63, 26)
        Me.TxtInterest.TabIndex = 23
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(199, 115)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(64, 20)
        Me.label18.TabIndex = 22
        Me.label18.Text = "Interest"
        '
        'txtInstallmentAmount
        '
        Me.txtInstallmentAmount.BackColor = System.Drawing.SystemColors.Window
        Me.txtInstallmentAmount.Enabled = False
        Me.txtInstallmentAmount.Location = New System.Drawing.Point(74, 151)
        Me.txtInstallmentAmount.Name = "txtInstallmentAmount"
        Me.txtInstallmentAmount.Size = New System.Drawing.Size(121, 26)
        Me.txtInstallmentAmount.TabIndex = 21
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(6, 154)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(53, 20)
        Me.label17.TabIndex = 20
        Me.label17.Text = "Pokok"
        '
        'cmbLoanPayment
        '
        Me.cmbLoanPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoanPayment.FormattingEnabled = True
        Me.cmbLoanPayment.Location = New System.Drawing.Point(212, 86)
        Me.cmbLoanPayment.Name = "cmbLoanPayment"
        Me.cmbLoanPayment.Size = New System.Drawing.Size(165, 28)
        Me.cmbLoanPayment.TabIndex = 19
        '
        'PBTapCard
        '
        Me.PBTapCard.Location = New System.Drawing.Point(424, 102)
        Me.PBTapCard.Name = "PBTapCard"
        Me.PBTapCard.Size = New System.Drawing.Size(75, 15)
        Me.PBTapCard.TabIndex = 18
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(74, 177)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(303, 26)
        Me.txtRefNo.TabIndex = 17
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(6, 180)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(67, 20)
        Me.label12.TabIndex = 16
        Me.label12.Text = "Ref. No."
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(6, 89)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(43, 20)
        Me.label11.TabIndex = 15
        Me.label11.Text = "Type"
        '
        'cmbTransType
        '
        Me.cmbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransType.FormattingEnabled = True
        Me.cmbTransType.Location = New System.Drawing.Point(74, 86)
        Me.cmbTransType.Name = "cmbTransType"
        Me.cmbTransType.Size = New System.Drawing.Size(121, 28)
        Me.cmbTransType.TabIndex = 14
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(71, 135)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(181, 20)
        Me.lblMessage.TabIndex = 13
        Me.lblMessage.Text = "*Amount is not sufficient"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(74, 112)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(121, 26)
        Me.txtAmount.TabIndex = 12
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 115)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 20)
        Me.label4.TabIndex = 11
        Me.label4.Text = "Amount"
        '
        'txtCardSN
        '
        Me.txtCardSN.Location = New System.Drawing.Point(74, 63)
        Me.txtCardSN.Name = "txtCardSN"
        Me.txtCardSN.ReadOnly = True
        Me.txtCardSN.Size = New System.Drawing.Size(303, 26)
        Me.txtCardSN.TabIndex = 10
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 66)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(69, 20)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Card SN"
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(424, 15)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(75, 87)
        Me.btnPayment.TabIndex = 4
        Me.btnPayment.Text = "Tap Card"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'txtBillingDate
        '
        Me.txtBillingDate.Location = New System.Drawing.Point(74, 39)
        Me.txtBillingDate.Name = "txtBillingDate"
        Me.txtBillingDate.ReadOnly = True
        Me.txtBillingDate.Size = New System.Drawing.Size(303, 26)
        Me.txtBillingDate.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 42)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(89, 20)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Billing Date"
        '
        'txtBillingNo
        '
        Me.txtBillingNo.Location = New System.Drawing.Point(74, 15)
        Me.txtBillingNo.Name = "txtBillingNo"
        Me.txtBillingNo.ReadOnly = True
        Me.txtBillingNo.Size = New System.Drawing.Size(303, 26)
        Me.txtBillingNo.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Billing No."
        '
        'txtTmp
        '
        Me.txtTmp.Location = New System.Drawing.Point(383, 154)
        Me.txtTmp.Name = "txtTmp"
        Me.txtTmp.Size = New System.Drawing.Size(16, 26)
        Me.txtTmp.TabIndex = 28
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.PBLoading)
        Me.groupBox4.Location = New System.Drawing.Point(544, 27)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(573, 507)
        Me.groupBox4.TabIndex = 5
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Receipt Preview"
        '
        'PBLoading
        '
        Me.PBLoading.Image = CType(resources.GetObject("PBLoading.Image"), System.Drawing.Image)
        Me.PBLoading.Location = New System.Drawing.Point(142, 189)
        Me.PBLoading.Name = "PBLoading"
        Me.PBLoading.Size = New System.Drawing.Size(100, 102)
        Me.PBLoading.TabIndex = 1
        Me.PBLoading.TabStop = False
        Me.PBLoading.Visible = False
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtCashierName)
        Me.groupBox3.Controls.Add(Me.label15)
        Me.groupBox3.Controls.Add(Me.txtCashierID)
        Me.groupBox3.Controls.Add(Me.label16)
        Me.groupBox3.Controls.Add(Me.txtLocation)
        Me.groupBox3.Controls.Add(Me.label14)
        Me.groupBox3.Controls.Add(Me.txtMachineID)
        Me.groupBox3.Controls.Add(Me.label13)
        Me.groupBox3.Location = New System.Drawing.Point(12, 423)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(526, 72)
        Me.groupBox3.TabIndex = 6
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Payment"
        '
        'txtCashierName
        '
        Me.txtCashierName.Location = New System.Drawing.Point(304, 45)
        Me.txtCashierName.Name = "txtCashierName"
        Me.txtCashierName.ReadOnly = True
        Me.txtCashierName.Size = New System.Drawing.Size(209, 26)
        Me.txtCashierName.TabIndex = 32
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(232, 48)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(109, 20)
        Me.label15.TabIndex = 31
        Me.label15.Text = "Cashier Name"
        '
        'txtCashierID
        '
        Me.txtCashierID.Location = New System.Drawing.Point(74, 45)
        Me.txtCashierID.Name = "txtCashierID"
        Me.txtCashierID.ReadOnly = True
        Me.txtCashierID.Size = New System.Drawing.Size(156, 26)
        Me.txtCashierID.TabIndex = 30
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(6, 48)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(84, 20)
        Me.label16.TabIndex = 29
        Me.label16.Text = "Cashier ID"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(304, 19)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.Size = New System.Drawing.Size(209, 26)
        Me.txtLocation.TabIndex = 28
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(257, 22)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(70, 20)
        Me.label14.TabIndex = 27
        Me.label14.Text = "Location"
        '
        'txtMachineID
        '
        Me.txtMachineID.Location = New System.Drawing.Point(74, 19)
        Me.txtMachineID.Name = "txtMachineID"
        Me.txtMachineID.ReadOnly = True
        Me.txtMachineID.Size = New System.Drawing.Size(156, 26)
        Me.txtMachineID.TabIndex = 26
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(6, 22)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(90, 20)
        Me.label13.TabIndex = 25
        Me.label13.Text = "Machine ID"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Red
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(109, 511)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(62, 44)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(13, 511)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(62, 44)
        Me.btnClear.TabIndex = 9
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.Image = CType(resources.GetObject("btnSubmit.Image"), System.Drawing.Image)
        Me.btnSubmit.Location = New System.Drawing.Point(320, 511)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 44)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnRePrint
        '
        Me.btnRePrint.BackColor = System.Drawing.Color.Transparent
        Me.btnRePrint.Image = CType(resources.GetObject("btnRePrint.Image"), System.Drawing.Image)
        Me.btnRePrint.Location = New System.Drawing.Point(401, 511)
        Me.btnRePrint.Name = "btnRePrint"
        Me.btnRePrint.Size = New System.Drawing.Size(75, 44)
        Me.btnRePrint.TabIndex = 7
        Me.btnRePrint.UseVisualStyleBackColor = False
        '
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1223, 567)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnRePrint)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Koperasi EDC - Payment"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.picCustPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox4.ResumeLayout(False)
        CType(Me.PBLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents lblMessage2 As Label
    Private WithEvents picCustPhoto As PictureBox
    Private WithEvents txtResignDate As TextBox
    Private WithEvents label10 As Label
    Private WithEvents txtMemberID As TextBox
    Private WithEvents label9 As Label
    Private WithEvents txtPlafon As TextBox
    Private WithEvents label8 As Label
    Private WithEvents txtUnitBusiness As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtCustName As TextBox
    Private WithEvents label6 As Label
    Private WithEvents txtNPK As TextBox
    Private WithEvents label5 As Label
    Private WithEvents BtnScan As Button
    Private WithEvents txtInter As TextBox
    Private WithEvents label19 As Label
    Private WithEvents TxtTotInstallment As TextBox
    Private WithEvents TxtInterest As TextBox
    Private WithEvents label18 As Label
    Private WithEvents txtInstallmentAmount As TextBox
    Private WithEvents label17 As Label
    Private WithEvents cmbLoanPayment As ComboBox
    Private WithEvents PBTapCard As ProgressBar
    Private WithEvents txtRefNo As TextBox
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents cmbTransType As ComboBox
    Private WithEvents lblMessage As Label
    Private WithEvents txtAmount As TextBox
    Private WithEvents label4 As Label
    Private WithEvents txtCardSN As TextBox
    Private WithEvents label3 As Label
    Private WithEvents btnPayment As Button
    Private WithEvents txtBillingDate As TextBox
    Private WithEvents label2 As Label
    Private WithEvents txtBillingNo As TextBox
    Private WithEvents label1 As Label
    Private WithEvents txtTmp As TextBox
    Private WithEvents groupBox4 As GroupBox
    Private WithEvents PBLoading As PictureBox
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents txtCashierName As TextBox
    Private WithEvents label15 As Label
    Private WithEvents txtCashierID As TextBox
    Private WithEvents label16 As Label
    Private WithEvents txtLocation As TextBox
    Private WithEvents label14 As Label
    Private WithEvents txtMachineID As TextBox
    Private WithEvents label13 As Label
    Private WithEvents BtnCancel As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnSubmit As Button
    Private WithEvents btnRePrint As Button
End Class
