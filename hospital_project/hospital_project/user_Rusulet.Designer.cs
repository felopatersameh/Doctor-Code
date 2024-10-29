namespace hospital_project
{
    partial class user_Rusulet
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.new__personTableAdapter = new hospital_project.Data_paitnetTableAdapters.New__personTableAdapter();
            this.tableAdapterManager = new hospital_project.Data_paitnetTableAdapters.TableAdapterManager();
            this.analysticTableAdapter = new hospital_project.Data_paitnetTableAdapters.analysticTableAdapter();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(602, 151);
            this.textBox4.Margin = new System.Windows.Forms.Padding(7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(374, 41);
            this.textBox4.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.label2.Location = new System.Drawing.Point(410, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 52;
            this.label2.Text = "National ID";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.BackColor = System.Drawing.Color.Transparent;
            this.no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.no.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.no.ForeColor = System.Drawing.Color.Red;
            this.no.Location = new System.Drawing.Point(602, 217);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(2, 38);
            this.no.TabIndex = 63;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.BackColor = System.Drawing.Color.Transparent;
            this.yes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yes.ForeColor = System.Drawing.Color.Lime;
            this.yes.Location = new System.Drawing.Point(602, 217);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(2, 38);
            this.yes.TabIndex = 63;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // new__personTableAdapter
            // 
            this.new__personTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.analysticTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.New__personTableAdapter = this.new__personTableAdapter;
            this.tableAdapterManager.UpdateOrder = hospital_project.Data_paitnetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // analysticTableAdapter
            // 
            this.analysticTableAdapter.ClearBeforeFill = true;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientButton1.BorderRadius = 28;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientButton1.Location = new System.Drawing.Point(377, 434);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 58);
            this.guna2GradientButton1.TabIndex = 66;
            this.guna2GradientButton1.Text = "Search";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.AutoRoundedCorners = true;
            this.guna2GradientButton2.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientButton2.BorderRadius = 28;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientButton2.Location = new System.Drawing.Point(949, 434);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(180, 58);
            this.guna2GradientButton2.TabIndex = 67;
            this.guna2GradientButton2.Text = "Print";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.AutoRoundedCorners = true;
            this.guna2GradientButton3.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientButton3.BorderRadius = 28;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientButton3.Location = new System.Drawing.Point(648, 434);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(180, 58);
            this.guna2GradientButton3.TabIndex = 68;
            this.guna2GradientButton3.Text = "Delete";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // user_Rusulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.no);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "user_Rusulet";
            this.Size = new System.Drawing.Size(1383, 669);
            this.Load += new System.EventHandler(this.user_Rusulet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label yes;
        private Data_paitnetTableAdapters.New__personTableAdapter new__personTableAdapter;
        private Data_paitnetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Data_paitnetTableAdapters.analysticTableAdapter analysticTableAdapter;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
    }
}