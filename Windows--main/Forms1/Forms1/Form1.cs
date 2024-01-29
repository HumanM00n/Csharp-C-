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
            /* -- Ouvrir la petite fenêtre pour afficher un message -- */

            // MessageBox.Show("Ca dit quoi l'équipe", "caption",
            // MessageBoxButtons.OK, MessageBoxIcon.Information);

            /* -- Condition pour que l'utilisateur ne puisse pas envoyer un donnée vide lorsqu'il clique sur le bouton -- */
            string prenom = inputPrenom.Text; // Il faut rajouter le ".Text" pour récupérer la donnée saisi

            if (prenom.Length > 0) {
                MessageBox.Show($"Como esta {prenom}", "caption",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("Veuillez saisir un prénom", "caption",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("Veuillez saisir un prénom", "ERREUR UTILISATEUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
  
    }
}
