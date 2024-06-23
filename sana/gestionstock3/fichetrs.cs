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

namespace gestionstock3
{
    public partial class fichetrs : Form
    {
        public fichetrs()
        {
            InitializeComponent();
        }

        private void fichetrs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
            string query = "SELECT Machine FROM trs";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["Machine"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la récupération des machines : " + ex.Message);
                    return;
                }
            }

            Form form = new Form();
            form.Text = "Sélectionner une machine";
            form.Width = 300;
            form.Height = 150;
            comboBox.Dock = DockStyle.Fill;
            form.Controls.Add(comboBox);

            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            buttonOk.Text = "OK";
            buttonOk.Dock = DockStyle.Bottom;
            buttonOk.DialogResult = DialogResult.OK;
            form.Controls.Add(buttonOk);
            form.AcceptButton = buttonOk;

            if (form.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string input = comboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("La machine sélectionnée est obligatoire pour continuer.");
                return;
            }

            string querySelectedMachine = "SELECT Date, Machine, Tisserand, OF, Designation, Reference, `TRS(%)` FROM trs WHERE Machine = @Machine";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(querySelectedMachine, connection);
                    cmd.Parameters.AddWithValue("@Machine", input);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();

                    dataGridView1.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Aucune donnée trouvée pour la machine sélectionnée.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la récupération des données : " + ex.Message);
                }
            }
        }


        private void ConfigurerDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("nom_machine", "Machine");
            dataGridView1.Columns.Add("nom_tisserand", "Tisserand");
            dataGridView1.Columns.Add("OF", "OF");
            dataGridView1.Columns.Add("designation", "Designation");
            dataGridView1.Columns.Add("reference", "Référence");
            dataGridView1.Columns.Add("trs", "TRS (%)");
        }
    }
}
