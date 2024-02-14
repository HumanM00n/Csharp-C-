namespace genPassword
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNbr = new Label();
            edInputNbr = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // labelNbr
            // 
            labelNbr.AutoSize = true;
            labelNbr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNbr.Location = new Point(86, 68);
            labelNbr.Name = "labelNbr";
            labelNbr.Size = new Size(289, 21);
            labelNbr.TabIndex = 0;
            labelNbr.Text = "Combien voulez-vous de mot de passe ?";
            labelNbr.Click += label1_Click;
            // 
            // edInputNbr
            // 
            edInputNbr.Location = new Point(86, 106);
            edInputNbr.Name = "edInputNbr";
            edInputNbr.Size = new Size(289, 23);
            edInputNbr.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(86, 145);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 30);
            btnOk.TabIndex = 2;
            btnOk.Text = "Valider";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 257);
            Controls.Add(btnOk);
            Controls.Add(edInputNbr);
            Controls.Add(labelNbr);
            Name = "Form2";
            Text = "Nombres de mot de passe...";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNbr;
        private TextBox edInputNbr;
        private Button btnOk;
    }
}