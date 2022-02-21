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
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
{
    String connectionstring;

    SqlConnection  cnn = new SqlConnection();
try
{
if (rdwin.Checked == true)
{
connectionstring = "Server=" + txtserver.Text;
connectionstring += ";database=" + txtdatabase.Text;
connectionstring += ";integrated security=true";
cnn.ConnectionString = connectionstring;
}
else
{
connectionstring = "Server=" + txtserver.Text;
connectionstring += ";database=" + txtdatabase.Text;
connectionstring += ";uid=" + txtuser.Text;
connectionstring += ";pwd=" + txtpass.Text;
cnn.ConnectionString = connectionstring;
}
cnn.Open();
MessageBox.Show("ket noi thanh cong");
cnn.Close();
}
catch (Exception ex)
{
MessageBox.Show("loi ke noi" + ex.Message);
}
}

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection();
            try
            {


                string s = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\qlbh.mdb";
                cnn.ConnectionString = s;
                cnn.Open();
                MessageBox.Show("ket noi thanh cong");
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi ket noi" + ex.Message);
            }
        }


    }
}
