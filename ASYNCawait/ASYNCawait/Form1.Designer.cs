
namespace ASYNCawait
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
            this.btn_normal = new System.Windows.Forms.Button();
            this.btn_async = new System.Windows.Forms.Button();
            this.rtxt_results = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_normal
            // 
            this.btn_normal.Location = new System.Drawing.Point(45, 12);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(295, 41);
            this.btn_normal.TabIndex = 0;
            this.btn_normal.Text = "Normal Execute";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // btn_async
            // 
            this.btn_async.Location = new System.Drawing.Point(45, 59);
            this.btn_async.Name = "btn_async";
            this.btn_async.Size = new System.Drawing.Size(295, 41);
            this.btn_async.TabIndex = 0;
            this.btn_async.Text = "Async Excecute";
            this.btn_async.UseVisualStyleBackColor = true;
            this.btn_async.Click += new System.EventHandler(this.btn_async_Click);
            // 
            // rtxt_results
            // 
            this.rtxt_results.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxt_results.Location = new System.Drawing.Point(0, 106);
            this.rtxt_results.Name = "rtxt_results";
            this.rtxt_results.Size = new System.Drawing.Size(389, 196);
            this.rtxt_results.TabIndex = 1;
            this.rtxt_results.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 302);
            this.Controls.Add(this.rtxt_results);
            this.Controls.Add(this.btn_async);
            this.Controls.Add(this.btn_normal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.Button btn_async;
        private System.Windows.Forms.RichTextBox rtxt_results;
    }
}

