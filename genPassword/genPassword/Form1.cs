using System.Reflection.PortableExecutable;

namespace genPassword
{
    public partial class groupBox : Form
    {
        private static string AlphaMin = "abcdefghijklmnopqrstuvwxyz";
        private static string AlphaMaj = AlphaMin.ToUpper();
        private static string AlphaChiffres = "0123456789";
        private static string AlphaSpec = "#_@-*$";
        private static string Alphabet = string.Empty;

        public groupBox()
        {
            InitializeComponent();
        }

        private bool CheckPasswdLength(out int inputLenghtVal)
        {
            // Convertir inputLenght en int
            if (!int.TryParse(inputLenght.Text, out inputLenghtVal))
            {
                MessageBox.Show("La longueur doit être un nombre", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Test de la longueur <=0
            if (inputLenghtVal <= 0)
            {
                MessageBox.Show("La longueur doit être un nombre supérieur à 0", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void btnPasswd_Click(object sender, EventArgs e)
        {

            int PasswdLen = 0;

            // Controller que la valeur vsaisie 
            //  pour la longueur est correcte
            // ***********************************
            if (!CheckPasswdLength(out PasswdLen))
            {
                return;
            }

            if (!ConstruireAlpha())
            {
                return;
            }
        }


        private bool ConstruireAlpha()
        {
            Alphabet = string.Empty;

            if (checkMin.Checked)
            {
                Alphabet += AlphaMin;
            }

            if (checkMaj.Checked)
            {
                Alphabet += AlphaMaj;
            }

            if (checkChiffres.Checked)
            {
                Alphabet += AlphaChiffres;
            }

            if (checkSpec.Checked)
            {
                Alphabet += AlphaSpec;
            }

            // Condition si aucune case n'a été cochée 
            if (Alphabet.Length == 0)
            {
                return false;
            }
            return true;
        }


        public void btnPasswd_Click_1(object sender, EventArgs e)
        {
            int PasswdLen = 0;
            string password = string.Empty;

            // Controller que la valeur vsaisie 
            //  pour la longueur est correcte
            // ***********************************
            if (!CheckPasswdLength(out PasswdLen))
            {
                return;
            }

            if (!ConstruireAlpha())
            {
                return;
            }
            password = genPassword(PasswdLen);
            listBoxPasswd.Items.Add(password);
        }


        private void GenListPasswd_Click(object sender, EventArgs e)
        {
            int PasswdLen = 0;
            string password = string.Empty;

            // Controller que la valeur vsaisie 
            //  pour la longueur est correcte
            // ***********************************
            if (!CheckPasswdLength(out PasswdLen))
            {
                return;
            }

            if (!ConstruireAlpha())
            {
                return;
            }

            // Générer cinq mots de passe 
            for (int i = 0; i < 5; i++)
            {
                password = genPassword(PasswdLen);
                listBoxPasswd.Items.Add(password);
            }
            // Générer un mot de passe 

            password = genPassword(PasswdLen);
            listBoxPasswd.Items.Add(password);
        }



        private string genPassword(int PassLen)
        {
            int genNombres;

            // On crée le tirage le random
            var rnd = new Random();
            string passwd = "";


            // Utilisation d'une boucle while 
            int i = 0;
            while (i < PassLen)
            {
                genNombres = rnd.Next(Alphabet.Length);
                passwd += Alphabet[genNombres];
                i++;
            }
            return passwd;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Load(object sender, EventArgs e)
        {

        }

        private void listBoxPasswd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(listBoxPasswd.SelectedItem.ToString());
        }

        private void GenListPasswd_Click_1(object sender, EventArgs e)
        {

            int PasswdLen = 0;
            string password = string.Empty;

            // Controller que la valeur vsaisie 
            //  pour la longueur est correcte
            // ***********************************
            if (!CheckPasswdLength(out PasswdLen))
            {
                return;
            }

            if (!ConstruireAlpha())
            {
                return;
            }


            // Demander le nombre de mots de passe à générer
            var winForm2 = new Form2();
            winForm2.ShowDialog();

           

            // Récupere la valeur saisie dans fomr2
            int nbPasswd = winForm2.InputNbr;

            // generer la liste des mots de passe
            for(int i=0; i< nbPasswd; i++)
            {
                listBoxPasswd.Items.Add(genPassword(PasswdLen));

            }

        }
    }
}
