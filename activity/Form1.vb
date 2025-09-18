Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBoxCourse.Items.AddRange(New String() {
            "BSIT", "BSHRM", "BSA", "BEED", "BSED", "BSBA", "BSMT", "BSCE"
        })
    End Sub

    ' Show Result Button
    Private Sub btnShowResult_Click(sender As Object, e As EventArgs) Handles btnShowResult.Click
        ' Name
        Dim studentName As String = If(txtName.Text.Trim() <> "", txtName.Text, "No name entered")

        ' Gender
        Dim gender As String
        If radioButtonMale.Checked Then
            gender = "Male"
        ElseIf radioButtonFemale.Checked Then
            gender = "Female"
        Else
            gender = "Not selected"
        End If

        ' Course
        Dim course As String = If(comboBoxCourse.SelectedItem IsNot Nothing,
                                  comboBoxCourse.SelectedItem.ToString(),
                                  "Not selected")

        ' Hobbies
        Dim hobbies As New List(Of String)
        If checkBoxReading.Checked Then hobbies.Add("Reading")
        If checkBoxSports.Checked Then hobbies.Add("Sports")
        If checkBoxMusic.Checked Then hobbies.Add("Music")
        If checkBoxDancing.Checked Then hobbies.Add("Dancing")
        Dim hobbiesText As String = If(hobbies.Count > 0, String.Join(", ", hobbies), "None")

        ' Message
        Dim message As String =
            "Student Name: " & studentName & vbCrLf &
            "Gender: " & gender & vbCrLf &
            "Course: " & course & vbCrLf &
            "Hobbies: " & hobbiesText

        MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Clear Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtName.Clear()
        radioButtonMale.Checked = False
        radioButtonFemale.Checked = False
        comboBoxCourse.SelectedIndex = -1
        checkBoxReading.Checked = False
        checkBoxSports.Checked = False
        checkBoxMusic.Checked = False
        checkBoxDancing.Checked = False
    End Sub

    ' Exit Button


End Class