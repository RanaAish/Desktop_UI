using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing;

namespace Desktop_UI
{
    public partial class noconnect : UserControl
    {
        public noconnect()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            transfer_data.Form2 dataset = new transfer_data.Form2();
            dataset.Show();
            
        }

        private void noconnect_Load(object sender, EventArgs e)
        {
            
        }
    }
}
