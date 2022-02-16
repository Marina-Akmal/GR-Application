using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace GOODS
{
    public partial class ListTransaction : UserControl
    {
        public ListTransaction()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClicked;
        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }
      
        readonly DataTable dt = new DataTable();

        private void NewBttn_Click(object sender, EventArgs e)
        {
            InputData idt = new InputData();
            SupplierItem.ShowControl(idt, Content);
            OnButtonClicked(e);
        }

        private void Searchbtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = String.Format("convert(PurchaseOrder, 'System.String') like '%{0}%'", SearchTB.Text);
                Datalist.DataSource = dv.ToTable();
            }
        }

        private void Datalist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Datalist.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {

                if (Datalist.CurrentCell != null && Datalist.CurrentCell.Value != null)
                    Datalist.CurrentCell.Value.ToString();
                    DETAILS2 idt = new DETAILS2();
                    SupplierItem.ShowControl(idt, Content);
                {
                    idt.DTP.Text = Datalist.CurrentRow.Cells[1].Value.ToString();
                    idt.POI.Text = Datalist.CurrentRow.Cells[2].Value.ToString();
                    idt.DOI.Text = Datalist.CurrentRow.Cells[3].Value.ToString();
                    idt.INI.Text = Datalist.CurrentRow.Cells[4].Value.ToString();
                    idt.SNI.Text = Datalist.CurrentRow.Cells[5].Value.ToString();
                    idt.AWB1.Text = Datalist.CurrentRow.Cells[6].Value.ToString();
                    idt.PCI.Text = Datalist.CurrentRow.Cells[7].Value.ToString();
                    idt.comboPC.Text = Datalist.CurrentRow.Cells[8].Value.ToString();
                    idt.ENI.Text = Datalist.CurrentRow.Cells[9].Value.ToString();
                    idt.REMI.Text = Datalist.CurrentRow.Cells[10].Value.ToString();

                    idt.Show();

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
                CommandText = "select * from ListTransaction"
            };
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                //load DataReader into the DataTable
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                Datalist.DataSource = dt;
            }
        }

        private void SearchTB_Leave(object sender, EventArgs e)
        {
            if (SearchTB.Text == "")
            {
                SearchTB.Text = "Search by Purchase Order number";
            }
        }

        private void SearchTB_Enter(object sender, EventArgs e)
        {
            if (SearchTB.Text == "Search by Purchase Order number")
            {
                SearchTB.Text = "";
            }
        }

        private void Datalist_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.Datalist.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
