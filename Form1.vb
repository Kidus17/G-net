Option Strict On
Option Explicit On
Public Class Form1
    'Program: Lab-1 Counter change program
    'Author: Dagmawi G.
    'Date: October 16, 2017
    'Description: Program will calculate a change from given amounts and label the change in each type of coins

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'Subroutine: btn1-click
        'Author:Dagmawi G.
        'Date: October 16, 2017
        'Description: Button handler for calculating the inputs
        Dim DblInput1 As Double
        Dim DblInput2 As Double
        Dim DblChange As Double
        Dim intChg As Integer
        Dim intTwenties As Integer
        Dim intTens As Integer
        Dim intFives As Integer
        Dim intOnes As Integer
        Dim intQuarters As Integer
        Dim intDimes As Integer
        Dim intNickels As Integer
        Dim intPennies As Integer
        If IsNumeric(txtInput1.Text) And IsNumeric(txtInput2.Text) Then


            'convert input to Double variable
            DblInput1 = CDbl(txtInput1.Text)
            DblInput2 = CDbl(txtInput2.Text)
            DblChange = DblInput2 - DblInput1
            lblChange.Text = DblChange.ToString("c")
            intChg = CInt(DblChange * 100)
            'Do Math
            intTwenties = intChg \ 2000
            intChg = intChg Mod 2000
            lblTwenties.Text = CStr(intTwenties)
            intTens = intChg \ 1000
            intChg = intChg Mod 1000
            'Convert answer to string and output
            lblTens.Text = CStr(intTens)
            'Do Math
            intFives = intChg \ 500
            intChg = intChg Mod 500
            'Convert answer to string and output
            lblFives.Text = CStr(intFives)
            'Do Math
            intOnes = intChg \ 100
            intChg = intChg Mod 100
            'Convert answer to string and output
            lblOnes.Text = CStr(intOnes)
            'Do Math
            intQuarters = intChg \ 50
            intChg = intChg Mod 50
            'Convert answer to string and output
            lblQuarters.Text = CStr(intQuarters)
            'Do Math
            intDimes = intChg \ 25
            intChg = intChg Mod 25
            'Convert answer to string and output
            lblDimes.Text = CStr(intDimes)
            'Do Math
            intNickels = intChg \ 10
            intChg = intChg Mod 10
            lblNickels.Text = CStr(intNickels)
            'Do Math
            intPennies = intChg \ 5
            intChg = intChg Mod 5
            'Convert answer to string and output
            lblPennies.Text = CStr(intPennies)




        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        'SUbroutine: btn2-Click
        'Author: Dagmaawi G.
        'Date: October16,2017
        'Description: Button handler to clear all the inputs and labels in the program
        txtInput1.Clear()
        txtInput2.Clear()
        lblChange.Text = String.Empty
        lblTwenties.Text = String.Empty
        lblTens.Text = String.Empty
        lblFives.Text = String.Empty
        lblOnes.Text = String.Empty
        lblQuarters.Text = String.Empty
        lblDimes.Text = String.Empty
        lblNickels.Text = String.Empty
        lblPennies.Text = String.Empty

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        'Subroutine: btn3_CLick
        'Author: Dagmawi G.
        'Date:October16, 2017
        'Description: Button handler used for exiting the program
        Me.Close()
    End Sub
End Class
