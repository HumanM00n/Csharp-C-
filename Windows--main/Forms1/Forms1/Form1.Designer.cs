namespace Forms1
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
            btnNew = new Button();
            inputPrenom = new TextBox();
            labelPrenom = new Label();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Location = new Point(329, 158);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(69, 43);
            btnNew.TabIndex = 0;
            btnNew.Text = "Submit";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += BtnNew_Click;
            // 
            // inputPrenom
            // 
            inputPrenom.Location = new Point(231, 69);
            inputPrenom.Name = "inputPrenom";
            inputPrenom.Size = new Size(273, 23);
            inputPrenom.TabIndex = 1;
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Location = new Point(283, 37);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(154, 15);
            labelPrenom.TabIndex = 2;
            labelPrenom.Text = "Vueillez saisir votre prénom ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(labelPrenom);
            Controls.Add(inputPrenom);
            Controls.Add(btnNew);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private TextBox inputPrenom;
        private Label labelPrenom;
    }
}
