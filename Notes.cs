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

namespace UCycle
{
    public partial class Notes : Form
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


        public Notes()
        {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            loadFont();
            AllocFont(font, this.dgvNote, 10.00F);


            GetNotes();
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

        private void GetNotes()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //DateTime dts = DateTime.Now;
                string Query = "SELECT * FROM not_table ORDER BY Id Asc;";
                MySqlConnection myConn2 = new MySqlConnection(Home.miHomeRef.my_data_loc);
                MySqlCommand myComm2 = new MySqlCommand(Query, myConn2);

                //myComm2.CommandTimeout = 120;

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myComm2;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                dgvNote.DataSource = dtable;

                //DateTime dte = DateTime.Now;
                //TimeSpan ts = dte - dts;
                //MessageBox.Show("Fetch took (ms):" + ts.TotalMilliseconds.ToString());
                //
                dgvNote.RowHeadersVisible = false;
                dgvNote.Columns[0].Width = 40;
                dgvNote.Columns[1].Width = 600;

                if (dtable.Rows.Count > maxRow)
                {
                    //sp.Play();
                }

                maxRow = dtable.Rows.Count;


                //OrderGridSet();

                try
                {

                    dgvNote.ClearSelection();
                    //dataGridView1.FirstDisplayedScrollingRowIndex = idswap - 1;

                    dgvNote.Rows[0].Selected = true;//dgvOrde.Rows.Count - 2].Selected = true;
                    dgvNote.CurrentCell = dgvNote[0, 0];//dgvOrde.Rows.Count - 2];

                    curNavRow = dgvNote.CurrentRow.Index;


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
            GetNotes();
        }

        private void dgvNote_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                curNavRow = dgvNote.CurrentRow.Index;
                //PopulateText();
                txt_note.Text = dgvNote.Rows[curNavRow].Cells[1].Value.ToString();
            }
            catch { txt_note.Text = ""; }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM not_table WHERE Id='" + (curNavRow + 1) + "';";
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

                    int ui = Convert.ToInt32((curNavRow + 1));
                    //UpdateEntry();

                    //if (dtable.Rows.Count == 1)
                    {
                        string query = "UPDATE not_table SET" +
                            " " + "Notification='" + txt_note.Text +
                            "' WHERE Id=" + ui + ";";
                        MySqlConnection myConn = new MySqlConnection(Home.miHomeRef.my_data_loc);
                        MySqlCommand myCommand = new MySqlCommand(query, myConn);

                        MySqlDataReader myReader2;
                        myConn.Open();
                        myReader2 = myCommand.ExecuteReader();


                        //while (myReader2.Read())
                        //{ }
                        myConn.Close();
                        MessageBox.Show("id " + ui + ": updated", appName);

                    }

                    btn_caf.PerformClick();


                    this.Cursor = Cursors.Default;
                }
                //else { }
            }
            else
            {
                MessageBox.Show("Not found. Item not updated", appName);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not active yet", appName);
        }
    }
}
