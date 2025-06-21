namespace Subprocesos_y_WinForm.BackgroundClase
{
    partial class BackgroundWorkerF
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            startAsyncButton = new Button();
            cancelAsyncButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // startAsyncButton
            // 
            startAsyncButton.Location = new Point(45, 60);
            startAsyncButton.Name = "startAsyncButton";
            startAsyncButton.Size = new Size(75, 23);
            startAsyncButton.TabIndex = 0;
            startAsyncButton.Text = "Start";
            startAsyncButton.UseVisualStyleBackColor = true;
            startAsyncButton.Click += startAsyncButton_Click;
            // 
            // cancelAsyncButton
            // 
            cancelAsyncButton.Location = new Point(126, 60);
            cancelAsyncButton.Name = "cancelAsyncButton";
            cancelAsyncButton.Size = new Size(75, 23);
            cancelAsyncButton.TabIndex = 1;
            cancelAsyncButton.Text = "Cancel";
            cancelAsyncButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(110, 21);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(29, 15);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "30%";
            resultLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BackgroundWorkerF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 110);
            Controls.Add(resultLabel);
            Controls.Add(cancelAsyncButton);
            Controls.Add(startAsyncButton);
            Name = "BackgroundWorkerF";
            Text = "BackgroundWorker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button startAsyncButton;
        private Button cancelAsyncButton;
        private Label resultLabel;
    }
}