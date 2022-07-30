

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using FROM_ORM;

namespace FORM_ORM_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            employee o = new employee();
            //  o.Id = 1;
            o.Name = textBox1.Text;
            o.Age = Convert.ToInt32(textBox2.Text);
            var my = new employeecontext();
            my.Employee1.Add(o);                // table name add function
            my.SaveChanges();
            MessageBox.Show("Record inserted");
        }
    }
}

