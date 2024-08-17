Imports System.IO

Public Class Form1
  ' take an address csv file and combine same <streetaddress1> + <zipcode> into a single row
  '  and combine the name values to <FirstName> (first row) + " / " <FirstName> (second row) , etc.
  ' The input file should already be sorted in StreetAddress1, Zipcode5, and Zipcode4

  Dim swOutput As StreamWriter = Nothing
  ' column positions
  Dim FirstName As Integer = 0
  Dim MiddleName As Integer = 1
  Dim LastName As Integer = 2
  Dim Address1 As Integer = 3
  Dim City As Integer = 4
  Dim USState As Integer = 5
  Dim ZipCode5 As Integer = 6
  Dim ZipCode4 As Integer = 7
  Dim Sex As Integer = 8
  Dim Race As Integer = 9
  Dim Age As Integer = 10
  Dim Registration_Date As Integer = 11
  Dim Registration_Number As Integer = 12
  Dim Phone As Integer = 13
  Dim LastVoted As Integer = 14

  Dim Delimiter As String = ","


  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub

  Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
    If Not File.Exists(txtInputFile.Text) Then
      MessageBox.Show("Can't find input file")
      Exit Sub
    End If
    If File.Exists(txtOutputFile.Text) Then
      If MessageBox.Show("Verify Overwrite", "Output already exists; Okay to overwrite?", MessageBoxButtons.OKCancel) = vbCancel Then
        Exit Sub
      End If
    End If


    'open the output file and wipeout previous
    Dim OutputFileName As String = txtOutputFile.Text
    swOutput = My.Computer.FileSystem.OpenTextFileWriter(OutputFileName, False)

    ' load the csv into an array
    Dim rows As String() = File.ReadAllLines(txtInputFile.Text)

    If rows.Count = 0 Then
      MessageBox.Show("CSV file is empty")
      Exit Sub
    End If
    If rows.Count = 1 Then
      MessageBox.Show("Only 1 record on CSV; presume a header record")
      Exit Sub
    End If

    Dim duplicateRows As Integer = 0

    ' process through the csv (skip header), creating output
    For row As Integer = 1 To rows.Count - 1
      ' split the row into columns
      Dim columns As String() = rows(row).Split(",")
      ' At last row on file? just write that out
      If row = rows.Count - 1 Then
        Call WriteTheRow(columns)
        Exit For
      End If
      ' check if next record's key is same as this one.
      duplicateRows = 0
      For nextrow As Integer = row + 1 To rows.Count - 1
        Dim nextColumns As String() = rows(nextrow).Split(Delimiter)
        If nextColumns(Address1) = columns(Address1) And
           nextColumns(ZipCode5) = columns(ZipCode5) And
           nextColumns(ZipCode4) = columns(ZipCode4) Then
          columns(FirstName) &= " / " & nextColumns(FirstName)
          duplicateRows += 1
        End If
      Next
      Call WriteTheRow(columns)
      row += duplicateRows
    Next

    swOutput.Close()
    MessageBox.Show("Process Complete.")
  End Sub
  Sub WriteTheRow(ByRef columns As String())
    Try
      swOutput.WriteLine(columns(FirstName) & Delimiter &
                         columns(LastName) & Delimiter &
                         columns(Address1) & Delimiter &
                         columns(City) & Delimiter &
                         columns(USState) & Delimiter &
                         columns(ZipCode5) & "-" &
                         columns(ZipCode4))

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Error Writing to Output CSV")
      Me.Close()
    End Try
  End Sub
End Class
