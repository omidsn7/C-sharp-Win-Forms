
namespace HTML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_html = new System.Windows.Forms.TextBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(2, 7);
            this.txt_name.MaxLength = 70;
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(169, 30);
            this.txt_name.TabIndex = 0;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(2, 43);
            this.txt_age.MaxLength = 70;
            this.txt_age.Multiline = true;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(169, 30);
            this.txt_age.TabIndex = 2;
            // 
            // txt_html
            // 
            this.txt_html.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_html.Location = new System.Drawing.Point(177, 0);
            this.txt_html.Multiline = true;
            this.txt_html.Name = "txt_html";
            this.txt_html.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_html.Size = new System.Drawing.Size(220, 201);
            this.txt_html.TabIndex = 3;
            // 
            // btn_done
            // 
            this.btn_done.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Location = new System.Drawing.Point(2, 79);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(169, 34);
            this.btn_done.TabIndex = 4;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(2, 119);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(169, 32);
            this.btn_show.TabIndex = 4;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(2, 157);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(169, 32);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 201);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.txt_html);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_html;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_save;
    }
}

