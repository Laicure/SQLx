Option Strict Off

Module UnModulatorX

	Friend Sub Exporter(ByRef ExportPathName As String, ByRef dtxx As Data.DataTable)
		Dim excel As New Object
		Dim wBook As Object
		Dim wSheet As Object

		excel = CreateObject("Excel.Application")

		excel.EnableEvents = False
		excel.ScreenUpdating = False
		excel.DisplayAlerts = False

		wBook = excel.Workbooks.Add
		wSheet = wBook.ActiveSheet

		Dim dr As System.Data.DataRow
		Dim colIndex As Integer = 0

		For Each dc As Data.DataColumn In dtxx.Columns
			colIndex = colIndex + 1
			excel.Cells(1, colIndex) = dc.ColumnName
		Next

		Dim arrX(dtxx.Rows.Count, dtxx.Columns.Count) As Object

		wSheet.Columns.NumberFormat = "@"

		For r As Integer = 0 To dtxx.Rows.Count - 1
			dr = dtxx.Rows(r)
			For c As Integer = 0 To dtxx.Columns.Count - 1
				If Not IsDBNull(dr(c)) Then
					If dr(c).GetType = GetType(Date) Then
						arrX(r, c) = Format(dr(c), "yyyy-MM-dd HH:mm:ss").ToString
					Else
						If IsNumeric(dr(c)) = True Then
							arrX(r, c) = dr(c)
						Else
							arrX(r, c) = dr(c).ToString.Replace(vbCrLf, " ").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbTab, " ")
						End If
					End If
				Else
					arrX(r, c) = "-"
				End If
			Next
		Next

		Dim c1 As Object = wSheet.Cells(2, 1)
		Dim c2 As Object = wSheet.Cells(1 + dtxx.Rows.Count, dtxx.Columns.Count)

		Dim Rr As Object = wSheet.Range(c1, c2)

		Rr.value2 = arrX

		excel.EnableEvents = True
		excel.ScreenUpdating = True
		excel.DisplayAlerts = True

		wSheet.Columns.AutoFit()

		wBook.SaveAs(ExportPathName & ".xlsx")

		wBook.Close(False, Nothing, Nothing)
		excel.Quit()

		Runtime.InteropServices.Marshal.ReleaseComObject(excel)
		Runtime.InteropServices.Marshal.ReleaseComObject(wBook)
		Runtime.InteropServices.Marshal.ReleaseComObject(wSheet)
		GC.Collect()
	End Sub

End Module