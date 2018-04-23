Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerDbAccessExample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
'            #Region "#SaveDataEvent"
            ' ...
            AddHandler schedulerStorage1.AppointmentsChanged, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler schedulerStorage1.AppointmentsInserted, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler schedulerStorage1.AppointmentsDeleted, AddressOf OnAppointmentChangedInsertedDeleted
            ' ...
'            #End Region ' #SaveDataEvent
'            #Region "#RowUpdatedEvent"
            ' ...
            AddHandler appointmentsTableAdapter.Adapter.RowUpdated, AddressOf appointmentsTableAdapter_RowUpdated
            ' ...
'            #End Region ' #RowUpdatedEvent
            schedulerControl1.Start = Date.Today
            schedulerControl1.GroupType = SchedulerGroupType.Resource
            schedulerControl1.ActiveView.ResourcesPerPage = 2

            schedulerStorage1.Appointments.ResourceSharing = True

            schedulerControl1.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top
            schedulerControl1.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.ZoomImage
            schedulerControl1.OptionsView.ResourceHeaders.ImageSize = New Size(140, 70)
            schedulerControl1.OptionsView.ResourceHeaders.Height = 100
        End Sub


        #Region "#LoadData"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Resources' table. You can move, or remove it, as needed.
            Me.resourcesTableAdapter.Fill(Me.schedulerTestDataSet.Resources)
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
            Me.appointmentsTableAdapter.Fill(Me.schedulerTestDataSet.Appointments)
        End Sub
        #End Region ' #LoadData

        #Region "#SaveDataEventHandler"
        Private Sub OnAppointmentChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            appointmentsTableAdapter.Update(schedulerTestDataSet)
            schedulerTestDataSet.AcceptChanges()
        End Sub
        #End Region ' #SaveDataEventHandler
        #Region "#RowUpdatedEventHandler"
        Private Sub appointmentsTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs)
            If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
                Dim id As Integer = 0
                Using cmd As New System.Data.OleDb.OleDbCommand("SELECT @@IDENTITY", appointmentsTableAdapter.Connection)
                    id = DirectCast(cmd.ExecuteScalar(), Integer)
                End Using
                e.Row("ID") = id
            End If
        End Sub
        #End Region ' #RowUpdatedEventHandler
    End Class
End Namespace
