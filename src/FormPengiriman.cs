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
using System.Globalization;

namespace src
{
    public partial class FormPengiriman : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=kirimslur;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public FormPengiriman()
        {
            InitializeComponent();
        }

        private void FormPengiriman_Load(object sender, EventArgs e)
        {
            refresh();
            Pelanggan("pengirim");
            Pelanggan("penerima");
            Barang();
            Kurir();
        }

        private void Pelanggan(string pelanggan)
        {
            string query = "SELECT id, nama FROM pelanggan";
            try
            {
                databaseConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = reader["nama"].ToString();
                        item.Value = reader["id"].ToString();

                        if (pelanggan.Equals("penerima"))
                        {
                            cbPenerima.Items.Add(item);
                        } else
                        {
                            cbPengirim.Items.Add(item);
                        }
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
//                refresh();
                databaseConnection.Close();
            }
        }

        private void Barang()
        {
            string query = "SELECT id, nama FROM barang";
            try
            {
                databaseConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = reader["nama"].ToString();
                        item.Value = reader["id"].ToString();

                        cbBarang.Items.Add(item);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
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

        private void Kurir()
        {
            string query = "SELECT id, nama FROM kurir";
            try
            {
                databaseConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = reader["nama"].ToString();
                        item.Value = reader["id"].ToString();

                        cbKurir.Items.Add(item);
                    }

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
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

        private void Regular_Checked(object sender, EventArgs e)
        {
            tbTotal.Text = "70000";
        }

        private void Express_Checked(object sender, EventArgs e)
        {
            tbTotal.Text = "120000";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO invoice (`id`, `no_resi`, `tanggal`, `id_pengirim`, " +
                "`id_penerima`, `id_barang`, `id_kurir`, `kategori`, `total`) " +
                "VALUES (null, @no_resi, @tanggal, @id_pengirim, @id_penerima, @id_barang, " +
                "@id_kurir, @kategori, @total)";

            try
            {
                databaseConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;

                cmd.Parameters.AddWithValue("@no_resi", rnd());
                cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@id_pengirim", (cbPengirim.SelectedItem as ComboboxItem).Value.ToString());
                cmd.Parameters.AddWithValue("@id_penerima", (cbPenerima.SelectedItem as ComboboxItem).Value.ToString());
                cmd.Parameters.AddWithValue("@id_barang", (cbBarang.SelectedItem as ComboboxItem).Value.ToString());
                cmd.Parameters.AddWithValue("@id_kurir", (cbKurir.SelectedItem as ComboboxItem).Value.ToString());
                cmd.Parameters.AddWithValue("@kategori", rbExpress.Checked ? rbExpress.Text : rbRegular.Text);
                cmd.Parameters.AddWithValue("@total", tbTotal.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }

            refresh();
        }

        private string rnd()
        {
            String random = "1234567890";
            String no_resi = "";
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                no_resi += random[rnd.Next(random.Length)];
            }

            return no_resi;
        }

        private void listPengiriman_MouseClick(object sender, MouseEventArgs e)
        {
            dtTanggal.Text = listPengiriman.Items[listPengiriman.FocusedItem.Index].SubItems[0].Text;
            no_resi.Text = listPengiriman.Items[listPengiriman.FocusedItem.Index].SubItems[1].Text;
            cbPengirim.Text = listPengiriman.Items[listPengiriman.FocusedItem.Index].SubItems[2].Text;
            cbPenerima.Text = listPengiriman.Items[listPengiriman.FocusedItem.Index].SubItems[3].Text;
            cbBarang.Text = listPengiriman.Items[listPengiriman.FocusedItem.Index].SubItems[4].Text;
            cbKurir.Text = listPengiriman.Items[listPengiriman.FocusedItem.Index].SubItems[5].Text;
            tbTotal.Text = listPengiriman.Items[listPengiriman.FocusedItem.Index].SubItems[6].Text;

            string kategori = listPengiriman.Items[listPengiriman.FocusedItem.Index].SubItems[7].Text;
            if(kategori.Equals("pengirim"))
            {
                rbExpress.Checked = true;
            } else
            {
                rbRegular.Checked = true;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM invoice WHERE no_resi = @no_resi";

            try
            {
                databaseConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;

                cmd.Parameters.AddWithValue("@no_resi", no_resi.Text);
                cmd.BeginExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }

            refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE invoice SET tanggal = @tanggal, " +
                "id_pengirim = @id_pengirim, id_penerima = @id_penerima, " +
                "id_barang = @id_barang, id_kurir = @id_kurir, kategori = @kategori, " +
                "total = @total WHERE no_resi = @no_resi";

            try
            {
                databaseConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;

                cmd.Parameters.AddWithValue("@no_resi", no_resi.Text);
                cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@id_penerima", (cbPenerima.SelectedItem as ComboboxItem).Value.ToString());
                cmd.Parameters.AddWithValue("@id_pengirim", (cbPengirim.SelectedItem as ComboboxItem).Value.ToString());
                cmd.Parameters.AddWithValue("@id_kurir", (cbKurir.SelectedItem as ComboboxItem).Value.ToString());
                cmd.Parameters.AddWithValue("@kategori", rbExpress.Checked ? rbExpress.Text : rbRegular.Text);
                cmd.Parameters.AddWithValue("@total", tbTotal.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }

            refresh();
        }

        private void refresh()
        {
            listPengiriman.Items.Clear();

            string query = "SELECT i.no_resi, i.tanggal, pengirim, penerima, " +
                "b.nama as barang, k.nama as kurir, i.kategori, i.total FROM invoice i, " +
                "(select id as id_pengirim, nama as pengirim from pelanggan) as pengirim, " +
                "(select id as id_penerima, nama as penerima from pelanggan) as penerima, " +
                "barang b, kurir k where i.id_pengirim = pengirim.id_pengirim and " +
                "i.id_penerima = penerima.id_penerima and b.id = i.id_barang and k.id = i.id_kurir";

            try
            {
                databaseConnection.Open();

                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["tanggal"].ToString());
                        listViewItem.SubItems.Add(reader["no_resi"].ToString());
                        listViewItem.SubItems.Add(reader["pengirim"].ToString());
                        listViewItem.SubItems.Add(reader["penerima"].ToString());
                        listViewItem.SubItems.Add(reader["barang"].ToString());
                        listViewItem.SubItems.Add(reader["kurir"].ToString());
                        listViewItem.SubItems.Add(reader["kategori"].ToString());
                        listViewItem.SubItems.Add(reader["total"].ToString());

                        listPengiriman.Items.Add(listViewItem);
                    }

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
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
