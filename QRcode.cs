using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.Drawing.Printing;
using Newtonsoft.Json;

namespace GOODS
{
    public partial class QRcode : UserControl
    {
        PrintPreviewDialog prdia = new PrintPreviewDialog();
        PrintDocument prdoc = new PrintDocument();
        public QRcode(InputData frm)
        {
            InitializeComponent();
        }

        public QRcode(SupplierItemModel supplierItem)
        {
            InitializeComponent();

            //Konversi class menjadi 1 baris string
            //string value = supplierItem.DateSender + ";" +
            //                supplierItem.PurchaseOrder + ";" +
            //                supplierItem.DeliveryOrder + ";" +
            //                supplierItem.InvoiceNo + ";" +
            //                supplierItem.ShipperName + ";" +
            //                supplierItem.AWBReff + ";" +
            //                supplierItem.Package + ";" +
            //                supplierItem.EnduserName + ";" +
            //                supplierItem.Remarks + ";" +
            //                supplierItem.ItemName + ";" +
            //                supplierItem.ItemName2 + ";";

            string value = JsonConvert.SerializeObject(supplierItem);

            QRCodeGenerator qrCodeGen = new QRCodeGenerator();
            QRCodeData codeData = qrCodeGen.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(codeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(10, Color.Black, Color.White, true);
            pictureBox1.Image = qrCodeImage;
        }
    
        //public QRcode(SupplierItem supplierItem)
        //{
        //    InitializeComponent();

        //    //Konversi class menjadi 1 baris string
        //    string value = supplierItem.DateSender + ";" +
        //                    supplierItem.PurchaseOrder + ";" +
        //                    supplierItem.DeliveryOrder + ";" +
        //                    supplierItem.InvoiceNo + ";" +
        //                    supplierItem.ShipperName + ";" +
        //                    supplierItem.AWBReff + ";" +
        //                    supplierItem.Package + ";" +
        //                    supplierItem.EnduserName + ";" +
        //                    supplierItem.Remarks + ";" +
        //                    supplierItem.ItemName + ";" +
        //                    supplierItem.ItemName2 + ";";

        //    QRCodeGenerator qrCodeGen = new QRCodeGenerator();
        //    QRCodeData codeData = qrCodeGen.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
        //    QRCode qrCode = new QRCode(codeData);

        //    Bitmap qrCodeImage = qrCode.GetGraphic(10, Color.Black, Color.White, true);
        //    pictureBox1.Image = qrCodeImage;
        //}

        private void PictureBox1_Click(object sender,System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
        }
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            prdia.Document = prdoc;
            prdoc.PrintPage += new PrintPageEventHandler(prdoc_printpage);
            prdia.ShowDialog();
        }
        public void prdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
        Bitmap memoryimg;
        public void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Print(this.panel1);


            //PrintDialog pd = new PrintDialog();
            //PrintDocument doc = new PrintDocument();
            //pd.Document = doc;
            //doc.PrintPage += DocPic;
            //if (pd.ShowDialog() == DialogResult.OK)
            //{
            //    doc.Print();
            //}



            ListTransaction nl = new ListTransaction();
            SupplierItem.ShowControl(nl, Content);

        }
        //private void DocPic(object sender, PrintPageEventArgs e)
        //{
        //    Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        //    pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
        //    e.Graphics.DrawImage(bm, 0, 0);
        //    bm.Dispose();
        //}

    }
}
