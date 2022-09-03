' @author - Moobi Kabelo
' @date 2022/09/04
Public Class Calculator
    REM array to store user input numbers MAX 50
    Dim Numbers(50) As Decimal
    REM array to store user input operators MAX 49
    Dim Symbols(49) As Char
    REM to store numbers sum 
    Dim Sum As Decimal

    REM funtion to add
    Function adddNumbers(ByVal arrNumbers As Array) As Decimal
        Try

        Catch ex As Exception
            MessageBox.Show("", "ERROR!")
        End Try
    End Function

    REM functiuon to subtract 
    Function subtractNumbers(ByVal arrNumbers As Array) As Decimal
        Try

        Catch ex As Exception
            MessageBox.Show("", "ERROR!")
        End Try
    End Function

    REM function to multiply
    Function multiplyNumbers(ByVal arrNumbers As Array) As Decimal
        Try

        Catch ex As Exception
            MessageBox.Show("", "ERROR!")
        End Try
    End Function

    REM function to divide
    Function divideNumbers(ByVal arrNumbers As Array) As Decimal
        Try

        Catch ex As Exception
            MessageBox.Show("", "ERROR!")
        End Try
    End Function

    REM button to calculate user input
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Try

        Catch ex As Exception
            MessageBox.Show("", "ERROR!")
        End Try
    End Sub

    REM button to clear user input
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            REM clear numbers, symbosl arrays and sum
            Array.Clear(Numbers, 0, Numbers.Length)
            Array.Clear(Symbols, 0, Symbols.Length)
            Sum = 0

            REM celar screen
            lsbScreen.Items.Clear()
        Catch ex As Exception
            MessageBox.Show("Sorry, failed to clear values.", "Program Error")
        End Try
    End Sub
End Class