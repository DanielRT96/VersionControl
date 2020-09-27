using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            label1.Text = Resource1.FullName;
            button1.Text = Resource1.Add;
            button2.Text = Resource1.WriteIn;

            //listBox1 items
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox2.Text,
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());

                for (var i = 0; i < users.Count; i++)
                {

                    writer.WriteLine(users[i].ID + "-" + users[i].FullName.ToString());

                }
                writer.Close();

            }

        }


    }
}
