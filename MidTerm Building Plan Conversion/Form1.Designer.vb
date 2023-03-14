<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildingPlansConversion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picboxbuilding = New System.Windows.Forms.PictureBox()
        Me.lblConverterApp = New System.Windows.Forms.Label()
        Me.lblEntervalueandconversion = New System.Windows.Forms.Label()
        Me.txtuservalueentry = New System.Windows.Forms.TextBox()
        Me.grpboxconvertmeasurement = New System.Windows.Forms.GroupBox()
        Me.rbtnMeterstoInches = New System.Windows.Forms.RadioButton()
        Me.rbtnInchestoMeters = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMeasurementsDisplay = New System.Windows.Forms.Label()
        CType(Me.picboxbuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxconvertmeasurement.SuspendLayout()
        Me.SuspendLayout()
        '
        'picboxbuilding
        '
        Me.picboxbuilding.Image = Global.MidTerm_Building_Plan_Conversion.My.Resources.Resources.building
        Me.picboxbuilding.Location = New System.Drawing.Point(2, 2)
        Me.picboxbuilding.Name = "picboxbuilding"
        Me.picboxbuilding.Size = New System.Drawing.Size(281, 221)
        Me.picboxbuilding.TabIndex = 0
        Me.picboxbuilding.TabStop = False
        Me.picboxbuilding.UseWaitCursor = True
        '
        'lblConverterApp
        '
        Me.lblConverterApp.AutoSize = True
        Me.lblConverterApp.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConverterApp.Location = New System.Drawing.Point(380, 42)
        Me.lblConverterApp.Name = "lblConverterApp"
        Me.lblConverterApp.Size = New System.Drawing.Size(312, 43)
        Me.lblConverterApp.TabIndex = 1
        Me.lblConverterApp.Text = "Converter App"
        Me.lblConverterApp.UseWaitCursor = True
        '
        'lblEntervalueandconversion
        '
        Me.lblEntervalueandconversion.AutoSize = True
        Me.lblEntervalueandconversion.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntervalueandconversion.Location = New System.Drawing.Point(315, 140)
        Me.lblEntervalueandconversion.Name = "lblEntervalueandconversion"
        Me.lblEntervalueandconversion.Size = New System.Drawing.Size(314, 66)
        Me.lblEntervalueandconversion.TabIndex = 2
        Me.lblEntervalueandconversion.Text = "Enter a value and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion"
        Me.lblEntervalueandconversion.UseWaitCursor = True
        '
        'txtuservalueentry
        '
        Me.txtuservalueentry.BackColor = System.Drawing.Color.Indigo
        Me.txtuservalueentry.Font = New System.Drawing.Font("Stencil", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuservalueentry.ForeColor = System.Drawing.Color.White
        Me.txtuservalueentry.Location = New System.Drawing.Point(920, 172)
        Me.txtuservalueentry.Name = "txtuservalueentry"
        Me.txtuservalueentry.Size = New System.Drawing.Size(142, 26)
        Me.txtuservalueentry.TabIndex = 3
        Me.txtuservalueentry.UseWaitCursor = True
        '
        'grpboxconvertmeasurement
        '
        Me.grpboxconvertmeasurement.BackColor = System.Drawing.Color.Indigo
        Me.grpboxconvertmeasurement.Controls.Add(Me.rbtnMeterstoInches)
        Me.grpboxconvertmeasurement.Controls.Add(Me.rbtnInchestoMeters)
        Me.grpboxconvertmeasurement.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxconvertmeasurement.ForeColor = System.Drawing.SystemColors.Control
        Me.grpboxconvertmeasurement.Location = New System.Drawing.Point(744, 276)
        Me.grpboxconvertmeasurement.Name = "grpboxconvertmeasurement"
        Me.grpboxconvertmeasurement.Size = New System.Drawing.Size(416, 217)
        Me.grpboxconvertmeasurement.TabIndex = 4
        Me.grpboxconvertmeasurement.TabStop = False
        Me.grpboxconvertmeasurement.Text = "Convert Measurement"
        Me.grpboxconvertmeasurement.UseWaitCursor = True
        '
        'rbtnMeterstoInches
        '
        Me.rbtnMeterstoInches.AutoSize = True
        Me.rbtnMeterstoInches.Location = New System.Drawing.Point(11, 134)
        Me.rbtnMeterstoInches.Name = "rbtnMeterstoInches"
        Me.rbtnMeterstoInches.Size = New System.Drawing.Size(295, 37)
        Me.rbtnMeterstoInches.TabIndex = 1
        Me.rbtnMeterstoInches.TabStop = True
        Me.rbtnMeterstoInches.Text = "Meters to Inches"
        Me.rbtnMeterstoInches.UseVisualStyleBackColor = True
        Me.rbtnMeterstoInches.UseWaitCursor = True
        '
        'rbtnInchestoMeters
        '
        Me.rbtnInchestoMeters.AutoSize = True
        Me.rbtnInchestoMeters.Location = New System.Drawing.Point(11, 56)
        Me.rbtnInchestoMeters.Name = "rbtnInchestoMeters"
        Me.rbtnInchestoMeters.Size = New System.Drawing.Size(295, 37)
        Me.rbtnInchestoMeters.TabIndex = 0
        Me.rbtnInchestoMeters.TabStop = True
        Me.rbtnInchestoMeters.Text = "Inches to Meters"
        Me.rbtnInchestoMeters.UseVisualStyleBackColor = True
        Me.rbtnInchestoMeters.UseWaitCursor = True
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.MediumPurple
        Me.btnConvert.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConvert.Location = New System.Drawing.Point(76, 643)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(266, 74)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        Me.btnConvert.UseWaitCursor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumPurple
        Me.btnClear.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(447, 643)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(266, 74)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.UseWaitCursor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumPurple
        Me.btnExit.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(856, 643)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(266, 74)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.UseWaitCursor = True
        '
        'lblMeasurementsDisplay
        '
        Me.lblMeasurementsDisplay.AutoSize = True
        Me.lblMeasurementsDisplay.Location = New System.Drawing.Point(992, 529)
        Me.lblMeasurementsDisplay.Name = "lblMeasurementsDisplay"
        Me.lblMeasurementsDisplay.Size = New System.Drawing.Size(181, 20)
        Me.lblMeasurementsDisplay.TabIndex = 9
        Me.lblMeasurementsDisplay.Text = "lblMeasurementsDisplay"
        Me.lblMeasurementsDisplay.UseWaitCursor = True
        '
        'frmBuildingPlansConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(1310, 843)
        Me.Controls.Add(Me.lblMeasurementsDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpboxconvertmeasurement)
        Me.Controls.Add(Me.txtuservalueentry)
        Me.Controls.Add(Me.lblEntervalueandconversion)
        Me.Controls.Add(Me.lblConverterApp)
        Me.Controls.Add(Me.picboxbuilding)
        Me.Name = "frmBuildingPlansConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulding Plans Conversion"
        Me.UseWaitCursor = True
        CType(Me.picboxbuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxconvertmeasurement.ResumeLayout(False)
        Me.grpboxconvertmeasurement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picboxbuilding As PictureBox
    Friend WithEvents lblConverterApp As Label
    Friend WithEvents lblEntervalueandconversion As Label
    Friend WithEvents txtuservalueentry As TextBox
    Friend WithEvents grpboxconvertmeasurement As GroupBox
    Friend WithEvents rbtnMeterstoInches As RadioButton
    Friend WithEvents rbtnInchestoMeters As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMeasurementsDisplay As Label
End Class
