using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Frm_Player : Form
    {
        string[] paths, files;

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            
            if(ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    listbox_musics.Items.Add(files[i]);
                }
            }
        }

        private void listbox_musics_ItemClick(object sender, EventArgs e)
        {
            mediaplayer.URL = paths[listbox_musics.SelectedIndex];
        }

        public Frm_Player()
        {
            InitializeComponent();
        }
    }
}
