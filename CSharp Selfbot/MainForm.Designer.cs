namespace CSharp_Selfbot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.top_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c_Token = new System.Windows.Forms.ToolStripTextBox();
            this.c_Prefix = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.c_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_status = new System.Windows.Forms.Label();
            this.user_date = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_avatar = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.connect_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.discord_prefix = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.discord_token = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectToAccount = new System.ComponentModel.BackgroundWorker();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogoMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_avatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Controls.Add(this.minimize_btn);
            this.top_panel.Controls.Add(this.exit_btn);
            this.top_panel.Location = new System.Drawing.Point(-2, -63);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(714, 96);
            this.top_panel.TabIndex = 0;
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "C# Selfbot";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(655, 60);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(23, 35);
            this.minimize_btn.TabIndex = 2;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Text = "_";
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(682, 60);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(23, 35);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.TabStop = false;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pictureBox1.ContextMenuStrip = this.LogoMenuStrip;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LogoMenuStrip
            // 
            this.LogoMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LogoMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.LogoMenuStrip.Name = "LogoMenuStrip";
            this.LogoMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_Token,
            this.c_Prefix,
            this.toolStripSeparator1,
            this.c_Connect});
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // c_Token
            // 
            this.c_Token.Name = "c_Token";
            this.c_Token.Size = new System.Drawing.Size(100, 23);
            this.c_Token.Text = "Token";
            // 
            // c_Prefix
            // 
            this.c_Prefix.Name = "c_Prefix";
            this.c_Prefix.Size = new System.Drawing.Size(100, 23);
            this.c_Prefix.Text = "Prefix";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // c_Connect
            // 
            this.c_Connect.Name = "c_Connect";
            this.c_Connect.Size = new System.Drawing.Size(180, 22);
            this.c_Connect.Text = "Connect";
            this.c_Connect.Click += new System.EventHandler(this.c_Connect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.user_status);
            this.panel1.Controls.Add(this.user_date);
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.user_avatar);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.connect_btn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.discord_prefix);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.discord_token);
            this.panel1.Location = new System.Drawing.Point(17, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 362);
            this.panel1.TabIndex = 3;
            // 
            // user_status
            // 
            this.user_status.AutoSize = true;
            this.user_status.BackColor = System.Drawing.Color.Transparent;
            this.user_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.user_status.ForeColor = System.Drawing.Color.White;
            this.user_status.Location = new System.Drawing.Point(100, 333);
            this.user_status.Name = "user_status";
            this.user_status.Size = new System.Drawing.Size(28, 17);
            this.user_status.TabIndex = 12;
            this.user_status.Text = "n/a";
            // 
            // user_date
            // 
            this.user_date.AutoSize = true;
            this.user_date.BackColor = System.Drawing.Color.Transparent;
            this.user_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.user_date.ForeColor = System.Drawing.Color.White;
            this.user_date.Location = new System.Drawing.Point(110, 314);
            this.user_date.Name = "user_date";
            this.user_date.Size = new System.Drawing.Size(28, 17);
            this.user_date.TabIndex = 11;
            this.user_date.Text = "n/a";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BackColor = System.Drawing.Color.Transparent;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.user_name.ForeColor = System.Drawing.Color.White;
            this.user_name.Location = new System.Drawing.Point(125, 295);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(28, 17);
            this.user_name.TabIndex = 10;
            this.user_name.Text = "n/a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username:";
            // 
            // user_avatar
            // 
            this.user_avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_avatar.Image = ((System.Drawing.Image)(resources.GetObject("user_avatar.Image")));
            this.user_avatar.Location = new System.Drawing.Point(71, 142);
            this.user_avatar.Name = "user_avatar";
            this.user_avatar.Size = new System.Drawing.Size(168, 145);
            this.user_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_avatar.TabIndex = 6;
            this.user_avatar.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(14, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 2);
            this.panel5.TabIndex = 5;
            // 
            // connect_btn
            // 
            this.connect_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.connect_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connect_btn.FlatAppearance.BorderSize = 0;
            this.connect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect_btn.ForeColor = System.Drawing.Color.White;
            this.connect_btn.Location = new System.Drawing.Point(14, 102);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(287, 22);
            this.connect_btn.TabIndex = 4;
            this.connect_btn.TabStop = false;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = false;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(14, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 2);
            this.panel4.TabIndex = 3;
            // 
            // discord_prefix
            // 
            this.discord_prefix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.discord_prefix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discord_prefix.ForeColor = System.Drawing.Color.White;
            this.discord_prefix.Location = new System.Drawing.Point(14, 68);
            this.discord_prefix.Name = "discord_prefix";
            this.discord_prefix.Size = new System.Drawing.Size(287, 13);
            this.discord_prefix.TabIndex = 2;
            this.discord_prefix.TabStop = false;
            this.discord_prefix.Text = "Prefix";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(14, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 2);
            this.panel3.TabIndex = 1;
            // 
            // discord_token
            // 
            this.discord_token.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.discord_token.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discord_token.ForeColor = System.Drawing.Color.White;
            this.discord_token.Location = new System.Drawing.Point(14, 35);
            this.discord_token.Name = "discord_token";
            this.discord_token.Size = new System.Drawing.Size(287, 13);
            this.discord_token.TabIndex = 0;
            this.discord_token.TabStop = false;
            this.discord_token.Text = "Token";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.clear_btn);
            this.panel2.Controls.Add(this.logs);
            this.panel2.Location = new System.Drawing.Point(372, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 362);
            this.panel2.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(10, 350);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(287, 2);
            this.panel6.TabIndex = 7;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(10, 325);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(287, 22);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.TabStop = false;
            this.clear_btn.Text = "Clear Logs";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.logs.ForeColor = System.Drawing.Color.White;
            this.logs.FormattingEnabled = true;
            this.logs.Location = new System.Drawing.Point(6, 4);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(301, 314);
            this.logs.TabIndex = 0;
            this.logs.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Config";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(376, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Logs";
            // 
            // ConnectToAccount
            // 
            this.ConnectToAccount.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConnectToAccount_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Selfbot";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogoMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_avatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip LogoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox c_Token;
        private System.Windows.Forms.ToolStripTextBox c_Prefix;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem c_Connect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox discord_token;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox discord_prefix;
        private System.Windows.Forms.Label user_status;
        private System.Windows.Forms.Label user_date;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox user_avatar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.ListBox logs;
        private System.ComponentModel.BackgroundWorker ConnectToAccount;
    }
}

