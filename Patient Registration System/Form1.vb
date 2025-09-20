Imports System.Data.SqlClient
Imports System.IO


Public Class Form1

    Dim connString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=PatientDB;Integrated Security=True"
    Dim selectedImageBytes As Byte()

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Insert new records into the database
        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand("INSERT INTO Patients (FullName, Gender, DateOfBirth, PhoneNumber, Address, MedicalCondition, RegistrationDate, ProfileImage) VALUES (@FullName, @Gender, @DOB, @Phone, @Address, @MedicalCondition, @RegDate, @ProfileImage)", conn)

            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
            cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@DOB", dtpDateOfBirth.Value.Date)
            cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@MedicalCondition", If(String.IsNullOrWhiteSpace(txtMedicalCondition.Text), DBNull.Value, txtMedicalCondition.Text))
            cmd.Parameters.AddWithValue("@RegDate", dtpRegistrationDate.Value.Date)
            cmd.Parameters.Add("@ProfileImage", SqlDbType.VarBinary).Value = If(selectedImageBytes IsNot Nothing, selectedImageBytes, DBNull.Value)

            conn.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("Patient Registered Successfully!")

            DisplayRecords()

        End Using


    End Sub


    'Display records on gridview

    Private Sub DisplayRecords()

        Using conn As New SqlConnection(connString)

            Dim cmd As New SqlCommand("SELECT * FROM Patients", conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvDisplay.DataSource = table

        End Using


    End Sub

    'Resize image to fit in the picture box
    Private Function ResizeImage(ByVal img As Image, ByVal width As Integer, ByVal height As Integer) As Image
        Dim resizedBitmap As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(resizedBitmap)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(img, 0, 0, width, height)
        End Using
        Return resizedBitmap
    End Function


    'To load image for PC
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Using ofd As New OpenFileDialog

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then

                Using ms As New MemoryStream(File.ReadAllBytes(ofd.FileName))

                    Dim originalImage As Image = Image.FromStream(ms)
                    picProfile.Image = ResizeImage(originalImage, 200, 120) ' Resize to 150x150 pixels
                    selectedImageBytes = ms.ToArray()

                End Using

            End If

        End Using

    End Sub


    'Update records in database
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If dgvDisplay.SelectedRows.Count > 0 Then
            Dim id = Convert.ToInt32(dgvDisplay.SelectedRows(0).Cells("Id").Value)
            Using conn As New SqlConnection(connString)
                Dim cmd As New SqlCommand("UPDATE Patients SET FullName = @FullName, Gender = @Gender, DateOfBirth = @DOB, PhoneNumber = @Phone, Address = @Address, MedicalCondition = @MedicalCondition, RegistrationDate = @RegDate, ProfileImage = @ProfileImage WHERE Id = @Id", conn)
                cmd.Connection = conn
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
                cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@DOB", dtpDateOfBirth.Value.Date)
                cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@MedicalCondition", If(String.IsNullOrWhiteSpace(txtMedicalCondition.Text), DBNull.Value, txtMedicalCondition.Text))
                cmd.Parameters.AddWithValue("@RegDate", dtpRegistrationDate.Value.Date)
                cmd.Parameters.Add("@ProfileImage", SqlDbType.VarBinary).Value = If(selectedImageBytes IsNot Nothing, selectedImageBytes, DBNull.Value)
                conn.Open()
                cmd.ExecuteNonQuery()

                MessageBox.Show("Patient Record Updated Successfully!")

                DisplayRecords()

            End Using

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayRecords()

        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnClear.Enabled = False

    End Sub

    Private Sub dgvDisplay_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisplay.CellClick

        'If header is clicked, no record should display
        If e.RowIndex < 0 OrElse dgvDisplay.Rows(e.RowIndex).IsNewRow Then Exit Sub

        Dim row As DataGridViewRow = dgvDisplay.Rows(e.RowIndex)

        txtFullName.Text = row.Cells("FullName").Value.ToString()
        cmbGender.SelectedItem = row.Cells("Gender").Value.ToString()
        dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells("DateOfBirth").Value)
        txtPhoneNumber.Text = row.Cells("PhoneNumber").Value.ToString()
        txtAddress.Text = row.Cells("Address").Value.ToString()
        txtMedicalCondition.Text = If(row.Cells("MedicalCondition").Value IsNot DBNull.Value, row.Cells("MedicalCondition").Value.ToString(), "")
        dtpRegistrationDate.Value = Convert.ToDateTime(row.Cells("RegistrationDate").Value)

        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnClear.Enabled = True

        'display image

        If Not IsDBNull(row.Cells("ProfileImage").Value) Then

            Dim imageBytes As Byte() = CType(row.Cells("ProfileImage").Value, Byte())

            Using ms As New MemoryStream(imageBytes)
                Dim originalImage As Image = Image.FromStream(ms)
                picProfile.Image = ResizeImage(originalImage, 250, 170) ' Resize before display
            End Using

        Else
            picProfile.Image = Nothing

        End If

    End Sub



    'Delete records from database

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvDisplay.SelectedRows.Count > 0 Then
            Dim id = Convert.ToInt32(dgvDisplay.SelectedRows(0).Cells("Id").Value)
            Using conn As New SqlConnection(connString)
                Dim cmd As New SqlCommand("DELETE FROM Patients WHERE Id = @Id", conn)
                cmd.Connection = conn
                cmd.Parameters.AddWithValue("@Id", id)
                conn.Open()
                cmd.ExecuteNonQuery()

                MessageBox.Show("Patient Record Deleted Successfully!")

                DisplayRecords()

            End Using

        End If

    End Sub

    'Clear all fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFullName.Clear()
        cmbGender.SelectedIndex = -1
        dtpDateOfBirth.Value = DateTime.Now
        txtPhoneNumber.Clear()
        txtAddress.Clear()
        txtMedicalCondition.Clear()
        dtpRegistrationDate.Value = DateTime.Now
        picProfile.Image = Nothing
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnClear.Enabled = False


    End Sub


End Class
