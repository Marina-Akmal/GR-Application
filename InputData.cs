
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
    public partial class InputData : UserControl

    {
        public InputData()
        {
            InitializeComponent();
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

        private void Generate_Click(object sender, EventArgs e)
        {

            //save textBox to database
            try
            {
                using (SQLiteConnection dbcon = new SQLiteConnection("Data Source=C:\\SQLiteStudio\\mylist.db3;Version=3"))
                {
                    dbcon.Open();
                    string sql;
                    sql = "INSERT INTO ListTransaction(DateSender,PurchaseOrder,DeliveryOrder,InvoiceNo,ShipperName, AWBReff, Package,Unit, EnduserName, Remarks)"
                        + " Values(@DateSender,@PurchaseOrder,@DeliveryOrder,@InvoiceNo,@ShipperName,@AWBReff,@Package,@Unit, @EnduserName,@Remarks)";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, dbcon))
                    {
                        cmd.Parameters.AddWithValue("DateSender", DTP.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("PurchaseOrder", POI.Text);
                        cmd.Parameters.AddWithValue("DeliveryOrder", DOI.Text);
                        cmd.Parameters.AddWithValue("InvoiceNo", INI.Text);
                        cmd.Parameters.AddWithValue("ShipperName", SNI.Text);
                        cmd.Parameters.AddWithValue("AWBReff", AWB1.Text);
                        cmd.Parameters.AddWithValue("Package", PCI.Text);
                        cmd.Parameters.AddWithValue("Unit", comboPC.Text);
                        cmd.Parameters.AddWithValue("EnduserName", ENI.Text);
                        cmd.Parameters.AddWithValue("Remarks", REMI.Text);

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

            DataTable dt = GetDataTableFromDGV(DGV);
            dt.Rows.RemoveAt(dt.Rows.Count - 1);
            if (dt.Select("Column2='' or Column3='' or Column4='' or " +
                    "Column2 is null or Column3 is null or Column4 is null").Count() > 0)
            {
                MessageBox.Show("Something Whent Wrong");
                return;
            }

            //save DGV to database
            foreach (DataRow dr in dt.Select("Column1<>''"))
            {
                try
                {
                    using (SQLiteConnection db = new SQLiteConnection("Data Source=C:\\SQLiteStudio\\mylist.db3;Version=3"))
                    {
                        string sql2;
                        sql2 = "INSERT INTO ItemName(Item,Qty,UOM,PurchaseOrder)" + "VALUES(@Item,@Qty,@UOM,@PurchaseOrder)";

                        using (SQLiteCommand cmd2 = new SQLiteCommand(sql2, db))
                        {
                            cmd2.Parameters.AddWithValue("Item", dr["Column2"].ToString());
                            cmd2.Parameters.AddWithValue("Qty", dr["Column3"].ToString());
                            cmd2.Parameters.AddWithValue("UOM", dr["Column4"].ToString());
                            cmd2.Parameters.AddWithValue("PurchaseOrder", POI.Text);

                            db.Open();
                            cmd2.ExecuteNonQuery();
                            db.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fix the DataGridView ");

                }

            }

            //show error icon if value is null
            if (string.IsNullOrEmpty(DTP.Text))
            {
                DTP.Focus();
                errorProvider1.SetError(DTP, "Please Enter fix");
                return;
            }
            if (string.IsNullOrEmpty(POI.Text))
            {
                POI.Focus();
                errorProvider1.SetError(POI, "Please Enter Prchase Order");
                return;
            }

            if (string.IsNullOrEmpty(DOI.Text))
            {
                DOI.Focus();
                errorProvider1.SetError(DOI, "Please Enter Delivery Order");
                return;
            }
            if (string.IsNullOrEmpty(SNI.Text))
            {
                SNI.Focus();
                errorProvider1.SetError(SNI, "Please Enter Shipper Name");
                return;
            }
            if (string.IsNullOrEmpty(PCI.Text))
            {
                PCI.Focus();
                errorProvider1.SetError(PCI, "Please Enter Package ");
                return;
            }
            if (string.IsNullOrEmpty(comboPC.Text))
            {
                comboPC.Focus();
                errorProvider1.SetError(comboPC, "Please choice Package");
                return;
            }
            if (string.IsNullOrEmpty(ENI.Text))
            {
                ENI.Focus();
                errorProvider1.SetError(ENI, "Please Enter Enduser Name");
                return;
            }

     
            SupplierItemModel supplierItem = new SupplierItemModel
            {
                DateSender = DTP.Text,
                PurchaseOrder = POI.Text,
                DeliveryOrder = DOI.Text,
                InvoiceNo = INI.Text,
                ShipperName = SNI.Text,
                AWBReff = AWB.Text,
                Package = PCI.Text,
                PackageUOM = comboPC.Text,
                EnduserName = ENI.Text,
                Remarks = REMI.Text,
                Item = new List<SupplierItemDetailModel>(),
            };

            string itemlist = "", qtylist = "", uomlist = "";

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



        private void DGV_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.DGV.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void DTP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void POI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DOI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number + Char
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void INI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number + Char
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Char only
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AWB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number + Char
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ENI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Char only
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void POI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(POI.Text))
            {
                e.Cancel = true;
                POI.Focus();
                errorProvider1.SetError(POI, "the Purchase Order can't empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(POI, null);
            }
        }

        private void DOI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DOI.Text))
            {
                e.Cancel = true;
                DOI.Focus();
                errorProvider1.SetError(DOI, "Delivery Order can't empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(DOI, null);
            }
        }

        private void SNI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(SNI.Text))
            {
                e.Cancel = true;
                SNI.Focus();
                errorProvider1.SetError(SNI, "the Shipper Name can't empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(SNI, null);
            }
        }


        private void PCI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PCI.Text))
            {
                e.Cancel = true;
                PCI.Focus();
                errorProvider1.SetError(PCI, "the Package can't empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(PCI, null);
            }
        }

        private void ComboPC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboPC.Text))
            {
                e.Cancel = true;
                comboPC.Focus();
                errorProvider1.SetError(comboPC, "can't empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboPC, null);
            }
        }

        private void ENI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ENI.Text))
            {
                e.Cancel = true;
                ENI.Focus();
                errorProvider1.SetError(ENI, "the Enduser Name can't empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ENI, null);
            }
        }

        private void POI_TextChanged(object sender, EventArgs e)
        {
            //if(string.IsNullOrWhiteSpace(POI.Text))
            //{
            //    label1.Text = null;
            //}
            //else
            //{
            //    label1.ForeColor = Color.Red;
            //    label1.Text = "Purchase Order Harus diisi";
            //}
        }
    }
    }


    

