﻿Public Class frmReportePremios
    Private Sub frmReportePremios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdSIGAP_DataSet.VwPremios' table. You can move, or remove it, as needed.
        'Me.VwPremiosTableAdapter.Fill(Me.bdSIGAP_DataSet.VwPremios)

        Dim idCarrera As Integer
        idCarrera = frmReportePremioSeleccionar.cbCarrera.SelectedValue

        Me.VwDevolucionesTableAdapter.FillByIdCarrera(bdSIGAP_DataSet.VwDevoluciones, idCarrera) ' <-- CAMBIAR EL 26 POR EL PARAMETRO
        Dim setup = Me.ReportViewer1.GetPageSettings()
        setup.Margins = New System.Drawing.Printing.Margins(1, 1, 1, 1)
        Me.ReportViewer1.SetPageSettings(setup)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class