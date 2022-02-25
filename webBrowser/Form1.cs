using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace webBrowser
{
    public partial class  Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnOpenWeb (object sender, EventArgs e)
        {
            Form2 url = new Form2();
            url.ShowDialog();
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            dataGridView1.Visible = true;
            if (e.Node.Text.Equals("09-122"))
            {
                dataGridView1.Rows.Clear();
                {
                    foreach (string line in File.ReadLines("Students122.txt", Encoding.Default))
                    {
                        string[] array = line.Split();
                        dataGridView1.Rows.Add(array);
                    }
                }
            }
            if (e.Node.Text.Equals("09-121"))
            {
                dataGridView1.Rows.Clear();
                foreach (string line in File.ReadLines("Students121.txt", Encoding.Default))
                {
                    string[] array = line.Split();
                    dataGridView1.Rows.Add(array);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            this.dataGridView1.Rows.Add(Stud.Name,Stud.Age,Stud.Describe);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

    }
}
