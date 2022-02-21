using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection();
            try
            {
                string s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtlink.Text ;
                cnn.ConnectionString = s;
                cnn.Open();
                MessageBox.Show("ket noi thanh cong");
                cnn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("loi ket noi" + ex.Message);
            }
        }
    }
}
