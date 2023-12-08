
namespace asm
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Z = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbLast = new System.Windows.Forms.TextBox();
            this.lbLastMonth = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txbThis = new System.Windows.Forms.TextBox();
            this.lbThisMonth = new System.Windows.Forms.Label();
            this.dtgWaterBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.txbType = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWaterBill)).BeginInit();
            this.SuspendLayout();
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Location = new System.Drawing.Point(151, 22);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(18, 13);
            this.Z.TabIndex = 0;
            this.Z.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(429, 22);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 20);
            this.txbID.TabIndex = 1;
            // 
            // txbLast
            // 
            this.txbLast.Location = new System.Drawing.Point(429, 100);
            this.txbLast.Name = "txbLast";
            this.txbLast.Size = new System.Drawing.Size(100, 20);
            this.txbLast.TabIndex = 3;
            // 
            // lbLastMonth
            // 
            this.lbLastMonth.AutoSize = true;
            this.lbLastMonth.Location = new System.Drawing.Point(151, 100);
            this.lbLastMonth.Name = "lbLastMonth";
            this.lbLastMonth.Size = new System.Drawing.Size(168, 13);
            this.lbLastMonth.TabIndex = 2;
            this.lbLastMonth.Text = "Last month’s water meter readings";
            this.lbLastMonth.Click += new System.EventHandler(this.lbLastMonth_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(429, 48);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(151, 48);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
            // 
            // txbThis
            // 
            this.txbThis.Location = new System.Drawing.Point(429, 126);
            this.txbThis.Name = "txbThis";
            this.txbThis.Size = new System.Drawing.Size(100, 20);
            this.txbThis.TabIndex = 7;
            // 
            // lbThisMonth
            // 
            this.lbThisMonth.AutoSize = true;
            this.lbThisMonth.Location = new System.Drawing.Point(151, 126);
            this.lbThisMonth.Name = "lbThisMonth";
            this.lbThisMonth.Size = new System.Drawing.Size(168, 13);
            this.lbThisMonth.TabIndex = 6;
            this.lbThisMonth.Text = "This month’s water meter readings";
            // 
            // dtgWaterBill
            // 
            this.dtgWaterBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgWaterBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgWaterBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgWaterBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgWaterBill.Location = new System.Drawing.Point(0, 244);
            this.dtgWaterBill.Name = "dtgWaterBill";
            this.dtgWaterBill.Size = new System.Drawing.Size(1018, 318);
            this.dtgWaterBill.TabIndex = 8;
            this.dtgWaterBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgWaterBill_CellClick);
            this.dtgWaterBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgWaterBill_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LastMonthWaterMeter";
            this.Column3.HeaderText = "Last month’s water meter";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThisMonthWaterMeter";
            this.Column4.HeaderText = "This month’s water meter";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "UserType";
            this.Column5.HeaderText = "Type of customer";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TotalBill";
            this.Column6.HeaderText = "Total water bill";
            this.Column6.Name = "Column6";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(154, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(454, 173);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(358, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(249, 173);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(154, 211);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(249, 214);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(280, 20);
            this.txbSearch.TabIndex = 14;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // txbType
            // 
            this.txbType.Location = new System.Drawing.Point(429, 74);
            this.txbType.Name = "txbType";
            this.txbType.Size = new System.Drawing.Size(100, 20);
            this.txbType.TabIndex = 16;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(151, 74);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(89, 13);
            this.lbType.TabIndex = 15;
            this.lbType.Text = "Type of customer";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 562);
            this.Controls.Add(this.txbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgWaterBill);
            this.Controls.Add(this.txbThis);
            this.Controls.Add(this.lbThisMonth);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txbLast);
            this.Controls.Add(this.lbLastMonth);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.Z);
            this.Name = "frmMain";
            this.Text = "Water Bill";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgWaterBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbLast;
        private System.Windows.Forms.Label lbLastMonth;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txbThis;
        private System.Windows.Forms.Label lbThisMonth;
        private System.Windows.Forms.DataGridView dtgWaterBill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.TextBox txbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

