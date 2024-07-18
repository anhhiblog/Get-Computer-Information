Imports System
Imports System.IO
Imports System.Management
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Public Module HardwareInfo

	Public Function GetProcessor() As String
		Dim managementClass As ManagementClass = New ManagementClass("Win32_Processor")
		Dim instances As ManagementObjectCollection = managementClass.GetInstances()
		Dim result As String = String.Empty
		Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
		While enumerator.MoveNext()
			Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
			result = managementObject("Name").ToString
		End While
		Return result
	End Function

	Public Function GetManufacturer() As String
		Dim managementClass As ManagementClass = New ManagementClass("Win32_BaseBoard")
		Dim instances As ManagementObjectCollection = managementClass.GetInstances()
		Dim result As String = String.Empty
		Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
		While enumerator.MoveNext()
			Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
			result = managementObject("Manufacturer").ToString
		End While
		Return result
	End Function

	Public Function GetProductr() As String
		Dim managementClass As ManagementClass = New ManagementClass("Win32_BaseBoard")
		Dim instances As ManagementObjectCollection = managementClass.GetInstances()
		Dim result As String = String.Empty
		Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
		While enumerator.MoveNext()
			Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
			result = managementObject("Product").ToString
		End While
		Return result
	End Function

	Public Function GetDiskSize() As String
		Dim managementClass As ManagementClass = New ManagementClass("Win32_DiskDrive")
		Dim instances As ManagementObjectCollection = managementClass.GetInstances()
		Dim result As String = String.Empty
		Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
		While enumerator.MoveNext()
			Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
			result = managementObject("Size").ToString
		End While
		Return result
	End Function

	Public Function GetDiskType() As String
		Dim scope = New ManagementScope("\\.\root\microsoft\windows\storage")
		Dim searcher = New ManagementObjectSearcher("SELECT * FROM MSFT_PhysicalDisk")
		Dim result As String = String.Empty
		scope.Connect()
		searcher.Scope = scope
		Dim rootDrive As String = Path.GetPathRoot(Environment.SystemDirectory)
		Dim queryObj As ManagementObject
		For Each queryObj In searcher.Get()
			Select Case queryObj("MediaType")
				Case 1
					result = "Unspecified"
				Case 3
					result = "HDD"
				Case 4
					result = "SSD"
				Case 5
					result = "SCM"
				Case Else
					result = "Unspecified"
			End Select
		Next
		searcher.Dispose()
		Return result
	End Function

	Public Function GetDiskModel() As String
		Dim managementClass As ManagementClass = New ManagementClass("Win32_DiskDrive")
		Dim instances As ManagementObjectCollection = managementClass.GetInstances()
		Dim result As String = String.Empty
		Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
		While enumerator.MoveNext()
			Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
			result = managementObject("Model").ToString
		End While
		Return result
	End Function

	Public Function GetMemoryType() As String
		Dim managementClass As ManagementClass = New ManagementClass("Win32_PhysicalMemory")
		Dim instances As ManagementObjectCollection = managementClass.GetInstances()
		Dim result As String
		Dim ramTemp As Int16
		Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
		While enumerator.MoveNext()
			Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
			ramTemp = managementObject("SMBIOSMemoryType").ToString
		End While
		If ramTemp = 26 Then
			result = "DDR4"
		ElseIf ramTemp = 24 Then
			result = "DDR3"
		ElseIf ramTemp = 21 Or ramTemp = 22 Then
			result = "DDR2"
		Else
			result = "Unspecified"
		End If
		Return result
	End Function

	Public Function GetMemorySpeed() As String
		Dim managementClass As ManagementClass = New ManagementClass("Win32_PhysicalMemory")
		Dim instances As ManagementObjectCollection = managementClass.GetInstances()
		Dim result As String = String.Empty
		Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
		While enumerator.MoveNext()
			Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
			result = managementObject("Speed").ToString
		End While
		Return result
	End Function

	Public Function GetCurrentBuild() As String
		Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
		Dim strVersion As String = CStr(registryKey.GetValue("ReleaseId"))
		Dim strBuild01 As String = CStr(registryKey.GetValue("CurrentBuild"))
		Dim strBuild02 As String = CStr(registryKey.GetValue("UBR"))
		Dim result As String = strVersion & " (Build " & strBuild01 & "." & strBuild02 & ")"
		Return result
	End Function

	Public Function GetSystemType() As String
		Dim result As String
		If System.Environment.Is64BitOperatingSystem = True Then
			result = "64-bit"
		Else
			result = "32-bit"
		End If
		Return result
	End Function

End Module
