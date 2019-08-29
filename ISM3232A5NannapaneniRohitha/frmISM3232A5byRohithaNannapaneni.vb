Public Class frmISM3232A5byRohithaNannapaneni
    Private Sub btnComputeGrades_Click(sender As Object, e As EventArgs) Handles btnComputeGrades.Click
        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim FirstQuiz As Decimal
        Dim SecondQuiz As Decimal
        Dim ThirdQuiz As Decimal
        Dim FourthQuiz As Decimal
        Dim FifthQuiz As Decimal
        Dim FirstExam As Decimal
        Dim SecondExam As Decimal
        Dim TotalScore As Decimal
        Dim PercentScore As Decimal
        Dim YourGrade As String = ""
        Dim HighScore As Integer = 0
        Dim HighFirstName As String = ""
        Dim HighLastName As String = ""

        FileOpen(2, "StudentScoresOutput.txt", OpenMode.Output)
        FileOpen(1, "StudentScores.txt", OpenMode.Input)
        Do Until EOF(1)
            Input(1, FirstName)
            Input(1, LastName)
            Input(1, FirstQuiz)
            Input(1, SecondQuiz)
            Input(1, ThirdQuiz)
            Input(1, FourthQuiz)
            Input(1, FifthQuiz)
            Input(1, FirstExam)
            Input(1, SecondExam)
            TotalScore = (FirstQuiz + SecondQuiz + ThirdQuiz + FourthQuiz + FifthQuiz + FirstExam + SecondExam)
            PercentScore = (TotalScore / 135) * 100
            Call ComputeGrade(PercentScore, YourGrade)
            MsgBox("Grade for " & FirstName & " " & LastName & " is " & YourGrade)

            PrintLine(2, FirstName & "," & LastName & "," & TotalScore & "," & PercentScore & "," & YourGrade & vbCrLf)
            If HighScore < TotalScore Then
                HighScore = TotalScore
                HighFirstName = FirstName
                HighLastName = LastName
            End If
            'Lowest Score
        Loop
        PrintLine(2, "Highest Score = " & HighScore & " " & "by" & " " & HighFirstName & " " & HighLastName)
        FileClose(1)
        FileClose(2)
        MsgBox("High Score = " & HighScore & " " & "by" & " " & HighFirstName & " " & HighLastName)

    End Sub
    Sub ComputeGrade(ByVal Score As Decimal, ByRef Grade As String)
        Select Case Score
            Case Is > 90
                Grade = "A"
            Case Is > 80
                Grade = "B"
            Case Is > 70
                Grade = "C"
            Case Is > 60
                Grade = "D"
            Case Is < 60
                Grade = "F"
        End Select


    End Sub
End Class
