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

namespace UCycle
{
    public partial class Registrations : Form
    {

        string dev_name = "rilobas.app";
        string dev_email = "rilobas.app";

        string appName = "UCycle";
        //Home form_home = new Home();

        //public static Form1 miForm1rref = null;

        //string my_data_loc = "SERVER=u-cycle.app; USER ID=ib_ucu_usr; DATABASE=ideabwoy_ucycle_database; PORT=3306; PASSWORD=kg]h[nTaufz#7D;";
        

        int maxRow = 0;
        int curNavRow = 0;

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;


        public Registrations()
        {
            InitializeComponent();
        }

        private void btn_caf_Click(object sender, EventArgs e)
        {
            GetWalls();
            GetRegistrations();
        }

        private void GetWalls()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //DateTime dts = DateTime.Now;
                string Query = "SELECT * FROM wal_table ORDER BY Id Asc;";
                MySqlConnection myConn2 = new MySqlConnection(Home.miHomeRef.my_data_loc);
                MySqlCommand myComm2 = new MySqlCommand(Query, myConn2);

                //myComm2.CommandTimeout = 120;

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myComm2;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                dgvWal.DataSource = dtable;

                //DateTime dte = DateTime.Now;
                //TimeSpan ts = dte - dts;
                //MessageBox.Show("Fetch took (ms):" + ts.TotalMilliseconds.ToString());
                //
                foreach (DataGridViewColumn column in dgvWal.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }


                dgvWal.RowHeadersVisible = false;
                //dgvWal.RowTemplate.Height = 50;
                dgvWal.Columns[0].Width = 40;
                dgvWal.Columns[1].Width = 160;
                dgvWal.Columns[2].Width = 200;
                dgvWal.Columns[3].Width = 200;


                maxRow = dtable.Rows.Count;



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
        private void GetRegistrations()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //DateTime dts = DateTime.Now;
                string Query = "SELECT * FROM reg_table ORDER BY Id Desc;";
                MySqlConnection myConn2 = new MySqlConnection(Home.miHomeRef.my_data_loc);
                MySqlCommand myComm2 = new MySqlCommand(Query, myConn2);

                //myComm2.CommandTimeout = 120;

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myComm2;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                dgvReg.DataSource = dtable;


                foreach (DataGridViewColumn column in dgvReg.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }


                //DateTime dte = DateTime.Now;
                //TimeSpan ts = dte - dts;
                //MessageBox.Show("Fetch took (ms):" + ts.TotalMilliseconds.ToString());
                //
                dgvReg.RowHeadersVisible = false;
                //dgvReg.RowTemplate.Height = 50;
                dgvReg.Columns[0].Width = 40;
                dgvReg.Columns[1].Width = 120;
                dgvReg.Columns[2].Width = 80;
                dgvReg.Columns[3].Width = 120;
                dgvReg.Columns[4].Width = 120;
                dgvReg.Columns[5].Width = 80;
                dgvReg.Columns[6].Width = 80;
                dgvReg.Columns[7].Width = 80;
                dgvReg.Columns[8].Width = 80;

                if (dtable.Rows.Count > maxRow)
                {
                    //sp.Play();
                }

                maxRow = dtable.Rows.Count;


                //OrderGridSet();

                try
                {

                    dgvReg.ClearSelection();
                    //dataGridView1.FirstDisplayedScrollingRowIndex = idswap - 1;

                    dgvReg.Rows[0].Selected = true;//dgvOrde.Rows.Count - 2].Selected = true;
                    dgvReg.CurrentCell = dgvReg[0, 0];//dgvOrde.Rows.Count - 2];

                    curNavRow = dgvReg.CurrentRow.Index;


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

        private void Registrations_Load(object sender, EventArgs e)
        {
            //btn_caf.PerformClick();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (dgvReg.DataSource != null)
            {
                curNavRow = dgvReg.CurrentRow.Index;
                string idtoupdate = dgvReg.Rows[curNavRow].Cells[0].Value.ToString();
                string usertoupdate = dgvReg.Rows[curNavRow].Cells[1].Value.ToString();
                string provisionedTrue = "";
                string provisionedAddress = "";

                this.Cursor = Cursors.WaitCursor;
                for (int i = 0; i < dgvWal.Rows.Count - 1; i++)
                {
                    if (dgvWal.Rows[i].Cells[0].Value.ToString() == idtoupdate)
                    {
                        provisionedTrue = "Y";
                        provisionedAddress = dgvWal.Rows[i].Cells[2].Value.ToString();
                        break;
                    }
                    
                }
                this.Cursor = Cursors.Default;




                if (dgvReg.Rows[curNavRow].Cells[2].Value.ToString() == "")
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;

                        //for registration mapping
                        {
                            string query = "UPDATE reg_table SET " +
                                "Allocated='" + provisionedTrue + "', " +
                                "WallAdd='" + provisionedAddress + "' " +
                                "WHERE Id=" + idtoupdate + ";";
                            MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
                            MySqlCommand myCommand = new MySqlCommand(query, myConn);
                            MySqlDataReader myReader2;
                            myConn.Open();
                            myReader2 = myCommand.ExecuteReader();
                            myConn.Close();
                        }

                        //for wallet user addition mapping
                        {
                            string query = "UPDATE wal_table SET " +
                                "Username='" + usertoupdate + "' " +
                                "WHERE Id=" + idtoupdate + ";";
                            MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
                            MySqlCommand myCommand = new MySqlCommand(query, myConn);
                            MySqlDataReader myReader2;
                            myConn.Open();
                            myReader2 = myCommand.ExecuteReader();
                            myConn.Close();
                        }

                        MessageBox.Show(usertoupdate + " Provisioned and updated!", appName);


                        this.Cursor = Cursors.Default;


                        GetRegistrations();
                        GetWalls();
                    }
                    catch
                    {
                        MessageBox.Show("");
                    }
                }
                else
                {
                    MessageBox.Show("Select appropriate user-walletaddress mapping for account provisioning", appName);
                }
            }
            else
            {
                MessageBox.Show("Get first", appName);
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\10101110\Desktop\0.txt");
                string[] linesData;

                for (int i = 0; i < lines.Length; i++)
                {
                    linesData = lines[i].Split(new string[] { " " }, StringSplitOptions.None);
                    this.Cursor = Cursors.WaitCursor;
                    string queryFind = "SELECT * FROM wal_table WHERE WallAdd='" + linesData[2] + "';";
                    MySqlConnection myConn2 = new MySqlConnection(Home.miHomeRef.my_data_loc);
                    MySqlCommand myComm2 = new MySqlCommand(queryFind, myConn2);
                    MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                    myAdapter.SelectCommand = myComm2;
                    DataTable dtable = new DataTable();
                    myAdapter.Fill(dtable);
                    myConn2.Close();

                    if (dtable.Rows.Count == 0)
                    {

                        string cipherText = EncryptIt(linesData[3]);
                        //write
                        string query = "INSERT INTO wal_table(WallAdd, PriKeyHash) VALUES ('" + linesData[2] + "', '" + cipherText + "');";
                        MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
                        MySqlCommand myCommand = new MySqlCommand(query, myConn);
                        MySqlDataReader myReader2;
                        //myCommand.CommandTimeout = 20;
                        myConn.Open();
                        myReader2 = myCommand.ExecuteReader();
                        myConn.Close();

                        this.Text = (i + 1).ToString() + " of " + lines.Length.ToString() + " done";
                    }
                    else
                    {
                        MessageBox.Show("Wallet Address: '" + linesData[2] + "' already exists, and will be skipped");
                    }
                    this.Cursor = Cursors.Default;
                }

                MessageBox.Show("Import completed SUCCESFULLY!");
            }
            catch
            {
                MessageBox.Show("Unauthorized and File not found");
            }
        }



        private static string EncryptIt(string dataString)
        {
            string hashKey = "u-cycle.app";
            byte[] data = UTF8Encoding.UTF8.GetBytes(dataString);

            string hashResult;
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashKey));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    hashResult = Convert.ToBase64String(results);
                }

            }

            return hashResult;

        }

        private void dgvWal_SelectionChanged(object sender, EventArgs e)
        {
            curNavRow = dgvWal.CurrentRow.Index;
            txtPK.Text = DecryptIt(dgvWal.Rows[curNavRow].Cells[3].Value.ToString());


        }

        private static string DecryptIt(string dataString)
        {
            try
            {
                string hashKey = "u-cycle.app";
                byte[] data = Convert.FromBase64String(dataString);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashKey));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        hashKey = UTF8Encoding.UTF8.GetString(results);
                    }

                }

                return hashKey;
            }
            catch
            {
                return "!!!";
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtPK.Text != "")
            {
                Clipboard.SetText(txtPK.Text);
            }
            else {
                MessageBox.Show("Select an address to copy to the clipboard.", appName);
            }
            
        }

    }
}
