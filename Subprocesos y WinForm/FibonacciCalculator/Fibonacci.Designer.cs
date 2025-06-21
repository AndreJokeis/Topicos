namespace Subprocesos_y_WinForm.FibonacciCalculator
{
    partial class Fibonacci
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
            cancelAsyncButton = new Button();
            startAsyncButton = new Button();
            numericUpDown1 = new NumericUpDown();
            progressBar1 = new ProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            resultLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cancelAsyncButton
            // 
            cancelAsyncButton.Location = new Point(93, 70);
            cancelAsyncButton.Name = "cancelAsyncButton";
            cancelAsyncButton.Size = new Size(75, 23);
            cancelAsyncButton.TabIndex = 3;
            cancelAsyncButton.Text = "Cancel";
            cancelAsyncButton.UseVisualStyleBackColor = true;
            cancelAsyncButton.Click += cancelAsyncButton_Click;
            // 
            // startAsyncButton
            // 
            startAsyncButton.Location = new Point(12, 70);
            startAsyncButton.Name = "startAsyncButton";
            startAsyncButton.Size = new Size(75, 23);
            startAsyncButton.TabIndex = 2;
            startAsyncButton.Text = "Start";
            startAsyncButton.UseVisualStyleBackColor = true;
            startAsyncButton.Click += startAsyncButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 12);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(86, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 41);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(156, 23);
            progressBar1.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(113, 14);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(38, 15);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "label1";
            // 
            // Fibonacci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 120);
            Controls.Add(resultLabel);
            Controls.Add(progressBar1);
            Controls.Add(numericUpDown1);
            Controls.Add(cancelAsyncButton);
            Controls.Add(startAsyncButton);
            Name = "Fibonacci";
            Text = "Fibonacci";
            Click += startAsyncButton_Click;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelAsyncButton;
        private Button startAsyncButton;
        private NumericUpDown numericUpDown1;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label resultLabel;
    }
}