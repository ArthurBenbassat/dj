Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim naam As String
        Dim plaats As String
        Dim verdient As Integer
        Dim gemiddelde As Decimal
        Dim optelling As Integer
        FileOpen(1, "C:\Users\Arthur\Downloads\dj.txt", OpenMode.Input)
        Do While Not EOF(1)
            Input(1, plaats)
            Input(1, naam)
            Input(1, verdient)
            optelling += verdient
            plaats = plaats.Substring(1)
            ListBox1.Items.Add(plaats & naam & " " & verdient)
        Loop
        gemiddelde = optelling / 30
        ListBox1.Items.Add("Het gemiddelde bedraagt: " & gemiddelde)

    End Sub
End Class
