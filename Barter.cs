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
    public partial class Barter : Form
    {
        string dev_name = "rilobas.app";
        string dev_email = "him@rilobas.app";

        string appName = "U-Cycle";


        int maxRow = 0;
        int curNavRow = 0;

        Boolean ene = false;

        //FtpSetting _inputParameter;
        //Boolean uploadSuccess = false;

        public Barter()
        {
            InitializeComponent();
        }

        private void btn_caf_Click(object sender, EventArgs e)
        {
            //          `Id` INT NOT NULL AUTO_INCREMENT,
            //`Name` VARCHAR(25) NULL,
            //`Description` VARCHAR(50) NULL,
            //`Itempicture` VARCHAR(8) NULL,
            //`Price` DOUBLE(10,2) NULL,
            //`Registrationdate` DATETIME NULL DEFAULT CURRENT_TIMESTAMP COMMENT '', 

            GetBarterItems();
            txt_id.Text = (maxRow + 1).ToString();


            txt_bartercode.Text =
                txt_bartername.Text =
                txt_description.Text =                
                txt_barterpicture.Text =
                txt_price.Text =
                txt_regdate.Text = "";

            pb_item.Image = null;
        }

        private void GetBarterItems()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string Query = "SELECT * FROM sto_table;";
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
            txt_bartercode.Text = dgvVari.Rows[curNavRow].Cells[1].Value.ToString();
            txt_bartername.Text = dgvVari.Rows[curNavRow].Cells[2].Value.ToString();
            txt_description.Text = dgvVari.Rows[curNavRow].Cells[3].Value.ToString();
            txt_price.Text = dgvVari.Rows[curNavRow].Cells[5].Value.ToString();
            txt_barterpicture.Text = dgvVari.Rows[curNavRow].Cells[4].Value.ToString();
            txt_regdate.Text = dgvVari.Rows[curNavRow].Cells[6].Value.ToString();

            //pbItem.Image = Bitmap.FromStream(stream);
        }

        private void ClearAllFields()
        {
            txt_bartercode.Text = "";
            txt_bartername.Text = "";
            txt_description.Text = "";

            txt_price.Text = "";
            txt_barterpicture.Text = "";
            txt_regdate.Text = "";
        }

        private void Barter_Load(object sender, EventArgs e)
        {
            btn_caf.PerformClick();
        }

        private void ElligibleRegistration()
        {
            ene = false;

            TextBox[] rdoTxt = new TextBox[6]
            {
                txt_id, txt_bartercode, txt_bartername,
                txt_description, txt_price, txt_barterpicture,
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
                string Query = "SELECT * FROM sto_table WHERE Id='" + txt_id.Text + "';";
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

                        GetBarterItems();

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
                    MessageBox.Show("Not found. Barter not updated", appName);
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
                    string query = "UPDATE sto_table SET" +
                        " " + "Bartercode='" + txt_bartercode.Text +
                        "', Bartername='" + txt_bartername.Text +
                        "', Description='" + txt_description.Text +
                        "', Price='" + txt_price.Text +
                        
                        "' WHERE Id=" + txt_id.Text + ";";
                    MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
                    MySqlCommand myCommand = new MySqlCommand(query, myConn);

                    MySqlDataReader myReader2;
                    myConn.Open();
                    myReader2 = myCommand.ExecuteReader();


                    //while (myReader2.Read())
                    //{ }
                    myConn.Close();
                    MessageBox.Show(txt_bartercode.Text + " updated", appName);

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

        private void btn_create_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not active yet", appName);
        }

    }
}
