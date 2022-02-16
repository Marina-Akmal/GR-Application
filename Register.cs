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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Passktb_Leave(object sender, EventArgs e)
        {
            if(Passktb.Text != Passtb.Text)
            {
                MessageBox.Show("Password is Not Matching");
                Passktb.Focus();
                return;
            }
        }

        private void Regisbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection dbcon = new SQLiteConnection("Data Source=C:\\SQLiteStudio\\mylist.db3;Version=3"))
                {
                    dbcon.Open();
                    string sql;
                    sql = "INSERT INTO User(Username,Password,Status) Values(@Username,@Password,@Status)";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, dbcon))
                    {
                        //cmd.Parameters.AddWithValue("ID", IDtb.Text);
                        cmd.Parameters.AddWithValue("Username", Usertb.Text);
                        cmd.Parameters.AddWithValue("Password", Passtb.Text);
                        cmd.Parameters.AddWithValue("Status", stsCmb.Text);

                        cmd.ExecuteNonQuery();
                        dbcon.Close();


                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Please fix the textBox ");
                //return;
            }
            //if (string.IsNullOrEmpty(IDtb.Text))
            //{
            //    IDtb.Focus();
            //    errorProvider1.SetError(IDtb, "Please Enter fix");
            //    return;
            //}
            if (string.IsNullOrEmpty(Usertb.Text))
            {
                Usertb.Focus();
                errorProvider1.SetError(Usertb, "Please Enter fix");
                return;
            }
            if (string.IsNullOrEmpty(Passtb.Text))
            {
                Passtb.Focus();
                errorProvider1.SetError(Passtb, "Please Enter fix");
                return;
            }
            if (string.IsNullOrEmpty(stsCmb.Text))
            {
                stsCmb.Focus();
                errorProvider1.SetError(stsCmb, "Please Enter fix");
                return;
            }

            UserList ul = new UserList();
            SupplierItem.ShowControl(ul, Content);

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            UserList ul = new UserList();
            SupplierItem.ShowControl(ul, Content);
        }
    }
}
