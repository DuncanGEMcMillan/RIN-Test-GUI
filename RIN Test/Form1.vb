Imports Microsoft.Office.Interop
Imports System.Windows.Forms
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Dim ExePath As String = "c:\SYCATUS\RIN-Utility\RunTime\"
    Dim StatusFile As String = ""

    Private Sub Trigger_Button_Click(sender As Object, e As EventArgs) Handles Trigger_Button.Click
        Using com As IO.Ports.SerialPort =
    My.Computer.Ports.OpenSerialPort("COM16")
            com.WriteLine("*TRG") ' Trigger measurement
        End Using
    End Sub
    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        Using com As IO.Ports.SerialPort =
My.Computer.Ports.OpenSerialPort("COM16")
            com.WriteLine("*RST") ' Reset ESA
            com.WriteLine("INIT:CONT OFF") ' Set ESA to single sweep
            com.WriteLine("*IDN?") ' Query device ID
            Dim Text As String = com.ReadLine()
            DeviceID_TB.Text = Text
            com.WriteLine("FREQ:STAR?") ' Read start freq
            Text = com.ReadLine()
            Text = Text.Remove(0, 1)
            StartFreq_TB.Text = Text
            StartFreq_TB.Refresh()
            com.WriteLine("FREQ:STOP?") ' Read Stop freq
            Text = com.ReadLine()
            Text = Text.Remove(0, 1)
            StopFreq_TB.Text = Text
            StopFreq_TB.Refresh()
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RIN_Button.Click
        'Using com As IO.Ports.SerialPort =
        'My.Computer.Ports.OpenSerialPort("COM16")
        '    com.WriteLine(":CONFigure?") ' 
        '    Dim Text As String = com.ReadLine()
        '    Text = Text.Replace(0, 1)
        '    com.WriteLine(":TRAC:DATA? TRACE1") ' Set Trace 1 as the measurement trace to reference
        '    com.WriteLine("FREQ:STAR " + StartFreq_TB.Text + "Hz") ' Set RIN test frequency range from GUI settings
        '    com.WriteLine("FREQ:STOP " + StopFreq_TB.Text + "Hz") ' Set RIN test frequency range from GUI settings
        '    Text = com.ReadLine()
        '    Text = Text.Replace(0, 1)
        'End Using
        '' Insert Bass Code here

        '' Query the result to find the Trace Peak
        'Using com As IO.Ports.SerialPort =
        'My.Computer.Ports.OpenSerialPort("COM16")
        '    com.WriteLine(":TRACe:MATH:PEAK[:DATA]?")
        '    'com.WriteLine("CALC:DATA4:PEAK? –150, 10, FREQ, GTDL")
        'End Using

        Dim dataTable1 As New DataTable("Raw Data")
        Dim dataTable2 As New DataTable("5% Smoothed Data")
        dataTable1.Columns.Add("X", GetType(Double))
        dataTable1.Columns.Add("Y", GetType(Double))
        dataTable2.Columns.Add("X", GetType(Double))
        dataTable2.Columns.Add("Y", GetType(Double))

        '' Load Excel file.
        Dim workbook
        Dim objExcel = CreateObject("excel.application")
        workbook = objExcel.Workbooks.Open("C:\Test Folder\RIN_Test.csv")

        Dim RIN As String = workbook.Sheets(1).Range("C26").Value ' Read RIN Peak value (dB/Hz)
        Dim RIN_Freq As String = workbook.Sheets(1).Range("B26").Value ' Read RIN Peak frequency value (MHz)
        RIN_Freq_TB.Text = RIN_Freq
        RIN_Freq_TB.Refresh()
        RIN_Peak_TB.Text = RIN
        RIN_Peak_TB.Refresh()

        ' Loop though csv entries until end of data range
        Dim FreqArr As New ArrayList
        Dim RINArr As New ArrayList
        Dim RINSmoothArr As New ArrayList

        Dim Column As String = "A"
        Dim Column2 As String = "B"
        Dim Column3 As String = "C"
        Dim Counter As Integer = 30

        Dim Val As String = workbook.Sheets(1).Range("A30").Value
        Do Until Convert.ToString(workbook.Sheets(1).Range(Column + Convert.ToString(Counter)).Value) = ""
            dataTable1.Rows.Add({(workbook.Sheets(1).Range(Column + Convert.ToString(Counter)).Value), _
                                    (workbook.Sheets(1).Range(Column2 + Convert.ToString(Counter)).Value)})
            dataTable2.Rows.Add({(workbook.Sheets(1).Range(Column + Convert.ToString(Counter)).Value), _
                                    (workbook.Sheets(1).Range(Column3 + Convert.ToString(Counter)).Value)})
            Counter += 1
        Loop
        workbook.Close()
        objExcel.Quit()

        FastLine1.AutoRepaint = False ' Redraw in live data mode
        FastLine1.DataSource = dataTable1 ' Set source for data
        'Set Ordering to none, to increment speed when adding points
        FastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        FastLine2.AutoRepaint = False ' Redraw in live data mode
        FastLine2.DataSource = dataTable2 ' Set source for data
        'Set Ordering to none, to increment speed when adding points
        FastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.None
        FastLine1.CheckDataSource()
        FastLine1.RefreshSeries() ' Update plot with new data
        FastLine1.Repaint() ' Redraw plot

        FastLine2.CheckDataSource()
        FastLine2.RefreshSeries() ' Update plot with new data
        FastLine2.Repaint() ' Redraw plot

        Dim Result As String = "Fail"
        If Convert.ToDouble(RIN_Peak_TB.Text) < -140 Then
            Result = "Pass"
        End If
        TChart1.Text = "PIC UID-XXX; RIN:" + RIN_Peak_TB.Text + "dB/Hz@" + RIN_Freq_TB.Text + "MHz, Test Result:" + Result
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Calibration_Button.Click
        MsgBox("Turn off laser or disconnect for Calibration Trace!")
        Using com As IO.Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort("COM16")
            com.WriteLine(":CONFigure?") ' 
            Dim Text As String = com.ReadLine()
            Text = Text.Replace(0, 1)
            com.WriteLine(":TRAC:DATA? TRACE1") ' 
            Text = com.ReadLine()
            Text = Text.Replace(0, 1)
        End Using

        ' Insert Bass code here
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Read_Frequency.Click
        Using com As IO.Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort("COM16")
            Dim Text As String = com.ReadLine()
            com.WriteLine("FREQ:STAR?") ' Read start freq
            Text = com.ReadLine()
            Text = Text.Remove(0, 1)
            StartFreq_TB.Text = Text
            StartFreq_TB.Refresh()

            com.WriteLine("FREQ:STOP?") ' Read Stop freq
            Text = com.ReadLine()
            Text = Text.Remove(0, 1)
            StopFreq_TB.Text = Text
            StopFreq_TB.Refresh()
        End Using
    End Sub
    Private Sub Set_Frequency_Click(sender As Object, e As EventArgs) Handles Set_Frequency.Click
        Using com As IO.Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort("COM16")

            Dim StartFrequency As String = "10"
            StartFreq_TB.Text = StartFrequency
            com.WriteLine("FREQ:STAR " + StartFrequency) ' Set Start frequency

            Dim StopFrequency As String = "10000"
            StopFreq_TB.Text = StopFrequency
            com.WriteLine("FREQ:STOP " + StopFrequency) ' Set Stop frequency
        End Using
    End Sub

    Private Sub Read_BMM_Click(sender As Object, e As EventArgs) Handles Read_DMM.Click
        ' Read DMM voltage GPIB Address 22
        ' SYSTem:COMMunicate:ENABle ON,GPIB
        ' SYSTem:COMMunicate:GPIB:ADDRess?
        ' FETCh?
        ' *RST
        Using com As IO.Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort("COM16")
            ' Read voltage from front panel of DMM
            com.WriteLine("++addr 22") ' Read front panel
            com.WriteLine("READ?") ' Read front panel 2.400E-03
            Dim Text As String = com.ReadLine()
            DMM_AVGPow_TB.Text = Text
            DMM_AVGPow_TB.Refresh()
            com.WriteLine("++addr 16") ' Set GPIB address back to MXA Signal analyser
        End Using
    End Sub

    Private Sub Read_Bandwidth_Button_Click(sender As Object, e As EventArgs) Handles Read_Bandwidth_Button.Click
        ' Read MXA Signal Analyser Bandwidth
        Using com As IO.Ports.SerialPort =
    My.Computer.Ports.OpenSerialPort("COM16")
            ' Read voltage from front panel of DMM
            com.WriteLine("++addr 16") ' Read front panel
            com.WriteLine("BANDwidth?") ' Read front panel resolution bandwidth 1.000000000E+05 100kHz
            Dim Text As String = com.ReadLine()
            Bandwidth_TB.Text = Text
            Bandwidth_TB.Refresh()
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim sMeasur As String
        'Dim lRet As Long

        'bDebugFlag = False       '
        'bRunFlag = False
        'Call DispOpmsg("")
        'Call DispState("")

        ExePath = "c:\SYCATUS\RIN-Utility\RunTime\"
        StatusFile = ExePath & "status.txt"
    End Sub
End Class
