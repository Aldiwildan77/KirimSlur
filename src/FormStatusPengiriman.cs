using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src
{
    public partial class FormStatusPengiriman : Form
    {
        private String noresi;
        private String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kirimslur;SslMode=none";
        public FormStatusPengiriman(String resi)
        {
            InitializeComponent();
            this.noresi = resi;
            tbCekResi.Text = resi;
        }

        private void dropdownTambahStatus()
        {
            cbTambahStatus.Text = "Pilih status...";
            String[] listTambahStatus = { "Kantor menerima barang", "Dalam Proses pengiriman", "Diterima di pusat", "Diterima di cabang I", "Diterima di cabang II", "Diterima di cabang III" };
            cbTambahStatus.Items.AddRange(listTambahStatus);
        }

        private void FormStatusPengiriman_Load(object sender, EventArgs e)
        {
            dropdownTambahStatus();
        }

        private void BtnTambahStatus_Click(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                int idStatus = getIdStatus(cbTambahStatus.Text);
                int idInvoice = getIdInvoice();

                databaseConnection.Open();

                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                commandDatabase.CommandText = "INSERT INTO invoice_status (`id_invoice`,`id_status`, `tanggal`) VALUES('" + idInvoice + "','" + idStatus + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                commandDatabase.ExecuteNonQuery();
                getStatusPengiriman();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private int getIdInvoice()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            int idInvoice = 0;

            try
            {
                databaseConnection.Open();

                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                commandDatabase.Parameters.AddWithValue("@no_resi", noresi);
                commandDatabase.CommandText = "SELECT id FROM invoice WHERE no_resi = @no_resi";
                MySqlDataReader read = commandDatabase.ExecuteReader();
                while (read.Read())
                {
                    idInvoice = Int32.Parse(read["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
            return idInvoice;
        }

        private int getIdStatus(String status)
        {
            int idStatus = 0;
            if (status.Equals("Kantor menerima barang"))
            {
                idStatus = 1;
            }
            else if (status.Equals("Dalam Proses pengiriman"))
            {
                idStatus = 2;
            }
            else if (status.Equals("Diterima di pusat"))
            {
                idStatus = 3;
            }
            else if (status.Equals("Diterima di cabang I"))
            {
                idStatus = 4;
            }
            else if (status.Equals("Diterima di cabang II"))
            {
                idStatus = 5;
            }
            else if (status.Equals("Diterima di cabang III"))
            {
                idStatus = 6;
            }
            return idStatus;
        }

        private void getStatusPengiriman()
        {
            lvStatusPengiriman.Items.Clear();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();

                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                commandDatabase.Parameters.AddWithValue("@no_resi", noresi);
                commandDatabase.CommandText = "SELECT * FROM invoice_status ivs join status s on ivs.id_status = s.id WHERE ivs.id_invoice IN (SELECT id FROM invoice WHERE no_resi = @no_resi)";
                MySqlDataReader read = commandDatabase.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem listViewItem = new ListViewItem(read["id_status"].ToString());
                    listViewItem.SubItems.Add(read["tanggal"].ToString());
                    listViewItem.SubItems.Add(read["nama"].ToString());
                    lvStatusPengiriman.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }
    }
}
