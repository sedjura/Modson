using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace ModsonService.TestApp
{
    public partial class Form1 : Form
    {
        private readonly DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var connstring = $"Server={_serverTE.Text};Port={_portTE.Text};" +
                                 $"User Id={_userTE.Text};Password={_passwordTE.Text};Database={_dbNameTE.Text};";
                var conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = $"SELECT * FROM {_tableTE.Text}";
                var da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                _tableGC.DataSource = dt;
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }
    }
}
