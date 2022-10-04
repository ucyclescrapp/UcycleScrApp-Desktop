using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

using System.Threading;

using System.Media;

using System.Runtime.InteropServices;
using System.Drawing.Text;

//
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
//
using System.Security.Cryptography;
//

namespace UCycle
{
    public partial class Schedule : Form
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


        //
        string fUser;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kLlGVInMGVuBDwSFUVOVKTh2FTGMZfDbLp5AMKTo",
            BasePath = "https://u-cycle-a3b59.firebaseio.com/"

        };
        IFirebaseClient client;
        //
        private string CallHashing256(string s)
        {
            var hasher = SHA256.Create();
            string encodedKey = ToHex(hasher.ComputeHash(Encoding.UTF8.GetBytes(s)), true);
            return encodedKey;
        }
        private static string ToHex(byte[] bytes, bool upperCase)
        {
            StringBuilder result = new StringBuilder(bytes.Length * 2);
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString(upperCase ? "X2" : "x2"));
            }
            return result.ToString();
        }
        //
        string txtId = "";


        public Schedule()
        {
            InitializeComponent();
        }

        private void loadFont()
        {
            byte[] fontArray = UCycle.Properties.Resources.dgvfont;
            int datalength = UCycle.Properties.Resources.dgvfont.Length;
            IntPtr ptrData = Marshal.AllocCoTaskMem(datalength);
            Marshal.Copy(fontArray, 0, ptrData, datalength);
            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptrData, datalength);
            Marshal.FreeCoTaskMem(ptrData);
            ff = pfc.Families[0];


            font = new Font(ff, 10f, FontStyle.Regular);
        }

        private void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(ff, size, fontStyle);
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            loadFont();
            AllocFont(font, this.dgvSche, 10.00F);

            //btn_caf.PerformClick();

            client = new FireSharp.FirebaseClient(config);
        }

        private void GetSchedule()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //DateTime dts = DateTime.Now;
                string Query = "SELECT * FROM sch_table ORDER BY Id Desc;";
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
                MessageBox.Show("Unreachable");
                //txt_help.ForeColor = System.Drawing.Color.Red;
                //txt_help.Text = "Internet or Remote Host Unreachable ";
                this.Close();
            }
        }

        private void btn_caf_Click(object sender, EventArgs e)
        {
            GetSchedule();

            double tWeight = 0.0;
            for (int i = 0; i < dgvSche.Rows.Count - 1; i++)
            {
                tWeight += (double)dgvSche.Rows[i].Cells[3].Value;
            }
            MessageBox.Show(tWeight.ToString());
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (txtId != "")
            {
                //MessageBox.Show("Not active yet", appName);
                string active_username = dgvSche.Rows[curNavRow].Cells[4].Value.ToString();
                string fUser = CallHashing256(active_username);
                Boolean proceed_with_update = false;

                if (txtPpm.Text == "WALLET")
                {
                    //0
                    this.Cursor = Cursors.WaitCursor;
                    FirebaseResponse response;
                    Data obj;
                    double initial_user_balance = 0.0;


                    //1. read selected username balance from firebase if catch then 0 balance
                    try
                    {
                        response = await client.GetTaskAsync("Member/" + fUser);
                        obj = response.ResultAs<Data>();
                        initial_user_balance = Double.Parse(obj.userbalance.ToString());
                        //MessageBox.Show(initial_user_balance.ToString());
                    }
                    catch { }


                    //2. get current RCY rate
                    double record_rcy_rate = Double.Parse(dgvSche.Rows[curNavRow].Cells[2].Value.ToString()) / Double.Parse("500");


                    //3. add read value to current RCY rate
                    double user_new_balance = initial_user_balance + record_rcy_rate;
                    user_new_balance = Math.Round(user_new_balance, 2);

                    //4. go and insert new firebase username balance data
                    try
                    {
                        var data = new Data
                        {
                            username = active_username, //"one@rilobas.app",
                            userbalance = user_new_balance
                        };

                        response = await client.SetTaskAsync("Member/" + fUser, data);
                        Data result = response.ResultAs<Data>();

                        MessageBox.Show(active_username + ": updated to " + user_new_balance.ToString());
                        proceed_with_update = true;

                    }
                    catch
                    {
                        this.Cursor = Cursors.Default;
                        proceed_with_update = false;
                        MessageBox.Show("NOT succesful");
                    }


                    //5. update mysql sch_table ppm to completed 
                    if (proceed_with_update)
                    {
                        DoTheRecordUpdate(txtId);
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Not DONE!");
                    }

                    this.Cursor = Cursors.Default;
                    btn_caf.PerformClick();
                }
                else if (txtPpm.Text == "COMPLETED")
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("already COMPLETED!");
                }


            }
            else
            {
                MessageBox.Show("Select a record first", appName);
            }
        }

        private void DoTheRecordUpdate(string r_id)
        {
            this.Cursor = Cursors.WaitCursor;

            string query = "UPDATE sch_table SET " + 
                "Status='" + "C', " +
                            "Ppm='" + "COMPLETED" +
                            "' WHERE Id=" + r_id + ";";
            MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
            MySqlCommand myCommand = new MySqlCommand(query, myConn);

            MySqlDataReader myReader2;
            myConn.Open();
            myReader2 = myCommand.ExecuteReader();


            //while (myReader2.Read())
            //{ }
            myConn.Close();

            this.Cursor = Cursors.Default;
        }

        private void dgvSche_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                curNavRow = dgvSche.CurrentRow.Index;
                PopulateText();
            }
            catch { }
        }

        private void PopulateText()
        {
            txtId = dgvSche.Rows[curNavRow].Cells[0].Value.ToString();
            txtUser.Text = dgvSche.Rows[curNavRow].Cells[4].Value.ToString();
            txtPhone.Text = dgvSche.Rows[curNavRow].Cells[12].Value.ToString();

            txtWeight.Text = dgvSche.Rows[curNavRow].Cells[3].Value.ToString();
            txtPrice.Text = dgvSche.Rows[curNavRow].Cells[2].Value.ToString();

            txtLocation.Text = dgvSche.Rows[curNavRow].Cells[5].Value.ToString() + " " +
                //dgvSche.Rows[curNavRow].Cells[6].Value.ToString().Substring(0, 9) + " " +
                //dgvSche.Rows[curNavRow].Cells[7].Value.ToString();
                dgvSche.Rows[curNavRow].Cells[13].Value.ToString();
            txtLandmark.Text = dgvSche.Rows[curNavRow].Cells[14].Value.ToString();

            //pbItem.Image = Bitmap.FromStream(stream);
            txtPpm.Text = dgvSche.Rows[curNavRow].Cells[15].Value.ToString();
        }
    }
}
