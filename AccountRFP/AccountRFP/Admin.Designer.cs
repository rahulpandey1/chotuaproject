
namespace AccountRFP
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vertical = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b2bproducts = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dealDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.vertical,
            this.customer,
            this.b2bproducts,
            this.dealDescr,
            this.engType,
            this.dealSize,
            this.cp,
            this.currentStatus,
            this.comments,
            this.pocName,
            this.month});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1432, 624);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // no
            // 
            this.no.HeaderText = "SNo";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.no.Width = 125;
            // 
            // vertical
            // 
            this.vertical.HeaderText = "Vertical";
            this.vertical.MinimumWidth = 6;
            this.vertical.Name = "vertical";
            this.vertical.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vertical.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vertical.Width = 125;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.MinimumWidth = 6;
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            this.customer.Width = 125;
            // 
            // b2bproducts
            // 
            this.b2bproducts.HeaderText = "B2B  Prodcut Involved";
            this.b2bproducts.MinimumWidth = 6;
            this.b2bproducts.Name = "b2bproducts";
            this.b2bproducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.b2bproducts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.b2bproducts.Width = 125;
            // 
            // dealDescr
            // 
            this.dealDescr.HeaderText = "Deal Description";
            this.dealDescr.MinimumWidth = 6;
            this.dealDescr.Name = "dealDescr";
            this.dealDescr.Width = 125;
            // 
            // engType
            // 
            this.engType.HeaderText = "Engagement Type";
            this.engType.MinimumWidth = 6;
            this.engType.Name = "engType";
            this.engType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.engType.Width = 125;
            // 
            // dealSize
            // 
            this.dealSize.HeaderText = "Deal Size";
            this.dealSize.MinimumWidth = 6;
            this.dealSize.Name = "dealSize";
            this.dealSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dealSize.Width = 125;
            // 
            // cp
            // 
            this.cp.HeaderText = "CP";
            this.cp.MinimumWidth = 6;
            this.cp.Name = "cp";
            this.cp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cp.Width = 125;
            // 
            // currentStatus
            // 
            this.currentStatus.HeaderText = "Current Status";
            this.currentStatus.MinimumWidth = 6;
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.currentStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.currentStatus.Width = 125;
            // 
            // comments
            // 
            this.comments.HeaderText = "Comments";
            this.comments.MinimumWidth = 6;
            this.comments.Name = "comments";
            this.comments.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.comments.Width = 125;
            // 
            // pocName
            // 
            this.pocName.HeaderText = "Poc Name";
            this.pocName.MinimumWidth = 6;
            this.pocName.Name = "pocName";
            this.pocName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pocName.Width = 125;
            // 
            // month
            // 
            this.month.HeaderText = "Month";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            this.month.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.month.Width = 125;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 624);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewComboBoxColumn vertical;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewComboBoxColumn b2bproducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn engType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp;
        private System.Windows.Forms.DataGridViewComboBoxColumn currentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
    }
}