

Public Class frmBuildingPlansConversion




    Private Sub lblEntervalueandconversion_Click(sender As Object, e As EventArgs) Handles lblEntervalueandconversion.Click

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declare variables for conversions
        Dim strinches As String
        Dim strMeasurementconversion As String
        Dim decinches As Decimal
        Dim inches As Integer
        Dim meters As Integer
        Dim decMeasurementconversion As Decimal = 0D







        Dim dectotal As Decimal = meters = inches / 39.37 Or meters = inches * 0.0254






        Dim strBoxMsg As String = "The measurement must be greater than zero"
        Dim strIBoxTitle As String = "Input Error"
        Dim strNotNumericErrMsg As String = "Enter a positive number"
        Dim strNegErrMsg As String = "Enter a positive number"


        Dim intinchesmeasurements = ""
        Dim metersmeasurements = ""
        Dim intMinEntries As Integer = 0
        Dim intEntries As Integer = 1









        meters = inches / 39.37 Or meters = inches * 0.0254











    End Sub

    Private Sub frmBuildingPlansConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtuservalueentry.Clear()
        grpboxconvertmeasurement.Select()
        lblMeasurementsDisplay.Text = ""
        btnClear.Enabled = True



    End Sub

    Private Sub lblMeasurementsDisplay_Click(sender As Object, e As EventArgs) Handles lblMeasurementsDisplay.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
