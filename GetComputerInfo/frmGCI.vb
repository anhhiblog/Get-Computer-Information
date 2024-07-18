Imports System
Imports System.IO
Imports System.Management
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Public Class frmGCI
    Private Sub frmGCI_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtPCName.Text = My.Computer.Name
        txtOS.Text = My.Computer.Info.OSFullName & " (" & HardwareInfo.GetSystemType & ")"
        txtProcessor.Text = HardwareInfo.GetProcessor()
        txtMBManufacture.Text = HardwareInfo.GetManufacturer()
        txtHDSize.Text = Math.Round(HardwareInfo.GetDiskSize() / 1024 / 1024 / 1024, 0) & " Gb"
        txtHDType.Text = HardwareInfo.GetDiskType()
        txtHDModel.Text = HardwareInfo.GetDiskModel()
        txtMemType.Text = HardwareInfo.GetMemoryType()
        txtMemSpeed.Text = HardwareInfo.GetMemorySpeed() & " MHz"
        txtWinVer.Text = HardwareInfo.GetCurrentBuild()
        txtMBProduct.Text = HardwareInfo.GetProductr()
        Call GetNetworkList()
        Call GetNetwork()
        Call GetMemory()
        Call GetMemoryList()
        Call GetDriveInfo()
    End Sub

    Private Sub GetNetworkList()
        Try
            Dim strConnectionID As String
            Dim strMac As String
            Dim strQuery As String = "SELECT * FROM Win32_NetworkAdapter WHERE PhysicalAdapter = True"
            Dim query As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)
            Dim queryCollection As ManagementObjectCollection = query.Get()
            Dim mo As ManagementObject
            lvNetwork.Items.Clear()
            For Each mo In queryCollection
                strConnectionID = mo("NetConnectionID").ToString
                strMac = mo("MACAddress").ToString
                Dim str(2) As String
                Dim itm As ListViewItem
                str(0) = strConnectionID
                str(1) = strMac
                itm = New ListViewItem(str)
                lvNetwork.Items.Insert(0, itm)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetNetwork()
        Try
            Dim strMACAddress As String = String.Empty
            Dim strIPAddress As String = String.Empty
            Dim strAdapter As String = String.Empty
            Dim strQuery As String = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True"
            Dim query As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)
            Dim queryCollection As ManagementObjectCollection = query.Get()
            Dim mo As ManagementObject
            For Each mo In queryCollection
                strMACAddress = mo("MacAddress").ToString()
                strIPAddress = mo("IPAddress")(0).ToString()
                strAdapter = mo("Description").ToString()
                Exit For
            Next
            txtNWMac.Text = strMACAddress
            txtNWIp.Text = strIPAddress
            txtNWAdapter.Text = strAdapter
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetMemory()
        Try
            Dim strSlots As String
            Dim strSize As String
            Dim strQuery As String = "SELECT * FROM Win32_PhysicalMemory"
            Dim query As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)
            Dim queryCollection As ManagementObjectCollection = query.Get()
            Dim mo As ManagementObject
            strSlots = 0
            strSize = 0
            For Each mo In queryCollection
                strSlots = (strSlots + 1).ToString
                strSize = (strSize + (mo("Capacity") / 1024 / 1024 / 1024)).ToString
            Next
            txtMemSlots.Text = strSlots
            txtMemSize.Text = strSize & " Gb"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetMemoryList()
        Try
            Dim strSlots As String
            Dim strSize As String
            Dim strManufacturer As String
            Dim strSpeed As String
            Dim strQuery As String = "SELECT * FROM Win32_PhysicalMemory"
            Dim query As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)
            Dim queryCollection As ManagementObjectCollection = query.Get()
            Dim mo As ManagementObject
            strSlots = 0
            strSize = 0
            lvMemory.Items.Clear()
            For Each mo In queryCollection
                strSlots = (strSlots + 1).ToString
                strSize = mo("Capacity") / 1024 / 1024 / 1024.ToString
                strSpeed = mo("Speed").ToString
                strManufacturer = mo("Manufacturer").ToString
                Dim str(4) As String
                Dim itm As ListViewItem
                str(0) = "RAM" & strSlots
                str(1) = strSize & " Gb"
                str(2) = strSpeed & " MHz"
                str(3) = strManufacturer
                itm = New ListViewItem(str)
                lvMemory.Items.Insert(0, itm)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetDriveInfo()
        Try
            Dim strVolume As String
            Dim strSize As String
            Dim strFree As String
            Dim strQuery As String = "SELECT * FROM Win32_LogicalDisk"
            Dim query As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)
            Dim queryCollection As ManagementObjectCollection = query.Get()
            Dim mo As ManagementObject
            lvStorage.Items.Clear()
            For Each mo In queryCollection
                strVolume = mo("DeviceID") & " (" & mo("VolumeName") & ")"
                strSize = Math.Round(mo("Size") / 1024 / 1024 / 1024, 0).ToString
                strFree = Math.Round(mo("FreeSpace") / 1024 / 1024 / 1024, 0).ToString
                Dim str(3) As String
                Dim itm As ListViewItem
                str(0) = strVolume
                str(1) = strSize & " Gb"
                str(2) = strFree & " Gb"
                itm = New ListViewItem(str)
                lvStorage.Items.Insert(0, itm)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles tsbAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub ExportHtml_Click(sender As Object, e As EventArgs) Handles tsbExportHtml.Click
        Dim upath As String
        Dim sd As New SaveFileDialog
        Dim html As String = "<table>"
        html &= "<font color=navy>"
        html &= "<b>COMPUTER INFORMATION</b>"
        html &= "</font>"
        html &= "<hr/>"

        html &= "Date: " & Format(Now(), "yyyy/MM/dd HH:mm:ss")
        html &= "</br>"
        html &= "Computer Name: " & txtPCName.Text
        html &= "</br>"
        html &= "Operating System: " & txtOS.Text
        html &= "</br>"
        html &= "Windows Version: " & txtWinVer.Text
        html &= "</br>"
        html &= "Processor: " & txtProcessor.Text
        html &= "</br>"
        html &= "</br>"

        html &= "<b>Mainboard</b>"
        html &= "<hr/>"
        html &= "Manufacturer: " & txtMBManufacture.Text
        html &= "</br>"
        html &= "Product: " & txtMBProduct.Text
        html &= "</br>"
        html &= "</br>"

        html &= "<b>Storage</b>"
        html &= "<hr/>"
        html &= "Total Size: " & txtHDSize.Text
        html &= "</br>"
        html &= "Type: " & txtHDType.Text
        html &= "</br>"
        html &= "Model: " & txtHDModel.Text
        html &= "</br>"
        html &= "</br>"

        html &= "<b>Network</b>"
        html &= "<hr/>"
        html &= "IP Address: " & txtNWIp.Text
        html &= "</br>"
        html &= "MAC Address: " & txtNWMac.Text
        html &= "</br>"
        html &= "Adapter: " & txtNWAdapter.Text
        html &= "</br>"
        html &= "</br>"

        html &= "<b>Memory</b>"
        html &= "<hr/>"
        html &= "Slots: " & txtMemSlots.Text
        html &= "</br>"
        html &= "Total Size: " & txtMemSize.Text
        html &= "</br>"
        html &= "Speed: " & txtMemSpeed.Text
        html &= "</br>"
        html &= "Type: " & txtMemType.Text
        html &= "</br>"
        html &= "</br>"

        html &= "<b>Other</b>"
        html &= "<hr/>"
        html &= "<b>&emsp;Disk Partition</b>"
        html &= "</br>"
        Dim s3 As Long = 1
        For Each item1 As ListViewItem In lvStorage.Items
            s3 = s3 + 1
            html &= "&emsp;&emsp;" & item1.Text
            html &= "</br>"
            html &= "&emsp;&emsp;Size: " & item1.SubItems(1).Text
            html &= "</br>"
            html &= "&emsp;&emsp;Free Space: " & item1.SubItems(2).Text
            html &= "</br>"
            If s3 > 1 Then
                html &= "</br>"
            End If
        Next

        html &= "<b>&emsp;Ram</b>"
        html &= "</br>"
        Dim s2 As Long = 1
        For Each item2 As ListViewItem In lvMemory.Items
            s2 = s2 + 1
            html &= "&emsp;&emsp;" & item2.Text
            html &= "</br>"
            html &= "&emsp;&emsp;Size: " & item2.SubItems(1).Text
            html &= "</br>"
            html &= "&emsp;&emsp;Speed: " & item2.SubItems(2).Text
            html &= "</br>"
            html &= "&emsp;&emsp;Manufacturer: " & item2.SubItems(3).Text
            html &= "</br>"
            If s2 > 1 Then
                html &= "</br>"
            End If
        Next

        html &= "<b>&emsp;Network</b>"
        html &= "</br>"
        Dim s1 As Long = 1
        For Each item3 As ListViewItem In lvNetwork.Items
            s1 = s1 + 1
            html &= "&emsp;&emsp;" & item3.Text
            html &= "</br>"
            html &= "&emsp;&emsp;MAC Address: " & item3.SubItems(1).Text
            html &= "</br>"
            If s1 > 1 Then
                html &= "</br>"
            End If
        Next

        html &= "<hr/>"
        html &= "<i>"
        html &= "<font color=green>"
        html &= "G"
        html &= "</font>"
        html &= "<font color=red>"
        html &= "C"
        html &= "</font>"
        html &= "<font color=blue>"
        html &= "I"
        html &= "</font>"
        html &= "<font color=navy>"
        html &= " - Copyright &copy; 2024 https://www.anhhiblog.net - " & String.Format("Version {0}", My.Application.Info.Version.ToString)
        html &= "</font>"
        html &= "</i>"
        html &= "</table>"

        With sd
            .Title = "Save GCI File"
            .FileName = txtPCName.Text
            .DefaultExt = ".html"
            .AddExtension = True
            .Filter = "HTML|*.html"
        End With

        If sd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            upath = sd.FileName
            File.WriteAllText(upath, html)
        End If

    End Sub

End Class
