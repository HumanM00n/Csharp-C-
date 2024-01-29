namespace WinFormsApplication
{
    partial class Form1
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
            labelNom = new Label();
            inputNom = new TextBox();
            labelListe = new Label();
            listBox = new ListBox();
            label1 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(610, 63);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // inputNom
            // 
            inputNom.Location = new Point(610, 81);
            inputNom.Name = "inputNom";
            inputNom.Size = new Size(178, 23);
            inputNom.TabIndex = 1;
            //inputNom.TextChanged += inputNom_TextChanged;
            // 
            // labelListe
            // 
            labelListe.AutoSize = true;
            labelListe.Location = new Point(40, 63);
            labelListe.Name = "labelListe";
            labelListe.Size = new Size(85, 15);
            labelListe.TabIndex = 3;
            labelListe.Text = "Liste des noms";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(40, 81);
            listBox.Name = "listBox";
            listBox.Size = new Size(284, 214);
            listBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 18);
            label1.Name = "label1";
            label1.Size = new Size(346, 30);
            label1.TabIndex = 5;
            label1.Text = "Enregistrer des noms pour une liste ";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(610, 119);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(178, 41);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Enregistrer";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(listBox);
            Controls.Add(labelListe);
            Controls.Add(inputNom);
            Controls.Add(labelNom);
            Name = "Form1";
            Text = "Enregistrer des noms ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private TextBox inputNom;
        private Label labelListe;
        private ListBox listBox;
        private Label label1;
        private Button btnSubmit;
    }
}
