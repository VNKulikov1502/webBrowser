using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowser
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stud.Name = Name1.Text;
            Stud.Age = Age1.Text;
            Stud.Describe = Describe1.Text;
            this.Close();

        }
    }

}
