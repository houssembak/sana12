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
    public partial class TRSMachines : Form
    {
        public TRSMachines()
        {
            InitializeComponent();
            RemplirComboBox();
            RemplirComboBox1();
            RemplirComboBox12();
            RemplirComboBox123();
            RemplirComboBox1234();

        }
        private void RemplirComboBox()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT code FROM tisserands";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["code"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void RemplirComboBox1()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT code FROM parcmachine";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["code"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void RemplirComboBox12()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT OF FROM commande";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["OF"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void RemplirComboBox123()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT designation FROM commande";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox4.Items.Add(reader["designation"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void RemplirComboBox1234()
        {
            /*connexion ma3 l base de donnée */
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";
            string query = "SELECT reference FROM articles";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox5.Items.Add(reader["reference"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrEmpty(textBox17.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox9.Text, out decimal valeur1) && decimal.TryParse(textBox17.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 / valeur2;

                    // Afficher le résultat dans textBox3
                    textBox8.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox16.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox4.Text, out decimal valeur1) && decimal.TryParse(textBox16.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 - valeur2;

                    // Afficher le résultat dans textBox3
                    textBox9.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

                // Assurez-vous que les TextBox ne sont pas vides
                if (!string.IsNullOrEmpty(textTt.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    // Essayer de convertir les textes en nombres
                    if (decimal.TryParse(textTt.Text, out decimal valeur1) && decimal.TryParse(textBox2.Text, out decimal valeur2))
                    {
                        // Effectuer la soustraction
                        decimal resultat = valeur1 - valeur2;

                        // Afficher le résultat dans textBox3
                        textBox3.Text = resultat.ToString("F2");
                    }
                    else
                    {
                        // Afficher un message d'erreur si la conversion échoue
                        MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Afficher un message d'erreur si les TextBox sont vides
                    MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Assurez-vous que les TextBox ne sont pas vides
            if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox7.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox3.Text, out decimal valeur1) && decimal.TryParse(textBox7.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 - valeur2;

                    // Afficher le résultat dans textBox3
                    textBox4.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrEmpty(textBox11.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox10.Text, out decimal valeur1) && decimal.TryParse(textBox11.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 - valeur2;

                    // Afficher le résultat dans textBox3
                    textBox12.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrEmpty(textBox9.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox8.Text, out decimal valeur1) && decimal.TryParse(textBox9.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = (valeur1 / valeur2) ;

                    // Afficher le résultat dans textBox3
                    textBox6.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TRSMachines_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox4.Text, out decimal valeur1) && decimal.TryParse(textBox3.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = (valeur1 / valeur2) ;

                    // Afficher le résultat dans textBox3
                    textBox14.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrEmpty(textBox4.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox9.Text, out decimal valeur1) && decimal.TryParse(textBox4.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = (valeur1 / valeur2);

                    // Afficher le résultat dans textBox3
                    textBox15.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Définir la chaîne de connexion
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=devnet";

            // Créer la commande SQL d'insertion
            string query = "INSERT INTO trs (Date, Machine, Tisserand, tt, tprevu, tr, timprevu, tf, VP, VR, ECRAT, tb, Msorti, MNonconfirme, Mconforme, OF, Designation, Reference, mq, tu, do, tp, tq, `TRS(%)`) " +
                           "VALUES (@Date, @Machine, @Tisserand, @tt, @tprevu, @tr, @timprevu, @tf, @VP, @VR, @ECRAT, @tb, @Msorti, @MNonconfirme, @Mconforme, @OF, @Designation, @Reference, @mq, @tu, @do, @tp, @tq, @trs)";

            // Utiliser une connexion et une commande MySql
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Ajouter les paramètres à la commande
                    command.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Machine", comboBox2.SelectedItem);
                    command.Parameters.AddWithValue("@Tisserand", comboBox1.SelectedItem);
                    command.Parameters.AddWithValue("@tt", textTt.Text);
                    command.Parameters.AddWithValue("@tprevu", textBox2.Text);
                    command.Parameters.AddWithValue("@tr", textBox3.Text);
                    command.Parameters.AddWithValue("@timprevu", textBox7.Text);
                    command.Parameters.AddWithValue("@tf", textBox4.Text);
                    command.Parameters.AddWithValue("@VP", textBox13.Text);
                    command.Parameters.AddWithValue("@VR", textBox5.Text);
                    command.Parameters.AddWithValue("@ECRAT", textBox16.Text);
                    command.Parameters.AddWithValue("@tb", textBox9.Text);
                    command.Parameters.AddWithValue("@Msorti", textBox10.Text);
                    command.Parameters.AddWithValue("@MNonconfirme", textBox11.Text);
                    command.Parameters.AddWithValue("@Mconforme", textBox12.Text);
                    command.Parameters.AddWithValue("@OF", comboBox3.SelectedItem);
                    command.Parameters.AddWithValue("@Designation", comboBox4.SelectedItem);
                    command.Parameters.AddWithValue("@Reference", comboBox5.SelectedItem);
                    command.Parameters.AddWithValue("@mq", textBox17.Text);
                    command.Parameters.AddWithValue("@tu", textBox8.Text);
                    command.Parameters.AddWithValue("@do", textBox14.Text);
                    command.Parameters.AddWithValue("@tp", textBox15.Text);
                    command.Parameters.AddWithValue("@tq", textBox6.Text);
                    command.Parameters.AddWithValue("@trs", textBox1.Text);

                    // Ouvrir la connexion
                    connection.Open();

                    // Exécuter la commande
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Données insérées avec succès !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox14.Text) && !string.IsNullOrEmpty(textBox15.Text) && !string.IsNullOrEmpty(textBox6.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox14.Text, out decimal valeur1) && decimal.TryParse(textBox15.Text, out decimal valeur2) && decimal.TryParse(textBox6.Text, out decimal valeur3))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 * valeur2 * valeur3 * 100;

                    // Afficher le résultat dans textBox3
                    textBox1.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrEmpty(textBox5.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox13.Text, out decimal valeur1) && decimal.TryParse(textBox5.Text, out decimal valeur2))
                {
                    // Effectuer la soustraction
                    decimal resultat = valeur1 - valeur2;

                    // Afficher le résultat dans textBox3
                    textBox16.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrEmpty(textBox10.Text))
            {
                // Essayer de convertir les textes en nombres
                if (decimal.TryParse(textBox11.Text, out decimal valeur1) && decimal.TryParse(textBox9.Text, out decimal valeur2) && decimal.TryParse(textBox10.Text, out decimal valeur3))
                {
                    // Effectuer la soustraction
                    decimal resultat = ((valeur1 * valeur2)) / valeur3;

                    // Afficher le résultat dans textBox3
                    textBox17.Text = resultat.ToString("F2");
                }
                else
                {
                    // Afficher un message d'erreur si la conversion échoue
                    MessageBox.Show("Veuillez entrer des nombres valides dans les TextBox.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Afficher un message d'erreur si les TextBox sont vides
                MessageBox.Show("Veuillez remplir les deux TextBox.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
