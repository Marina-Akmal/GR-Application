
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Configuration;




namespace GOODS
{
    public partial class Login : Form
    {
        int movX = 0, movY = 0;
        bool movDown;
        public Login()
        {
            InitializeComponent();

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //connect to database
        readonly DataTable dt = new DataTable();


        private void Loginbtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\SQLiteStudio\\mylist.db3;Version=3");
            conn.Open();
            if (Usertb.Text == "" || Passtb.Text == "")
            {
                MessageBox.Show("Please enter Username or Password");
                return;
            }
            else
            {
                SQLiteDataAdapter dtap = new SQLiteDataAdapter("Select Username,Password,Status From User where Username= '" + Usertb.Text + "' AND Password='" + Passtb.Text + "' ", conn);
                dtap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Status"].ToString() == "Admin")
                        {
                            Register rg = new Register();
                            SupplierItem.ShowControl(rg, Content);

                        }
                        else if (dr["Status"].ToString() == "User")
                        {
                            ListTransaction lt = new ListTransaction();
                            SupplierItem.ShowControl(lt, Content);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("the Username Or Password you entered is incorrect ");
                    return;
                }

            }
        }


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
                    // Datalist.DataSource = dt;
                }
            }

            private void Usertb_Enter(object sender, EventArgs e)
            {
                if (Usertb.Text == "Username")
                {
                    Usertb.Text = "";
                }
            }

            private void Usertb_Leave(object sender, EventArgs e)
            {
                if (Usertb.Text == "")
                {
                    Usertb.Text = "Username";
                }

            }

            private void Passtb_Enter(object sender, EventArgs e)
            {
                if (Passtb.Text == "Password")
                {
                    Passtb.Text = "";
                }

            }

            private void Passtb_Leave(object sender, EventArgs e)
            {
                if (Passtb.Text == "")
                {
                    Passtb.Text = "Password";
                }

            }

            private void panel2_MouseDown(object sender, MouseEventArgs e)
            {
                movDown = true;
            }

            private void panel2_MouseMove(object sender, MouseEventArgs e)
            {
                if (movDown)
                {
                    movX = MousePosition.X - 200;
                    movY = MousePosition.Y - 40;
                    this.SetDesktopLocation(movX, movY);
                }
            }

            private void panel2_MouseUp(object sender, MouseEventArgs e)
            {
                movDown = false;
            }
        }
    } 