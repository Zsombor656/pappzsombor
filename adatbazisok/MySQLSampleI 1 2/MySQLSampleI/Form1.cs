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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MySQLSampleI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString = $"Server={txtHost.Text};Port={txtPort.Text};" +
                                      $"Database={txtDatabase.Text};" +
                                      $"Uid={txtUser.Text};Pwd={txtPass.Text}";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Sikeres kapcsolódás!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a kapcsolódás során: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHost.Text = "localhost";
            txtPort.Text = "3307";
            txtUser.Text = "root";
            txtPass.Text = string.Empty;
            txtDatabase.Text = "zs_konyvek";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string konyvNev = txtKonyvNev.Text;

            string connectionString = $"Server={txtHost.Text};Port={txtPort.Text};" +
                                      $"Database={txtDatabase.Text};" +
                                      $"Uid={txtUser.Text};Pwd={txtPass.Text}";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sqlSelectId = "SELECT id FROM konyvek WHERE cim = @cim LIMIT 1;";
                    MySqlCommand cmdSelect = new MySqlCommand(sqlSelectId, conn);
                    cmdSelect.Parameters.AddWithValue("@cim", konyvNev);

                    object result = cmdSelect.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Nincs ilyen könyv a konyvek táblában!");
                        return;
                    }

                    int konyvId = Convert.ToInt32(result);

                    string sqlInsert =
                        "INSERT INTO kolcsonzes (konyv_id, datum) VALUES (@konyv_id, @datum);";

                    MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conn);
                    cmdInsert.Parameters.AddWithValue("@konyv_id", konyvId);
                    cmdInsert.Parameters.AddWithValue("@datum", DateTime.Now);

                    cmdInsert.ExecuteNonQuery();

                    string sqlSelect = "SELECT * FROM kolcsonzes";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlSelect, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    MessageBox.Show("Kölcsönzés sikeresen rögzítve!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba: " + ex.Message);
                }
            }
        }


        private void txtUserNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click_1(object sender, EventArgs e)
        {
            string connectionString = $"Server={txtHost.Text};Port={txtPort.Text};" +
                                      $"Database={txtDatabase.Text};" +
                                      $"Uid={txtUser.Text};Pwd={txtPass.Text}";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Tárolt eljárás meghívása
                    MySqlCommand cmd = new MySqlCommand("ListKonyvek", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adatok betöltése DataTable-be
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Megjelenítés DataGridView-ban
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba: " + ex.Message);
                }
            }
        }


        //    string connectionString = "Server=localhost;Port=3306;Database=mo_varosok;Uid=root;Pwd='';";
        //        using (MySqlConnection conn = new MySqlConnection(connectionString))
        //        {
        //            conn.Open();
        //            string sql = "SELECT * FROM tablaNev";
        //            MySqlCommand cmd = new MySqlCommand(sql, conn);
        //            MySqlDataReader reader = cmd.ExecuteReader();
        //            //Itt illesztjük be az adatot a DataGridView-ba
        //            DataTable dt = new DataTable();
        //            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //            da.Fill(dt);
        //            dataGridView1.DataSource = dt;
        //        }
    }
}
