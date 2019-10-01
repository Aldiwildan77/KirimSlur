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
    public partial class FormBarang : Form
    {
        private static string connectionString =
        "server=localhost;port=3306;username=root;password=;database=kirimslur;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public FormBarang()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO barang (id,nama,berat,jenis) VALUES (null,@nama,@berat,@jenis)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@berat", tbBerat.Text);
                cmd.Parameters.AddWithValue("@jenis", tbJenis.Text);
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
            string query = "UPDATE barang SET nama = @nama, berat = @berat, jenis = @jenis WHERE id = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", tbIdBarang.Text);
                cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@berat", tbBerat.Text);
                cmd.Parameters.AddWithValue("@jenis", tbJenis.Text);
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
            string query = "DELETE FROM barang WHERE id = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", tbIdBarang.Text);
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
            listBarang.Items.Clear();
            string query = "SELECT * FROM barang";
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
                    listViewItem.SubItems.Add(reader["berat"].ToString());
                    listViewItem.SubItems.Add(reader["jenis"].ToString());
                    listBarang.Items.Add(listViewItem);
                }
            }
            reader.Close();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            databaseConnection.Open();
            refresh();
            databaseConnection.Close();
        }

        private void listBarang_MouseClick(object sender, MouseEventArgs e)
        {
            tbIdBarang.Text = listBarang.Items[listBarang.FocusedItem.Index].SubItems[0].Text;
            tbNama.Text = listBarang.Items[listBarang.FocusedItem.Index].SubItems[1].Text;
            tbBerat.Text = listBarang.Items[listBarang.FocusedItem.Index].SubItems[2].Text;
            tbJenis.Text = listBarang.Items[listBarang.FocusedItem.Index].SubItems[3].Text;
        }
    }
}
