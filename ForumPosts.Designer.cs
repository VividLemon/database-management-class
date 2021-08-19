
namespace Final
{
    partial class ForumPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForumPosts));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblForumName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddTo = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.richTxtValue = new System.Windows.Forms.RichTextBox();
            this.finalDataSet = new Final.FinalDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Final.FinalDataSetTableAdapters.ProductsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.forumDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet19 = new Final.FinalDataSet19();
            this.forumDetailsTableAdapter = new Final.FinalDataSet19TableAdapters.ForumDetailsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forumDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Forum";
            // 
            // lblForumName
            // 
            this.lblForumName.AutoSize = true;
            this.lblForumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForumName.Location = new System.Drawing.Point(221, 62);
            this.lblForumName.Name = "lblForumName";
            this.lblForumName.Size = new System.Drawing.Size(0, 25);
            this.lblForumName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddTo
            // 
            this.btnAddTo.Location = new System.Drawing.Point(479, 380);
            this.btnAddTo.Name = "btnAddTo";
            this.btnAddTo.Size = new System.Drawing.Size(75, 23);
            this.btnAddTo.TabIndex = 9;
            this.btnAddTo.Text = "Add to!";
            this.btnAddTo.UseVisualStyleBackColor = true;
            this.btnAddTo.Click += new System.EventHandler(this.btnAddTo_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(13, 95);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(44, 13);
            this.lblContent.TabIndex = 10;
            this.lblContent.Text = "Content";
            this.lblContent.Visible = false;
            // 
            // richTxtValue
            // 
            this.richTxtValue.Location = new System.Drawing.Point(12, 111);
            this.richTxtValue.Name = "richTxtValue";
            this.richTxtValue.Size = new System.Drawing.Size(461, 327);
            this.richTxtValue.TabIndex = 11;
            this.richTxtValue.Text = "";
            this.richTxtValue.Visible = false;
            // 
            // finalDataSet
            // 
            this.finalDataSet.DataSetName = "FinalDataSet";
            this.finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.finalDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.forumIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.forumDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 327);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
            // 
            // forumDetailsBindingSource
            // 
            this.forumDetailsBindingSource.DataMember = "ForumDetails";
            this.forumDetailsBindingSource.DataSource = this.finalDataSet19;
            // 
            // finalDataSet19
            // 
            this.finalDataSet19.DataSetName = "FinalDataSet19";
            this.finalDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // forumDetailsTableAdapter
            // 
            this.forumDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forumIdDataGridViewTextBoxColumn
            // 
            this.forumIdDataGridViewTextBoxColumn.DataPropertyName = "ForumId";
            this.forumIdDataGridViewTextBoxColumn.HeaderText = "ForumId";
            this.forumIdDataGridViewTextBoxColumn.Name = "forumIdDataGridViewTextBoxColumn";
            this.forumIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // ForumPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTxtValue);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.btnAddTo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblForumName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ForumPosts";
            this.Text = "Forum Posts";
            this.Load += new System.EventHandler(this.ForumPosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forumDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblForumName;
        private System.Windows.Forms.Button button1;
        private FinalDataSet19 finalDataSet19;
        private System.Windows.Forms.BindingSource forumDetailsBindingSource;
        private FinalDataSet19TableAdapters.ForumDetailsTableAdapter forumDetailsTableAdapter;
        private System.Windows.Forms.Button btnAddTo;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.RichTextBox richTxtValue;
        private FinalDataSet finalDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private FinalDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    }
}