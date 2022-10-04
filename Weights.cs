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

namespace UCycle
{
    public partial class Weights : Form
    {
        string dev_name = "rilobas.app";
        string dev_email = "him@rilobas.app";

        string appName = "U-Cycle";

        

        int maxRow = 0;
        int curNavRow = 0;

        Boolean ene = false;

        FtpSetting _inputParameter;
        Boolean uploadSuccess = false;


        public Weights()
        {
            InitializeComponent();
        }

        struct FtpSetting
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string FileName { get; set; }

            public string FullName { get; set; }
        }

        private void Weights_Load(object sender, EventArgs e)
        {
            btn_caf.PerformClick();
        }

        private void btn_caf_Click(object sender, EventArgs e)
        {
            GetWeightItems();
            txt_id.Text = (maxRow + 1).ToString();


            txt_plasticcode.Text =
                txt_plasticname.Text =
                txt_description.Text =
                txt_price.Text =
                txt_itempicture.Text =
                txt_regdate.Text = "";

            pb_plastic.Image = null;

            cmb_category.SelectedIndex =
            cmb_color.SelectedIndex =
            cmb_plastictype.SelectedIndex = 0;
        }

        private void GetWeightItems()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string Query = "SELECT * FROM typ_table;";
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

                dgvVari.Columns[7].Width = 80;
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
                    //PopulateText();
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

        private void ClearAllFields()
        {
            txt_plasticcode.Text = "";
            txt_plasticname.Text = "";
            txt_description.Text = "";

            txt_price.Text = "";
            txt_itempicture.Text = "";

            //txt_category.Text = "";
            //txt_color.Text = "";
            //txt_quantity.Text = "";
            //txt_weight.Text = "";
            //txt_plastictype.Text = "";
        }

        private void PopulateText()
        {
            txt_id.Text = dgvVari.Rows[curNavRow].Cells[0].Value.ToString();
            txt_plasticcode.Text = dgvVari.Rows[curNavRow].Cells[1].Value.ToString();
            txt_plasticname.Text = dgvVari.Rows[curNavRow].Cells[2].Value.ToString();
            txt_description.Text = dgvVari.Rows[curNavRow].Cells[3].Value.ToString();
            txt_price.Text = dgvVari.Rows[curNavRow].Cells[4].Value.ToString();
            txt_itempicture.Text = dgvVari.Rows[curNavRow].Cells[5].Value.ToString();
            txt_regdate.Text = dgvVari.Rows[curNavRow].Cells[6].Value.ToString();

            //txt_category.Text = dgvVari.Rows[curNavRow].Cells[7].Value.ToString();
            //txt_color.Text = dgvVari.Rows[curNavRow].Cells[8].Value.ToString();
            //txt_quantity.Text = dgvVari.Rows[curNavRow].Cells[9].Value.ToString();
            //txt_weight.Text = dgvVari.Rows[curNavRow].Cells[10].Value.ToString();
            //txt_plastictype.Text = dgvVari.Rows[curNavRow].Cells[11].Value.ToString();

            //pbItem.Image = Bitmap.FromStream(stream);
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

        private void ElligibleRegistration()
        {
            ene = false;

            TextBox[] rdoTxt = new TextBox[6]
            {
                txt_id, txt_plasticcode, txt_plasticname,
                txt_description, txt_price, txt_itempicture
                //txt_category, txt_color, txt_quantity, txt_weight, txt_plastictype,
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            ElligibleRegistration();
            if (ene)
            {
                string Query = "SELECT * FROM typ_table WHERE Id='" + txt_id.Text + "';";
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

                        GetWeightItems();

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
                    string query = "UPDATE typ_table SET" +
                        " " + "Plasticcode='" + txt_plasticcode.Text +
                        "', Plasticname='" + txt_plasticname.Text +
                        "', Description='" + txt_description.Text +
                        "', Price='" + txt_price.Text +
                        //"', Itempicture='" + txt_id.Text + ".png" +//+ txt_itempicture.Text +
                        //"', Last_Login='" + Form1.miForm1rref.suser.ToUpper() +
                        //"', Category='" + txt_category.Text +
                        //"', Color='" + txt_color.Text +
                        //"', Quantity='" + txt_quantity.Text +
                        //"', Weight='" + txt_weight.Text +
                        //"', Plastictype='" + txt_plastictype.Text +
                        "' WHERE Id=" + txt_id.Text + ";";
                    MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
                    MySqlCommand myCommand = new MySqlCommand(query, myConn);

                    MySqlDataReader myReader2;
                    myConn.Open();
                    myReader2 = myCommand.ExecuteReader();


                    //while (myReader2.Read())
                    //{ }
                    myConn.Close();
                    MessageBox.Show(txt_plasticcode.Text + " updated", appName);

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

        private void btn_create_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not active yet", appName);
        }
    }
}
