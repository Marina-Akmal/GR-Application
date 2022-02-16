using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOODS
{
    public partial class UserList : UserControl
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            SupplierItem.ShowControl(rg, Content);
        }
        DataTable dt = new DataTable();
        private void Content_Paint(object sender, PaintEventArgs e)
        {
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=C:\\SQLiteStudio\\mylist.db3;Version=3");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand
            {
                Connection = myconnection,
                CommandText = "select * from User"
            };
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                //load DataReader into the DataTable
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
            this.Hide();
        }
    }
}
