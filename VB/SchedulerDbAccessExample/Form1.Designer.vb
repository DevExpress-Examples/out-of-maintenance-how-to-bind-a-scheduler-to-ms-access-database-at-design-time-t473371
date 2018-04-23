Namespace SchedulerDbAccessExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.schedulerTestDataSet = New SchedulerDbAccessExample.SchedulerTestDataSet()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.appointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.resourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.appointmentsTableAdapter = New SchedulerDbAccessExample.SchedulerTestDataSetTableAdapters.AppointmentsTableAdapter()
            Me.resourcesTableAdapter = New SchedulerDbAccessExample.SchedulerTestDataSetTableAdapters.ResourcesTableAdapter()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataSource = Me.schedulerTestDataSet
            Me.bindingSource1.Position = 0
            ' 
            ' schedulerTestDataSet
            ' 
            Me.schedulerTestDataSet.DataSetName = "SchedulerTestDataSet"
            Me.schedulerTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.DataStorage = Me.schedulerStorage1
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(548, 416)
            Me.schedulerControl1.Start = New Date(2017, 1, 19, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            ' 
            ' schedulerStorage1
            ' 
            Me.schedulerStorage1.Appointments.DataSource = Me.appointmentsBindingSource
            Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage1.Appointments.Mappings.End = "EndDate"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceIDs"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartDate"
            Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId"
            Me.schedulerStorage1.Appointments.Mappings.Type = "Type"
            Me.schedulerStorage1.Resources.DataSource = Me.resourcesBindingSource
            Me.schedulerStorage1.Resources.Mappings.Caption = "ResourceName"
            Me.schedulerStorage1.Resources.Mappings.Color = "Color"
            Me.schedulerStorage1.Resources.Mappings.Id = "ResourceID"
            Me.schedulerStorage1.Resources.Mappings.Image = "Picture"
            ' 
            ' appointmentsBindingSource
            ' 
            Me.appointmentsBindingSource.DataMember = "Appointments"
            Me.appointmentsBindingSource.DataSource = Me.bindingSource1
            ' 
            ' resourcesBindingSource
            ' 
            Me.resourcesBindingSource.DataMember = "Resources"
            Me.resourcesBindingSource.DataSource = Me.bindingSource1
            ' 
            ' appointmentsTableAdapter
            ' 
            Me.appointmentsTableAdapter.ClearBeforeFill = True
            ' 
            ' resourcesTableAdapter
            ' 
            Me.resourcesTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(548, 416)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private bindingSource1 As System.Windows.Forms.BindingSource
        Private schedulerTestDataSet As SchedulerTestDataSet
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private appointmentsBindingSource As System.Windows.Forms.BindingSource
        Private appointmentsTableAdapter As SchedulerTestDataSetTableAdapters.AppointmentsTableAdapter
        Private resourcesBindingSource As System.Windows.Forms.BindingSource
        Private resourcesTableAdapter As SchedulerTestDataSetTableAdapters.ResourcesTableAdapter
    End Class
End Namespace

