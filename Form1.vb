Public Class Form1
    Private Sub btnIntArray_Click(sender As Object, e As EventArgs) Handles btnIntArray.Click

        'Declare the array
        Dim IntNumbers(4) As Integer

        'Store numbers into array
        IntNumbers(0) = 1
        IntNumbers(1) = 2
        IntNumbers(2) = 3
        IntNumbers(3) = 4
        IntNumbers(4) = 5


        'Displaying in Messagebox

        MessageBox.Show("First number is: " & IntNumbers(0))
        MessageBox.Show("Second number is:" & IntNumbers(1))
        MessageBox.Show("Third number is: " & IntNumbers(2))
        MessageBox.Show("Forth number is: " & IntNumbers(3))
        MessageBox.Show("Fifth number is: " & IntNumbers(4))

        'Displays Numbers inputed in list box

        For i = 0 To 4
            lstBox.Items.Add(IntNumbers(i))
        Next

    End Sub

    Private Sub btnstrArray_Click(sender As Object, e As EventArgs) Handles btnstrArray.Click

        'Declaring String Array
        Dim strText(4) As String

        'Store values in array

        strText(0) = "This"
        strText(1) = "Is"
        strText(2) = "A"
        strText(3) = "String"
        strText(4) = "Array"


        'Display in the list box using loop

        For i = 0 To 4
            lstBox.Items.Add(strText(i))
        Next

    End Sub

    Private Sub btnTimesTable_Click(sender As Object, e As EventArgs) Handles btnTimesTable.Click
        'Declarations
        Dim IntNumbers() As Integer
        Dim intTimes As Integer
        Dim intStart, intEnd As Integer


        intTimes = Val(txtMultiplier.Text)
        intStart = Val(txtStart.Text)
        intEnd = Val(txtEnd.Text)

        ReDim IntNumbers(intEnd)

        For i = intStart To intEnd
            IntNumbers(i) = i * intTimes
            lstBox.Items.Add(intTimes & " times " & i & "=" & IntNumbers(i))
        Next

    End Sub
End Class
