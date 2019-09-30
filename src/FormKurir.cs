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
    public partial class FormKurir : Form
    {
        private static string connectionString =
"server=localhost;port=3306;username=root;password=;database=kirimslur;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public FormKurir()
        {
            InitializeComponent();
        }
        //query nunggu database
        private void BtnTambah_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO kurir (nama,no_ktp,no_telp) VALUES (@nama,@no_ktp, @no_telp)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@no_ktp", tbNoKTP.Text);
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
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE kurir SET nama = @nama, no_ktp=@no_ktp, no_telp= @no_telp WHERE id = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                cmd.Parameters.AddWithValue("@no_ktp", tbNoKTP.Text);
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

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM kurir WHERE id = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                //cmd.Parameters.AddWithValue("@id", text_id.Text);
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
            listKurir.Items.Clear();
            string query = "SELECT * FROM kurir";
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
                    listViewItem.SubItems.Add(reader["no_ktp"].ToString());
                    listViewItem.SubItems.Add(reader["no_telp"].ToString());
                    listKurir.Items.Add(listViewItem);
                }
            }
            reader.Close();
        }

        private void FormKurir_Load(object sender, EventArgs e)
        {
            databaseConnection.Open();
            refresh();
            databaseConnection.Close();
        }

        private void ListKurir_MouseClick(object sender, MouseEventArgs e)
        {
            tbNama.Text = listKurir.Items[listKurir.FocusedItem.Index].SubItems[0].Text;
            tbNoKTP.Text = listKurir.Items[listKurir.FocusedItem.Index].SubItems[1].Text;
            tbTelp.Text = listKurir.Items[listKurir.FocusedItem.Index].SubItems[2].Text;
        }
    }
}
