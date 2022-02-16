
namespace GOODS
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.Content = new System.Windows.Forms.Panel();
            this.stsCmb = new System.Windows.Forms.ComboBox();
            this.nextbtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Passklbl = new System.Windows.Forms.Label();
            this.Passktb = new System.Windows.Forms.TextBox();
            this.Regislbl = new System.Windows.Forms.Label();
            this.Passtb = new System.Windows.Forms.TextBox();
            this.Passlbl = new System.Windows.Forms.Label();
            this.Regisbtn = new System.Windows.Forms.Button();
            this.Usertb = new System.Windows.Forms.TextBox();
            this.Userlbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Content.Controls.Add(this.stsCmb);
            this.Content.Controls.Add(this.nextbtn);
            this.Content.Controls.Add(this.label2);
            this.Content.Controls.Add(this.Passklbl);
            this.Content.Controls.Add(this.Passktb);
            this.Content.Controls.Add(this.Regislbl);
            this.Content.Controls.Add(this.Passtb);
            this.Content.Controls.Add(this.Passlbl);
            this.Content.Controls.Add(this.Regisbtn);
            this.Content.Controls.Add(this.Usertb);
            this.Content.Controls.Add(this.Userlbl);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(927, 531);
            this.Content.TabIndex = 7;
            // 
            // stsCmb
            // 
            this.stsCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsCmb.ForeColor = System.Drawing.Color.Black;
            this.stsCmb.FormattingEnabled = true;
            this.stsCmb.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.stsCmb.Location = new System.Drawing.Point(370, 311);
            this.stsCmb.Name = "stsCmb";
            this.stsCmb.Size = new System.Drawing.Size(253, 28);
            this.stsCmb.TabIndex = 88;
            // 
            // nextbtn
            // 
            this.nextbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextbtn.FlatAppearance.BorderSize = 0;
            this.nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbtn.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.nextbtn.IconColor = System.Drawing.Color.White;
            this.nextbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.nextbtn.IconSize = 30;
            this.nextbtn.Location = new System.Drawing.Point(898, 3);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(26, 28);
            this.nextbtn.TabIndex = 85;
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(280, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 84;
            this.label2.Text = "Status";
            // 
            // Passklbl
            // 
            this.Passklbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Passklbl.AutoSize = true;
            this.Passklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passklbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Passklbl.Location = new System.Drawing.Point(152, 254);
            this.Passklbl.Name = "Passklbl";
            this.Passklbl.Size = new System.Drawing.Size(185, 18);
            this.Passklbl.TabIndex = 83;
            this.Passklbl.Text = "Password Confirmation";
            // 
            // Passktb
            // 
            this.Passktb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passktb.ForeColor = System.Drawing.Color.Black;
            this.Passktb.Location = new System.Drawing.Point(370, 248);
            this.Passktb.Multiline = true;
            this.Passktb.Name = "Passktb";
            this.Passktb.Size = new System.Drawing.Size(253, 27);
            this.Passktb.TabIndex = 81;
            this.Passktb.UseWaitCursor = true;
            this.Passktb.Leave += new System.EventHandler(this.Passktb_Leave);
            // 
            // Regislbl
            // 
            this.Regislbl.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Regislbl.AutoSize = true;
            this.Regislbl.BackColor = System.Drawing.Color.Transparent;
            this.Regislbl.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regislbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Regislbl.Location = new System.Drawing.Point(431, 46);
            this.Regislbl.Name = "Regislbl";
            this.Regislbl.Size = new System.Drawing.Size(98, 24);
            this.Regislbl.TabIndex = 80;
            this.Regislbl.Text = "Register";
            // 
            // Passtb
            // 
            this.Passtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passtb.ForeColor = System.Drawing.Color.Black;
            this.Passtb.Location = new System.Drawing.Point(370, 194);
            this.Passtb.Multiline = true;
            this.Passtb.Name = "Passtb";
            this.Passtb.Size = new System.Drawing.Size(253, 27);
            this.Passtb.TabIndex = 79;
            this.Passtb.UseWaitCursor = true;
            // 
            // Passlbl
            // 
            this.Passlbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Passlbl.AutoSize = true;
            this.Passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Passlbl.Location = new System.Drawing.Point(253, 198);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(83, 18);
            this.Passlbl.TabIndex = 78;
            this.Passlbl.Text = "Password";
            // 
            // Regisbtn
            // 
            this.Regisbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Regisbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Regisbtn.FlatAppearance.BorderSize = 0;
            this.Regisbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Regisbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regisbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Regisbtn.Location = new System.Drawing.Point(370, 412);
            this.Regisbtn.Name = "Regisbtn";
            this.Regisbtn.Size = new System.Drawing.Size(253, 33);
            this.Regisbtn.TabIndex = 73;
            this.Regisbtn.Text = "Register";
            this.Regisbtn.UseVisualStyleBackColor = false;
            this.Regisbtn.Click += new System.EventHandler(this.Regisbtn_Click);
            // 
            // Usertb
            // 
            this.Usertb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertb.ForeColor = System.Drawing.Color.Black;
            this.Usertb.Location = new System.Drawing.Point(370, 140);
            this.Usertb.Multiline = true;
            this.Usertb.Name = "Usertb";
            this.Usertb.Size = new System.Drawing.Size(253, 27);
            this.Usertb.TabIndex = 74;
            this.Usertb.UseWaitCursor = true;
            // 
            // Userlbl
            // 
            this.Userlbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Userlbl.Location = new System.Drawing.Point(251, 142);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(85, 18);
            this.Userlbl.TabIndex = 77;
            this.Userlbl.Text = "Username";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Content);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(927, 531);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Content;
        private System.Windows.Forms.TextBox Passtb;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.Button Regisbtn;
        private System.Windows.Forms.TextBox Usertb;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label Regislbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Passklbl;
        private System.Windows.Forms.TextBox Passktb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton nextbtn;
        private System.Windows.Forms.ComboBox stsCmb;
    }
}
