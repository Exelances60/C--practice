using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class customMessage : Form
    {
         public string message { get; set; }

        public customMessage()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblCustomMessage.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
