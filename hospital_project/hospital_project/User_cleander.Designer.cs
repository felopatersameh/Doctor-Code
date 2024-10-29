namespace hospital_project
{
    partial class User_cleander
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.data_paitnet = new hospital_project.Data_paitnet();
            this.new__personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.new__personTableAdapter = new hospital_project.Data_paitnetTableAdapters.New__personTableAdapter();
            this.tableAdapterManager = new hospital_project.Data_paitnetTableAdapters.TableAdapterManager();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.newpersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatsappDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressurepatinetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodpressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGlogozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_paitnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new__personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newpersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(581, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 53);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 7, 0, 0, 0, 0);
            // 
            // data_paitnet
            // 
            this.data_paitnet.DataSetName = "Data_paitnet";
            this.data_paitnet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // new__personBindingSource
            // 
            this.new__personBindingSource.DataMember = "New__person";
            this.new__personBindingSource.DataSource = this.data_paitnet;
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
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.phone1DataGridViewTextBoxColumn,
            this.whatsappDataGridViewTextBoxColumn,
            this.phone2DataGridViewTextBoxColumn,
            this.medicenDataGridViewTextBoxColumn,
            this.healthDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.deNameDataGridViewTextBoxColumn,
            this.pressurepatinetDataGridViewTextBoxColumn,
            this.bloodpressureDataGridViewTextBoxColumn,
            this.bloodGlogozDataGridViewTextBoxColumn,
            this.bmiDataGridViewTextBoxColumn,
            this.sportsDataGridViewTextBoxColumn,
            this.diseasesDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.newpersonBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.Gray;
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 359);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1684, 582);
            this.guna2DataGridView1.TabIndex = 2;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 18;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.AutoRoundedCorners = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientButton2.BorderRadius = 28;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.guna2GradientButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientButton2.Location = new System.Drawing.Point(924, 58);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(180, 58);
            this.guna2GradientButton2.TabIndex = 13;
            this.guna2GradientButton2.Text = "Search";
            this.guna2GradientButton2.UseTransparentBackground = true;
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // newpersonBindingSource
            // 
            this.newpersonBindingSource.DataMember = "New__person";
            this.newpersonBindingSource.DataSource = this.data_paitnet;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phone1DataGridViewTextBoxColumn
            // 
            this.phone1DataGridViewTextBoxColumn.DataPropertyName = "phone1";
            this.phone1DataGridViewTextBoxColumn.HeaderText = "phone1";
            this.phone1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phone1DataGridViewTextBoxColumn.Name = "phone1DataGridViewTextBoxColumn";
            this.phone1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // whatsappDataGridViewTextBoxColumn
            // 
            this.whatsappDataGridViewTextBoxColumn.DataPropertyName = "whatsapp";
            this.whatsappDataGridViewTextBoxColumn.HeaderText = "whatsapp";
            this.whatsappDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.whatsappDataGridViewTextBoxColumn.Name = "whatsappDataGridViewTextBoxColumn";
            this.whatsappDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phone2DataGridViewTextBoxColumn
            // 
            this.phone2DataGridViewTextBoxColumn.DataPropertyName = "phone2";
            this.phone2DataGridViewTextBoxColumn.HeaderText = "phone2";
            this.phone2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phone2DataGridViewTextBoxColumn.Name = "phone2DataGridViewTextBoxColumn";
            this.phone2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicenDataGridViewTextBoxColumn
            // 
            this.medicenDataGridViewTextBoxColumn.DataPropertyName = "Medicen";
            this.medicenDataGridViewTextBoxColumn.HeaderText = "Medicen";
            this.medicenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicenDataGridViewTextBoxColumn.Name = "medicenDataGridViewTextBoxColumn";
            this.medicenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // healthDataGridViewTextBoxColumn
            // 
            this.healthDataGridViewTextBoxColumn.DataPropertyName = "Health";
            this.healthDataGridViewTextBoxColumn.HeaderText = "Health";
            this.healthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.healthDataGridViewTextBoxColumn.Name = "healthDataGridViewTextBoxColumn";
            this.healthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "doctor";
            this.doctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deNameDataGridViewTextBoxColumn
            // 
            this.deNameDataGridViewTextBoxColumn.DataPropertyName = "deName";
            this.deNameDataGridViewTextBoxColumn.HeaderText = "deName";
            this.deNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deNameDataGridViewTextBoxColumn.Name = "deNameDataGridViewTextBoxColumn";
            this.deNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pressurepatinetDataGridViewTextBoxColumn
            // 
            this.pressurepatinetDataGridViewTextBoxColumn.DataPropertyName = "pressurepatinet";
            this.pressurepatinetDataGridViewTextBoxColumn.HeaderText = "pressurepatinet";
            this.pressurepatinetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pressurepatinetDataGridViewTextBoxColumn.Name = "pressurepatinetDataGridViewTextBoxColumn";
            this.pressurepatinetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bloodpressureDataGridViewTextBoxColumn
            // 
            this.bloodpressureDataGridViewTextBoxColumn.DataPropertyName = "Bloodpressure";
            this.bloodpressureDataGridViewTextBoxColumn.HeaderText = "Bloodpressure";
            this.bloodpressureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodpressureDataGridViewTextBoxColumn.Name = "bloodpressureDataGridViewTextBoxColumn";
            this.bloodpressureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bloodGlogozDataGridViewTextBoxColumn
            // 
            this.bloodGlogozDataGridViewTextBoxColumn.DataPropertyName = "BloodGlogoz";
            this.bloodGlogozDataGridViewTextBoxColumn.HeaderText = "BloodGlogoz";
            this.bloodGlogozDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodGlogozDataGridViewTextBoxColumn.Name = "bloodGlogozDataGridViewTextBoxColumn";
            this.bloodGlogozDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bmiDataGridViewTextBoxColumn
            // 
            this.bmiDataGridViewTextBoxColumn.DataPropertyName = "bmi";
            this.bmiDataGridViewTextBoxColumn.HeaderText = "bmi";
            this.bmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bmiDataGridViewTextBoxColumn.Name = "bmiDataGridViewTextBoxColumn";
            this.bmiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sportsDataGridViewTextBoxColumn
            // 
            this.sportsDataGridViewTextBoxColumn.DataPropertyName = "sports";
            this.sportsDataGridViewTextBoxColumn.HeaderText = "sports";
            this.sportsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sportsDataGridViewTextBoxColumn.Name = "sportsDataGridViewTextBoxColumn";
            this.sportsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diseasesDataGridViewTextBoxColumn
            // 
            this.diseasesDataGridViewTextBoxColumn.DataPropertyName = "Diseases";
            this.diseasesDataGridViewTextBoxColumn.HeaderText = "Diseases";
            this.diseasesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diseasesDataGridViewTextBoxColumn.Name = "diseasesDataGridViewTextBoxColumn";
            this.diseasesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // User_cleander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "User_cleander";
            this.Size = new System.Drawing.Size(1684, 941);
            this.Load += new System.EventHandler(this.User_cleander_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_paitnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new__personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newpersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Data_paitnetTableAdapters.New__personTableAdapter new__personTableAdapter;
        private Data_paitnet data_paitnet;
        private System.Windows.Forms.BindingSource new__personBindingSource;
        private Data_paitnetTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatsappDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressurepatinetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodpressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGlogozDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource newpersonBindingSource;
    }
}
