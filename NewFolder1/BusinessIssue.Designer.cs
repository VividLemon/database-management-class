
namespace Final.NewFolder1
{
    partial class BusinessIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessIssue));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.finalDataSetbis = new Final.FinalDataSetbis();
            this.businessIssuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessIssuesTableAdapter = new Final.FinalDataSetbisTableAdapters.BusinessIssuesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessInformationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSetbis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessIssuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(713, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSaveInfo,
            this.idDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.issueDataGridViewTextBoxColumn,
            this.businessInformationIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.businessIssuesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 332);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.HeaderText = "Save";
            this.btnSaveInfo.Name = "btnSaveInfo";
            // 
            // finalDataSetbis
            // 
            this.finalDataSetbis.DataSetName = "FinalDataSetbis";
            this.finalDataSetbis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessIssuesBindingSource
            // 
            this.businessIssuesBindingSource.DataMember = "BusinessIssues";
            this.businessIssuesBindingSource.DataSource = this.finalDataSetbis;
            // 
            // businessIssuesTableAdapter
            // 
            this.businessIssuesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            // 
            // issueDataGridViewTextBoxColumn
            // 
            this.issueDataGridViewTextBoxColumn.DataPropertyName = "Issue";
            this.issueDataGridViewTextBoxColumn.HeaderText = "Issue";
            this.issueDataGridViewTextBoxColumn.Name = "issueDataGridViewTextBoxColumn";
            // 
            // businessInformationIdDataGridViewTextBoxColumn
            // 
            this.businessInformationIdDataGridViewTextBoxColumn.DataPropertyName = "BusinessInformationId";
            this.businessInformationIdDataGridViewTextBoxColumn.HeaderText = "BusinessInformationId";
            this.businessInformationIdDataGridViewTextBoxColumn.Name = "businessInformationIdDataGridViewTextBoxColumn";
            // 
            // BusinessIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BusinessIssue";
            this.Text = "BusinessIssue";
            this.Load += new System.EventHandler(this.BusinessIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSetbis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessIssuesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSaveInfo;
        private FinalDataSetbis finalDataSetbis;
        private System.Windows.Forms.BindingSource businessIssuesBindingSource;
        private FinalDataSetbisTableAdapters.BusinessIssuesTableAdapter businessIssuesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessInformationIdDataGridViewTextBoxColumn;
    }
}