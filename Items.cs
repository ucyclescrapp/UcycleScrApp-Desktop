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

using System.Net;
using System.IO;

//using Excel = Microsoft.Office.Interop.Excel;


namespace UCycle
{
    public partial class Items : Form
    {
        string dev_name = "rilobas.app";
        string dev_email = "him@rilobas.app";

        string appName = "U-Cycle";


        int maxRow = 0;
        int curNavRow = 0;

        Boolean ene = false;

        FtpSetting _inputParameter;
        Boolean uploadSuccess = false;


        public Items()
        {
            InitializeComponent();
        }

        private void pb_item_Click(object sender, EventArgs e)
        {
            LocatePicture();
        }

        private void LocatePicture()
        {
            string el = "";

            using (OpenFileDialog ofg = new OpenFileDialog())
            {
                ofg.Multiselect = false;
                ofg.ValidateNames = true;

                ofg.Title = "Locate Profile Picture";
                ofg.Filter = "PNG Image|*.png";
                ofg.FilterIndex = 1;
                ofg.RestoreDirectory = true;
                ofg.FileName = string.Empty;


                if (ofg.ShowDialog() == DialogResult.OK)
                {
                    //addDat = ofg.FileName;
                }

                if ((ofg.SafeFileName != "") && ((ofg.SafeFileName.Length <= 64)))
                {
                    el = ofg.FileName;
                    txt_itempicture.Text = el;//.Replace(":", "%3A").Replace(@"\", "%2F");
                    pb_item.ImageLocation = txt_itempicture.Text;


                }
                else
                {
                    MessageBox.Show("Location string longer than expected please load the picture from from desktop", appName);
                }
                ofg.Dispose();
            }
        }

        private void btn_caf_Click(object sender, EventArgs e)
        {
            GetVarietyItems();
            txt_id.Text = (maxRow + 1).ToString();


            txt_itemcode.Text =
                txt_itemname.Text =
                txt_description.Text =
                txt_price.Text =
                txt_itempicture.Text =
                txt_regdate.Text = "";

            pb_item.Image = null;

            cmb_category.SelectedIndex = 0;
            cmb_color.SelectedIndex = 0;
            cmb_plastictype.SelectedIndex = 0;
        }

        private void GetVarietyItems()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string Query = "SELECT * FROM var_table;";
                MySqlConnection myConn2 = new MySqlConnection(Home.miHomeRef.my_data_loc);
                MySqlCommand myComm2 = new MySqlCommand(Query, myConn2);

                //myComm2.CommandTimeout = 120;

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myComm2;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                dgvVari.DataSource = dtable;

                myConn2.Close();
                //
                dgvVari.RowHeadersVisible = false;
                dgvVari.Columns[0].Width = 40;
                dgvVari.Columns[1].Width = 80;
                dgvVari.Columns[2].Width = 140;
                dgvVari.Columns[3].Width = 220;
                dgvVari.Columns[4].Width = 60;

                dgvVari.Columns[5].Width = 4;
                dgvVari.Columns[6].Width = 4;
                dgvVari.Columns[7].Width = 4;

                dgvVari.Columns[8].Width = 80;
                dgvVari.Columns[9].Width = 80;
                dgvVari.Columns[10].Width = 80;

                maxRow = dtable.Rows.Count;


                //OrderGridSet();



                //dtable.Clear();


                try
                {
                    dgvVari.ClearSelection();
                    //dataGridView1.FirstDisplayedScrollingRowIndex = idswap - 1;

                    dgvVari.Rows[dgvVari.Rows.Count - 1].Selected = true;
                    dgvVari.CurrentCell = dgvVari[0, dgvVari.Rows.Count - 1];

                    curNavRow = dgvVari.CurrentRow.Index;
                    PopulateText();
                }
                catch
                {
                    this.Cursor = Cursors.Default;
                    ClearAllFields();
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;


                maxRow = 0;
                //MessageBox.Show(ex.ToString() + "");
                //txt_help.ForeColor = System.Drawing.Color.Red;
                //txt_help.Text = "Internet or Remote Host Unreachable ";
            }
        }

        private void PopulateText()
        {
            txt_id.Text = dgvVari.Rows[curNavRow].Cells[0].Value.ToString();
            txt_itemcode.Text = dgvVari.Rows[curNavRow].Cells[1].Value.ToString();
            txt_itemname.Text = dgvVari.Rows[curNavRow].Cells[2].Value.ToString();
            txt_description.Text = dgvVari.Rows[curNavRow].Cells[3].Value.ToString();
            txt_price.Text = dgvVari.Rows[curNavRow].Cells[4].Value.ToString();
            txt_itempicture.Text = dgvVari.Rows[curNavRow].Cells[5].Value.ToString();
            txt_regdate.Text = dgvVari.Rows[curNavRow].Cells[6].Value.ToString();

            txt_category.Text = dgvVari.Rows[curNavRow].Cells[7].Value.ToString();
            txt_color.Text = dgvVari.Rows[curNavRow].Cells[8].Value.ToString();
            txt_quantity.Text = dgvVari.Rows[curNavRow].Cells[9].Value.ToString();
            txt_weight.Text = dgvVari.Rows[curNavRow].Cells[10].Value.ToString();
            txt_plastictype.Text = dgvVari.Rows[curNavRow].Cells[11].Value.ToString();

            //pbItem.Image = Bitmap.FromStream(stream);
        }

        struct FtpSetting
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string FileName { get; set; }

            public string FullName { get; set; }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not active yet", appName);

            //try
            //{
            //    this.Cursor = Cursors.WaitCursor;

            //    uploadSuccess = false;
            //    ElligibleRegistration();
            //    if (ene)
            //    {
            //        backgroundWorker.RunWorkerAsync();
            //    }
            //    else { }

            //    this.Cursor = Cursors.Default;

            //}
            //catch
            //{
            //    this.Cursor = Cursors.Default;
            //    MessageBox.Show("Error file not upploaded. Image may already exist", appName);
            //}
        }

        private void ElligibleRegistration()
        {
            ene = false;

            TextBox[] rdoTxt = new TextBox[10]
            {
                txt_id, txt_itemcode, txt_itemname,
                txt_description, txt_price, txt_itempicture,
                txt_color, txt_quantity, txt_weight, txt_plastictype,
            };

            for (int i = 0; i < rdoTxt.Length; i++)
            {
                if (rdoTxt[i].Text != "") { ene = true; }
                else
                {
                    ene = false;

                    string s = rdoTxt[i].Name.Replace("txt_", "").Replace("_", " ");
                    MessageBox.Show("Enter valid information for the '" + s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1) + "'", appName);
                    break;
                }
            }

        }

        private void ClearAllFields()
        {
            txt_itemcode.Text = "";
            txt_itemname.Text = "";
            txt_description.Text = "";

            txt_price.Text = "";
            txt_itempicture.Text = "";

            txt_category.Text = "";
            txt_color.Text = "";
            txt_quantity.Text = "";
            txt_weight.Text = "";
            txt_plastictype.Text = "";
        }

        private void CreateEntry()
        {
            try
            {
                //WRITE TO MYSQL DATABASE
                string query = "INSERT INTO var_table(Itemcode, Itemname, Description, Price, Itempicture, Category, Color, Quantity, Weight, Plastictype) VALUES ('"
                    + txt_itemcode.Text + "','"//1
                    + txt_itemname.Text + "','"//2
                    + txt_description.Text + "','"//3
                    + txt_price.Text + "','"//4
                    + txt_id.Text + ".png" + "','"//5

                    + txt_category.Text + "','"//6
                    + txt_color.Text + "','"//7
                    + txt_quantity.Text + "','"//8
                    + txt_weight.Text + "','"//9
                    + txt_plastictype.Text + //10
                    "');";




                MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
                MySqlCommand myCommand = new MySqlCommand(query, myConn);
                MySqlDataReader myReader2;
                myConn.Open();
                myReader2 = myCommand.ExecuteReader();
                //MessageBox.Show("Record created succesfully at Server.");
                //while (myReader2.Read())
                //{ }
                myConn.Close();
                //refresh display
                //btn_get_Click(sender, e);



                MessageBox.Show("New item (Itemname: '" + txt_itemname.Text + "', Itemcode: '" + txt_itemcode.Text + "' registered.", appName);
                //dataGridView1.Rows[Convert.ToInt16(dataGridView1.Rows.Count) - 1].Selected = true;
                //
                //btn_20.PerformClick();

                ClearAllFields();


            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString(), "");
            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            string fileName = txt_id.Text + ".png"; //what to store as
            string fullName = @txt_itempicture.Text;//"C:\Users\" + Environment.UserName + @"\Desktop\logo.png";
            string userName = "cycleusr@rilobas.app";
            string password = "cyclep#00";
            string server = "ftp://rilobas.app";

            System.IO.FileInfo fi = new System.IO.FileInfo(fileName);
            _inputParameter.Username =
            _inputParameter.Password =
            _inputParameter.Server =
            _inputParameter.FileName = fi.Name;
            _inputParameter.FullName = fi.FullName;

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", server, fileName)));
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(userName, password);
            Stream ftpStream = request.GetRequestStream();
            FileStream fs = File.OpenRead(fullName);
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;
            do
            {
                if (!backgroundWorker.CancellationPending)
                {
                    byteRead = fs.Read(buffer, 0, 1024);
                    ftpStream.Write(buffer, 0, byteRead);
                    read += (double)byteRead;
                    double percentage = read / total * 100;
                    backgroundWorker.ReportProgress((int)percentage);
                }
            }
            while (byteRead != 0);
            fs.Close();
            ftpStream.Close();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //lblStatus.Text = "Uploaded " + e.ProgressPercentage.ToString() + "%";
            //progressBar.Value = e.ProgressPercentage;
            //progressBar.Update();

            this.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //lblStatus.Text = "Upload Complete!";
            this.Cursor = Cursors.Default;
            MessageBox.Show("Item image uploaded successfully..", appName);
            uploadSuccess = true;
            this.Text = "Items";
            ContinueWithCreation();
            //btn_gae.PerformClick();
        }

        private void ContinueWithCreation()
        {
            if (uploadSuccess)
            {
                this.Cursor = Cursors.WaitCursor;


                string Query = "SELECT * FROM var_table WHERE Itemcode='" + txt_itemcode.Text + "';";
                MySqlConnection myConn2 = new MySqlConnection(Home.miHomeRef.my_data_loc);
                MySqlCommand myComm2 = new MySqlCommand(Query, myConn2);

                //myComm2.CommandTimeout = 120;

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myComm2;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                myConn2.Close();

                if (dtable.Rows.Count == 0)
                {
                    //ElligibleRegistration();
                    //if (ene)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        CreateEntry();
                        GetVarietyItems();
                        this.Cursor = Cursors.Default;
                    }
                    //else { }
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Specified itemcode already exists", appName);
                }
            }
            else
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Upload not successful", appName);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ElligibleRegistration();
            if (ene)
            {
                string Query = "SELECT * FROM var_table WHERE Id='" + txt_id.Text + "';";
                MySqlConnection myConn2 = new MySqlConnection(Home.miHomeRef.my_data_loc);
                MySqlCommand myComm2 = new MySqlCommand(Query, myConn2);

                //myComm2.CommandTimeout = 120;

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myComm2;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                myConn2.Close();

                if (dtable.Rows.Count == 1)
                {

                    //ElligibleRegistration();
                    //if (ene)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        int ui = Convert.ToInt32(txt_id.Text);

                        UpdateEntry();

                        GetVarietyItems();

                        {
                            //dgvVari.ClearSelection();
                            dgvVari.Rows[ui - 1].Selected = true;
                            dgvVari.CurrentCell = dgvVari[0, ui - 1];
                        }

                        this.Cursor = Cursors.Default;
                    }
                    //else { }
                }
                else
                {
                    MessageBox.Show("Not found. Item not updated", appName);
                }
            }
        }

        private void UpdateEntry()
        {
            try
            {
                //string Query = "SELECT * FROM var_table WHERE Id='" + txt_id.Text + "';";

                //MySqlConnection myConn2 = new MySqlConnection(my_data_loc);
                //MySqlCommand myComm2 = new MySqlCommand(Query, myConn2);

                //MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                //myAdapter.SelectCommand = myComm2;
                //DataTable dtable = new DataTable();
                //myAdapter.Fill(dtable);

                //if (dtable.Rows.Count == 1)
                {
                    string query = "UPDATE var_table SET" +
                        " " + "Itemcode='" + txt_itemcode.Text +
                        "', Itemname='" + txt_itemname.Text +
                        "', Description='" + txt_description.Text +
                        "', Price='" + txt_price.Text +
                        //"', Itempicture='" + txt_id.Text + ".png" +//+ txt_itempicture.Text +
                        //"', Last_Login='" + Form1.miForm1rref.suser.ToUpper() +
                        "', Category='" + txt_category.Text +
                        "', Color='" + txt_color.Text +
                        "', Quantity='" + txt_quantity.Text +
                        "', Weight='" + txt_weight.Text +
                        "', Plastictype='" + txt_plastictype.Text +
                        "' WHERE Id=" + txt_id.Text + ";";
                    MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
                    MySqlCommand myCommand = new MySqlCommand(query, myConn);

                    MySqlDataReader myReader2;
                    myConn.Open();
                    myReader2 = myCommand.ExecuteReader();


                    //while (myReader2.Read())
                    //{ }
                    myConn.Close();
                    MessageBox.Show(txt_itemcode.Text + " updated", appName);

                }


                //dtable.Dispose();

                //myAdapter.Dispose();
                //myComm2.Dispose();


                ////close database
                //myConn2.Close();

            }
            catch
            {

                MessageBox.Show("");
            }
        }

        private void Items_Load(object sender, EventArgs e)
        {
            btn_caf.PerformClick();
        }

        private void dgvVari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVari_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                curNavRow = dgvVari.CurrentRow.Index;
                PopulateText();
            }
            catch { }
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_category.Text = cmb_category.Text;
        }

        private void cmb_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_color.Text = cmb_color.Text;
        }

        private void cmb_plastictype_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_plastictype.Text = cmb_plastictype.Text;
        }

        private void txt_category_TextChanged(object sender, EventArgs e)
        {
            try { cmb_category.Text = txt_category.Text; }
            catch { }
        }

        private void txt_color_TextChanged(object sender, EventArgs e)
        {
            try { cmb_color.Text = txt_color.Text; }
            catch { }
        }

        private void txt_plastictype_TextChanged(object sender, EventArgs e)
        {
            try { cmb_plastictype.Text = txt_plastictype.Text; }
            catch { }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double pPrice = double.Parse(txt_price.Text);
            }
            catch
            {
                txt_price.Text = "";
            }
        }

        private void txt_weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double wPrice = double.Parse(txt_weight.Text);
            }
            catch
            {
                txt_weight.Text = "";
            }
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double qPrice = double.Parse(txt_quantity.Text);
            }
            catch
            {
                txt_quantity.Text = "";
            }
        }

        private void txt_itemcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_itemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }






    }
}
