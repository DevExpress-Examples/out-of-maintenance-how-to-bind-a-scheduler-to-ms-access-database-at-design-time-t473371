using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SchedulerDbAccessExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            #region #SaveDataEvent
            // ...
            schedulerStorage1.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            schedulerStorage1.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            schedulerStorage1.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;
            // ...
            #endregion #SaveDataEvent
            #region #RowUpdatedEvent
            // ...
            appointmentsTableAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(appointmentsTableAdapter_RowUpdated);
            // ...
            #endregion #RowUpdatedEvent
            schedulerControl1.Start = DateTime.Today;
            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.ActiveView.ResourcesPerPage = 2; ;
            schedulerStorage1.Appointments.ResourceSharing = true;

            schedulerControl1.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top;
            schedulerControl1.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.ZoomImage;
            schedulerControl1.OptionsView.ResourceHeaders.ImageSize = new Size(140, 70);
            schedulerControl1.OptionsView.ResourceHeaders.Height = 100;
        }


        #region #LoadData
        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'schedulerTestDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.schedulerTestDataSet.Resources);
            // TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.schedulerTestDataSet.Appointments);
        }
        #endregion #LoadData

        #region #SaveDataEventHandler
        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e) {
            appointmentsTableAdapter.Update(schedulerTestDataSet);
            schedulerTestDataSet.AcceptChanges();
        }
        #endregion #SaveDataEventHandler
        #region #RowUpdatedEventHandler
        private void appointmentsTableAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e) {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
                int id = 0;
                using (System.Data.OleDb.OleDbCommand cmd = 
                    new System.Data.OleDb.OleDbCommand("SELECT @@IDENTITY", appointmentsTableAdapter.Connection)) {
                    id = (int)cmd.ExecuteScalar();
                }
                e.Row["ID"] = id;
            }
        }
        #endregion #RowUpdatedEventHandler
    }
}
