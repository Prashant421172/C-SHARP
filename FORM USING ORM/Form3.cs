

using FROM_ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_ORM_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                var context = new employeecontext();
                int Id = Convert.ToInt32(textBox1.Text);
                employee s = context.Employee1.Find(Id);
                if (s == null)
                    Console.WriteLine("not there");
                else
                {

                    label2.Text = s.Name + " " + s.Age;


                }
            }
        }
    }
}




