namespace GOODS
{
    partial class ListTransaction
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Content = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NewBttn = new System.Windows.Forms.Button();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Datalist = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datalist)).BeginInit();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.Transparent;
            this.Content.Controls.Add(this.tableLayoutPanel2);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(927, 531);
            this.Content.TabIndex = 7;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.314995F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.04639F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.580153F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.532957F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.93409F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.344633F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(927, 531);
            this.tableLayoutPanel2.TabIndex = 82;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Datalist, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(43, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.11236F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.88764F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(838, 445);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.31232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.68768F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 542F));
            this.tableLayoutPanel1.Controls.Add(this.NewBttn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchTB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 39);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // NewBttn
            // 
            this.NewBttn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewBttn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewBttn.FlatAppearance.BorderSize = 0;
            this.NewBttn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBttn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NewBttn.Location = new System.Drawing.Point(3, 3);
            this.NewBttn.Name = "NewBttn";
            this.NewBttn.Size = new System.Drawing.Size(166, 33);
            this.NewBttn.TabIndex = 79;
            this.NewBttn.Text = "New List";
            this.NewBttn.UseVisualStyleBackColor = false;
            this.NewBttn.Click += new System.EventHandler(this.NewBttn_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTB.ForeColor = System.Drawing.Color.Black;
            this.SearchTB.Location = new System.Drawing.Point(292, 3);
            this.SearchTB.Multiline = true;
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(537, 33);
            this.SearchTB.TabIndex = 80;
            this.SearchTB.UseWaitCursor = true;
            this.SearchTB.Enter += new System.EventHandler(this.SearchTB_Enter);
            this.SearchTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Searchbtn_KeyPress);
            this.SearchTB.Leave += new System.EventHandler(this.SearchTB_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(175, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 39);
            this.label2.TabIndex = 81;
            this.label2.Text = "Search :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // Datalist
            // 
            this.Datalist.AllowUserToAddRows = false;
            this.Datalist.AllowUserToDeleteRows = false;
            this.Datalist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Datalist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datalist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No});
            this.Datalist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Datalist.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.Datalist.Location = new System.Drawing.Point(3, 48);
            this.Datalist.Name = "Datalist";
            this.Datalist.ReadOnly = true;
            this.Datalist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Datalist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Datalist.RowHeadersWidth = 50;
            this.Datalist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datalist.Size = new System.Drawing.Size(832, 394);
            this.Datalist.TabIndex = 5;
            this.Datalist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datalist_CellClick);
            this.Datalist.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Datalist_RowPostPaint);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // ListTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Content);
            this.Name = "ListTransaction";
            this.Size = new System.Drawing.Size(927, 531);
            this.Content.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datalist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Content;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button NewBttn;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView Datalist;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
    }
}
