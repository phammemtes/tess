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

namespace QuanLyThuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4JEBPEL\SQLEXPRESS;Initial Catalog=QLTHUOC;Integrated Security=True");
        public void hienthi()
        {
            con.Open();
            string sql = "select * from Thuoc";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            da.Fill(table);
            con.Close();
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqltk = "select * from Thuoc where MaThuoc = '"+textBox1.Text+"'";
            SqlCommand com = new SqlCommand(sqltk, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            da.Fill(table);
            con.Close();
            dataGridView1.DataSource = table;
            
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlthem = "Insert into Thuoc values ('"+txtma.Text+"','"+txtten.Text+"','"+datensx.Text+"','"+datahsd.Text+"','"+txtsoluong.Text+"')";
            SqlCommand com = new SqlCommand(sqlthem, con);
            com.ExecuteNonQuery();
            con.Close();
            hienthi();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlxoa = "delete from Thuoc where MaThuoc = '" + txtma.Text + "'";
            SqlCommand com = new SqlCommand(sqlxoa, con);
            com.ExecuteNonQuery();
            con.Close();
            hienthi();
        }
    }
        
}
