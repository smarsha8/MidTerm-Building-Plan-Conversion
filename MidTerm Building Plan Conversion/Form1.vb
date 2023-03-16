

Public Class frmBuildingPlansConversion




    Private Sub lblEntervalueandconversion_Click(sender As Object, e As EventArgs) Handles lblEntervalueandconversion.Click

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declare variables for conversions




        Dim decMeasurementconversion As Decimal
        Dim decmeters As Decimal = 0.0254D
        Dim decinches As Decimal = 39.37D
        Dim decLength As Decimal
        Dim deconvert As Decimal




        If IsNumeric(txtuservalueentry.Text) Then
            decMeasurementconversion = Convert.ToDecimal(txtuservalueentry.Text)
            'Determine lenghth is greater than 0

            If decMeasurementconversion > 0 Then
                If rbtnInchestoMeters.Checked Then
                    deconvert = decinches
                    'Display Length
                    decLength = decMeasurementconversion * decmeters
                    lblMeasurementsDisplay.Text = decLength.ToString("")
                ElseIf rbtnMeterstoInches.Checked Then
                    deconvert = decmeters
                    'Display length
                    decLength = decMeasurementconversion * decinches
                    lblMeasurementsDisplay.Text = decLength.ToString("")
                End If

            Else
                'Display error message
                MsgBox("You entered " & decMeasurementconversion.ToString() & " . Enter a Positive Number ",, "Input Error")
                txtuservalueentry.Text = ""
                txtuservalueentry.Focus()

            End If
        Else
            'Dispay error message if use entered a nonnumeric value
            MsgBox("Input Error",, "Nonnumeric Input")
            txtuservalueentry.Text = ""
            txtuservalueentry.Focus()
        End If
























    End Sub






    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtuservalueentry.Clear()
        grpboxconvertmeasurement.Select()
        btnClear.Enabled = True
        lblMeasurementsDisplay.Text = ""
        rbtnInchestoMeters.Checked = True
        rbtnMeterstoInches.Checked = False




    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmBuildingPlansConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtuservalueentry.Focus()
        lblMeasurementsDisplay.Text = ""
    End Sub
End Class
