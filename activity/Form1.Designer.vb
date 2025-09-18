
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblName = New Label()
        txtName = New TextBox()
        lblGender = New Label()
        radioButtonMale = New RadioButton()
        radioButtonFemale = New RadioButton()
        lblCourse = New Label()
        comboBoxCourse = New ComboBox()
        lblHobbies = New Label()
        checkBoxReading = New CheckBox()
        checkBoxSports = New CheckBox()
        checkBoxMusic = New CheckBox()
        checkBoxDancing = New CheckBox()
        btnShowResult = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(40, 30)
        lblName.Name = "lblName"
        lblName.Size = New Size(44, 14)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(120, 27)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 22)
        txtName.TabIndex = 1
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(40, 70)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(56, 14)
        lblGender.TabIndex = 2
        lblGender.Text = "Gender:"
        ' 
        ' radioButtonMale
        ' 
        radioButtonMale.AutoSize = True
        radioButtonMale.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radioButtonMale.Location = New Point(120, 68)
        radioButtonMale.Name = "radioButtonMale"
        radioButtonMale.Size = New Size(53, 18)
        radioButtonMale.TabIndex = 3
        radioButtonMale.TabStop = True
        radioButtonMale.Text = "Male"
        radioButtonMale.UseVisualStyleBackColor = True
        ' 
        ' radioButtonFemale
        ' 
        radioButtonFemale.AutoSize = True
        radioButtonFemale.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radioButtonFemale.Location = New Point(199, 68)
        radioButtonFemale.Name = "radioButtonFemale"
        radioButtonFemale.Size = New Size(66, 18)
        radioButtonFemale.TabIndex = 4
        radioButtonFemale.TabStop = True
        radioButtonFemale.Text = "Female"
        radioButtonFemale.UseVisualStyleBackColor = True
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(40, 110)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(56, 14)
        lblCourse.TabIndex = 5
        lblCourse.Text = "Course:"
        ' 
        ' comboBoxCourse
        ' 
        comboBoxCourse.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxCourse.FormattingEnabled = True
        comboBoxCourse.Location = New Point(120, 107)
        comboBoxCourse.Name = "comboBoxCourse"
        comboBoxCourse.Size = New Size(200, 22)
        comboBoxCourse.TabIndex = 6
        ' 
        ' lblHobbies
        ' 
        lblHobbies.AutoSize = True
        lblHobbies.Location = New Point(40, 150)
        lblHobbies.Name = "lblHobbies"
        lblHobbies.Size = New Size(63, 14)
        lblHobbies.TabIndex = 7
        lblHobbies.Text = "Hobbies:"
        ' 
        ' checkBoxReading
        ' 
        checkBoxReading.AutoSize = True
        checkBoxReading.Location = New Point(120, 148)
        checkBoxReading.Name = "checkBoxReading"
        checkBoxReading.Size = New Size(76, 18)
        checkBoxReading.TabIndex = 8
        checkBoxReading.Text = "Reading"
        checkBoxReading.UseVisualStyleBackColor = True
        ' 
        ' checkBoxSports
        ' 
        checkBoxSports.AutoSize = True
        checkBoxSports.Location = New Point(200, 148)
        checkBoxSports.Name = "checkBoxSports"
        checkBoxSports.Size = New Size(71, 18)
        checkBoxSports.TabIndex = 9
        checkBoxSports.Text = "Sports"
        checkBoxSports.UseVisualStyleBackColor = True
        ' 
        ' checkBoxMusic
        ' 
        checkBoxMusic.AutoSize = True
        checkBoxMusic.Location = New Point(120, 173)
        checkBoxMusic.Name = "checkBoxMusic"
        checkBoxMusic.Size = New Size(62, 18)
        checkBoxMusic.TabIndex = 10
        checkBoxMusic.Text = "Music"
        checkBoxMusic.UseVisualStyleBackColor = True
        ' 
        ' checkBoxDancing
        ' 
        checkBoxDancing.AutoSize = True
        checkBoxDancing.Location = New Point(200, 173)
        checkBoxDancing.Name = "checkBoxDancing"
        checkBoxDancing.Size = New Size(76, 18)
        checkBoxDancing.TabIndex = 11
        checkBoxDancing.Text = "Dancing"
        checkBoxDancing.UseVisualStyleBackColor = True
        ' 
        ' btnShowResult
        ' 
        btnShowResult.Location = New Point(146, 214)
        btnShowResult.Name = "btnShowResult"
        btnShowResult.Size = New Size(100, 30)
        btnShowResult.TabIndex = 12
        btnShowResult.Text = "Show Result"
        btnShowResult.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(409, 300)
        Controls.Add(btnShowResult)
        Controls.Add(checkBoxDancing)
        Controls.Add(checkBoxMusic)
        Controls.Add(checkBoxSports)
        Controls.Add(checkBoxReading)
        Controls.Add(lblHobbies)
        Controls.Add(comboBoxCourse)
        Controls.Add(lblCourse)
        Controls.Add(radioButtonFemale)
        Controls.Add(radioButtonMale)
        Controls.Add(lblGender)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Font = New Font("Stencil", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Student Information Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents radioButtonMale As RadioButton
    Friend WithEvents radioButtonFemale As RadioButton
    Friend WithEvents lblCourse As Label
    Friend WithEvents comboBoxCourse As ComboBox
    Friend WithEvents lblHobbies As Label
    Friend WithEvents checkBoxReading As CheckBox
    Friend WithEvents checkBoxSports As CheckBox
    Friend WithEvents checkBoxMusic As CheckBox
    Friend WithEvents checkBoxDancing As CheckBox
    Friend WithEvents btnShowResult As Button
End Class
