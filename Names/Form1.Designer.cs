namespace Names
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
            lblNames = new Label();
            lstNames = new ListBox();
            btnAgregar = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // lblNames
            // 
            lblNames.AutoSize = true;
            lblNames.Location = new Point(29, 23);
            lblNames.Name = "lblNames";
            lblNames.Size = new Size(44, 15);
            lblNames.TabIndex = 0;
            lblNames.Text = "Names";
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 15;
            lstNames.Location = new Point(12, 56);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(178, 94);
            lstNames.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(240, 109);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar!";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(196, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 23);
            txtName.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 187);
            Controls.Add(txtName);
            Controls.Add(btnAgregar);
            Controls.Add(lstNames);
            Controls.Add(lblNames);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNames;
        private ListBox lstNames;
        private Button btnAgregar;
        private TextBox txtName;
    }
}
