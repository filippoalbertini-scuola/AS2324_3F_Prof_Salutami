namespace AS2324_3F_Prof_Salutami
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
            label1 = new Label();
            txtNome = new TextBox();
            lblSaluto = new Label();
            btnSaluta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 85);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(195, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(260, 27);
            txtNome.TabIndex = 1;
            // 
            // lblSaluto
            // 
            lblSaluto.AutoSize = true;
            lblSaluto.Location = new Point(198, 154);
            lblSaluto.Name = "lblSaluto";
            lblSaluto.Size = new Size(18, 20);
            lblSaluto.TabIndex = 2;
            lblSaluto.Text = "...";
            // 
            // btnSaluta
            // 
            btnSaluta.Location = new Point(259, 235);
            btnSaluta.Name = "btnSaluta";
            btnSaluta.Size = new Size(151, 49);
            btnSaluta.TabIndex = 3;
            btnSaluta.Text = "Saluta";
            btnSaluta.UseVisualStyleBackColor = true;
            btnSaluta.Click += btnSaluta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 368);
            Controls.Add(btnSaluta);
            Controls.Add(lblSaluto);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Prof; 3F; 01/03/2024; Saluta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label lblSaluto;
        private Button btnSaluta;
    }
}
