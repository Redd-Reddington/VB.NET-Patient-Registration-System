<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtFullName = New TextBox()
        cmbGender = New ComboBox()
        txtPhoneNumber = New TextBox()
        txtAddress = New TextBox()
        txtMedicalCondition = New TextBox()
        dtpDateOfBirth = New DateTimePicker()
        dtpRegistrationDate = New DateTimePicker()
        picProfile = New PictureBox()
        lblFullName = New Label()
        lblGender = New Label()
        lblDateOfBirth = New Label()
        lblPhoneNumber = New Label()
        lblAddress = New Label()
        lblMedicalCondition = New Label()
        lblRegistrationDate = New Label()
        lblProfileImage = New Label()
        lblHeading = New Label()
        dgvDisplay = New DataGridView()
        btnBrowse = New Button()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDisplay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(285, 86)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(267, 27)
        txtFullName.TabIndex = 0
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        cmbGender.Location = New Point(285, 137)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(267, 28)
        cmbGender.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(285, 258)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(267, 27)
        txtPhoneNumber.TabIndex = 3
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(285, 308)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(267, 27)
        txtAddress.TabIndex = 4
        ' 
        ' txtMedicalCondition
        ' 
        txtMedicalCondition.Location = New Point(285, 364)
        txtMedicalCondition.Name = "txtMedicalCondition"
        txtMedicalCondition.Size = New Size(267, 27)
        txtMedicalCondition.TabIndex = 5
        ' 
        ' dtpDateOfBirth
        ' 
        dtpDateOfBirth.Location = New Point(285, 194)
        dtpDateOfBirth.Name = "dtpDateOfBirth"
        dtpDateOfBirth.Size = New Size(267, 27)
        dtpDateOfBirth.TabIndex = 6
        ' 
        ' dtpRegistrationDate
        ' 
        dtpRegistrationDate.Location = New Point(285, 435)
        dtpRegistrationDate.Name = "dtpRegistrationDate"
        dtpRegistrationDate.Size = New Size(267, 27)
        dtpRegistrationDate.TabIndex = 7
        ' 
        ' picProfile
        ' 
        picProfile.Location = New Point(285, 497)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(267, 181)
        picProfile.TabIndex = 8
        picProfile.TabStop = False
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 12F)
        lblFullName.Location = New Point(98, 85)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(100, 28)
        lblFullName.TabIndex = 9
        lblFullName.Text = "Full Name"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 12F)
        lblGender.Location = New Point(98, 133)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(76, 28)
        lblGender.TabIndex = 10
        lblGender.Text = "Gender"
        ' 
        ' lblDateOfBirth
        ' 
        lblDateOfBirth.AutoSize = True
        lblDateOfBirth.Font = New Font("Segoe UI", 12F)
        lblDateOfBirth.Location = New Point(98, 194)
        lblDateOfBirth.Name = "lblDateOfBirth"
        lblDateOfBirth.Size = New Size(125, 28)
        lblDateOfBirth.TabIndex = 11
        lblDateOfBirth.Text = "Date Of Birth"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Font = New Font("Segoe UI", 12F)
        lblPhoneNumber.Location = New Point(98, 257)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(144, 28)
        lblPhoneNumber.TabIndex = 13
        lblPhoneNumber.Text = "Phone Number"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 12F)
        lblAddress.Location = New Point(98, 308)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(82, 28)
        lblAddress.TabIndex = 14
        lblAddress.Text = "Address"
        ' 
        ' lblMedicalCondition
        ' 
        lblMedicalCondition.AutoSize = True
        lblMedicalCondition.Font = New Font("Segoe UI", 12F)
        lblMedicalCondition.Location = New Point(98, 364)
        lblMedicalCondition.Name = "lblMedicalCondition"
        lblMedicalCondition.Size = New Size(173, 28)
        lblMedicalCondition.TabIndex = 15
        lblMedicalCondition.Text = "Medical Condition"
        ' 
        ' lblRegistrationDate
        ' 
        lblRegistrationDate.AutoSize = True
        lblRegistrationDate.Font = New Font("Segoe UI", 12F)
        lblRegistrationDate.Location = New Point(98, 433)
        lblRegistrationDate.Name = "lblRegistrationDate"
        lblRegistrationDate.Size = New Size(163, 28)
        lblRegistrationDate.TabIndex = 16
        lblRegistrationDate.Text = "Registration Date"
        ' 
        ' lblProfileImage
        ' 
        lblProfileImage.AutoSize = True
        lblProfileImage.Font = New Font("Segoe UI", 12F)
        lblProfileImage.Location = New Point(98, 535)
        lblProfileImage.Name = "lblProfileImage"
        lblProfileImage.Size = New Size(137, 28)
        lblProfileImage.TabIndex = 17
        lblProfileImage.Text = "Profile Imagee"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblHeading.Location = New Point(285, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(547, 46)
        lblHeading.TabIndex = 18
        lblHeading.Text = "PATIENT REGISTRATION SYSTEM"
        ' 
        ' dgvDisplay
        ' 
        dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDisplay.Location = New Point(625, 86)
        dgvDisplay.Name = "dgvDisplay"
        dgvDisplay.RowHeadersWidth = 51
        dgvDisplay.Size = New Size(1154, 564)
        dgvDisplay.TabIndex = 19
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(330, 684)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(160, 29)
        btnBrowse.TabIndex = 20
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(149, 741)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(122, 43)
        btnSave.TabIndex = 21
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(293, 741)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(122, 43)
        btnUpdate.TabIndex = 22
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(445, 741)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(122, 43)
        btnDelete.TabIndex = 23
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(585, 741)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(122, 43)
        btnClear.TabIndex = 24
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1791, 907)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(btnBrowse)
        Controls.Add(dgvDisplay)
        Controls.Add(lblHeading)
        Controls.Add(lblProfileImage)
        Controls.Add(lblRegistrationDate)
        Controls.Add(lblMedicalCondition)
        Controls.Add(lblAddress)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblDateOfBirth)
        Controls.Add(lblGender)
        Controls.Add(lblFullName)
        Controls.Add(picProfile)
        Controls.Add(dtpRegistrationDate)
        Controls.Add(dtpDateOfBirth)
        Controls.Add(txtMedicalCondition)
        Controls.Add(txtAddress)
        Controls.Add(txtPhoneNumber)
        Controls.Add(cmbGender)
        Controls.Add(txtFullName)
        Name = "Form1"
        Text = "Form1"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDisplay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFullName As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtMedicalCondition As TextBox
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents dtpRegistrationDate As DateTimePicker
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblMedicalCondition As Label
    Friend WithEvents lblRegistrationDate As Label
    Friend WithEvents lblProfileImage As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents dgvDisplay As DataGridView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button

End Class
