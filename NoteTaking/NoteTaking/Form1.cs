using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class NOTE : Form
    {
        DataTable Table;
        public NOTE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Table = new DataTable();

            Table.Columns.Add("Title", typeof(String));
            Table.Columns.Add("Messages", typeof(String));

            dgv_notes.DataSource = Table;

            dgv_notes.Columns["Messages"].Visible = false;
            dgv_notes.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Clear()
        {
            txt_title.Clear();
            txt_message.Clear();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Table.Rows.Add(txt_title.Text, txt_message.Text);
            Clear();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            int index = dgv_notes.CurrentCell.RowIndex;

            if (index > -1)
            {
                txt_title.Text = Table.Rows[index].ItemArray[0].ToString();
                txt_message.Text = Table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = dgv_notes.CurrentCell.RowIndex;

            Table.Rows[index].Delete();
        }
    }
}
