namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void BtnNew_Click(object sender, EventArgs e)
        {
            /* -- Ouvrir la petite fen�tre pour afficher un message -- */

            // MessageBox.Show("Ca dit quoi l'�quipe", "caption",
            // MessageBoxButtons.OK, MessageBoxIcon.Information);

            /* -- Condition pour que l'utilisateur ne puisse pas envoyer un donn�e vide lorsqu'il clique sur le bouton -- */
            string prenom = inputPrenom.Text; // Il faut rajouter le ".Text" pour r�cup�rer la donn�e saisi

            if (prenom.Length > 0) {
                MessageBox.Show($"Como esta {prenom}", "caption",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("Veuillez saisir un pr�nom", "caption",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("Veuillez saisir un pr�nom", "ERREUR UTILISATEUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
  
    }
}
