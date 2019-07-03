<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.btnAdminDetails = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnQues = New System.Windows.Forms.Button()
        Me.btnSI = New System.Windows.Forms.Button()
        Me.btnAddAdmin = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.lblAdminId = New System.Windows.Forms.Label()
        Me.MainDBDataSet = New ExaminationSystem.MainDBDataSet()
        Me.MainDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.pnl1.SuspendLayout()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(22, 10)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(106, 19)
        Me.lblAdmin.TabIndex = 0
        Me.lblAdmin.Text = "Admin Name"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(921, 22)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(96, 52)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.Button2)
        Me.pnl1.Controls.Add(Me.PictureBox1)
        Me.pnl1.Controls.Add(Me.btnAdminDetails)
        Me.pnl1.Controls.Add(Me.btnLogout)
        Me.pnl1.Controls.Add(Me.Button1)
        Me.pnl1.Controls.Add(Me.btnPassword)
        Me.pnl1.Controls.Add(Me.btnTest)
        Me.pnl1.Controls.Add(Me.btnQues)
        Me.pnl1.Controls.Add(Me.btnSI)
        Me.pnl1.Controls.Add(Me.btnAddAdmin)
        Me.pnl1.Controls.Add(Me.btnProfile)
        Me.pnl1.Controls.Add(Me.lblAdminId)
        Me.pnl1.Location = New System.Drawing.Point(12, 59)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(1050, 459)
        Me.pnl1.TabIndex = 3
        '
        'btnAdminDetails
        '
        Me.btnAdminDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAdminDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminDetails.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminDetails.ForeColor = System.Drawing.Color.White
        Me.btnAdminDetails.Location = New System.Drawing.Point(105, 20)
        Me.btnAdminDetails.Name = "btnAdminDetails"
        Me.btnAdminDetails.Size = New System.Drawing.Size(96, 52)
        Me.btnAdminDetails.TabIndex = 8
        Me.btnAdminDetails.Text = "Admin Details"
        Me.btnAdminDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdminDetails.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(717, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 52)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Results"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.Location = New System.Drawing.Point(615, 22)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(96, 52)
        Me.btnPassword.TabIndex = 6
        Me.btnPassword.Text = "Change Password"
        Me.btnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.Location = New System.Drawing.Point(513, 22)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(96, 52)
        Me.btnTest.TabIndex = 5
        Me.btnTest.Text = "Schedule Test"
        Me.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'btnQues
        '
        Me.btnQues.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnQues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQues.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQues.ForeColor = System.Drawing.Color.White
        Me.btnQues.Location = New System.Drawing.Point(411, 22)
        Me.btnQues.Name = "btnQues"
        Me.btnQues.Size = New System.Drawing.Size(96, 52)
        Me.btnQues.TabIndex = 4
        Me.btnQues.Text = "Add/View Questions"
        Me.btnQues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnQues.UseVisualStyleBackColor = False
        '
        'btnSI
        '
        Me.btnSI.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSI.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSI.ForeColor = System.Drawing.Color.White
        Me.btnSI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSI.Location = New System.Drawing.Point(309, 22)
        Me.btnSI.Name = "btnSI"
        Me.btnSI.Size = New System.Drawing.Size(96, 52)
        Me.btnSI.TabIndex = 3
        Me.btnSI.Text = "Student Info"
        Me.btnSI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSI.UseVisualStyleBackColor = False
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAdmin.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAddAdmin.Location = New System.Drawing.Point(207, 22)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(96, 52)
        Me.btnAddAdmin.TabIndex = 2
        Me.btnAddAdmin.Text = "Add Admin"
        Me.btnAddAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Location = New System.Drawing.Point(3, 21)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(96, 52)
        Me.btnProfile.TabIndex = 1
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'lblAdminId
        '
        Me.lblAdminId.AutoSize = True
        Me.lblAdminId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminId.Location = New System.Drawing.Point(10, 0)
        Me.lblAdminId.Name = "lblAdminId"
        Me.lblAdminId.Size = New System.Drawing.Size(49, 19)
        Me.lblAdminId.TabIndex = 0
        Me.lblAdminId.Text = "Admin"
        '
        'MainDBDataSet
        '
        Me.MainDBDataSet.DataSetName = "MainDBDataSet"
        Me.MainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainDBDataSetBindingSource
        '
        Me.MainDBDataSetBindingSource.DataSource = Me.MainDBDataSet
        Me.MainDBDataSetBindingSource.Position = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1044, 499)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(819, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 52)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "About Us"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(22, 37)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(67, 19)
        Me.lblSubject.TabIndex = 1
        Me.lblSubject.Text = "Subject"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1091, 528)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblAdmin)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdmin As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnl1 As Panel
    Friend WithEvents btnPassword As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents btnQues As Button
    Friend WithEvents btnSI As Button
    Friend WithEvents btnAddAdmin As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents lblAdminId As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAdminDetails As Button
    Friend WithEvents MainDBDataSetBindingSource As BindingSource
    Friend WithEvents MainDBDataSet As MainDBDataSet
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblSubject As Label
End Class
