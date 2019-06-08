namespace WindowsFormsApp2
{
    partial class Form1
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
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.rbShow3 = new System.Windows.Forms.RadioButton();
            this.rbShow5 = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load/Process Employee File";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(225, 21);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(92, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process File";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(225, 21);
            this.textbox1.Name = "textbox";
            this.textbox1.Size = new System.Drawing.Size(92, 23);
            this.textbox1.TabIndex = 1;
            this.textbox1.Text = "Process File";
            //this.textbox1.Click += new System.Object.ToString(this.textbox1);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeColumns = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colAddress,
            this.colEmpType,
            this.colSupervisor,
            this.colCostCenter,
            this.colDevType,
            this.colTaxType});
            this.dgvEmployees.Location = new System.Drawing.Point(20, 90);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ShowEditingIcon = false;
            this.dgvEmployees.Size = new System.Drawing.Size(697, 214);
            this.dgvEmployees.TabIndex = 2;
            // 
            // rbShow3
            // 
            this.rbShow3.AutoSize = true;
            this.rbShow3.Checked = true;
            this.rbShow3.Location = new System.Drawing.Point(47, 54);
            this.rbShow3.Name = "rbShow3";
            this.rbShow3.Size = new System.Drawing.Size(121, 20);
            this.rbShow3.TabIndex = 3;
            this.rbShow3.TabStop = true;
            this.rbShow3.Text = "Show 3 Records";
            this.rbShow3.UseVisualStyleBackColor = true;
            // 
            // rbShow5
            // 
            this.rbShow5.AutoSize = true;
            this.rbShow5.Location = new System.Drawing.Point(174, 54);
            this.rbShow5.Name = "rbShow5";
            this.rbShow5.Size = new System.Drawing.Size(121, 20);
            this.rbShow5.TabIndex = 4;
            this.rbShow5.TabStop = true;
            this.rbShow5.Text = "Show 5 Records";
            this.rbShow5.UseVisualStyleBackColor = true;
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Location = new System.Drawing.Point(301, 54);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(128, 20);
            this.rbShowAll.TabIndex = 5;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show All Records";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(615, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Width = 250;
            // 
            // colEmpType
            // 
            this.colEmpType.DataPropertyName = "empType";
            this.colEmpType.HeaderText = "Employee Type";
            this.colEmpType.Name = "colEmpType";
            this.colEmpType.Width = 125;
            // 
            // colSupervisor
            // 
            this.colSupervisor.DataPropertyName = "supervisor";
            this.colSupervisor.HeaderText = "Supervisor";
            this.colSupervisor.Name = "colSupervisor";
            this.colSupervisor.Width = 125;
            // 
            // colCostCenter
            // 
            this.colCostCenter.DataPropertyName = "costcenter";
            this.colCostCenter.HeaderText = "Cost Center";
            this.colCostCenter.Name = "colCostCenter";
            // 
            // colDevType
            // 
            this.colDevType.DataPropertyName = "devtype";
            this.colDevType.HeaderText = "Dev Type";
            this.colDevType.Name = "colDevType";
            // 
            // colTaxType
            // 
            this.colTaxType.DataPropertyName = "taxtype";
            this.colTaxType.HeaderText = "Tax Type";
            this.colTaxType.Name = "colTaxType";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 318);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rbShowAll);
            this.Controls.Add(this.rbShow5);
            this.Controls.Add(this.rbShow3);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Employee Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.RadioButton rbShow3;
        private System.Windows.Forms.RadioButton rbShow5;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxType;
       // private 
    }
}

