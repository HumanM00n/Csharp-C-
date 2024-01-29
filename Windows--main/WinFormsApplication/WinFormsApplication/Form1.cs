using System.Threading.Channels;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nom = inputNom.Text;

            if (listBox.Items.Contains(nom) == false)
            {
                listBox.Items.Add(nom);
                MessageBox.Show($"Hello {nom} votre nom a bien été enregistré ", "Bonjour",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                inputNom.Text = "";
            }
            else
            {
                MessageBox.Show($"Le nom '{nom}' a déjà été renseigné ! Veuillez saisir un autre nom ", "ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
