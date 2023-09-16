using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayStationSecendG
{
    public partial class Cafe : Form
    {
        public Cafe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.Rows.Add(product_name.Text, product_name.Text, product_name.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void product_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
