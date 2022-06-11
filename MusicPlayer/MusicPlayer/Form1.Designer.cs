
namespace MusicPlayer
{
    partial class Frm_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Player));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_musicplayer = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnl_listandplayer = new System.Windows.Forms.Panel();
            this.listbox_musics = new DevComponents.DotNetBar.ListBoxAdv();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnl_top.SuspendLayout();
            this.pnl_listandplayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.Transparent;
            this.pnl_top.Controls.Add(this.lbl_musicplayer);
            this.pnl_top.Controls.Add(this.guna2ControlBox1);
            this.pnl_top.Controls.Add(this.btn_exit);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(396, 25);
            this.pnl_top.TabIndex = 0;
            // 
            // lbl_musicplayer
            // 
            this.lbl_musicplayer.AutoSize = true;
            this.lbl_musicplayer.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_musicplayer.ForeColor = System.Drawing.Color.Snow;
            this.lbl_musicplayer.Image = global::MusicPlayer.Properties.Resources.play_button;
            this.lbl_musicplayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_musicplayer.Location = new System.Drawing.Point(3, 3);
            this.lbl_musicplayer.Name = "lbl_musicplayer";
            this.lbl_musicplayer.Size = new System.Drawing.Size(100, 19);
            this.lbl_musicplayer.TabIndex = 2;
            this.lbl_musicplayer.Text = "My Music Player";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Snow;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Snow;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Snow;
            this.guna2ControlBox1.Location = new System.Drawing.Point(340, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(26, 22);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_exit.HoverState.BorderColor = System.Drawing.Color.Snow;
            this.btn_exit.HoverState.FillColor = System.Drawing.Color.Snow;
            this.btn_exit.HoverState.IconColor = System.Drawing.Color.Black;
            this.btn_exit.IconColor = System.Drawing.Color.Snow;
            this.btn_exit.Location = new System.Drawing.Point(369, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(26, 22);
            this.btn_exit.TabIndex = 1;
            // 
            // pnl_listandplayer
            // 
            this.pnl_listandplayer.BackColor = System.Drawing.Color.Transparent;
            this.pnl_listandplayer.Controls.Add(this.mediaplayer);
            this.pnl_listandplayer.Controls.Add(this.listbox_musics);
            this.pnl_listandplayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_listandplayer.Location = new System.Drawing.Point(0, 25);
            this.pnl_listandplayer.Name = "pnl_listandplayer";
            this.pnl_listandplayer.Size = new System.Drawing.Size(396, 218);
            this.pnl_listandplayer.TabIndex = 1;
            // 
            // listbox_musics
            // 
            this.listbox_musics.AutoScroll = true;
            this.listbox_musics.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.listbox_musics.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.listbox_musics.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.listbox_musics.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.listbox_musics.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.listbox_musics.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.listbox_musics.BackgroundStyle.Class = "ListBoxAdv";
            this.listbox_musics.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.listbox_musics.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.listbox_musics.BackgroundStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBarBackground2;
            this.listbox_musics.ContainerControlProcessDialogKey = true;
            this.listbox_musics.Dock = System.Windows.Forms.DockStyle.Right;
            this.listbox_musics.DragDropSupport = true;
            this.listbox_musics.EnableDragDrop = true;
            this.listbox_musics.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_musics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listbox_musics.ItemSpacing = 0;
            this.listbox_musics.Location = new System.Drawing.Point(226, 0);
            this.listbox_musics.Name = "listbox_musics";
            this.listbox_musics.Size = new System.Drawing.Size(170, 218);
            this.listbox_musics.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.listbox_musics.TabIndex = 0;
            this.listbox_musics.Text = "Musics";
            this.listbox_musics.UseNativeDragDrop = true;
            this.listbox_musics.ItemClick += new System.EventHandler(this.listbox_musics_ItemClick);
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalItem = false;
            this.buttonItem1.Name = "buttonItem1";
            // 
            // btn_add
            // 
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderColor = System.Drawing.Color.Snow;
            this.btn_add.BorderRadius = 15;
            this.btn_add.BorderThickness = 1;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.Transparent;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.Snow;
            this.btn_add.HoverState.BorderColor = System.Drawing.Color.Snow;
            this.btn_add.HoverState.CustomBorderColor = System.Drawing.Color.Snow;
            this.btn_add.HoverState.FillColor = System.Drawing.Color.Snow;
            this.btn_add.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Image = global::MusicPlayer.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(226, 248);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(169, 33);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // mediaplayer
            // 
            this.mediaplayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(0, 0);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(220, 218);
            this.mediaplayer.TabIndex = 1;
            // 
            // Frm_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::MusicPlayer.Properties.Resources.photo_1534796636912_3b95b3ab5986;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 287);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pnl_listandplayer);
            this.Controls.Add(this.pnl_top);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_listandplayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private Guna.UI2.WinForms.Guna2ControlBox btn_exit;
        private System.Windows.Forms.Label lbl_musicplayer;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel pnl_listandplayer;
        private DevComponents.DotNetBar.ListBoxAdv listbox_musics;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private AxWMPLib.AxWindowsMediaPlayer mediaplayer;
    }
}

