Imports System.IO

Public Class frmDataGridView

    Dim frmDGV As DataGridViewTextBoxColumn

    Private Sub frmDGV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Name = My.Resources.appNameDGV

        Timer1.Start()

        Dim line As String
        Dim RR() As String
        Dim rowcount As Integer
        Dim Path As String

        Path = "C:\Users\jk017\Downloads\RR.txt"

        Try

            Dim fileread As StreamReader
            fileread = New StreamReader(Path)

            Do Until fileread.EndOfStream
                line = fileread.ReadLine

                RR = line.Split(",")

                DGV.Rows.Add()
                DGV.Rows(rowcount).Cells(0).Value = RR(0)
                DGV.Rows(rowcount).Cells(1).Value = Val(RR(1))

                rowcount = rowcount + 1
            Loop

            fileread.Close()


        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try

        DGV.Sort(DGV.Columns(1), System.ComponentModel.ListSortDirection.Descending)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        AxWindowsMediaPlayer1.URL = "C:\Users\jk017\Downloads\cheering.wav"

    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Timer1.Stop()


        frmMain.Show()
        Me.Close()
    End Sub

    
End Class