using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML
{
    public partial class Form1 : Form
    {
        PDatabase db = new PDatabase();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            var person = new Person { Name = txt_name.Text, Age = byte.Parse(txt_age.Text) };
            try
            {
                db.People.Add(person);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return;
            }
            txt_name.Text = "";
            txt_age.Text = "";
            txt_html.Text = "";
            MessageBox.Show("Person Inserted");
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            HTMLMaker hTMLMaker = new HTMLMaker();
            txt_html.Text = hTMLMaker.MakeHtml();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            HTMLMaker hTMLMaker = new HTMLMaker();
            string content = hTMLMaker.MakeHtml();
            System.IO.File.WriteAllText(@"C:\Users\O_sorayaee\Desktop\yoursite.htm", content);
            MessageBox.Show("Your File Is Saved");
        }
    }
}
