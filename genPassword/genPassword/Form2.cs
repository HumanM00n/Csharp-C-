using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace genPassword
{
    public partial class Form2 : Form
    {
        // Pour récupérer la valeur saisie 
        // A l'extérieur du formulaire 
        public int InputNbr { get; private set; }


        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Sauvegarde dans la propriété publique 
                // La valeur saisie par l'utilisateur 
                InputNbr = int.Parse(edInputNbr.Text); // On récupère la valeur 
                if (InputNbr == 0)
                {
                    MessageBox.Show("Veillez saisir un nombre supérieur à 0", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();

            }
            catch {
                    MessageBox.Show("Veillez saisir un nombre supérieur à 0", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

       /* private void btnOk_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Sauvegarde dans la propriété publique 
                // La valeur saisie par l'utilisateur 
                InputNbr = int.Parse(edInputNbr.Text); // On récupère la valeur 
                if (InputNbr == 0)
                {
                    MessageBox.Show("Veillez saisir un nombre supérieur à 0", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();

            }
            catch
            {
                MessageBox.Show("Veillez saisir un nombre supérieur à 0", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

        //}
    }
}

