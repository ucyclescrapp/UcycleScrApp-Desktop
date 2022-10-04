using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Drawing.Text;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace UCycle
{
    public partial class BarterSchedule : Form
    {
        string dev_name = "rilobas.app";
        string dev_email = "rilobas.app";

        string appName = "UCycle";
        //Home form_home = new Home();

        //public static Form1 miForm1rref = null;

        int maxRow = 0;
        int curNavRow = 0;

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;


        public BarterSchedule()
        {
            InitializeComponent();
        }

        private void btn_caf_Click(object sender, EventArgs e)
        {
            GetSchedule();
        }

        private void GetSchedule()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //DateTime dts = DateTime.Now;
                string Query = "SELECT * FROM bar_table ORDER BY Id Desc;";
                MySqlConnection myConn2 = new MySqlConnection(Home.miHomeRef.my_data_loc);
                MySqlCommand myComm2 = new MySqlCommand(Query, myConn2);

                //myComm2.CommandTimeout = 120;

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myComm2;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                dgvSche.DataSource = dtable;

                //DateTime dte = DateTime.Now;
                //TimeSpan ts = dte - dts;
                //MessageBox.Show("Fetch took (ms):" + ts.TotalMilliseconds.ToString());
                //
                dgvSche.RowHeadersVisible = false;
                //dgvSche.RowTemplate.Height = 50;
                dgvSche.Columns[0].Width = 40;
                dgvSche.Columns[1].Width = 190;
                dgvSche.Columns[2].Width = 60;
                dgvSche.Columns[3].Width = 60;
                dgvSche.Columns[4].Width = 140;
                dgvSche.Columns[5].Width = 60;
                dgvSche.Columns[6].Width = 60;
                dgvSche.Columns[7].Width = 60;
                dgvSche.Columns[8].Width = 80;
                dgvSche.Columns[9].Width = 100;
                dgvSche.Columns[10].Width = 110;
                dgvSche.Columns[11].Width = 60;
                dgvSche.Columns[12].Width = 60;
                dgvSche.Columns[13].Width = 60;
                dgvSche.Columns[14].Width = 60;
                dgvSche.Columns[15].Width = 100;

                if (dtable.Rows.Count > maxRow)
                {
                    //sp.Play();
                }

                maxRow = dtable.Rows.Count;


                //OrderGridSet();

                try
                {

                    dgvSche.ClearSelection();
                    //dataGridView1.FirstDisplayedScrollingRowIndex = idswap - 1;

                    dgvSche.Rows[0].Selected = true;//dgvOrde.Rows.Count - 2].Selected = true;
                    dgvSche.CurrentCell = dgvSche[0, 0];//dgvOrde.Rows.Count - 2];

                    curNavRow = dgvSche.CurrentRow.Index;


                }
                catch { }

                //lbl_req.Text = "UCycle Requests: " + maxRow.ToString();

                //ordersGotten = true;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                //ordersGotten = false;
                this.Cursor = Cursors.Default;

                maxRow = 0;
                MessageBox.Show(ex.ToString());
                //txt_help.ForeColor = System.Drawing.Color.Red;
                //txt_help.Text = "Internet or Remote Host Unreachable ";
                this.Close();
            }
        }

        private void BarterSchedule_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateSelected();
            GetSchedule();
        }

        private void UpdateSelected()
        {
            if (dgvSche.DataSource != null)
            {
                curNavRow = dgvSche.CurrentRow.Index;
                string idtoupdate = dgvSche.Rows[curNavRow].Cells[0].Value.ToString();
                string usertoupdate = dgvSche.Rows[curNavRow].Cells[1].Value.ToString();
                string barterScheduleTrue = "y";
                //string provisionedAddress = "";

                this.Cursor = Cursors.WaitCursor;
                

                if (dgvSche.Rows[curNavRow].Cells[8].Value.ToString() == "n")
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;

                        //for registration mapping
                        {
                            string query = "UPDATE bar_table SET " +
                                //"Status='" + barterScheduleTrue + "', " +
                                "Status='" + barterScheduleTrue + "' " +
                                "WHERE Id=" + idtoupdate + ";";
                            MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
                            MySqlCommand myCommand = new MySqlCommand(query, myConn);
                            MySqlDataReader myReader2;
                            myConn.Open();
                            myReader2 = myCommand.ExecuteReader();
                            myConn.Close();
                        }

                        

                        MessageBox.Show(usertoupdate + " barter schedule update successful!", appName);


                        this.Cursor = Cursors.Default;


                        GetSchedule();
                    }
                    catch
                    {
                        MessageBox.Show("");
                    }
                }
                else
                {
                    MessageBox.Show("Select appropriate barter schedule", appName);
                }
            }
            else
            {
                MessageBox.Show("Get first", appName);
            }
        }
    }
}
