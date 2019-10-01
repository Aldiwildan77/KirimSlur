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
    public partial class FormPelanggan : Form
    {
        private static string connectionString =
       "server=localhost;port=3306;username=root;password=;database=kirimslur;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public FormPelanggan()
        {
            InitializeComponent();
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO pelanggan (id,nama,alamat,kota,kodepos,no_telp) VALUES (null,@nama,@alamat,@kota,@kodepos,@no_telp)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@alamat", tbAlamat.Text);
                cmd.Parameters.AddWithValue("@kota", tbKota.Text);
                cmd.Parameters.AddWithValue("@kodepos", tbKodePos.Text);
                cmd.Parameters.AddWithValue("@no_telp", tbTelp.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refresh();
                databaseConnection.Close();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE pelanggan SET nama = @nama, alamat = @alamat, kota = @kota, kodepos = @kodepos, no_telp = @no_telp WHERE id = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", tbIdPelanggan.Text);
                cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@alamat", tbAlamat.Text);
                cmd.Parameters.AddWithValue("@kota", tbKota.Text);
                cmd.Parameters.AddWithValue("@kodepos", tbKodePos.Text);
                cmd.Parameters.AddWithValue("@no_telp", tbTelp.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refresh();
                databaseConnection.Close();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM pelanggan WHERE id = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", tbIdPelanggan.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refresh();
                databaseConnection.Close();
            }
        }
        private void refresh()
        {
            listPelanggan.Items.Clear();
            string query = "SELECT * FROM pelanggan";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            MySqlDataReader reader = cmd.ExecuteReader();
            // IMPORTANT :
            // If your query returns result, use the following processor :
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem listViewItem = new
                    ListViewItem(reader["id"].ToString());
                    listViewItem.SubItems.Add(reader["nama"].ToString());
                    listViewItem.SubItems.Add(reader["alamat"].ToString());
                    listViewItem.SubItems.Add(reader["kota"].ToString());
                    listViewItem.SubItems.Add(reader["kodepos"].ToString());
                    listViewItem.SubItems.Add(reader["no_telp"].ToString());
                    listPelanggan.Items.Add(listViewItem);
                }
            }
            reader.Close();
        }

        private void listPelanggan_MouseClick(object sender, MouseEventArgs e)
        {
            tbIdPelanggan.Text = listPelanggan.Items[listPelanggan.FocusedItem.Index].SubItems[0].Text;
            tbNama.Text = listPelanggan.Items[listPelanggan.FocusedItem.Index].SubItems[1].Text;
            tbAlamat.Text = listPelanggan.Items[listPelanggan.FocusedItem.Index].SubItems[2].Text;
            tbKota.Text = listPelanggan.Items[listPelanggan.FocusedItem.Index].SubItems[3].Text;
            tbKodePos.Text = listPelanggan.Items[listPelanggan.FocusedItem.Index].SubItems[4].Text;
            tbTelp.Text = listPelanggan.Items[listPelanggan.FocusedItem.Index].SubItems[5].Text;
        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            databaseConnection.Open();
            refresh();
            databaseConnection.Close();
        }
    }
}
