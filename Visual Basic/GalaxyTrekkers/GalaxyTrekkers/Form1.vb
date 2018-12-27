Public Class Form1
    Public Structure Member
        Public Id As String
        Public Firstname As String
        Public Lastname As String
        Public Initial As String
        Public grade As String
        Public class_Peroid As String

    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim student(250) As Member
        readfile(student)
    End Sub

    Sub readfile(ByVal student() As Member)

        Dim fileRead As IO.StreamReader
        fileRead = IO.File.OpenText("StudentList.txt")

        Dim parts() As String
        Dim i As Integer
        i = 0

        Do While Not fileRead.EndOfStream

            parts = Split(fileRead.ReadLine(), ",")

            student(i).Id = parts(0)
            student(i).Firstname = parts(1)
            student(i).Lastname = parts(2)
            student(i).Initial = parts(3)
            student(i).grade = parts(4)
            student(i).class_Peroid = parts(5)

            membersListBox.Items.Add(student(i).Id.PadLeft(10, "0") + ", " + student(i).Firstname + ", " + student(i).Lastname)
            i = i + 1
        Loop

        fileRead.Close()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class
