<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lab_officer_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lab_officer_dashboard))
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.landingpage = New System.Windows.Forms.TabPage()
        Me.quote = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.check_patient = New System.Windows.Forms.TabPage()
        Me.txtreceipt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lab_officer_remarkstxt = New System.Windows.Forms.TextBox()
        Me.test_resulttxt = New System.Windows.Forms.TextBox()
        Me.doctor_requesttxt = New System.Windows.Forms.TextBox()
        Me.gendertxt = New System.Windows.Forms.TextBox()
        Me.agetxt = New System.Windows.Forms.TextBox()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.About = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OlayinkasaheedolayemigmailcomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhoneNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DOCTORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lab_officerphonetxt = New System.Windows.Forms.TextBox()
        Me.employee_idtxt = New System.Windows.Forms.TextBox()
        Me.labofficernametxt = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.landingpage.SuspendLayout()
        Me.check_patient.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.About.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.landingpage)
        Me.TabControl1.Controls.Add(Me.check_patient)
        Me.TabControl1.Controls.Add(Me.About)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(152, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(925, 530)
        Me.TabControl1.TabIndex = 45
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
        Me.check_patient.Controls.Add(Me.txtreceipt)
        Me.check_patient.Controls.Add(Me.Panel1)
        Me.check_patient.Controls.Add(Me.Button1)
        Me.check_patient.Controls.Add(Me.Button7)
        Me.check_patient.Controls.Add(Me.Save)
        Me.check_patient.Location = New System.Drawing.Point(4, 31)
        Me.check_patient.Name = "check_patient"
        Me.check_patient.Padding = New System.Windows.Forms.Padding(3)
        Me.check_patient.Size = New System.Drawing.Size(917, 495)
        Me.check_patient.TabIndex = 2
        Me.check_patient.Text = "check_patient"
        '
        'txtreceipt
        '
        Me.txtreceipt.BackColor = System.Drawing.SystemColors.Control
        Me.txtreceipt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceipt.Location = New System.Drawing.Point(565, 7)
        Me.txtreceipt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtreceipt.Multiline = True
        Me.txtreceipt.Name = "txtreceipt"
        Me.txtreceipt.ReadOnly = True
        Me.txtreceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtreceipt.Size = New System.Drawing.Size(343, 479)
        Me.txtreceipt.TabIndex = 110
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lab_officer_remarkstxt)
        Me.Panel1.Controls.Add(Me.test_resulttxt)
        Me.Panel1.Controls.Add(Me.doctor_requesttxt)
        Me.Panel1.Controls.Add(Me.gendertxt)
        Me.Panel1.Controls.Add(Me.agetxt)
        Me.Panel1.Controls.Add(Me.nametxt)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(6, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 429)
        Me.Panel1.TabIndex = 54
        '
        'lab_officer_remarkstxt
        '
        Me.lab_officer_remarkstxt.BackColor = System.Drawing.SystemColors.Control
        Me.lab_officer_remarkstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lab_officer_remarkstxt.Location = New System.Drawing.Point(89, 370)
        Me.lab_officer_remarkstxt.Multiline = True
        Me.lab_officer_remarkstxt.Name = "lab_officer_remarkstxt"
        Me.lab_officer_remarkstxt.Size = New System.Drawing.Size(170, 47)
        Me.lab_officer_remarkstxt.TabIndex = 130
        '
        'test_resulttxt
        '
        Me.test_resulttxt.BackColor = System.Drawing.SystemColors.Control
        Me.test_resulttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.test_resulttxt.Location = New System.Drawing.Point(89, 308)
        Me.test_resulttxt.Multiline = True
        Me.test_resulttxt.Name = "test_resulttxt"
        Me.test_resulttxt.Size = New System.Drawing.Size(170, 47)
        Me.test_resulttxt.TabIndex = 130
        '
        'doctor_requesttxt
        '
        Me.doctor_requesttxt.BackColor = System.Drawing.SystemColors.Control
        Me.doctor_requesttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.doctor_requesttxt.Location = New System.Drawing.Point(89, 257)
        Me.doctor_requesttxt.Multiline = True
        Me.doctor_requesttxt.Name = "doctor_requesttxt"
        Me.doctor_requesttxt.ReadOnly = True
        Me.doctor_requesttxt.Size = New System.Drawing.Size(170, 45)
        Me.doctor_requesttxt.TabIndex = 129
        '
        'gendertxt
        '
        Me.gendertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gendertxt.Location = New System.Drawing.Point(89, 215)
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.ReadOnly = True
        Me.gendertxt.Size = New System.Drawing.Size(170, 26)
        Me.gendertxt.TabIndex = 128
        '
        'agetxt
        '
        Me.agetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.agetxt.Location = New System.Drawing.Point(89, 183)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.ReadOnly = True
        Me.agetxt.Size = New System.Drawing.Size(170, 26)
        Me.agetxt.TabIndex = 127
        '
        'nametxt
        '
        Me.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nametxt.Location = New System.Drawing.Point(89, 151)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.ReadOnly = True
        Me.nametxt.Size = New System.Drawing.Size(170, 26)
        Me.nametxt.TabIndex = 126
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 19)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "Age :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 19)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Names :"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(10, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 121
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Remarks"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.searchbtn)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.searchtxt)
        Me.Panel2.Location = New System.Drawing.Point(174, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 77)
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
        Me.searchbtn.Location = New System.Drawing.Point(172, 26)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 32)
        Me.searchbtn.TabIndex = 5
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
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
        Me.searchtxt.Location = New System.Drawing.Point(7, 29)
        Me.searchtxt.Multiline = True
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(161, 27)
        Me.searchtxt.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Test Result"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 218)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 19)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "Gender :"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 257)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 43)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Doctor Test Request"
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
        Me.Button1.Location = New System.Drawing.Point(407, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 36)
        Me.Button1.TabIndex = 108
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
        Me.Button7.Location = New System.Drawing.Point(204, 445)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 36)
        Me.Button7.TabIndex = 108
        Me.Button7.Text = "Preview"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.Gainsboro
        Me.Save.Enabled = False
        Me.Save.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Save.FlatAppearance.BorderSize = 2
        Me.Save.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(6, 445)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(100, 36)
        Me.Save.TabIndex = 109
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = False
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
        Me.Label6.Location = New System.Drawing.Point(159, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(626, 26)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "About LAUTECH Teaching Hosipital and the PRMS system"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'OlayinkasaheedolayemigmailcomToolStripMenuItem
        '
        Me.OlayinkasaheedolayemigmailcomToolStripMenuItem.Name = "OlayinkasaheedolayemigmailcomToolStripMenuItem"
        Me.OlayinkasaheedolayemigmailcomToolStripMenuItem.Size = New System.Drawing.Size(343, 26)
        Me.OlayinkasaheedolayemigmailcomToolStripMenuItem.Text = "olayinkasaheedolayemi@gmail.com"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(343, 26)
        Me.ToolStripMenuItem2.Text = "07030796165"
        '
        'PhoneNoToolStripMenuItem
        '
        Me.PhoneNoToolStripMenuItem.Name = "PhoneNoToolStripMenuItem"
        Me.PhoneNoToolStripMenuItem.Size = New System.Drawing.Size(343, 26)
        Me.PhoneNoToolStripMenuItem.Text = "Olasquare"
        '
        'AboutDeveloperToolStripMenuItem
        '
        Me.AboutDeveloperToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhoneNoToolStripMenuItem, Me.ToolStripMenuItem2, Me.OlayinkasaheedolayemigmailcomToolStripMenuItem})
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.AboutDeveloperToolStripMenuItem.Text = "About Developer "
        '
        'AboutSystemToolStripMenuItem
        '
        Me.AboutSystemToolStripMenuItem.Name = "AboutSystemToolStripMenuItem"
        Me.AboutSystemToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.AboutSystemToolStripMenuItem.Text = "About System"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutSystemToolStripMenuItem, Me.AboutDeveloperToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(69, 25)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CheckPatientToolStripMenuItem
        '
        Me.CheckPatientToolStripMenuItem.Name = "CheckPatientToolStripMenuItem"
        Me.CheckPatientToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.CheckPatientToolStripMenuItem.Text = "Check patient"
        '
        'DOCTORToolStripMenuItem
        '
        Me.DOCTORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckPatientToolStripMenuItem})
        Me.DOCTORToolStripMenuItem.Name = "DOCTORToolStripMenuItem"
        Me.DOCTORToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.DOCTORToolStripMenuItem.Text = "Patient"
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
        Me.EditProfileToolStripMenuItem.Text = "Edit profile"
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1102, 29)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(2, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BackgroundImage = Global.Patient_Record_Management_System_PRMS_.My.Resources.Resources.Presentation1
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Location = New System.Drawing.Point(0, 29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(152, 577)
        Me.Panel4.TabIndex = 46
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lab_officerphonetxt)
        Me.GroupBox3.Controls.Add(Me.employee_idtxt)
        Me.GroupBox3.Controls.Add(Me.labofficernametxt)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Century725 Cn BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 388)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.DarkRed
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Maroon
        Me.LinkLabel1.Location = New System.Drawing.Point(22, 341)
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
        Me.Label11.Location = New System.Drawing.Point(27, 226)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 19)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Phone No"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 34)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Welcome"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 134)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "Employee_ID"
        '
        'lab_officerphonetxt
        '
        Me.lab_officerphonetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lab_officerphonetxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_officerphonetxt.Location = New System.Drawing.Point(-2, 248)
        Me.lab_officerphonetxt.Multiline = True
        Me.lab_officerphonetxt.Name = "lab_officerphonetxt"
        Me.lab_officerphonetxt.ReadOnly = True
        Me.lab_officerphonetxt.Size = New System.Drawing.Size(127, 26)
        Me.lab_officerphonetxt.TabIndex = 140
        '
        'employee_idtxt
        '
        Me.employee_idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.employee_idtxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_idtxt.Location = New System.Drawing.Point(-2, 156)
        Me.employee_idtxt.Multiline = True
        Me.employee_idtxt.Name = "employee_idtxt"
        Me.employee_idtxt.ReadOnly = True
        Me.employee_idtxt.Size = New System.Drawing.Size(127, 27)
        Me.employee_idtxt.TabIndex = 140
        '
        'labofficernametxt
        '
        Me.labofficernametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labofficernametxt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labofficernametxt.Location = New System.Drawing.Point(-1, 74)
        Me.labofficernametxt.Multiline = True
        Me.labofficernametxt.Name = "labofficernametxt"
        Me.labofficernametxt.ReadOnly = True
        Me.labofficernametxt.Size = New System.Drawing.Size(127, 26)
        Me.labofficernametxt.TabIndex = 140
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 48)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 34)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = "Lab Officer"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_officer_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Patient_Record_Management_System_PRMS_.My.Resources.Resources.Presentation2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1102, 595)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "lab_officer_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lab_officer_dashboard"
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents landingpage As System.Windows.Forms.TabPage
    Friend WithEvents quote As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents check_patient As System.Windows.Forms.TabPage
    Friend WithEvents txtreceipt As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lab_officer_remarkstxt As System.Windows.Forms.TextBox
    Friend WithEvents test_resulttxt As System.Windows.Forms.TextBox
    Friend WithEvents doctor_requesttxt As System.Windows.Forms.TextBox
    Friend WithEvents gendertxt As System.Windows.Forms.TextBox
    Friend WithEvents agetxt As System.Windows.Forms.TextBox
    Friend WithEvents nametxt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents searchbtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents searchtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents About As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OlayinkasaheedolayemigmailcomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhoneNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutDeveloperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DOCTORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HOMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lab_officerphonetxt As System.Windows.Forms.TextBox
    Friend WithEvents employee_idtxt As System.Windows.Forms.TextBox
    Friend WithEvents labofficernametxt As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
