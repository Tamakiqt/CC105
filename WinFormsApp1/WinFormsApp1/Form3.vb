Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Gather the data from the input fields
        Dim studentID As String = txtStudentID.Text
            Dim studentName As String = txtStudentName.Text
        Dim courseSubject As String = txtCourseSubject1.Text
        Dim courseSubject2 As String = txtCourseSubject2.Text
        Dim courseSubject3 As String = txtCourseSubject3.Text
        Dim courseSubject4 As String = txtCourseSubject4.Text
        Dim courseSubject5 As String = txtCourseSubject5.Text
        Dim midtermGrade As Double = Double.Parse(txtMidterm.Text)
            Dim finalsGrade As Double = Double.Parse(txtFinals.Text)
            Dim averageGrade As Double = (midtermGrade + finalsGrade) / 2
            Dim remarks As String = txtRemarks.Text

            ' Display the data in a message box or a dedicated output area
            MessageBox.Show($"Student ID: {studentID}" & vbCrLf &
                        $"Student Name: {studentName}" & vbCrLf &
                        $"Course Subject: {courseSubject}" & vbCrLf &
                        $"Midterm Grade: {midtermGrade}" & vbCrLf &
                        $"Finals Grade: {finalsGrade}" & vbCrLf &
                        $"Average Grade: {averageGrade}" & vbCrLf &
                        $"Remarks: {remarks}")
        End Sub
    End Class
