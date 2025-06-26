namespace WinformsAndADONet
{
    partial class frmNuevoCliente
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
            groupBox1 = new GroupBox();
            txtCustomerID = new TextBox();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtpOrderDate = new DateTimePicker();
            numOrderAmount = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btnCreateAccount = new Button();
            btnPlaceOrder = new Button();
            btnAddAnotherAccount = new Button();
            btnAddFinish = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar cuenta";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(219, 78);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(197, 31);
            txtCustomerID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(193, 23);
            label2.TabIndex = 2;
            label2.Text = "Identificador del cliente:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(184, 30);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(232, 31);
            txtCustomerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre del cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpOrderDate);
            groupBox2.Controls.Add(numOrderAmount);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(30, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(500, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crear pedido";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpOrderDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(166, 79);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 30);
            dtpOrderDate.TabIndex = 5;
            // 
            // numOrderAmount
            // 
            numOrderAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numOrderAmount.Location = new Point(219, 30);
            numOrderAmount.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numOrderAmount.Name = "numOrderAmount";
            numOrderAmount.Size = new Size(197, 30);
            numOrderAmount.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 86);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 2;
            label3.Text = "Fecha del pedido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 38);
            label4.Name = "label4";
            label4.Size = new Size(165, 23);
            label4.TabIndex = 0;
            label4.Text = "Cantidad de pedido:";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(566, 127);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(142, 29);
            btnCreateAccount.TabIndex = 5;
            btnCreateAccount.Text = "Crear cuenta";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(566, 288);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(142, 29);
            btnPlaceOrder.TabIndex = 6;
            btnPlaceOrder.Text = "Realizar pedido";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnAddAnotherAccount
            // 
            btnAddAnotherAccount.Location = new Point(450, 372);
            btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            btnAddAnotherAccount.Size = new Size(210, 29);
            btnAddAnotherAccount.TabIndex = 7;
            btnAddAnotherAccount.Text = "Agregar otra cuenta";
            btnAddAnotherAccount.UseVisualStyleBackColor = true;
            btnAddAnotherAccount.Click += btnAddAnotherAccount_Click;
            // 
            // btnAddFinish
            // 
            btnAddFinish.Location = new Point(30, 372);
            btnAddFinish.Name = "btnAddFinish";
            btnAddFinish.Size = new Size(94, 29);
            btnAddFinish.TabIndex = 8;
            btnAddFinish.Text = "Finalizar";
            btnAddFinish.UseVisualStyleBackColor = true;
            btnAddFinish.Click += btnAddFinish_Click;
            // 
            // frmNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddFinish);
            Controls.Add(btnAddAnotherAccount);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnCreateAccount);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNuevoCliente";
            Text = "Cuenta y pedidos nuevos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCustomerID;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dtpOrderDate;
        private NumericUpDown numOrderAmount;
        private Label label3;
        private Label label4;
        private Button btnCreateAccount;
        private Button btnPlaceOrder;
        private Button btnAddAnotherAccount;
        private Button btnAddFinish;
    }
}