using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCycle
{
    
    public partial class Form1 : Form
    {
        Home home = new Home();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text != "olatunji")
            { }
            else
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (home.Visible == false) { home = new Home(); home.Show(); }
                    else { home.BringToFront(); home.Location = new Point(2, 2); }
                    txtPass.Text = "";
                }
                catch { this.Cursor = Cursors.Default; home = new Home(); home.Show(); }
            }

            
            this.Cursor = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
