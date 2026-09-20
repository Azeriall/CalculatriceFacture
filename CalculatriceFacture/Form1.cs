namespace CalculatriceFacture
{
    public partial class Form1 : Form
    {
        double percentValue = 0;
        double prix = 0.0;
        double nombreTotal = 0.0;
        double nombreAAjouter = 0.0;

        List<string> montantAjouter = new List<string>();
        List<string> montantTotal = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out percentValue))
            {
                MessageBox.Show($"{textBox1.Text} % appliqué");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Erreur, veuillez entrer un nombre valide");
                textBox1.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out prix))
            {
                nombreAAjouter = (prix / 100 * percentValue);
                nombreAAjouter = Math.Round(nombreAAjouter, 3);
                nombreTotal = nombreTotal + nombreAAjouter;
                montantAjouter.Add($"Montant de {textBox2.Text} à {percentValue} % -> {nombreAAjouter:F2}");
                montantTotal.Add($"Total: {nombreTotal:F2}");
                listBox3.DataSource = null;
                listBox3.DataSource = montantTotal;
                listBox1.DataSource = null;
                listBox1.DataSource = montantAjouter;
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Erreur, veuillez entrer un nombre valide");
                textBox2.Clear();
            }

        }

        // pas touche svp
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                if (double.TryParse(textBox2.Text, out prix))
                {
                    nombreAAjouter = (prix / 100 * percentValue);
                    nombreAAjouter = Math.Round(nombreAAjouter, 3);
                    nombreTotal = nombreTotal + nombreAAjouter;
                    montantAjouter.Add($"Montant de {textBox2.Text} à {percentValue} % -> {nombreAAjouter:F2}");
                    montantTotal.Add($"Total: {nombreTotal:F2}");
                    listBox3.DataSource = null;
                    listBox3.DataSource = montantTotal;
                    listBox1.DataSource = null;
                    listBox1.DataSource = montantAjouter;
                    textBox2.Clear();

                }
                else
                {
                    MessageBox.Show("Erreur, veuillez entrer un nombre valide");
                    textBox2.Clear();
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = $"{nombreTotal:F2}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            percentValue = 0.0;
            nombreAAjouter = 0.0;
            nombreTotal = 0.0;
            prix = 0.0;
            montantAjouter.Clear();
            montantTotal.Clear();
            listBox3.DataSource = null;
            listBox3.DataSource = montantTotal;
            listBox1.DataSource = null;
            listBox1.DataSource = montantAjouter;
            textBox3.Clear();
            textBox2.Clear();
            MessageBox.Show("Réinitialisation réussi");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (double.TryParse(textBox1.Text, out percentValue))
                {
                    MessageBox.Show($"{textBox1.Text} % appliqué");
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Erreur, veuillez entrer un nombre valide");
                    textBox1.Clear();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //calculer
            button5.BackColor = Color.FromArgb(200, 255, 200);
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            // appliquer
            button7.BackColor = Color.FromArgb(200, 255, 200);
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;

            // ajouter
            button4.BackColor = Color.FromArgb(200, 255, 200);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;

            // reset
            button8.BackColor = Color.FromArgb(255, 100, 100);
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
