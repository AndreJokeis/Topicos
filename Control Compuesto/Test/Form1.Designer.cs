namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlAlarmClock1 = new ctlClockLib.ctlAlarmClock();
            this.dtpTest = new System.Windows.Forms.DateTimePicker();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctlAlarmClock1
            // 
            this.ctlAlarmClock1.AlarmSet = false;
            this.ctlAlarmClock1.AlarmTime = new System.DateTime(((long)(0)));
            this.ctlAlarmClock1.ClockBackColor = System.Drawing.Color.Empty;
            this.ctlAlarmClock1.ClockForeColor = System.Drawing.Color.Empty;
            this.ctlAlarmClock1.Location = new System.Drawing.Point(0, 0);
            this.ctlAlarmClock1.Name = "ctlAlarmClock1";
            this.ctlAlarmClock1.Size = new System.Drawing.Size(374, 282);
            this.ctlAlarmClock1.TabIndex = 0;
            // 
            // dtpTest
            // 
            this.dtpTest.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTest.Location = new System.Drawing.Point(84, 12);
            this.dtpTest.Name = "dtpTest";
            this.dtpTest.Size = new System.Drawing.Size(200, 20);
            this.dtpTest.TabIndex = 1;
            this.dtpTest.ValueChanged += new System.EventHandler(this.dtpTest_ValueChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(164, 45);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 284);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.dtpTest);
            this.Controls.Add(this.ctlAlarmClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctlClockLib.ctlAlarmClock ctlAlarmClock1;
        private System.Windows.Forms.DateTimePicker dtpTest;
        private System.Windows.Forms.Label lblTest;
    }
}

