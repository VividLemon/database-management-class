
namespace Final
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoginGo = new System.Windows.Forms.Button();
            this.btnStoreGo = new System.Windows.Forms.Button();
            this.btnForumGo = new System.Windows.Forms.Button();
            this.btnAdminGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 93);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(567, 112);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Access Our City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "How it works:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 266);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(567, 172);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Visit our store";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Visit our forum";
            // 
            // btnLoginGo
            // 
            this.btnLoginGo.Location = new System.Drawing.Point(713, 12);
            this.btnLoginGo.Name = "btnLoginGo";
            this.btnLoginGo.Size = new System.Drawing.Size(75, 23);
            this.btnLoginGo.TabIndex = 3;
            this.btnLoginGo.Text = "Login";
            this.btnLoginGo.UseVisualStyleBackColor = true;
            this.btnLoginGo.Click += new System.EventHandler(this.btnLoginGo_Click);
            // 
            // btnStoreGo
            // 
            this.btnStoreGo.Location = new System.Drawing.Point(609, 290);
            this.btnStoreGo.Name = "btnStoreGo";
            this.btnStoreGo.Size = new System.Drawing.Size(75, 23);
            this.btnStoreGo.TabIndex = 1;
            this.btnStoreGo.Text = "Store";
            this.btnStoreGo.UseVisualStyleBackColor = true;
            this.btnStoreGo.Click += new System.EventHandler(this.btnStoreGo_Click);
            // 
            // btnForumGo
            // 
            this.btnForumGo.Location = new System.Drawing.Point(609, 356);
            this.btnForumGo.Name = "btnForumGo";
            this.btnForumGo.Size = new System.Drawing.Size(75, 23);
            this.btnForumGo.TabIndex = 2;
            this.btnForumGo.Text = "Forum";
            this.btnForumGo.UseVisualStyleBackColor = true;
            this.btnForumGo.Click += new System.EventHandler(this.btnForumGo_Click);
            // 
            // btnAdminGo
            // 
            this.btnAdminGo.Location = new System.Drawing.Point(713, 42);
            this.btnAdminGo.Name = "btnAdminGo";
            this.btnAdminGo.Size = new System.Drawing.Size(75, 23);
            this.btnAdminGo.TabIndex = 12;
            this.btnAdminGo.TabStop = false;
            this.btnAdminGo.Text = "Admin";
            this.btnAdminGo.UseVisualStyleBackColor = true;
            this.btnAdminGo.Visible = false;
            this.btnAdminGo.Click += new System.EventHandler(this.btnAdminGo_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminGo);
            this.Controls.Add(this.btnForumGo);
            this.Controls.Add(this.btnStoreGo);
            this.Controls.Add(this.btnLoginGo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Landing";
            this.Text = "Access Our City";
            this.Load += new System.EventHandler(this.Landing_Load);
            this.VisibleChanged += new System.EventHandler(this.Landing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoginGo;
        private System.Windows.Forms.Button btnStoreGo;
        private System.Windows.Forms.Button btnForumGo;
        private System.Windows.Forms.Button btnAdminGo;
    }
}

