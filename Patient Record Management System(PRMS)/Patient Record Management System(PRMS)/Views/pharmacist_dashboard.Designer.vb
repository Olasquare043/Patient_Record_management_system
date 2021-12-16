<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmacist_dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmacist_dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DOCTORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhoneNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlayinkasaheedolayemigmailcomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.landingpage = New System.Windows.Forms.TabPage()
        Me.quote = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.check_patient = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.unavailable_drugtxt = New System.Windows.Forms.TextBox()
        Me.agetxt = New System.Windows.Forms.TextBox()
        Me.drug_giventxt = New System.Windows.Forms.TextBox()
        Me.pharmacist_remarkstxt = New System.Windows.Forms.TextBox()
        Me.doctor_prescriptiontxt = New System.Windows.Forms.TextBox()
        Me.gendertxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtreceipt = New System.Windows.Forms.TextBox()
        Me.About = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pharmacist_phonetxt = New System.Windows.Forms.TextBox()
        Me.employee_idtxt = New System.Windows.Forms.TextBox()
        Me.pharmacisttxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.landingpage.SuspendLayout()
        Me.check_patient.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.About.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.DOCTORToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1106, 29)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(67, 25)
        Me.HOMEToolStripMenuItem.Text = "Home"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'DOCTORToolStripMenuItem
        '
        Me.DOCTORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckPatientToolStripMenuItem})
        Me.DOCTORToolStripMenuItem.Name = "DOCTORToolStripMenuItem"
        Me.DOCTORToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.DOCTORToolStripMenuItem.Text = "Patient"
        '
        'CheckPatientToolStripMenuItem
        '
        Me.CheckPatientToolStripMenuItem.Name = "CheckPatientToolStripMenuItem"
        Me.CheckPatientToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.CheckPatientToolStripMenuItem.Text = "Check patient"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutSystemToolStripMenuItem, Me.AboutDeveloperToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(69, 25)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutSystemToolStripMenuItem
        '
        Me.AboutSystemToolStripMenuItem.Name = "AboutSystemToolStripMenuItem"
        Me.AboutSystemToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.AboutSystemToolStripMenuItem.Text = "About System"
        '
        'AboutDeveloperToolStripMenuItem
        '
        Me.AboutDeveloperToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhoneNoToolStripMenuItem, Me.ToolStripMenuItem2, Me.OlayinkasaheedolayemigmailcomToolStripMenuItem})
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.AboutDeveloperToolStripMenuItem.Text = "About Developer "
        '
        'PhoneNoToolStripMenuItem
        '
        Me.PhoneNoToolStripMenuItem.Name = "PhoneNoToolStripMenuItem"
        Me.PhoneNoToolStripMenuItem.Size = New System.Drawing.Size(343, 26)
        Me.PhoneNoToolStripMenuItem.Text = "Olasquare"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(343, 26)
        Me.ToolStripMenuItem2.Text = "07030796165"
        '
        'OlayinkasaheedolayemigmailcomToolStripMenuItem
        '
        Me.OlayinkasaheedolayemigmailcomToolStripMenuItem.Name = "OlayinkasaheedolayemigmailcomToolStripMenuItem"
        Me.OlayinkasaheedolayemigmailcomToolStripMenuItem.Size = New System.Drawing.Size(343, 26)
        Me.OlayinkasaheedolayemigmailcomToolStripMenuItem.Text = "olayinkasaheedolayemi@gmail.com"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.landingpage)
        Me.TabControl1.Controls.Add(Me.check_patient)
        Me.TabControl1.Controls.Add(Me.About)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(152, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(925, 530)
        Me.TabControl1.TabIndex = 39
        '
        'landingpage
        '
        Me.landingpage.BackColor = System.Drawing.SystemColors.Control
        Me.landingpage.BackgroundImage = Global.Patient_Record_Management_System_PRMS_.My.Resources.Resources.Doctor_Free_PNG_Image
        Me.landingpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.landingpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.landingpage.Controls.Add(Me.quote)
        Me.landingpage.Controls.Add(Me.Label1)
        Me.landingpage.Location = New System.Drawing.Point(4, 31)
        Me.landingpage.Name = "landingpage"
        Me.landingpage.Padding = New System.Windows.Forms.Padding(3)
        Me.landingpage.Size = New System.Drawing.Size(917, 495)
        Me.landingpage.TabIndex = 0
        Me.landingpage.Text = "landingpage"
        '
        'quote
        '
        Me.quote.BackColor = System.Drawing.Color.Transparent
        Me.quote.Font = New System.Drawing.Font("Century725 Cn BT", 21.75!)
        Me.quote.Location = New System.Drawing.Point(488, 28)
        Me.quote.Name = "quote"
        Me.quote.Size = New System.Drawing.Size(423, 107)
        Me.quote.TabIndex = 39
        Me.quote.Text = "To keep body in good health is our the duty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(674, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "120"
        '
        'check_patient
        '
        Me.check_patient.BackColor = System.Drawing.SystemColors.Control
        Me.check_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.check_patient.Controls.Add(Me.Button6)
        Me.check_patient.Controls.Add(Me.Button1)
        Me.check_patient.Controls.Add(Me.Button7)
        Me.check_patient.Controls.Add(Me.Panel1)
        Me.check_patient.Controls.Add(Me.txtreceipt)
        Me.check_patient.Location = New System.Drawing.Point(4, 31)
        Me.check_patient.Name = "check_patient"
        Me.check_patient.Padding = New System.Windows.Forms.Padding(3)
        Me.check_patient.Size = New System.Drawing.Size(917, 495)
        Me.check_patient.TabIndex = 2
        Me.check_patient.Text = "check_patient"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gainsboro
        Me.Button6.Enabled = False
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Button6.FlatAppearance.BorderSize = 2
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(6, 450)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 36)
        Me.Button6.TabIndex = 111
        Me.Button6.Text = "Save"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(454, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 36)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Button7.FlatAppearance.BorderSize = 2
        Me.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(249, 451)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(94, 36)
        Me.Button7.TabIndex = 110
        Me.Button7.Text = "Preview"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.unavailable_drugtxt)
        Me.Panel1.Controls.Add(Me.agetxt)
        Me.Panel1.Controls.Add(Me.drug_giventxt)
        Me.Panel1.Controls.Add(Me.pharmacist_remarkstxt)
        Me.Panel1.Controls.Add(Me.doctor_prescriptiontxt)
        Me.Panel1.Controls.Add(Me.gendertxt)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.nametxt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 437)
        Me.Panel1.TabIndex = 54
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(9, 355)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(294, 23)
        Me.CheckBox2.TabIndex = 130
        Me.CheckBox2.Text = "Yes, all doctor prescribed drugs was given ?"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'unavailable_drugtxt
        '
        Me.unavailable_drugtxt.BackColor = System.Drawing.SystemColors.Control
        Me.unavailable_drugtxt.Location = New System.Drawing.Point(141, 381)
        Me.unavailable_drugtxt.Multiline = True
        Me.unavailable_drugtxt.Name = "unavailable_drugtxt"
        Me.unavailable_drugtxt.Size = New System.Drawing.Size(170, 43)
        Me.unavailable_drugtxt.TabIndex = 129
        Me.unavailable_drugtxt.Visible = False
        '
        'agetxt
        '
        Me.agetxt.Location = New System.Drawing.Point(141, 206)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.ReadOnly = True
        Me.agetxt.Size = New System.Drawing.Size(170, 26)
        Me.agetxt.TabIndex = 129
        '
        'drug_giventxt
        '
        Me.drug_giventxt.BackColor = System.Drawing.SystemColors.Control
        Me.drug_giventxt.Location = New System.Drawing.Point(141, 305)
        Me.drug_giventxt.Multiline = True
        Me.drug_giventxt.Name = "drug_giventxt"
        Me.drug_giventxt.Size = New System.Drawing.Size(170, 44)
        Me.drug_giventxt.TabIndex = 128
        '
        'pharmacist_remarkstxt
        '
        Me.pharmacist_remarkstxt.BackColor = System.Drawing.SystemColors.Control
        Me.pharmacist_remarkstxt.Location = New System.Drawing.Point(341, 155)
        Me.pharmacist_remarkstxt.Multiline = True
        Me.pharmacist_remarkstxt.Name = "pharmacist_remarkstxt"
        Me.pharmacist_remarkstxt.Size = New System.Drawing.Size(170, 78)
        Me.pharmacist_remarkstxt.TabIndex = 126
        '
        'doctor_prescriptiontxt
        '
        Me.doctor_prescriptiontxt.BackColor = System.Drawing.SystemColors.Control
        Me.doctor_prescriptiontxt.Location = New System.Drawing.Point(141, 246)
        Me.doctor_prescriptiontxt.Multiline = True
        Me.doctor_prescriptiontxt.Name = "doctor_prescriptiontxt"
        Me.doctor_prescriptiontxt.ReadOnly = True
        Me.doctor_prescriptiontxt.Size = New System.Drawing.Size(170, 49)
        Me.doctor_prescriptiontxt.TabIndex = 126
        '
        'gendertxt
        '
        Me.gendertxt.Location = New System.Drawing.Point(141, 174)
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.ReadOnly = True
        Me.gendertxt.Size = New System.Drawing.Size(170, 26)
        Me.gendertxt.TabIndex = 128
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(337, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "Remarks"
        '
        'nametxt
        '
        Me.nametxt.Location = New System.Drawing.Point(141, 139)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.ReadOnly = True
        Me.nametxt.Size = New System.Drawing.Size(170, 26)
        Me.nametxt.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Doctor Prescription"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 19)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Names :"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 121
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Drugs Given"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.searchbtn)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.searchtxt)
        Me.Panel2.Location = New System.Drawing.Point(230, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 77)
        Me.Panel2.TabIndex = 119
        '
        'searchbtn
        '
        Me.searchbtn.BackColor = System.Drawing.Color.Gainsboro
        Me.searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.searchbtn.FlatAppearance.BorderSize = 2
        Me.searchbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbtn.Location = New System.Drawing.Point(205, 26)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 32)
        Me.searchbtn.TabIndex = 5
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 19)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Enter Patient H/C No"
        '
        'searchtxt
        '
        Me.searchtxt.AcceptsReturn = True
        Me.searchtxt.AcceptsTab = True
        Me.searchtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.searchtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.searchtxt.BackColor = System.Drawing.SystemColors.MenuBar
        Me.searchtxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchtxt.Location = New System.Drawing.Point(11, 29)
        Me.searchtxt.Multiline = True
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(190, 27)
        Me.searchtxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Unavailable Drugs"
        Me.Label2.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 173)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 19)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "Gender :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 205)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 19)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Age :"
        '
        'txtreceipt
        '
        Me.txtreceipt.BackColor = System.Drawing.SystemColors.Control
        Me.txtreceipt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceipt.Location = New System.Drawing.Point(562, 7)
        Me.txtreceipt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtreceipt.Multiline = True
        Me.txtreceipt.Name = "txtreceipt"
        Me.txtreceipt.ReadOnly = True
        Me.txtreceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtreceipt.Size = New System.Drawing.Size(343, 479)
        Me.txtreceipt.TabIndex = 53
        '
        'About
        '
        Me.About.BackColor = System.Drawing.SystemColors.Control
        Me.About.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.About.Controls.Add(Me.TextBox1)
        Me.About.Controls.Add(Me.Label6)
        Me.About.Location = New System.Drawing.Point(4, 31)
        Me.About.Name = "About"
        Me.About.Padding = New System.Windows.Forms.Padding(3)
        Me.About.Size = New System.Drawing.Size(917, 495)
        Me.About.TabIndex = 4
        Me.About.Text = "About"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(131, 85)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(653, 322)
        Me.TextBox1.TabIndex = 41
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(147, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(626, 26)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "About LAUTECH Teaching Hosipital and the PRMS system"
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BackgroundImage = Global.Patient_Record_Management_System_PRMS_.My.Resources.Resources.Presentation1
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Location = New System.Drawing.Point(0, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(152, 578)
        Me.Panel4.TabIndex = 40
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.pharmacist_phonetxt)
        Me.GroupBox3.Controls.Add(Me.employee_idtxt)
        Me.GroupBox3.Controls.Add(Me.pharmacisttxt)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 388)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.DarkRed
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Maroon
        Me.LinkLabel1.Location = New System.Drawing.Point(28, 339)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(82, 22)
        Me.LinkLabel1.TabIndex = 141
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Sign Out"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 226)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 19)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Phone No"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 34)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Welcome"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 134)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "Employee_ID"
        '
        'pharmacist_phonetxt
        '
        Me.pharmacist_phonetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pharmacist_phonetxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharmacist_phonetxt.Location = New System.Drawing.Point(-2, 248)
        Me.pharmacist_phonetxt.Multiline = True
        Me.pharmacist_phonetxt.Name = "pharmacist_phonetxt"
        Me.pharmacist_phonetxt.ReadOnly = True
        Me.pharmacist_phonetxt.Size = New System.Drawing.Size(133, 26)
        Me.pharmacist_phonetxt.TabIndex = 140
        '
        'employee_idtxt
        '
        Me.employee_idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.employee_idtxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_idtxt.Location = New System.Drawing.Point(-2, 157)
        Me.employee_idtxt.Multiline = True
        Me.employee_idtxt.Name = "employee_idtxt"
        Me.employee_idtxt.ReadOnly = True
        Me.employee_idtxt.Size = New System.Drawing.Size(127, 27)
        Me.employee_idtxt.TabIndex = 140
        '
        'pharmacisttxt
        '
        Me.pharmacisttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pharmacisttxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharmacisttxt.Location = New System.Drawing.Point(-1, 74)
        Me.pharmacisttxt.Multiline = True
        Me.pharmacisttxt.Name = "pharmacisttxt"
        Me.pharmacisttxt.ReadOnly = True
        Me.pharmacisttxt.Size = New System.Drawing.Size(126, 26)
        Me.pharmacisttxt.TabIndex = 140
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 45)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 34)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Pharmacist"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pharmacist_dashboard
        '
        Me.AcceptButton = Me.searchbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Patient_Record_Management_System_PRMS_.My.Resources.Resources.Presentation2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1106, 599)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "pharmacist_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pharmacist_dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.landingpage.ResumeLayout(False)
        Me.landingpage.PerformLayout()
        Me.check_patient.ResumeLayout(False)
        Me.check_patient.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.About.ResumeLayout(False)
        Me.About.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DOCTORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents landingpage As System.Windows.Forms.TabPage
    Friend WithEvents check_patient As System.Windows.Forms.TabPage
    Friend WithEvents About As System.Windows.Forms.TabPage
    Friend WithEvents CheckPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutDeveloperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhoneNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlayinkasaheedolayemigmailcomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents quote As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtreceipt As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents agetxt As System.Windows.Forms.TextBox
    Friend WithEvents gendertxt As System.Windows.Forms.TextBox
    Friend WithEvents nametxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents searchbtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents searchtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pharmacist_phonetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents employee_idtxt As System.Windows.Forms.TextBox
    Friend WithEvents pharmacisttxt As System.Windows.Forms.TextBox
    Friend WithEvents unavailable_drugtxt As System.Windows.Forms.TextBox
    Friend WithEvents drug_giventxt As System.Windows.Forms.TextBox
    Friend WithEvents doctor_prescriptiontxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents EditProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents pharmacist_remarkstxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
