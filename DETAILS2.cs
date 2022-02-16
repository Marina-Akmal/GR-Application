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
    public partial class DETAILS2 : UserControl
    {
        public DETAILS2()
        {
            InitializeComponent();
        }
        
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbcon = new SQLiteConnection("Data Source=C:\\SQLiteStudio\\mylist.db3;Version=3");
            try
            {
                DialogResult delete = MessageBox.Show("Are you sure you want to delete this Record", "Confirmation Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes)
                {
                    string Delete = " Delete From ListTransaction where PurchaseOrder = " + POI.Text + ";";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(Delete, dbcon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
                {
                    string Delete = " Delete From ItemName where PurchaseOrder =" + POI.Text + "";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(Delete, dbcon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListTransaction nl = new ListTransaction();
            SupplierItem.ShowControl(nl, Content);

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            SupplierItemModel supplierItem = new SupplierItemModel
            {
                DateSender = DTP.Text,
                PurchaseOrder = POI.Text,
                DeliveryOrder = DOI.Text,
                InvoiceNo = INI.Text,
                ShipperName = SNI.Text,
                AWBReff = AWB1.Text,
                Package = PCI.Text,
                PackageUOM = comboPC.Text,
                EnduserName = ENI.Text,
                Remarks = REMI.Text,
                Item = new List<SupplierItemDetailModel>(),
            };

            string itemlist = "", qtylist = "", uomlist = "";
            DataTable dt = GetDataTableFromDGV(DGV);

            foreach (DataRow dr in dt.Select("Column1<>''"))
            {
                supplierItem.Item.Add(new SupplierItemDetailModel()
                {
                    Item = dr["Column2"].ToString(),
                    qty = Convert.ToDecimal(dr["Column3"]),
                    uom = dr["Column4"].ToString(),
                });
                itemlist += dr["Column1"] + ";";
                qtylist += dr["Column2"] + ";";
                uomlist += dr["Column3"] + ";";
            }

            QRcode qri = new QRcode(supplierItem);
            SupplierItem.ShowControl(qri, Content);

            qri.shipper.Text = SNI.Text;
            SNI.Text = "";

            qri.enduser.Text = ENI.Text;
            ENI.Text = "";

        }

        private void POI_TextChanged(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\SQLiteStudio\\mylist.db3;Version=3");
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Item,Qty,UOM FROM ItemName WHERE PurchaseOrder LIKE '%" + POI.Text + "%'", conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            DGV.DataSource = dt;
            conn.Close();

        }
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {

            var dt = new DataTable();
            foreach (DataGridViewColumn column2 in dgv.Columns)
            {
                if (column2.Visible)
                {
                    dt.Columns.Add();
                }
            }
            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

        private void DGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.DGV.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
