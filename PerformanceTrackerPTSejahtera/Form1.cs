using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PerformanceTrackerPTSejahtera
{
    public partial class Form1 : Form //Penerapan Inheritance
    {
        public Form1()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            LoadData();
        }

        //Penerapan Encapsulation
        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Username=postgres;Password=1304;Database=responsi";
        private DataTable dt;
        private static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public interface IPerformanceTInterface
        {
            void LoadData();
            void InsertData();
            void UpdateData();
            void DeleteData();
        }

        public void LoadData()
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select nama_dev, status_kontrak, nama_proyek, jumlah_bug, fitur_selesai from developer";

                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dgvData.DataSource = dt;
                dt.Load(rd);

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


    }
}
