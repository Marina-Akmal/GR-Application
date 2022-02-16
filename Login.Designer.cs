
namespace GOODS
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.MinButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.Content = new System.Windows.Forms.Panel();
            this.Loginlbl = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.Passtb = new System.Windows.Forms.TextBox();
            this.Usertb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 589);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblTittle);
            this.panel2.Controls.Add(this.MinButton);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 42);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // lblTittle
            // 
            this.lblTittle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Black;
            this.lblTittle.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTittle.Location = new System.Drawing.Point(16, 13);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(69, 19);
            this.lblTittle.TabIndex = 4;
            this.lblTittle.Text = "GOODS";
            // 
            // MinButton
            // 
            this.MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.MinButton.IconColor = System.Drawing.Color.DarkOliveGreen;
            this.MinButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MinButton.IconSize = 30;
            this.MinButton.Location = new System.Drawing.Point(873, 13);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(26, 28);
            this.MinButton.TabIndex = 4;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ExitButton.IconColor = System.Drawing.Color.Brown;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ExitButton.IconSize = 30;
            this.ExitButton.Location = new System.Drawing.Point(899, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(26, 28);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Content.Controls.Add(this.panel4);
            this.Content.Controls.Add(this.panel3);
            this.Content.Controls.Add(this.iconButton4);
            this.Content.Controls.Add(this.iconButton3);
            this.Content.Controls.Add(this.Passtb);
            this.Content.Controls.Add(this.Usertb);
            this.Content.Controls.Add(this.Loginlbl);
            this.Content.Controls.Add(this.Loginbtn);
            this.Content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Content.Location = new System.Drawing.Point(0, 47);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(938, 540);
            this.Content.TabIndex = 6;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // Loginlbl
            // 
            this.Loginlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Loginlbl.AutoSize = true;
            this.Loginlbl.BackColor = System.Drawing.Color.Transparent;
            this.Loginlbl.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Loginlbl.Location = new System.Drawing.Point(455, 82);
            this.Loginlbl.Name = "Loginlbl";
            this.Loginlbl.Size = new System.Drawing.Size(69, 24);
            this.Loginlbl.TabIndex = 5;
            this.Loginlbl.Text = "Login";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Loginbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Loginbtn.FlatAppearance.BorderSize = 0;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Loginbtn.Location = new System.Drawing.Point(370, 315);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(253, 32);
            this.Loginbtn.TabIndex = 73;
            this.Loginbtn.Text = "LOG IN";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(370, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 3);
            this.panel4.TabIndex = 96;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(370, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 3);
            this.panel3.TabIndex = 95;
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(370, 237);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(30, 30);
            this.iconButton4.TabIndex = 94;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(368, 157);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(30, 30);
            this.iconButton3.TabIndex = 91;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // Passtb
            // 
            this.Passtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Passtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passtb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Passtb.Location = new System.Drawing.Point(415, 237);
            this.Passtb.Multiline = true;
            this.Passtb.Name = "Passtb";
            this.Passtb.Size = new System.Drawing.Size(205, 27);
            this.Passtb.TabIndex = 93;
            this.Passtb.UseWaitCursor = true;
            this.Passtb.Enter += new System.EventHandler(this.Passtb_Enter);
            this.Passtb.Leave += new System.EventHandler(this.Passtb_Leave);
            // 
            // Usertb
            // 
            this.Usertb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Usertb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usertb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Usertb.Location = new System.Drawing.Point(417, 160);
            this.Usertb.Multiline = true;
            this.Usertb.Name = "Usertb";
            this.Usertb.Size = new System.Drawing.Size(203, 27);
            this.Usertb.TabIndex = 92;
            this.Usertb.UseWaitCursor = true;
            this.Usertb.Enter += new System.EventHandler(this.Usertb_Enter);
            this.Usertb.Leave += new System.EventHandler(this.Usertb_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(938, 587);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton MinButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button Loginbtn;
        public System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Loginlbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox Passtb;
        private System.Windows.Forms.TextBox Usertb;
    }
}

