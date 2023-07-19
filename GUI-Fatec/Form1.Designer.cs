namespace GUI_Fatec
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btConectar = new System.Windows.Forms.Button();
            this.btDesconectar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.cbBoxBaud = new System.Windows.Forms.ComboBox();
            this.lbStatusConect = new System.Windows.Forms.Label();
            this.panelMessageConect = new System.Windows.Forms.Panel();
            this.panelConectControl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEnviar = new System.Windows.Forms.TextBox();
            this.textBoxReceber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btEnviar = new System.Windows.Forms.Button();
            this.btCleanReception = new System.Windows.Forms.Button();
            this.checkBoxReception = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btRD0 = new System.Windows.Forms.Button();
            this.btRD5 = new System.Windows.Forms.Button();
            this.btRD6 = new System.Windows.Forms.Button();
            this.btRD7 = new System.Windows.Forms.Button();
            this.btRD4 = new System.Windows.Forms.Button();
            this.btRD3 = new System.Windows.Forms.Button();
            this.btRD2 = new System.Windows.Forms.Button();
            this.btRD1 = new System.Windows.Forms.Button();
            this.labelRD0 = new System.Windows.Forms.Label();
            this.labelRD5 = new System.Windows.Forms.Label();
            this.labelRD6 = new System.Windows.Forms.Label();
            this.labelRD4 = new System.Windows.Forms.Label();
            this.labelRD7 = new System.Windows.Forms.Label();
            this.labelRD3 = new System.Windows.Forms.Label();
            this.labelRD2 = new System.Windows.Forms.Label();
            this.labelRD1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btAN0 = new System.Windows.Forms.Button();
            this.textBoxAN0 = new System.Windows.Forms.TextBox();
            this.checkBoxAN0 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxPWM1 = new System.Windows.Forms.CheckBox();
            this.checkBoxPWM2 = new System.Windows.Forms.CheckBox();
            this.labelPWM1 = new System.Windows.Forms.Label();
            this.labelPWM2 = new System.Windows.Forms.Label();
            this.trackBarPWM1 = new System.Windows.Forms.TrackBar();
            this.trackBarPWM2 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panelMessageConect.SuspendLayout();
            this.panelConectControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(34, 137);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(133, 50);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // btDesconectar
            // 
            this.btDesconectar.Location = new System.Drawing.Point(173, 137);
            this.btDesconectar.Name = "btDesconectar";
            this.btDesconectar.Size = new System.Drawing.Size(133, 50);
            this.btDesconectar.TabIndex = 1;
            this.btDesconectar.Text = "Desconectar";
            this.btDesconectar.UseVisualStyleBackColor = true;
            this.btDesconectar.Click += new System.EventHandler(this.btDesconectar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(34, 193);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(272, 43);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair da IHM";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Porta COM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(96, 56);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(83, 21);
            this.cbBoxPort.TabIndex = 5;
            // 
            // cbBoxBaud
            // 
            this.cbBoxBaud.FormattingEnabled = true;
            this.cbBoxBaud.Location = new System.Drawing.Point(96, 91);
            this.cbBoxBaud.Name = "cbBoxBaud";
            this.cbBoxBaud.Size = new System.Drawing.Size(83, 21);
            this.cbBoxBaud.TabIndex = 6;
            // 
            // lbStatusConect
            // 
            this.lbStatusConect.Location = new System.Drawing.Point(23, 25);
            this.lbStatusConect.Name = "lbStatusConect";
            this.lbStatusConect.Size = new System.Drawing.Size(112, 20);
            this.lbStatusConect.TabIndex = 7;
            this.lbStatusConect.Text = "Aguardando Conexão";
            // 
            // panelMessageConect
            // 
            this.panelMessageConect.BackColor = System.Drawing.Color.Azure;
            this.panelMessageConect.Controls.Add(this.lbStatusConect);
            this.panelMessageConect.Location = new System.Drawing.Point(96, 262);
            this.panelMessageConect.Name = "panelMessageConect";
            this.panelMessageConect.Size = new System.Drawing.Size(155, 70);
            this.panelMessageConect.TabIndex = 8;
            // 
            // panelConectControl
            // 
            this.panelConectControl.BackColor = System.Drawing.SystemColors.Info;
            this.panelConectControl.Controls.Add(this.label3);
            this.panelConectControl.Controls.Add(this.btDesconectar);
            this.panelConectControl.Controls.Add(this.panelMessageConect);
            this.panelConectControl.Controls.Add(this.btConectar);
            this.panelConectControl.Controls.Add(this.cbBoxBaud);
            this.panelConectControl.Controls.Add(this.btSair);
            this.panelConectControl.Controls.Add(this.cbBoxPort);
            this.panelConectControl.Controls.Add(this.label1);
            this.panelConectControl.Controls.Add(this.label2);
            this.panelConectControl.Location = new System.Drawing.Point(12, 12);
            this.panelConectControl.Name = "panelConectControl";
            this.panelConectControl.Size = new System.Drawing.Size(340, 352);
            this.panelConectControl.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(81, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Controle Conexão Serial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.checkBoxReception);
            this.panel1.Controls.Add(this.btCleanReception);
            this.panel1.Controls.Add(this.btEnviar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxReceber);
            this.panel1.Controls.Add(this.textBoxEnviar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(359, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 226);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(122, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Terminal Serial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Transmissão";
            // 
            // textBoxEnviar
            // 
            this.textBoxEnviar.Location = new System.Drawing.Point(50, 75);
            this.textBoxEnviar.Name = "textBoxEnviar";
            this.textBoxEnviar.Size = new System.Drawing.Size(258, 20);
            this.textBoxEnviar.TabIndex = 12;
            // 
            // textBoxReceber
            // 
            this.textBoxReceber.Location = new System.Drawing.Point(50, 136);
            this.textBoxReceber.Multiline = true;
            this.textBoxReceber.Name = "textBoxReceber";
            this.textBoxReceber.Size = new System.Drawing.Size(258, 50);
            this.textBoxReceber.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Recepção";
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(233, 101);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 15;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // btCleanReception
            // 
            this.btCleanReception.Location = new System.Drawing.Point(233, 192);
            this.btCleanReception.Name = "btCleanReception";
            this.btCleanReception.Size = new System.Drawing.Size(75, 23);
            this.btCleanReception.TabIndex = 16;
            this.btCleanReception.Text = "Limpar";
            this.btCleanReception.UseVisualStyleBackColor = true;
            this.btCleanReception.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxReception
            // 
            this.checkBoxReception.AutoSize = true;
            this.checkBoxReception.Location = new System.Drawing.Point(15, 197);
            this.checkBoxReception.Name = "checkBoxReception";
            this.checkBoxReception.Size = new System.Drawing.Size(114, 17);
            this.checkBoxReception.TabIndex = 17;
            this.checkBoxReception.Text = "Habilita Recepção";
            this.checkBoxReception.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.labelRD1);
            this.panel2.Controls.Add(this.labelRD2);
            this.panel2.Controls.Add(this.labelRD3);
            this.panel2.Controls.Add(this.labelRD7);
            this.panel2.Controls.Add(this.labelRD4);
            this.panel2.Controls.Add(this.labelRD6);
            this.panel2.Controls.Add(this.labelRD5);
            this.panel2.Controls.Add(this.labelRD0);
            this.panel2.Controls.Add(this.btRD1);
            this.panel2.Controls.Add(this.btRD2);
            this.panel2.Controls.Add(this.btRD3);
            this.panel2.Controls.Add(this.btRD4);
            this.panel2.Controls.Add(this.btRD7);
            this.panel2.Controls.Add(this.btRD6);
            this.panel2.Controls.Add(this.btRD5);
            this.panel2.Controls.Add(this.btRD0);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 249);
            this.panel2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(105, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "PORTD On/Off";
            // 
            // btRD0
            // 
            this.btRD0.Location = new System.Drawing.Point(15, 70);
            this.btRD0.Name = "btRD0";
            this.btRD0.Size = new System.Drawing.Size(41, 23);
            this.btRD0.TabIndex = 16;
            this.btRD0.Text = "RD0";
            this.btRD0.UseVisualStyleBackColor = true;
            this.btRD0.Click += new System.EventHandler(this.btRD0_Click);
            // 
            // btRD5
            // 
            this.btRD5.Location = new System.Drawing.Point(179, 113);
            this.btRD5.Name = "btRD5";
            this.btRD5.Size = new System.Drawing.Size(41, 23);
            this.btRD5.TabIndex = 17;
            this.btRD5.Text = "RD5";
            this.btRD5.UseVisualStyleBackColor = true;
            this.btRD5.Click += new System.EventHandler(this.btRD5_Click);
            // 
            // btRD6
            // 
            this.btRD6.Location = new System.Drawing.Point(179, 155);
            this.btRD6.Name = "btRD6";
            this.btRD6.Size = new System.Drawing.Size(41, 23);
            this.btRD6.TabIndex = 18;
            this.btRD6.Text = "RD6";
            this.btRD6.UseVisualStyleBackColor = true;
            this.btRD6.Click += new System.EventHandler(this.btRD6_Click);
            // 
            // btRD7
            // 
            this.btRD7.Location = new System.Drawing.Point(179, 199);
            this.btRD7.Name = "btRD7";
            this.btRD7.Size = new System.Drawing.Size(41, 23);
            this.btRD7.TabIndex = 19;
            this.btRD7.Text = "RD7";
            this.btRD7.UseVisualStyleBackColor = true;
            this.btRD7.Click += new System.EventHandler(this.btRD7_Click);
            // 
            // btRD4
            // 
            this.btRD4.Location = new System.Drawing.Point(179, 70);
            this.btRD4.Name = "btRD4";
            this.btRD4.Size = new System.Drawing.Size(41, 23);
            this.btRD4.TabIndex = 20;
            this.btRD4.Text = "RD4";
            this.btRD4.UseVisualStyleBackColor = true;
            this.btRD4.Click += new System.EventHandler(this.btRD4_Click);
            // 
            // btRD3
            // 
            this.btRD3.Location = new System.Drawing.Point(15, 199);
            this.btRD3.Name = "btRD3";
            this.btRD3.Size = new System.Drawing.Size(41, 23);
            this.btRD3.TabIndex = 21;
            this.btRD3.Text = "RD3";
            this.btRD3.UseVisualStyleBackColor = true;
            this.btRD3.Click += new System.EventHandler(this.btRD3_Click);
            // 
            // btRD2
            // 
            this.btRD2.Location = new System.Drawing.Point(15, 155);
            this.btRD2.Name = "btRD2";
            this.btRD2.Size = new System.Drawing.Size(41, 23);
            this.btRD2.TabIndex = 22;
            this.btRD2.Text = "RD2";
            this.btRD2.UseVisualStyleBackColor = true;
            this.btRD2.Click += new System.EventHandler(this.btRD2_Click);
            // 
            // btRD1
            // 
            this.btRD1.Location = new System.Drawing.Point(15, 113);
            this.btRD1.Name = "btRD1";
            this.btRD1.Size = new System.Drawing.Size(41, 23);
            this.btRD1.TabIndex = 23;
            this.btRD1.Text = "RD1";
            this.btRD1.UseVisualStyleBackColor = true;
            this.btRD1.Click += new System.EventHandler(this.btRD1_Click);
            // 
            // labelRD0
            // 
            this.labelRD0.AutoSize = true;
            this.labelRD0.BackColor = System.Drawing.Color.Yellow;
            this.labelRD0.Location = new System.Drawing.Point(66, 75);
            this.labelRD0.Name = "labelRD0";
            this.labelRD0.Size = new System.Drawing.Size(36, 13);
            this.labelRD0.TabIndex = 24;
            this.labelRD0.Text = "L0-Off";
            this.labelRD0.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelRD5
            // 
            this.labelRD5.AutoSize = true;
            this.labelRD5.BackColor = System.Drawing.Color.Yellow;
            this.labelRD5.Location = new System.Drawing.Point(239, 118);
            this.labelRD5.Name = "labelRD5";
            this.labelRD5.Size = new System.Drawing.Size(36, 13);
            this.labelRD5.TabIndex = 25;
            this.labelRD5.Text = "L5-Off";
            // 
            // labelRD6
            // 
            this.labelRD6.AutoSize = true;
            this.labelRD6.BackColor = System.Drawing.Color.Yellow;
            this.labelRD6.Location = new System.Drawing.Point(239, 160);
            this.labelRD6.Name = "labelRD6";
            this.labelRD6.Size = new System.Drawing.Size(36, 13);
            this.labelRD6.TabIndex = 26;
            this.labelRD6.Text = "L6-Off";
            // 
            // labelRD4
            // 
            this.labelRD4.AutoSize = true;
            this.labelRD4.BackColor = System.Drawing.Color.Yellow;
            this.labelRD4.Location = new System.Drawing.Point(239, 75);
            this.labelRD4.Name = "labelRD4";
            this.labelRD4.Size = new System.Drawing.Size(36, 13);
            this.labelRD4.TabIndex = 27;
            this.labelRD4.Text = "L4-Off";
            // 
            // labelRD7
            // 
            this.labelRD7.AutoSize = true;
            this.labelRD7.BackColor = System.Drawing.Color.Yellow;
            this.labelRD7.Location = new System.Drawing.Point(239, 204);
            this.labelRD7.Name = "labelRD7";
            this.labelRD7.Size = new System.Drawing.Size(36, 13);
            this.labelRD7.TabIndex = 28;
            this.labelRD7.Text = "L7-Off";
            // 
            // labelRD3
            // 
            this.labelRD3.AutoSize = true;
            this.labelRD3.BackColor = System.Drawing.Color.Yellow;
            this.labelRD3.Location = new System.Drawing.Point(66, 204);
            this.labelRD3.Name = "labelRD3";
            this.labelRD3.Size = new System.Drawing.Size(36, 13);
            this.labelRD3.TabIndex = 29;
            this.labelRD3.Text = "L3-Off";
            // 
            // labelRD2
            // 
            this.labelRD2.AutoSize = true;
            this.labelRD2.BackColor = System.Drawing.Color.Yellow;
            this.labelRD2.Location = new System.Drawing.Point(66, 160);
            this.labelRD2.Name = "labelRD2";
            this.labelRD2.Size = new System.Drawing.Size(36, 13);
            this.labelRD2.TabIndex = 30;
            this.labelRD2.Text = "L2-Off";
            // 
            // labelRD1
            // 
            this.labelRD1.AutoSize = true;
            this.labelRD1.BackColor = System.Drawing.Color.Yellow;
            this.labelRD1.Location = new System.Drawing.Point(66, 118);
            this.labelRD1.Name = "labelRD1";
            this.labelRD1.Size = new System.Drawing.Size(36, 13);
            this.labelRD1.TabIndex = 31;
            this.labelRD1.Text = "L1-Off";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.checkBoxAN0);
            this.panel3.Controls.Add(this.textBoxAN0);
            this.panel3.Controls.Add(this.btAN0);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(359, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 118);
            this.panel3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(80, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Leitura Canal Analógico AN0";
            // 
            // btAN0
            // 
            this.btAN0.Location = new System.Drawing.Point(50, 46);
            this.btAN0.Name = "btAN0";
            this.btAN0.Size = new System.Drawing.Size(75, 33);
            this.btAN0.TabIndex = 17;
            this.btAN0.Text = "Ler AN0";
            this.btAN0.UseVisualStyleBackColor = true;
            this.btAN0.Click += new System.EventHandler(this.btAN0_Click);
            // 
            // textBoxAN0
            // 
            this.textBoxAN0.Location = new System.Drawing.Point(144, 53);
            this.textBoxAN0.Name = "textBoxAN0";
            this.textBoxAN0.Size = new System.Drawing.Size(164, 20);
            this.textBoxAN0.TabIndex = 13;
            // 
            // checkBoxAN0
            // 
            this.checkBoxAN0.AutoSize = true;
            this.checkBoxAN0.Location = new System.Drawing.Point(11, 92);
            this.checkBoxAN0.Name = "checkBoxAN0";
            this.checkBoxAN0.Size = new System.Drawing.Size(120, 17);
            this.checkBoxAN0.TabIndex = 18;
            this.checkBoxAN0.Text = "Habilita Leitura AN0";
            this.checkBoxAN0.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel4.Controls.Add(this.trackBarPWM2);
            this.panel4.Controls.Add(this.trackBarPWM1);
            this.panel4.Controls.Add(this.labelPWM2);
            this.panel4.Controls.Add(this.labelPWM1);
            this.panel4.Controls.Add(this.checkBoxPWM2);
            this.panel4.Controls.Add(this.checkBoxPWM1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(722, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 491);
            this.panel4.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(89, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Controle PWMs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "PWM1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "PWM2";
            // 
            // checkBoxPWM1
            // 
            this.checkBoxPWM1.AutoSize = true;
            this.checkBoxPWM1.Location = new System.Drawing.Point(37, 89);
            this.checkBoxPWM1.Name = "checkBoxPWM1";
            this.checkBoxPWM1.Size = new System.Drawing.Size(46, 17);
            this.checkBoxPWM1.TabIndex = 19;
            this.checkBoxPWM1.Text = "OFF";
            this.checkBoxPWM1.UseVisualStyleBackColor = true;
            this.checkBoxPWM1.CheckedChanged += new System.EventHandler(this.checkBoxPWM1_CheckedChanged);
            // 
            // checkBoxPWM2
            // 
            this.checkBoxPWM2.AutoSize = true;
            this.checkBoxPWM2.Location = new System.Drawing.Point(208, 89);
            this.checkBoxPWM2.Name = "checkBoxPWM2";
            this.checkBoxPWM2.Size = new System.Drawing.Size(46, 17);
            this.checkBoxPWM2.TabIndex = 20;
            this.checkBoxPWM2.Text = "OFF";
            this.checkBoxPWM2.UseVisualStyleBackColor = true;
            this.checkBoxPWM2.CheckedChanged += new System.EventHandler(this.checkBoxPWM2_CheckedChanged);
            // 
            // labelPWM1
            // 
            this.labelPWM1.AutoSize = true;
            this.labelPWM1.Location = new System.Drawing.Point(53, 120);
            this.labelPWM1.Name = "labelPWM1";
            this.labelPWM1.Size = new System.Drawing.Size(21, 13);
            this.labelPWM1.TabIndex = 21;
            this.labelPWM1.Text = "0%";
            this.labelPWM1.Click += new System.EventHandler(this.label12_Click);
            // 
            // labelPWM2
            // 
            this.labelPWM2.AutoSize = true;
            this.labelPWM2.Location = new System.Drawing.Point(224, 120);
            this.labelPWM2.Name = "labelPWM2";
            this.labelPWM2.Size = new System.Drawing.Size(21, 13);
            this.labelPWM2.TabIndex = 22;
            this.labelPWM2.Text = "0%";
            // 
            // trackBarPWM1
            // 
            this.trackBarPWM1.LargeChange = 1;
            this.trackBarPWM1.Location = new System.Drawing.Point(37, 148);
            this.trackBarPWM1.Name = "trackBarPWM1";
            this.trackBarPWM1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPWM1.Size = new System.Drawing.Size(45, 307);
            this.trackBarPWM1.TabIndex = 23;
            this.trackBarPWM1.Scroll += new System.EventHandler(this.trackBarPWM1_Scroll);
            // 
            // trackBarPWM2
            // 
            this.trackBarPWM2.LargeChange = 1;
            this.trackBarPWM2.Location = new System.Drawing.Point(200, 148);
            this.trackBarPWM2.Name = "trackBarPWM2";
            this.trackBarPWM2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPWM2.Size = new System.Drawing.Size(45, 307);
            this.trackBarPWM2.TabIndex = 24;
            this.trackBarPWM2.Scroll += new System.EventHandler(this.trackBarPWM2_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(394, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 274);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(426, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "PROCURA-SE PROGRAMADOR ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(405, 613);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(287, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "MELHOR DO QUE EU AQUI NA FATEC";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Edwardian Script ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(883, 624);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 35);
            this.label14.TabIndex = 17;
            this.label14.Text = "Gustavo Gea";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(722, 510);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 120);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(439, 597);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 21);
            this.label15.TabIndex = 19;
            this.label15.Text = "EM MICROCONTROLADOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 657);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelConectControl);
            this.Name = "Form1";
            this.Text = "GUI-Fatec Gus e Jac";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMessageConect.ResumeLayout(false);
            this.panelConectControl.ResumeLayout(false);
            this.panelConectControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPWM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button btDesconectar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoxPort;
        private System.Windows.Forms.ComboBox cbBoxBaud;
        private System.Windows.Forms.Label lbStatusConect;
        private System.Windows.Forms.Panel panelMessageConect;
        private System.Windows.Forms.Panel panelConectControl;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCleanReception;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxReceber;
        private System.Windows.Forms.TextBox textBoxEnviar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxReception;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRD1;
        private System.Windows.Forms.Label labelRD2;
        private System.Windows.Forms.Label labelRD3;
        private System.Windows.Forms.Label labelRD7;
        private System.Windows.Forms.Label labelRD4;
        private System.Windows.Forms.Label labelRD6;
        private System.Windows.Forms.Label labelRD5;
        private System.Windows.Forms.Label labelRD0;
        private System.Windows.Forms.Button btRD1;
        private System.Windows.Forms.Button btRD2;
        private System.Windows.Forms.Button btRD3;
        private System.Windows.Forms.Button btRD4;
        private System.Windows.Forms.Button btRD7;
        private System.Windows.Forms.Button btRD6;
        private System.Windows.Forms.Button btRD5;
        private System.Windows.Forms.Button btRD0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxAN0;
        private System.Windows.Forms.TextBox textBoxAN0;
        private System.Windows.Forms.Button btAN0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelPWM2;
        private System.Windows.Forms.Label labelPWM1;
        private System.Windows.Forms.CheckBox checkBoxPWM2;
        private System.Windows.Forms.CheckBox checkBoxPWM1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarPWM2;
        private System.Windows.Forms.TrackBar trackBarPWM1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
    }
}

