namespace genPassword
{
    partial class groupBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(groupBox));
            labelLenght = new Label();
            labelPasswd = new Label();
            btnPasswd = new Button();
            GenListPasswd = new Button();
            resetList = new Button();
            listBoxPasswd = new ListBox();
            groupCaract = new GroupBox();
            label4 = new Label();
            labelChiffre = new Label();
            labelMaj = new Label();
            labelMin = new Label();
            checkSpec = new CheckBox();
            checkChiffres = new CheckBox();
            checkMaj = new CheckBox();
            checkMin = new CheckBox();
            inputLenght = new TextBox();
            groupCaract.SuspendLayout();
            SuspendLayout();
            // 
            // labelLenght
            // 
            labelLenght.AutoSize = true;
            labelLenght.BackColor = Color.Transparent;
            labelLenght.ForeColor = SystemColors.Control;
            labelLenght.Location = new Point(66, 61);
            labelLenght.Name = "labelLenght";
            labelLenght.Size = new Size(112, 15);
            labelLenght.TabIndex = 0;
            labelLenght.Text = "Longueur souhaitée";
            // 
            // labelPasswd
            // 
            labelPasswd.AutoSize = true;
            labelPasswd.BackColor = Color.Transparent;
            labelPasswd.ForeColor = Color.White;
            labelPasswd.Location = new Point(780, 61);
            labelPasswd.Name = "labelPasswd";
            labelPasswd.Size = new Size(103, 15);
            labelPasswd.TabIndex = 1;
            labelPasswd.Text = "Vos mots de passe";
            // 
            // btnPasswd
            // 
            btnPasswd.Location = new Point(408, 108);
            btnPasswd.Name = "btnPasswd";
            btnPasswd.Size = new Size(186, 37);
            btnPasswd.TabIndex = 2;
            btnPasswd.Text = "Générer un mot de passe";
            btnPasswd.UseVisualStyleBackColor = true;
            btnPasswd.Click += btnPasswd_Click_1;
            // 
            // GenListPasswd
            // 
            GenListPasswd.Location = new Point(408, 164);
            GenListPasswd.Name = "GenListPasswd";
            GenListPasswd.Size = new Size(186, 47);
            GenListPasswd.TabIndex = 3;
            GenListPasswd.Text = "Générer une liste de mot de passe";
            GenListPasswd.UseVisualStyleBackColor = true;
            GenListPasswd.Click += GenListPasswd_Click_1;
            // 
            // resetList
            // 
            resetList.Location = new Point(408, 313);
            resetList.Name = "resetList";
            resetList.Size = new Size(186, 37);
            resetList.TabIndex = 4;
            resetList.Text = "Vider la liste";
            resetList.UseVisualStyleBackColor = true;
            // 
            // listBoxPasswd
            // 
            listBoxPasswd.ForeColor = Color.Black;
            listBoxPasswd.FormattingEnabled = true;
            listBoxPasswd.ItemHeight = 15;
            listBoxPasswd.Location = new Point(780, 79);
            listBoxPasswd.Name = "listBoxPasswd";
            listBoxPasswd.Size = new Size(285, 244);
            listBoxPasswd.TabIndex = 5;
            listBoxPasswd.SelectedIndexChanged += listBoxPasswd_SelectedIndexChanged;
            // 
            // groupCaract
            // 
            groupCaract.BackColor = Color.Transparent;
            groupCaract.Controls.Add(label4);
            groupCaract.Controls.Add(labelChiffre);
            groupCaract.Controls.Add(labelMaj);
            groupCaract.Controls.Add(labelMin);
            groupCaract.Controls.Add(checkSpec);
            groupCaract.Controls.Add(checkChiffres);
            groupCaract.Controls.Add(checkMaj);
            groupCaract.Controls.Add(checkMin);
            groupCaract.Location = new Point(26, 150);
            groupCaract.Name = "groupCaract";
            groupCaract.Size = new Size(280, 180);
            groupCaract.TabIndex = 6;
            groupCaract.TabStop = false;
            groupCaract.Text = "Choix des caractères ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 134);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // labelChiffre
            // 
            labelChiffre.AutoSize = true;
            labelChiffre.Location = new Point(142, 105);
            labelChiffre.Name = "labelChiffre";
            labelChiffre.Size = new Size(0, 15);
            labelChiffre.TabIndex = 8;
            // 
            // labelMaj
            // 
            labelMaj.AutoSize = true;
            labelMaj.Location = new Point(142, 76);
            labelMaj.Name = "labelMaj";
            labelMaj.Size = new Size(0, 15);
            labelMaj.TabIndex = 8;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(142, 47);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(0, 15);
            labelMin.TabIndex = 9;
            labelMin.Click += label2_Click;
            // 
            // checkSpec
            // 
            checkSpec.AutoSize = true;
            checkSpec.BackColor = Color.White;
            checkSpec.Location = new Point(23, 130);
            checkSpec.Name = "checkSpec";
            checkSpec.Size = new Size(130, 19);
            checkSpec.TabIndex = 3;
            checkSpec.Text = "Caractères spéciaux";
            checkSpec.UseVisualStyleBackColor = false;
            checkSpec.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkChiffres
            // 
            checkChiffres.AutoSize = true;
            checkChiffres.BackColor = Color.White;
            checkChiffres.Location = new Point(23, 101);
            checkChiffres.Name = "checkChiffres";
            checkChiffres.Size = new Size(102, 19);
            checkChiffres.TabIndex = 2;
            checkChiffres.Text = "Chiffres (0 à 9)";
            checkChiffres.UseVisualStyleBackColor = false;
            // 
            // checkMaj
            // 
            checkMaj.AutoSize = true;
            checkMaj.BackColor = Color.White;
            checkMaj.Location = new Point(23, 72);
            checkMaj.Name = "checkMaj";
            checkMaj.Size = new Size(123, 19);
            checkMaj.TabIndex = 1;
            checkMaj.Text = "Lettres Majuscules";
            checkMaj.UseVisualStyleBackColor = false;
            checkMaj.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkMin
            // 
            checkMin.AutoSize = true;
            checkMin.BackColor = Color.White;
            checkMin.Location = new Point(22, 43);
            checkMin.Name = "checkMin";
            checkMin.Size = new Size(124, 19);
            checkMin.TabIndex = 0;
            checkMin.Text = "Lettres minuscules";
            checkMin.UseVisualStyleBackColor = false;
            // 
            // inputLenght
            // 
            inputLenght.Location = new Point(36, 88);
            inputLenght.Name = "inputLenght";
            inputLenght.Size = new Size(186, 23);
            inputLenght.TabIndex = 7;
            // 
            // groupBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1068, 450);
            Controls.Add(inputLenght);
            Controls.Add(groupCaract);
            Controls.Add(listBoxPasswd);
            Controls.Add(resetList);
            Controls.Add(GenListPasswd);
            Controls.Add(btnPasswd);
            Controls.Add(labelPasswd);
            Controls.Add(labelLenght);
            Name = "groupBox";
            Text = "Form1";
            Load += groupBox_Load;
            groupCaract.ResumeLayout(false);
            groupCaract.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLenght;
        private Label labelPasswd;
        private Button btnPasswd;
        private Button GenListPasswd;
        private Button resetList;
        private ListBox listBoxPasswd;
        private GroupBox groupCaract;
        private TextBox inputLenght;
        private Label label4;
        private Label labelChiffre;
        private Label labelMaj;
        private Label labelMin;
        private CheckBox checkSpec;
        private CheckBox checkChiffres;
        private CheckBox checkMaj;
        private CheckBox checkMin;
    }
}
