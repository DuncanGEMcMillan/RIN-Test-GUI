<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Trigger_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TChart1 = New Steema.TeeChart.TChart()
        Me.FastLine1 = New Steema.TeeChart.Styles.FastLine()
        Me.FastLine2 = New Steema.TeeChart.Styles.FastLine()
        Me.TextSource1 = New Steema.TeeChart.Data.TextSource()
        Me.Reset_Button = New System.Windows.Forms.Button()
        Me.DeviceID_TB = New System.Windows.Forms.TextBox()
        Me.StartFreq_TB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StopFreq_TB = New System.Windows.Forms.TextBox()
        Me.RIN_Button = New System.Windows.Forms.Button()
        Me.Set_Frequency = New System.Windows.Forms.Button()
        Me.Read_Frequency = New System.Windows.Forms.Button()
        Me.Calibration_Button = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Bandwidth_TB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DMM_AVGPow_TB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Read_DMM = New System.Windows.Forms.Button()
        Me.Read_Bandwidth_Button = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RIN_Peak_TB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RIN_Freq_TB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Trigger_Button
        '
        Me.Trigger_Button.Location = New System.Drawing.Point(841, 111)
        Me.Trigger_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Trigger_Button.Name = "Trigger_Button"
        Me.Trigger_Button.Size = New System.Drawing.Size(135, 28)
        Me.Trigger_Button.TabIndex = 0
        Me.Trigger_Button.Text = "Trigger Sweep"
        Me.Trigger_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(557, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Signal Analyzer Device ID"
        '
        'TChart1
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Bottom.Title.Caption = "Frequency(MHz)"
        Me.TChart1.Axes.Bottom.Title.Lines = New String() {"Frequency(MHz)"}
        '
        '
        '
        '
        '
        '
        Me.TChart1.Axes.Left.Title.Caption = "RIN (dB/Hz)"
        Me.TChart1.Axes.Left.Title.Lines = New String() {"RIN (dB/Hz)"}
        '
        '
        '
        Me.TChart1.Header.Lines = New String() {"RIN Test"}
        Me.TChart1.Location = New System.Drawing.Point(3, 2)
        Me.TChart1.Margin = New System.Windows.Forms.Padding(4)
        Me.TChart1.Name = "TChart1"
        Me.TChart1.Series.Add(Me.FastLine1)
        Me.TChart1.Series.Add(Me.FastLine2)
        Me.TChart1.Size = New System.Drawing.Size(551, 308)
        Me.TChart1.TabIndex = 2
        '
        'FastLine1
        '
        Me.FastLine1.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.FastLine1.ColorEach = False
        '
        '
        '
        Me.FastLine1.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.FastLine1.ShowInLegend = False
        Me.FastLine1.Title = "fastLine1"
        Me.FastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
        '
        '
        '
        Me.FastLine1.XValues.DataMember = "X"
        Me.FastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.FastLine1.YValues.DataMember = "Y"
        '
        'FastLine2
        '
        Me.FastLine2.Color = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.FastLine2.ColorEach = False
        '
        '
        '
        Me.FastLine2.LinePen.Color = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.FastLine2.ShowInLegend = False
        Me.FastLine2.Title = "fastLine2"
        Me.FastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore
        '
        '
        '
        Me.FastLine2.XValues.DataMember = "X"
        Me.FastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending
        '
        '
        '
        Me.FastLine2.YValues.DataMember = "Y"
        '
        'TextSource1
        '
        Me.TextSource1.DecimalSeparator = Global.Microsoft.VisualBasic.ChrW(46)
        Me.TextSource1.Series = Nothing
        '
        'Reset_Button
        '
        Me.Reset_Button.Location = New System.Drawing.Point(841, 139)
        Me.Reset_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(135, 28)
        Me.Reset_Button.TabIndex = 3
        Me.Reset_Button.Text = "Reset SA"
        Me.Reset_Button.UseVisualStyleBackColor = True
        '
        'DeviceID_TB
        '
        Me.DeviceID_TB.Location = New System.Drawing.Point(561, 28)
        Me.DeviceID_TB.Margin = New System.Windows.Forms.Padding(4)
        Me.DeviceID_TB.Name = "DeviceID_TB"
        Me.DeviceID_TB.Size = New System.Drawing.Size(417, 22)
        Me.DeviceID_TB.TabIndex = 4
        '
        'StartFreq_TB
        '
        Me.StartFreq_TB.Location = New System.Drawing.Point(561, 76)
        Me.StartFreq_TB.Margin = New System.Windows.Forms.Padding(4)
        Me.StartFreq_TB.Name = "StartFreq_TB"
        Me.StartFreq_TB.Size = New System.Drawing.Size(96, 22)
        Me.StartFreq_TB.TabIndex = 8
        Me.StartFreq_TB.Text = "20"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(557, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Start Frequency(Hz)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(699, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Stop Frequency(Hz)"
        '
        'StopFreq_TB
        '
        Me.StopFreq_TB.Location = New System.Drawing.Point(703, 76)
        Me.StopFreq_TB.Margin = New System.Windows.Forms.Padding(4)
        Me.StopFreq_TB.Name = "StopFreq_TB"
        Me.StopFreq_TB.Size = New System.Drawing.Size(133, 22)
        Me.StopFreq_TB.TabIndex = 6
        Me.StopFreq_TB.Text = "10000"
        '
        'RIN_Button
        '
        Me.RIN_Button.Location = New System.Drawing.Point(845, 254)
        Me.RIN_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.RIN_Button.Name = "RIN_Button"
        Me.RIN_Button.Size = New System.Drawing.Size(109, 28)
        Me.RIN_Button.TabIndex = 9
        Me.RIN_Button.Text = "Measure RIN"
        Me.RIN_Button.UseVisualStyleBackColor = True
        '
        'Set_Frequency
        '
        Me.Set_Frequency.Location = New System.Drawing.Point(841, 55)
        Me.Set_Frequency.Margin = New System.Windows.Forms.Padding(4)
        Me.Set_Frequency.Name = "Set_Frequency"
        Me.Set_Frequency.Size = New System.Drawing.Size(135, 28)
        Me.Set_Frequency.TabIndex = 10
        Me.Set_Frequency.Text = "Set Start/Stop"
        Me.Set_Frequency.UseVisualStyleBackColor = True
        '
        'Read_Frequency
        '
        Me.Read_Frequency.Location = New System.Drawing.Point(841, 83)
        Me.Read_Frequency.Margin = New System.Windows.Forms.Padding(4)
        Me.Read_Frequency.Name = "Read_Frequency"
        Me.Read_Frequency.Size = New System.Drawing.Size(135, 28)
        Me.Read_Frequency.TabIndex = 11
        Me.Read_Frequency.Text = "Read Start/Stop"
        Me.Read_Frequency.UseVisualStyleBackColor = True
        '
        'Calibration_Button
        '
        Me.Calibration_Button.Location = New System.Drawing.Point(845, 282)
        Me.Calibration_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Calibration_Button.Name = "Calibration_Button"
        Me.Calibration_Button.Size = New System.Drawing.Size(109, 28)
        Me.Calibration_Button.TabIndex = 12
        Me.Calibration_Button.Text = "Calibration "
        Me.Calibration_Button.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Trace 1", "Trace 2", "Trace 3", "Trace 4", "Trace 5"})
        Me.ComboBox1.Location = New System.Drawing.Point(841, 169)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.Text = "Trace 1"
        '
        'Bandwidth_TB
        '
        Me.Bandwidth_TB.Location = New System.Drawing.Point(561, 122)
        Me.Bandwidth_TB.Margin = New System.Windows.Forms.Padding(4)
        Me.Bandwidth_TB.Name = "Bandwidth_TB"
        Me.Bandwidth_TB.Size = New System.Drawing.Size(96, 22)
        Me.Bandwidth_TB.TabIndex = 15
        Me.Bandwidth_TB.Text = "300"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(557, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Bandwidth(Hz)"
        '
        'DMM_AVGPow_TB
        '
        Me.DMM_AVGPow_TB.Location = New System.Drawing.Point(562, 172)
        Me.DMM_AVGPow_TB.Margin = New System.Windows.Forms.Padding(4)
        Me.DMM_AVGPow_TB.Name = "DMM_AVGPow_TB"
        Me.DMM_AVGPow_TB.Size = New System.Drawing.Size(95, 22)
        Me.DMM_AVGPow_TB.TabIndex = 17
        Me.DMM_AVGPow_TB.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(558, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "DMM(mV)"
        '
        'Read_DMM
        '
        Me.Read_DMM.Location = New System.Drawing.Point(665, 166)
        Me.Read_DMM.Margin = New System.Windows.Forms.Padding(4)
        Me.Read_DMM.Name = "Read_DMM"
        Me.Read_DMM.Size = New System.Drawing.Size(131, 28)
        Me.Read_DMM.TabIndex = 18
        Me.Read_DMM.Text = "Read DMM"
        Me.Read_DMM.UseVisualStyleBackColor = True
        '
        'Read_Bandwidth_Button
        '
        Me.Read_Bandwidth_Button.Location = New System.Drawing.Point(665, 119)
        Me.Read_Bandwidth_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Read_Bandwidth_Button.Name = "Read_Bandwidth_Button"
        Me.Read_Bandwidth_Button.Size = New System.Drawing.Size(131, 28)
        Me.Read_Bandwidth_Button.TabIndex = 19
        Me.Read_Bandwidth_Button.Text = "Read Bandwidth"
        Me.Read_Bandwidth_Button.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(559, 198)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Automated ITU Grid RIN Test"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(560, 219)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 28)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Measure all DUT Channel RIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RIN_Peak_TB
        '
        Me.RIN_Peak_TB.Location = New System.Drawing.Point(684, 282)
        Me.RIN_Peak_TB.Margin = New System.Windows.Forms.Padding(4)
        Me.RIN_Peak_TB.Name = "RIN_Peak_TB"
        Me.RIN_Peak_TB.Size = New System.Drawing.Size(95, 22)
        Me.RIN_Peak_TB.TabIndex = 25
        Me.RIN_Peak_TB.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(681, 254)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "RIN Peak(dB/Hz)"
        '
        'RIN_Freq_TB
        '
        Me.RIN_Freq_TB.Location = New System.Drawing.Point(563, 280)
        Me.RIN_Freq_TB.Margin = New System.Windows.Forms.Padding(4)
        Me.RIN_Freq_TB.Name = "RIN_Freq_TB"
        Me.RIN_Freq_TB.Size = New System.Drawing.Size(96, 22)
        Me.RIN_Freq_TB.TabIndex = 23
        Me.RIN_Freq_TB.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(559, 254)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "RIN Freq(MHz)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 315)
        Me.Controls.Add(Me.RIN_Peak_TB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RIN_Freq_TB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Read_Bandwidth_Button)
        Me.Controls.Add(Me.Read_DMM)
        Me.Controls.Add(Me.DMM_AVGPow_TB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Bandwidth_TB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Calibration_Button)
        Me.Controls.Add(Me.Read_Frequency)
        Me.Controls.Add(Me.Set_Frequency)
        Me.Controls.Add(Me.RIN_Button)
        Me.Controls.Add(Me.StartFreq_TB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StopFreq_TB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DeviceID_TB)
        Me.Controls.Add(Me.Reset_Button)
        Me.Controls.Add(Me.TChart1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Trigger_Button)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Trigger_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TChart1 As Steema.TeeChart.TChart
    Friend WithEvents Reset_Button As System.Windows.Forms.Button
    Friend WithEvents DeviceID_TB As System.Windows.Forms.TextBox
    Friend WithEvents TextSource1 As Steema.TeeChart.Data.TextSource
    Friend WithEvents StartFreq_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StopFreq_TB As System.Windows.Forms.TextBox
    Friend WithEvents RIN_Button As System.Windows.Forms.Button
    Friend WithEvents Set_Frequency As System.Windows.Forms.Button
    Friend WithEvents Read_Frequency As System.Windows.Forms.Button
    Friend WithEvents Calibration_Button As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Bandwidth_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DMM_AVGPow_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Read_DMM As System.Windows.Forms.Button
    Friend WithEvents Read_Bandwidth_Button As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RIN_Peak_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RIN_Freq_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FastLine1 As Steema.TeeChart.Styles.FastLine
    Friend WithEvents FastLine2 As Steema.TeeChart.Styles.FastLine

End Class
