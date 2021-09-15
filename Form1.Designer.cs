namespace EjercicioSergioChavez
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.lbToquePantalla = new System.Windows.Forms.Label();
            this.tabAccountView = new System.Windows.Forms.TabPage();
            this.btnAccountContinuar = new System.Windows.Forms.Button();
            this.btnAccountCancelar = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnAccount1 = new System.Windows.Forms.Button();
            this.btnAccountBuscarNumeroCuenta = new System.Windows.Forms.Button();
            this.txtAccountNumeroCuenta = new System.Windows.Forms.TextBox();
            this.lbIngreseNumCuenta = new System.Windows.Forms.Label();
            this.tabBalanceView = new System.Windows.Forms.TabPage();
            this.btnBalancePagar = new System.Windows.Forms.Button();
            this.btnBalanceVolver = new System.Windows.Forms.Button();
            this.lbBalanceDeuda = new System.Windows.Forms.Label();
            this.lbBalanceTituloDeuda = new System.Windows.Forms.Label();
            this.lbBalanceUsuario = new System.Windows.Forms.Label();
            this.lbBalanceTituloUsuario = new System.Windows.Forms.Label();
            this.lbBalanceNumeroCuenta = new System.Windows.Forms.Label();
            this.lbBalanceTituloCuenta = new System.Windows.Forms.Label();
            this.tabPaymentView = new System.Windows.Forms.TabPage();
            this.btnPaymentCancelar = new System.Windows.Forms.Button();
            this.btnPaymentAbonar = new System.Windows.Forms.Button();
            this.btnPayment50Centavos = new System.Windows.Forms.Button();
            this.btnPayment1 = new System.Windows.Forms.Button();
            this.btnPayment2 = new System.Windows.Forms.Button();
            this.btnPayment5 = new System.Windows.Forms.Button();
            this.btnPayment10 = new System.Windows.Forms.Button();
            this.btnPayment20 = new System.Windows.Forms.Button();
            this.btnPayment50 = new System.Windows.Forms.Button();
            this.btnPayment100 = new System.Windows.Forms.Button();
            this.btnPayment200 = new System.Windows.Forms.Button();
            this.btnPayment500 = new System.Windows.Forms.Button();
            this.lbPaymentRestante = new System.Windows.Forms.Label();
            this.lbPaymentTituloRestante = new System.Windows.Forms.Label();
            this.lbPaymentDepositado = new System.Windows.Forms.Label();
            this.lbPaymentTituloDepositado = new System.Windows.Forms.Label();
            this.lbPaymentDeuda = new System.Windows.Forms.Label();
            this.lbPaymentTituloDeuda = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMostrarBaseDatos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.tabAccountView.SuspendLayout();
            this.tabBalanceView.SuspendLayout();
            this.tabPaymentView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWelcome);
            this.tabControl1.Controls.Add(this.tabAccountView);
            this.tabControl1.Controls.Add(this.tabBalanceView);
            this.tabControl1.Controls.Add(this.tabPaymentView);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(14, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 660);
            this.tabControl1.TabIndex = 0;
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.lbToquePantalla);
            this.tabWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabWelcome.Location = new System.Drawing.Point(4, 29);
            this.tabWelcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabWelcome.Size = new System.Drawing.Size(1078, 627);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            this.tabWelcome.Click += new System.EventHandler(this.tabWelcome_Click);
            // 
            // lbToquePantalla
            // 
            this.lbToquePantalla.AutoSize = true;
            this.lbToquePantalla.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToquePantalla.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbToquePantalla.Location = new System.Drawing.Point(177, 231);
            this.lbToquePantalla.Name = "lbToquePantalla";
            this.lbToquePantalla.Size = new System.Drawing.Size(708, 55);
            this.lbToquePantalla.TabIndex = 0;
            this.lbToquePantalla.Text = "Toque la pantalla para iniciar";
            this.lbToquePantalla.Click += new System.EventHandler(this.tabWelcome_Click);
            // 
            // tabAccountView
            // 
            this.tabAccountView.Controls.Add(this.btnAccountContinuar);
            this.tabAccountView.Controls.Add(this.btnAccountCancelar);
            this.tabAccountView.Controls.Add(this.btn0);
            this.tabAccountView.Controls.Add(this.btn9);
            this.tabAccountView.Controls.Add(this.btn8);
            this.tabAccountView.Controls.Add(this.btn7);
            this.tabAccountView.Controls.Add(this.btn6);
            this.tabAccountView.Controls.Add(this.btn5);
            this.tabAccountView.Controls.Add(this.btn4);
            this.tabAccountView.Controls.Add(this.btn3);
            this.tabAccountView.Controls.Add(this.btn2);
            this.tabAccountView.Controls.Add(this.btnAccount1);
            this.tabAccountView.Controls.Add(this.btnAccountBuscarNumeroCuenta);
            this.tabAccountView.Controls.Add(this.txtAccountNumeroCuenta);
            this.tabAccountView.Controls.Add(this.lbIngreseNumCuenta);
            this.tabAccountView.Location = new System.Drawing.Point(4, 29);
            this.tabAccountView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAccountView.Name = "tabAccountView";
            this.tabAccountView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAccountView.Size = new System.Drawing.Size(1078, 627);
            this.tabAccountView.TabIndex = 1;
            this.tabAccountView.Text = "Account View";
            this.tabAccountView.UseVisualStyleBackColor = true;
            // 
            // btnAccountContinuar
            // 
            this.btnAccountContinuar.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountContinuar.Location = new System.Drawing.Point(807, 526);
            this.btnAccountContinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccountContinuar.Name = "btnAccountContinuar";
            this.btnAccountContinuar.Size = new System.Drawing.Size(237, 79);
            this.btnAccountContinuar.TabIndex = 14;
            this.btnAccountContinuar.Text = "Continuar >";
            this.btnAccountContinuar.UseVisualStyleBackColor = true;
            this.btnAccountContinuar.Click += new System.EventHandler(this.btnAccountContinuar_Click);
            // 
            // btnAccountCancelar
            // 
            this.btnAccountCancelar.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountCancelar.Location = new System.Drawing.Point(39, 526);
            this.btnAccountCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccountCancelar.Name = "btnAccountCancelar";
            this.btnAccountCancelar.Size = new System.Drawing.Size(237, 79);
            this.btnAccountCancelar.TabIndex = 13;
            this.btnAccountCancelar.Text = "< Cancelar";
            this.btnAccountCancelar.UseVisualStyleBackColor = true;
            this.btnAccountCancelar.Click += new System.EventHandler(this.btnAccountCancelar_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(375, 545);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(192, 60);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(588, 458);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(84, 60);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(482, 458);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(84, 60);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(375, 458);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(84, 60);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(588, 365);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(84, 60);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(482, 365);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(84, 60);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(375, 365);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(84, 60);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(588, 265);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 60);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(482, 265);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 60);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnAccount1
            // 
            this.btnAccount1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount1.Location = new System.Drawing.Point(375, 265);
            this.btnAccount1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccount1.Name = "btnAccount1";
            this.btnAccount1.Size = new System.Drawing.Size(84, 60);
            this.btnAccount1.TabIndex = 3;
            this.btnAccount1.Text = "1";
            this.btnAccount1.UseVisualStyleBackColor = true;
            this.btnAccount1.Click += new System.EventHandler(this.btnAccount1_Click);
            // 
            // btnAccountBuscarNumeroCuenta
            // 
            this.btnAccountBuscarNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountBuscarNumeroCuenta.Location = new System.Drawing.Point(712, 161);
            this.btnAccountBuscarNumeroCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccountBuscarNumeroCuenta.Name = "btnAccountBuscarNumeroCuenta";
            this.btnAccountBuscarNumeroCuenta.Size = new System.Drawing.Size(84, 68);
            this.btnAccountBuscarNumeroCuenta.TabIndex = 2;
            this.btnAccountBuscarNumeroCuenta.Text = "←";
            this.btnAccountBuscarNumeroCuenta.UseVisualStyleBackColor = true;
            this.btnAccountBuscarNumeroCuenta.Click += new System.EventHandler(this.btnAccountBuscarNumeroCuenta_Click);
            // 
            // txtAccountNumeroCuenta
            // 
            this.txtAccountNumeroCuenta.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumeroCuenta.Location = new System.Drawing.Point(201, 161);
            this.txtAccountNumeroCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountNumeroCuenta.Name = "txtAccountNumeroCuenta";
            this.txtAccountNumeroCuenta.Size = new System.Drawing.Size(471, 69);
            this.txtAccountNumeroCuenta.TabIndex = 1;
            this.txtAccountNumeroCuenta.Text = "Número de cuenta...";
            this.txtAccountNumeroCuenta.TextChanged += new System.EventHandler(this.txtAccountNumeroCuenta_TextChanged);
            this.txtAccountNumeroCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNumeroCuenta_KeyPress);
            // 
            // lbIngreseNumCuenta
            // 
            this.lbIngreseNumCuenta.AutoSize = true;
            this.lbIngreseNumCuenta.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseNumCuenta.Location = new System.Drawing.Point(189, 58);
            this.lbIngreseNumCuenta.Name = "lbIngreseNumCuenta";
            this.lbIngreseNumCuenta.Size = new System.Drawing.Size(706, 67);
            this.lbIngreseNumCuenta.TabIndex = 0;
            this.lbIngreseNumCuenta.Text = "Ingrese su número de cuenta";
            // 
            // tabBalanceView
            // 
            this.tabBalanceView.Controls.Add(this.btnBalancePagar);
            this.tabBalanceView.Controls.Add(this.btnBalanceVolver);
            this.tabBalanceView.Controls.Add(this.lbBalanceDeuda);
            this.tabBalanceView.Controls.Add(this.lbBalanceTituloDeuda);
            this.tabBalanceView.Controls.Add(this.lbBalanceUsuario);
            this.tabBalanceView.Controls.Add(this.lbBalanceTituloUsuario);
            this.tabBalanceView.Controls.Add(this.lbBalanceNumeroCuenta);
            this.tabBalanceView.Controls.Add(this.lbBalanceTituloCuenta);
            this.tabBalanceView.Location = new System.Drawing.Point(4, 29);
            this.tabBalanceView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBalanceView.Name = "tabBalanceView";
            this.tabBalanceView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBalanceView.Size = new System.Drawing.Size(1078, 627);
            this.tabBalanceView.TabIndex = 2;
            this.tabBalanceView.Text = "Balance View";
            this.tabBalanceView.UseVisualStyleBackColor = true;
            // 
            // btnBalancePagar
            // 
            this.btnBalancePagar.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalancePagar.Location = new System.Drawing.Point(804, 515);
            this.btnBalancePagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBalancePagar.Name = "btnBalancePagar";
            this.btnBalancePagar.Size = new System.Drawing.Size(237, 79);
            this.btnBalancePagar.TabIndex = 15;
            this.btnBalancePagar.Text = "Pagar >";
            this.btnBalancePagar.UseVisualStyleBackColor = true;
            this.btnBalancePagar.Click += new System.EventHandler(this.btnBalancePagar_Click);
            // 
            // btnBalanceVolver
            // 
            this.btnBalanceVolver.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceVolver.Location = new System.Drawing.Point(36, 515);
            this.btnBalanceVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBalanceVolver.Name = "btnBalanceVolver";
            this.btnBalanceVolver.Size = new System.Drawing.Size(237, 79);
            this.btnBalanceVolver.TabIndex = 14;
            this.btnBalanceVolver.Text = "< Volver";
            this.btnBalanceVolver.UseVisualStyleBackColor = true;
            this.btnBalanceVolver.Click += new System.EventHandler(this.btnBalanceVolver_Click);
            // 
            // lbBalanceDeuda
            // 
            this.lbBalanceDeuda.AutoSize = true;
            this.lbBalanceDeuda.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceDeuda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbBalanceDeuda.Location = new System.Drawing.Point(431, 411);
            this.lbBalanceDeuda.Name = "lbBalanceDeuda";
            this.lbBalanceDeuda.Size = new System.Drawing.Size(128, 50);
            this.lbBalanceDeuda.TabIndex = 5;
            this.lbBalanceDeuda.Text = "Deuda";
            // 
            // lbBalanceTituloDeuda
            // 
            this.lbBalanceTituloDeuda.AutoSize = true;
            this.lbBalanceTituloDeuda.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceTituloDeuda.Location = new System.Drawing.Point(431, 342);
            this.lbBalanceTituloDeuda.Name = "lbBalanceTituloDeuda";
            this.lbBalanceTituloDeuda.Size = new System.Drawing.Size(126, 51);
            this.lbBalanceTituloDeuda.TabIndex = 4;
            this.lbBalanceTituloDeuda.Text = "Deuda";
            // 
            // lbBalanceUsuario
            // 
            this.lbBalanceUsuario.AutoSize = true;
            this.lbBalanceUsuario.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbBalanceUsuario.Location = new System.Drawing.Point(420, 252);
            this.lbBalanceUsuario.Name = "lbBalanceUsuario";
            this.lbBalanceUsuario.Size = new System.Drawing.Size(152, 50);
            this.lbBalanceUsuario.TabIndex = 3;
            this.lbBalanceUsuario.Text = "Usuario";
            // 
            // lbBalanceTituloUsuario
            // 
            this.lbBalanceTituloUsuario.AutoSize = true;
            this.lbBalanceTituloUsuario.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceTituloUsuario.Location = new System.Drawing.Point(420, 182);
            this.lbBalanceTituloUsuario.Name = "lbBalanceTituloUsuario";
            this.lbBalanceTituloUsuario.Size = new System.Drawing.Size(150, 51);
            this.lbBalanceTituloUsuario.TabIndex = 2;
            this.lbBalanceTituloUsuario.Text = "Usuario";
            // 
            // lbBalanceNumeroCuenta
            // 
            this.lbBalanceNumeroCuenta.AutoSize = true;
            this.lbBalanceNumeroCuenta.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceNumeroCuenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbBalanceNumeroCuenta.Location = new System.Drawing.Point(420, 102);
            this.lbBalanceNumeroCuenta.Name = "lbBalanceNumeroCuenta";
            this.lbBalanceNumeroCuenta.Size = new System.Drawing.Size(139, 50);
            this.lbBalanceNumeroCuenta.TabIndex = 1;
            this.lbBalanceNumeroCuenta.Text = "Cuenta";
            // 
            // lbBalanceTituloCuenta
            // 
            this.lbBalanceTituloCuenta.AutoSize = true;
            this.lbBalanceTituloCuenta.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceTituloCuenta.Location = new System.Drawing.Point(420, 35);
            this.lbBalanceTituloCuenta.Name = "lbBalanceTituloCuenta";
            this.lbBalanceTituloCuenta.Size = new System.Drawing.Size(137, 51);
            this.lbBalanceTituloCuenta.TabIndex = 0;
            this.lbBalanceTituloCuenta.Text = "Cuenta";
            // 
            // tabPaymentView
            // 
            this.tabPaymentView.Controls.Add(this.btnPaymentCancelar);
            this.tabPaymentView.Controls.Add(this.btnPaymentAbonar);
            this.tabPaymentView.Controls.Add(this.btnPayment50Centavos);
            this.tabPaymentView.Controls.Add(this.btnPayment1);
            this.tabPaymentView.Controls.Add(this.btnPayment2);
            this.tabPaymentView.Controls.Add(this.btnPayment5);
            this.tabPaymentView.Controls.Add(this.btnPayment10);
            this.tabPaymentView.Controls.Add(this.btnPayment20);
            this.tabPaymentView.Controls.Add(this.btnPayment50);
            this.tabPaymentView.Controls.Add(this.btnPayment100);
            this.tabPaymentView.Controls.Add(this.btnPayment200);
            this.tabPaymentView.Controls.Add(this.btnPayment500);
            this.tabPaymentView.Controls.Add(this.lbPaymentRestante);
            this.tabPaymentView.Controls.Add(this.lbPaymentTituloRestante);
            this.tabPaymentView.Controls.Add(this.lbPaymentDepositado);
            this.tabPaymentView.Controls.Add(this.lbPaymentTituloDepositado);
            this.tabPaymentView.Controls.Add(this.lbPaymentDeuda);
            this.tabPaymentView.Controls.Add(this.lbPaymentTituloDeuda);
            this.tabPaymentView.Location = new System.Drawing.Point(4, 29);
            this.tabPaymentView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPaymentView.Name = "tabPaymentView";
            this.tabPaymentView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPaymentView.Size = new System.Drawing.Size(1078, 627);
            this.tabPaymentView.TabIndex = 3;
            this.tabPaymentView.Text = "Payment View";
            this.tabPaymentView.UseVisualStyleBackColor = true;
            // 
            // btnPaymentCancelar
            // 
            this.btnPaymentCancelar.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentCancelar.Location = new System.Drawing.Point(39, 502);
            this.btnPaymentCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaymentCancelar.Name = "btnPaymentCancelar";
            this.btnPaymentCancelar.Size = new System.Drawing.Size(237, 79);
            this.btnPaymentCancelar.TabIndex = 23;
            this.btnPaymentCancelar.Text = "< Cancelar";
            this.btnPaymentCancelar.UseVisualStyleBackColor = true;
            this.btnPaymentCancelar.Click += new System.EventHandler(this.btnPaymentCancelar_Click);
            // 
            // btnPaymentAbonar
            // 
            this.btnPaymentAbonar.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentAbonar.Location = new System.Drawing.Point(795, 502);
            this.btnPaymentAbonar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaymentAbonar.Name = "btnPaymentAbonar";
            this.btnPaymentAbonar.Size = new System.Drawing.Size(237, 79);
            this.btnPaymentAbonar.TabIndex = 22;
            this.btnPaymentAbonar.Text = "Abonar >";
            this.btnPaymentAbonar.UseVisualStyleBackColor = true;
            this.btnPaymentAbonar.Click += new System.EventHandler(this.btnPaymentAbonar_Click);
            // 
            // btnPayment50Centavos
            // 
            this.btnPayment50Centavos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment50Centavos.FlatAppearance.BorderSize = 3;
            this.btnPayment50Centavos.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment50Centavos.Location = new System.Drawing.Point(762, 369);
            this.btnPayment50Centavos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment50Centavos.Name = "btnPayment50Centavos";
            this.btnPayment50Centavos.Size = new System.Drawing.Size(109, 55);
            this.btnPayment50Centavos.TabIndex = 21;
            this.btnPayment50Centavos.Text = "¢ 50";
            this.btnPayment50Centavos.UseVisualStyleBackColor = true;
            this.btnPayment50Centavos.Click += new System.EventHandler(this.btnPayment50Centavos_Click);
            // 
            // btnPayment1
            // 
            this.btnPayment1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment1.FlatAppearance.BorderSize = 3;
            this.btnPayment1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment1.Location = new System.Drawing.Point(613, 369);
            this.btnPayment1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment1.Name = "btnPayment1";
            this.btnPayment1.Size = new System.Drawing.Size(109, 55);
            this.btnPayment1.TabIndex = 20;
            this.btnPayment1.Text = "$1";
            this.btnPayment1.UseVisualStyleBackColor = true;
            this.btnPayment1.Click += new System.EventHandler(this.btnPayment1_Click);
            // 
            // btnPayment2
            // 
            this.btnPayment2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment2.FlatAppearance.BorderSize = 3;
            this.btnPayment2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment2.Location = new System.Drawing.Point(456, 369);
            this.btnPayment2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment2.Name = "btnPayment2";
            this.btnPayment2.Size = new System.Drawing.Size(109, 55);
            this.btnPayment2.TabIndex = 19;
            this.btnPayment2.Text = "$ 2";
            this.btnPayment2.UseVisualStyleBackColor = true;
            this.btnPayment2.Click += new System.EventHandler(this.btnPayment2_Click);
            // 
            // btnPayment5
            // 
            this.btnPayment5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment5.FlatAppearance.BorderSize = 3;
            this.btnPayment5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment5.Location = new System.Drawing.Point(305, 369);
            this.btnPayment5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment5.Name = "btnPayment5";
            this.btnPayment5.Size = new System.Drawing.Size(109, 55);
            this.btnPayment5.TabIndex = 18;
            this.btnPayment5.Text = "$ 5";
            this.btnPayment5.UseVisualStyleBackColor = true;
            this.btnPayment5.Click += new System.EventHandler(this.btnPayment5_Click);
            // 
            // btnPayment10
            // 
            this.btnPayment10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment10.FlatAppearance.BorderSize = 3;
            this.btnPayment10.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment10.Location = new System.Drawing.Point(152, 369);
            this.btnPayment10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment10.Name = "btnPayment10";
            this.btnPayment10.Size = new System.Drawing.Size(109, 55);
            this.btnPayment10.TabIndex = 17;
            this.btnPayment10.Text = "$ 10";
            this.btnPayment10.UseVisualStyleBackColor = true;
            this.btnPayment10.Click += new System.EventHandler(this.btnPayment10_Click);
            // 
            // btnPayment20
            // 
            this.btnPayment20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment20.FlatAppearance.BorderSize = 3;
            this.btnPayment20.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment20.Location = new System.Drawing.Point(762, 279);
            this.btnPayment20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment20.Name = "btnPayment20";
            this.btnPayment20.Size = new System.Drawing.Size(109, 55);
            this.btnPayment20.TabIndex = 16;
            this.btnPayment20.Text = "$ 20.00";
            this.btnPayment20.UseVisualStyleBackColor = true;
            this.btnPayment20.Click += new System.EventHandler(this.btnPayment20_Click);
            // 
            // btnPayment50
            // 
            this.btnPayment50.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment50.FlatAppearance.BorderSize = 3;
            this.btnPayment50.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment50.Location = new System.Drawing.Point(613, 279);
            this.btnPayment50.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment50.Name = "btnPayment50";
            this.btnPayment50.Size = new System.Drawing.Size(109, 55);
            this.btnPayment50.TabIndex = 15;
            this.btnPayment50.Text = "$50.00";
            this.btnPayment50.UseVisualStyleBackColor = true;
            this.btnPayment50.Click += new System.EventHandler(this.btnPayment50_Click);
            // 
            // btnPayment100
            // 
            this.btnPayment100.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment100.FlatAppearance.BorderSize = 3;
            this.btnPayment100.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment100.Location = new System.Drawing.Point(456, 279);
            this.btnPayment100.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment100.Name = "btnPayment100";
            this.btnPayment100.Size = new System.Drawing.Size(123, 55);
            this.btnPayment100.TabIndex = 14;
            this.btnPayment100.Text = "$ 100.00";
            this.btnPayment100.UseVisualStyleBackColor = true;
            this.btnPayment100.Click += new System.EventHandler(this.btnPayment100_Click);
            // 
            // btnPayment200
            // 
            this.btnPayment200.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment200.FlatAppearance.BorderSize = 3;
            this.btnPayment200.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment200.Location = new System.Drawing.Point(305, 279);
            this.btnPayment200.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment200.Name = "btnPayment200";
            this.btnPayment200.Size = new System.Drawing.Size(125, 55);
            this.btnPayment200.TabIndex = 13;
            this.btnPayment200.Text = "$ 200.00";
            this.btnPayment200.UseVisualStyleBackColor = true;
            this.btnPayment200.Click += new System.EventHandler(this.btnPayment200_Click);
            // 
            // btnPayment500
            // 
            this.btnPayment500.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayment500.FlatAppearance.BorderSize = 3;
            this.btnPayment500.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment500.Location = new System.Drawing.Point(152, 279);
            this.btnPayment500.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayment500.Name = "btnPayment500";
            this.btnPayment500.Size = new System.Drawing.Size(125, 55);
            this.btnPayment500.TabIndex = 12;
            this.btnPayment500.Text = "$ 500.00";
            this.btnPayment500.UseVisualStyleBackColor = true;
            this.btnPayment500.Click += new System.EventHandler(this.btnPayment500_Click);
            // 
            // lbPaymentRestante
            // 
            this.lbPaymentRestante.AutoSize = true;
            this.lbPaymentRestante.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentRestante.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPaymentRestante.Location = new System.Drawing.Point(788, 162);
            this.lbPaymentRestante.Name = "lbPaymentRestante";
            this.lbPaymentRestante.Size = new System.Drawing.Size(176, 50);
            this.lbPaymentRestante.TabIndex = 11;
            this.lbPaymentRestante.Text = "Restante";
            // 
            // lbPaymentTituloRestante
            // 
            this.lbPaymentTituloRestante.AutoSize = true;
            this.lbPaymentTituloRestante.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentTituloRestante.Location = new System.Drawing.Point(788, 94);
            this.lbPaymentTituloRestante.Name = "lbPaymentTituloRestante";
            this.lbPaymentTituloRestante.Size = new System.Drawing.Size(174, 51);
            this.lbPaymentTituloRestante.TabIndex = 10;
            this.lbPaymentTituloRestante.Text = "Restante";
            // 
            // lbPaymentDepositado
            // 
            this.lbPaymentDepositado.AutoSize = true;
            this.lbPaymentDepositado.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentDepositado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPaymentDepositado.Location = new System.Drawing.Point(449, 162);
            this.lbPaymentDepositado.Name = "lbPaymentDepositado";
            this.lbPaymentDepositado.Size = new System.Drawing.Size(211, 50);
            this.lbPaymentDepositado.TabIndex = 9;
            this.lbPaymentDepositado.Text = "Depositado";
            // 
            // lbPaymentTituloDepositado
            // 
            this.lbPaymentTituloDepositado.AutoSize = true;
            this.lbPaymentTituloDepositado.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentTituloDepositado.Location = new System.Drawing.Point(449, 94);
            this.lbPaymentTituloDepositado.Name = "lbPaymentTituloDepositado";
            this.lbPaymentTituloDepositado.Size = new System.Drawing.Size(209, 51);
            this.lbPaymentTituloDepositado.TabIndex = 8;
            this.lbPaymentTituloDepositado.Text = "Depositado";
            // 
            // lbPaymentDeuda
            // 
            this.lbPaymentDeuda.AutoSize = true;
            this.lbPaymentDeuda.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentDeuda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPaymentDeuda.Location = new System.Drawing.Point(140, 162);
            this.lbPaymentDeuda.Name = "lbPaymentDeuda";
            this.lbPaymentDeuda.Size = new System.Drawing.Size(128, 50);
            this.lbPaymentDeuda.TabIndex = 7;
            this.lbPaymentDeuda.Text = "Deuda";
            // 
            // lbPaymentTituloDeuda
            // 
            this.lbPaymentTituloDeuda.AutoSize = true;
            this.lbPaymentTituloDeuda.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentTituloDeuda.Location = new System.Drawing.Point(140, 94);
            this.lbPaymentTituloDeuda.Name = "lbPaymentTituloDeuda";
            this.lbPaymentTituloDeuda.Size = new System.Drawing.Size(126, 51);
            this.lbPaymentTituloDeuda.TabIndex = 6;
            this.lbPaymentTituloDeuda.Text = "Deuda";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnMostrarBaseDatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 627);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "See Database";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMostrarBaseDatos
            // 
            this.btnMostrarBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarBaseDatos.Location = new System.Drawing.Point(33, 21);
            this.btnMostrarBaseDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMostrarBaseDatos.Name = "btnMostrarBaseDatos";
            this.btnMostrarBaseDatos.Size = new System.Drawing.Size(192, 68);
            this.btnMostrarBaseDatos.TabIndex = 2;
            this.btnMostrarBaseDatos.Text = "Show Info";
            this.btnMostrarBaseDatos.UseVisualStyleBackColor = true;
            this.btnMostrarBaseDatos.Click += new System.EventHandler(this.btnMostrarBaseDatos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 233);
            this.dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(792, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 75);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 689);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.tabWelcome.PerformLayout();
            this.tabAccountView.ResumeLayout(false);
            this.tabAccountView.PerformLayout();
            this.tabBalanceView.ResumeLayout(false);
            this.tabBalanceView.PerformLayout();
            this.tabPaymentView.ResumeLayout(false);
            this.tabPaymentView.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabAccountView;
        private System.Windows.Forms.Label lbToquePantalla;
        private System.Windows.Forms.TabPage tabBalanceView;
        private System.Windows.Forms.TabPage tabPaymentView;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnAccount1;
        private System.Windows.Forms.Button btnAccountBuscarNumeroCuenta;
        private System.Windows.Forms.TextBox txtAccountNumeroCuenta;
        private System.Windows.Forms.Label lbIngreseNumCuenta;
        private System.Windows.Forms.Button btnAccountContinuar;
        private System.Windows.Forms.Button btnAccountCancelar;
        private System.Windows.Forms.Button btnBalancePagar;
        private System.Windows.Forms.Button btnBalanceVolver;
        private System.Windows.Forms.Label lbBalanceDeuda;
        private System.Windows.Forms.Label lbBalanceTituloDeuda;
        private System.Windows.Forms.Label lbBalanceUsuario;
        private System.Windows.Forms.Label lbBalanceTituloUsuario;
        private System.Windows.Forms.Label lbBalanceNumeroCuenta;
        private System.Windows.Forms.Label lbBalanceTituloCuenta;
        private System.Windows.Forms.Button btnPayment500;
        private System.Windows.Forms.Label lbPaymentRestante;
        private System.Windows.Forms.Label lbPaymentTituloRestante;
        private System.Windows.Forms.Label lbPaymentDepositado;
        private System.Windows.Forms.Label lbPaymentTituloDepositado;
        private System.Windows.Forms.Label lbPaymentDeuda;
        private System.Windows.Forms.Label lbPaymentTituloDeuda;
        private System.Windows.Forms.Button btnPayment20;
        private System.Windows.Forms.Button btnPayment50;
        private System.Windows.Forms.Button btnPayment100;
        private System.Windows.Forms.Button btnPayment200;
        private System.Windows.Forms.Button btnPayment50Centavos;
        private System.Windows.Forms.Button btnPayment1;
        private System.Windows.Forms.Button btnPayment2;
        private System.Windows.Forms.Button btnPayment5;
        private System.Windows.Forms.Button btnPayment10;
        private System.Windows.Forms.Button btnPaymentCancelar;
        private System.Windows.Forms.Button btnPaymentAbonar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrarBaseDatos;
        private System.Windows.Forms.Button button2;
    }
}

