using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKONtrol_Click(object sender, EventArgs e)
        {
            if (cbLambaAcık .Checked== true)
            {
                lbKontrol.Items.Add("lamba açık");
            }
            else
            {
                lbKontrol.Items.Add("lamba kapalı");
            } if (cbkombiAcık .Checked== true)
            {
                lbKontrol.Items.Add("kombi açık");
            }
            else
            {
                lbKontrol.Items.Add("kombi kapalı");
            }
        }
    }
}
