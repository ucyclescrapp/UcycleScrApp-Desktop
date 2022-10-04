using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;
using System.Net;
using System.IO;

namespace UCycle
{

    public partial class Home : Form
    {
        public static Home miHomeRef = null;
        public string my_data_loc = "SERVER=; USER ID=; DATABASE=; PORT=3306; PASSWORD=;";
        
        Items manageItems_form = new Items();
        Schedule viewSchedule_form = new Schedule();
        BarterSchedule viewBarterSchedule_form = new BarterSchedule();
        Weights viewWeights = new Weights();

        Notes viewNotes = new Notes();
        Barter viewBarter_form = new Barter();
        Registrations registrations_form = new Registrations();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            miHomeRef = this;
            makeARIdir();

            //verify upload file on desktop
        }

        private void makeARIdir()
        {
            string path = "C://Users/" + Environment.UserName + "/Documents/ARI_UCycle/";
            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                di.Attributes = FileAttributes.Directory;
            }

            string pathdeskupload = "C://Users/" + Environment.UserName + "/Desktop/UCycle (upload images)/";
            if (!Directory.Exists(pathdeskupload))
            {
                DirectoryInfo di = Directory.CreateDirectory(pathdeskupload);
                di.Attributes = FileAttributes.Directory;
            }


            this.Cursor = Cursors.Default;
        }

        private void btn_manage_items_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (manageItems_form.Visible == false) { manageItems_form = new Items(); manageItems_form.Show(); }
                else { manageItems_form.BringToFront(); manageItems_form.Location = new Point(2, 2); }
            }
            catch { this.Cursor = Cursors.Default; manageItems_form = new Items(); manageItems_form.Show(); }
            this.Cursor = Cursors.Default;
        }
        

        private void btn_view_schedule_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (viewSchedule_form.Visible == false) { viewSchedule_form = new Schedule(); viewSchedule_form.Show(); }
                else { viewSchedule_form.BringToFront(); viewSchedule_form.Location = new Point(2, 2); }
            }
            catch { this.Cursor = Cursors.Default; viewSchedule_form = new Schedule(); viewSchedule_form.Show(); }
            this.Cursor = Cursors.Default;
        }

        private void btn_manage_weight_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (viewWeights.Visible == false) { viewWeights = new Weights(); viewWeights.Show(); }
                else { viewWeights.BringToFront(); viewWeights.Location = new Point(2, 2); }
            }
            catch { this.Cursor = Cursors.Default; viewWeights = new Weights(); viewWeights.Show(); }
            this.Cursor = Cursors.Default;
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (viewNotes.Visible == false) { viewNotes = new Notes(); viewNotes.Show(); }
                else { viewNotes.BringToFront(); viewNotes.Location = new Point(2, 2); }
            }
            catch { this.Cursor = Cursors.Default; viewNotes = new Notes(); viewNotes.Show(); }
            this.Cursor = Cursors.Default;
        }

        private void btn_manage_barter_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (viewBarter_form.Visible == false) { viewBarter_form = new Barter(); viewBarter_form.Show(); }
                else { viewBarter_form.BringToFront(); viewBarter_form.Location = new Point(2, 2); }
            }
            catch { this.Cursor = Cursors.Default; viewBarter_form = new Barter(); viewBarter_form.Show(); }
            this.Cursor = Cursors.Default;
        }

        private void btn_registrations_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (registrations_form.Visible == false) { registrations_form = new Registrations(); registrations_form.Show(); }
                else { registrations_form.BringToFront(); registrations_form.Location = new Point(2, 2); }
            }
            catch { this.Cursor = Cursors.Default; registrations_form = new Registrations(); registrations_form.Show(); }
            this.Cursor = Cursors.Default;
        }

        private void btn_view_barter_schedule_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (viewBarterSchedule_form.Visible == false) { viewBarterSchedule_form = new BarterSchedule(); viewBarterSchedule_form.Show(); }
                else { viewBarterSchedule_form.BringToFront(); viewBarterSchedule_form.Location = new Point(2, 2); }
            }
            catch { this.Cursor = Cursors.Default; viewBarterSchedule_form = new BarterSchedule(); viewBarterSchedule_form.Show(); }
            this.Cursor = Cursors.Default;
        }
    }
}
