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



namespace UCycle
{
    public partial class Orders : Form
    {
        string dev_name = "rilobas.app";
        string dev_email = "rilobas.app";

        string appName = "UCycle";
        //Home form_home = new Home();

        //public static Form1 miForm1rref = null;

        string my_data_loc = "SERVER=rilobas.app; USER ID=rb_ucu_usr; DATABASE=ideabwoy_ucycle_db; PORT=3306; PASSWORD=kg]h[nTaufz#7D;";
        //string my_data_loc = "SERVER=127.0.0.1; USER ID=croot; DATABASE=ideabwoy_ucycle_db; PORT=3306; PASSWORD=sroot;";



        int maxRow = 0;
        int curNavRow = 0;

        Boolean ordersGotten = false;

        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

            GetOrders();

            //if (ordersGotten)
            //{
            //    DoChart();
            //}
            //else
            //{
            //    MessageBox.Show("Orders unreachable", appName);
            //}
        }

        private void GetOrders()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //DateTime dts = DateTime.Now;
                string Query = "SELECT * FROM sch_table ORDER BY Id Desc;";
                MySqlConnection myConn2 = new MySqlConnection(my_data_loc);
                MySqlCommand myComm2 = new MySqlCommand(Query, myConn2);

                //myComm2.CommandTimeout = 120;

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myComm2;
                DataTable dtable = new DataTable();
                myAdapter.Fill(dtable);
                dgvOrde.DataSource = dtable;

                //DateTime dte = DateTime.Now;
                //TimeSpan ts = dte - dts;
                //MessageBox.Show("Fetch took (ms):" + ts.TotalMilliseconds.ToString());
                //
                dgvOrde.Columns[0].Width = 40;
                dgvOrde.Columns[1].Width = 190;
                dgvOrde.Columns[2].Width = 100;
                dgvOrde.Columns[3].Width = 100;
                dgvOrde.Columns[4].Width = 140;
                dgvOrde.Columns[5].Width = 100;
                dgvOrde.Columns[6].Width = 140;
                dgvOrde.Columns[7].Width = 100;
                dgvOrde.Columns[8].Width = 100;
                dgvOrde.Columns[9].Width = 100;
                dgvOrde.Columns[10].Width = 100;
                dgvOrde.Columns[11].Width = 100;


                if (dtable.Rows.Count > maxRow)
                {
                    //sp.Play();
                }

                maxRow = dtable.Rows.Count;


                //OrderGridSet();

                try
                {

                    dgvOrde.ClearSelection();
                    //dataGridView1.FirstDisplayedScrollingRowIndex = idswap - 1;

                    dgvOrde.Rows[0].Selected = true;//dgvOrde.Rows.Count - 2].Selected = true;
                    dgvOrde.CurrentCell = dgvOrde[0, 0];//dgvOrde.Rows.Count - 2];

                    curNavRow = dgvOrde.CurrentRow.Index;


                }
                catch { }

                lbl_req.Text = "UCycle Requests: " + maxRow.ToString();

                ordersGotten = true;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                ordersGotten = false;
                this.Cursor = Cursors.Default;

                maxRow = 0;
                MessageBox.Show("Unreachable");
                //txt_help.ForeColor = System.Drawing.Color.Red;
                //txt_help.Text = "Internet or Remote Host Unreachable ";
                this.Close();
            }
        }

        private void DoChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Orders (#)");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chart2.Series.Clear();
            chart2.Series.Add("Income (N)");
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;


            DateTime rDate;
            double rMoney;



            int d = dgvOrde.Rows.Count - 1;
            DateTime[] rDt = new DateTime[d];
            double[] rMt = new double[d];

            for (int j = 0; j < dgvOrde.Rows.Count - 1; j++)
            {
                rDt[j] = Convert.ToDateTime(Convert.ToDateTime(dgvOrde.Rows[j].Cells[4].Value).ToString("dd-MM-yyyy"));

                try { rMt[j] = Convert.ToDouble(dgvOrde.Rows[j].Cells[2].Value); }
                catch { rMt[j] = 0.0; }
            }


            //DateTime dts = DateTime.Now;
            // mybubblesort
            for (int p = 0; p < rDt.Length - 1; p++)
            {
                for (int i = 0; i < rDt.Length - 1; i++)
                {
                    if (rDt[i] > rDt[i + 1])
                    {
                        rDate = rDt[i + 1];

                        rDt[i + 1] = rDt[i];

                        rDt[i] = rDate;

                        //
                        rMoney = rMt[i + 1];

                        rMt[i + 1] = rMt[i];

                        rMt[i] = rMoney;
                    }

                }
            }
            //DateTime dte = DateTime.Now;
            //TimeSpan ts = dte - dts;
            //MessageBox.Show("Sort took (ms):" + ts.TotalMilliseconds.ToString());



            int count = 0;
            int[] dCount = new int[rDt.Distinct().ToArray().Length];

            double moneycount = 0;
            double[] mCount = new double[rMt.Distinct().ToArray().Length];

            // array distinct count comparison
            int z = 0;
            for (int i = 0; i < rDt.Length; i++)
            {
                if ((i + 1) != rDt.Length)
                {
                    if (rDt[i] == rDt[i + 1])
                    {
                        count++;

                        moneycount += rMt[i];
                    }
                    else
                    {
                        count++;
                        dCount[z] = count;

                        //
                        moneycount += rMt[i];
                        mCount[z] = moneycount;
                        moneycount = 0;
                        //

                        count = 0;
                        z++;
                    }
                }
                else
                {
                    count++;
                    dCount[z] = count;

                    //
                    moneycount += rMt[i];
                    mCount[z] = moneycount;
                    moneycount = 0;
                    //

                    count = 0;
                    z++;
                }
            }
            // array distinct count comparison






            DateTime[] chartDayId = rDt.Distinct().ToArray();
            for (int i = 0; i < chartDayId.Length; i++)
            {
                //MessageBox.Show(chartDayId[i].ToString("dd-MM"));
                chart1.Series[0].Points.AddXY(chartDayId[i].ToString("dd-MM") + " (" + dCount[i].ToString() + ")", dCount[i]);
            }

            for (int i = 0; i < chartDayId.Length; i++)
            {
                //MessageBox.Show(chartDayId[i].ToString("dd-MM"));
                chart2.Series[0].Points.AddXY(chartDayId[i].ToString("dd-MM") + " (" + mCount[i].ToString() + ")", mCount[i]);
            }






        }
    }
}
