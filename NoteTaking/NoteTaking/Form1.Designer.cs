
namespace NoteTaking
{
    partial class NOTE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.dgv_notes = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Messages :";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(112, 21);
            this.txt_title.MaxLength = 50;
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(200, 30);
            this.txt_title.TabIndex = 0;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(112, 61);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(200, 139);
            this.txt_message.TabIndex = 1;
            // 
            // dgv_notes
            // 
            this.dgv_notes.AllowUserToAddRows = false;
            this.dgv_notes.AllowUserToDeleteRows = false;
            this.dgv_notes.AllowUserToResizeColumns = false;
            this.dgv_notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notes.Location = new System.Drawing.Point(377, 21);
            this.dgv_notes.Name = "dgv_notes";
            this.dgv_notes.ReadOnly = true;
            this.dgv_notes.RowHeadersVisible = false;
            this.dgv_notes.Size = new System.Drawing.Size(190, 179);
            this.dgv_notes.TabIndex = 3;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_new.Location = new System.Drawing.Point(112, 220);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(100, 30);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_save.Location = new System.Drawing.Point(230, 220);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 30);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_read.Location = new System.Drawing.Point(348, 220);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(100, 30);
            this.btn_read.TabIndex = 4;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.Location = new System.Drawing.Point(466, 220);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 30);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // NOTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 273);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dgv_notes);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NOTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.DataGridView dgv_notes;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_delete;
    }
}

