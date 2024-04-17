namespace ProyectoFinal
{
    partial class FormCompraTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompraTicket));
            label1 = new Label();
            textBox1 = new TextBox();
            label16 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbPaisOrigen = new ComboBox();
            label4 = new Label();
            cmbPaisDestino = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            dtpFechaSalida = new DateTimePicker();
            dtpFechaRegreso = new DateTimePicker();
            panelViajes = new Panel();
            btnComprar = new Button();
            btnB6 = new Button();
            btnB1 = new Button();
            btnB5 = new Button();
            btnB4 = new Button();
            btnB3 = new Button();
            btnA5 = new Button();
            btnB2 = new Button();
            btnA6 = new Button();
            btnA4 = new Button();
            btnA3 = new Button();
            btnA2 = new Button();
            btnA1 = new Button();
            avion = new PictureBox();
            panel3 = new Panel();
            panel6 = new Panel();
            panel8 = new Panel();
            label25 = new Label();
            btnFelx = new Button();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label18 = new Label();
            label15 = new Label();
            panel5 = new Panel();
            panel7 = new Panel();
            label26 = new Label();
            btnClassic = new Button();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label14 = new Label();
            label17 = new Label();
            subMenuTickets = new Panel();
            panel4 = new Panel();
            label13 = new Label();
            cmbNiño = new ComboBox();
            cmbAdulto = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            btnCantTicket = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panelOpcionesVuelo = new Panel();
            panelViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avion).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            subMenuTickets.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelOpcionesVuelo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(1, 36);
            label1.Name = "label1";
            label1.Size = new Size(471, 60);
            label1.TabIndex = 10;
            label1.Text = "      Compra de Tickets";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Beige;
            textBox1.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 66);
            textBox1.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(56, 125);
            label16.Name = "label16";
            label16.Size = new Size(136, 27);
            label16.TabIndex = 35;
            label16.Text = "Identificación";
            // 
            // txtID
            // 
            txtID.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(198, 122);
            txtID.Name = "txtID";
            txtID.Size = new Size(196, 30);
            txtID.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label2.Location = new Point(53, 6);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 38;
            label2.Text = "Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 40;
            label3.Text = "Clase Vuelo";
            // 
            // cmbPaisOrigen
            // 
            cmbPaisOrigen.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaisOrigen.FormattingEnabled = true;
            cmbPaisOrigen.Items.AddRange(new object[] { "Alta", "Turista" });
            cmbPaisOrigen.Location = new Point(13, 35);
            cmbPaisOrigen.Name = "cmbPaisOrigen";
            cmbPaisOrigen.Size = new Size(200, 31);
            cmbPaisOrigen.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label4.Location = new Point(288, 5);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 43;
            label4.Text = "Destino";
            // 
            // cmbPaisDestino
            // 
            cmbPaisDestino.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaisDestino.FormattingEnabled = true;
            cmbPaisDestino.Items.AddRange(new object[] { "Alta", "Turista" });
            cmbPaisDestino.Location = new Point(245, 35);
            cmbPaisDestino.Name = "cmbPaisDestino";
            cmbPaisDestino.Size = new Size(200, 31);
            cmbPaisDestino.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(69, 10);
            label6.Name = "label6";
            label6.Size = new Size(35, 23);
            label6.TabIndex = 47;
            label6.Text = "Ida";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(223, 10);
            label7.Name = "label7";
            label7.Size = new Size(61, 23);
            label7.TabIndex = 49;
            label7.Text = "Vuelta";
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.CalendarFont = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaSalida.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaSalida.Location = new Point(8, 36);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(163, 30);
            dtpFechaSalida.TabIndex = 50;
            // 
            // dtpFechaRegreso
            // 
            dtpFechaRegreso.CalendarFont = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaRegreso.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaRegreso.Location = new Point(184, 35);
            dtpFechaRegreso.Name = "dtpFechaRegreso";
            dtpFechaRegreso.Size = new Size(154, 30);
            dtpFechaRegreso.TabIndex = 51;
            // 
            // panelViajes
            // 
            panelViajes.Controls.Add(btnComprar);
            panelViajes.Controls.Add(btnB6);
            panelViajes.Controls.Add(btnB1);
            panelViajes.Controls.Add(btnB5);
            panelViajes.Controls.Add(btnB4);
            panelViajes.Controls.Add(btnB3);
            panelViajes.Controls.Add(btnA5);
            panelViajes.Controls.Add(btnB2);
            panelViajes.Controls.Add(btnA6);
            panelViajes.Controls.Add(btnA4);
            panelViajes.Controls.Add(btnA3);
            panelViajes.Controls.Add(btnA2);
            panelViajes.Controls.Add(btnA1);
            panelViajes.Controls.Add(avion);
            panelViajes.Controls.Add(panel3);
            panelViajes.Controls.Add(subMenuTickets);
            panelViajes.Controls.Add(panel2);
            panelViajes.Controls.Add(panel1);
            panelViajes.Controls.Add(panelOpcionesVuelo);
            panelViajes.Location = new Point(46, 155);
            panelViajes.Name = "panelViajes";
            panelViajes.Size = new Size(1074, 539);
            panelViajes.TabIndex = 54;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.Beige;
            btnComprar.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.ForeColor = SystemColors.ControlText;
            btnComprar.Location = new Point(927, 479);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(103, 43);
            btnComprar.TabIndex = 107;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            // 
            // btnB6
            // 
            btnB6.BackColor = Color.Purple;
            btnB6.FlatAppearance.BorderColor = Color.Purple;
            btnB6.FlatAppearance.BorderSize = 0;
            btnB6.FlatStyle = FlatStyle.Flat;
            btnB6.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB6.ForeColor = SystemColors.ControlText;
            btnB6.Location = new Point(634, 463);
            btnB6.Name = "btnB6";
            btnB6.Size = new Size(33, 28);
            btnB6.TabIndex = 106;
            btnB6.Text = "B6";
            btnB6.UseVisualStyleBackColor = false;
            // 
            // btnB1
            // 
            btnB1.BackColor = Color.Purple;
            btnB1.FlatAppearance.BorderColor = Color.Purple;
            btnB1.FlatAppearance.BorderSize = 0;
            btnB1.FlatStyle = FlatStyle.Flat;
            btnB1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB1.ForeColor = SystemColors.ControlText;
            btnB1.Location = new Point(615, 327);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(33, 28);
            btnB1.TabIndex = 105;
            btnB1.Text = "B1";
            btnB1.UseVisualStyleBackColor = false;
            // 
            // btnB5
            // 
            btnB5.BackColor = Color.Purple;
            btnB5.FlatAppearance.BorderColor = Color.Purple;
            btnB5.FlatAppearance.BorderSize = 0;
            btnB5.FlatStyle = FlatStyle.Flat;
            btnB5.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB5.ForeColor = SystemColors.ControlText;
            btnB5.Location = new Point(634, 429);
            btnB5.Name = "btnB5";
            btnB5.Size = new Size(33, 28);
            btnB5.TabIndex = 98;
            btnB5.Text = "B5";
            btnB5.UseVisualStyleBackColor = false;
            // 
            // btnB4
            // 
            btnB4.BackColor = Color.Purple;
            btnB4.FlatAppearance.BorderColor = Color.Purple;
            btnB4.FlatAppearance.BorderSize = 0;
            btnB4.FlatStyle = FlatStyle.Flat;
            btnB4.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB4.ForeColor = SystemColors.ControlText;
            btnB4.Location = new Point(634, 395);
            btnB4.Name = "btnB4";
            btnB4.Size = new Size(33, 28);
            btnB4.TabIndex = 97;
            btnB4.Text = "B4";
            btnB4.UseVisualStyleBackColor = false;
            // 
            // btnB3
            // 
            btnB3.BackColor = Color.Purple;
            btnB3.FlatAppearance.BorderColor = Color.Purple;
            btnB3.FlatAppearance.BorderSize = 0;
            btnB3.FlatStyle = FlatStyle.Flat;
            btnB3.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB3.ForeColor = SystemColors.ControlText;
            btnB3.Location = new Point(634, 361);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(33, 28);
            btnB3.TabIndex = 96;
            btnB3.Text = "B3";
            btnB3.UseVisualStyleBackColor = false;
            // 
            // btnA5
            // 
            btnA5.BackColor = Color.DarkOrange;
            btnA5.FlatAppearance.BorderColor = Color.Purple;
            btnA5.FlatAppearance.BorderSize = 0;
            btnA5.FlatStyle = FlatStyle.Flat;
            btnA5.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA5.ForeColor = SystemColors.ControlText;
            btnA5.Location = new Point(615, 293);
            btnA5.Name = "btnA5";
            btnA5.Size = new Size(33, 28);
            btnA5.TabIndex = 95;
            btnA5.Text = "A5";
            btnA5.UseVisualStyleBackColor = false;
            // 
            // btnB2
            // 
            btnB2.BackColor = Color.Purple;
            btnB2.FlatAppearance.BorderColor = Color.Purple;
            btnB2.FlatAppearance.BorderSize = 0;
            btnB2.FlatStyle = FlatStyle.Flat;
            btnB2.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB2.ForeColor = SystemColors.ControlText;
            btnB2.Location = new Point(654, 327);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(33, 28);
            btnB2.TabIndex = 86;
            btnB2.Text = "B2";
            btnB2.UseVisualStyleBackColor = false;
            // 
            // btnA6
            // 
            btnA6.BackColor = Color.DarkOrange;
            btnA6.FlatAppearance.BorderColor = Color.Purple;
            btnA6.FlatAppearance.BorderSize = 0;
            btnA6.FlatStyle = FlatStyle.Flat;
            btnA6.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA6.ForeColor = SystemColors.ControlText;
            btnA6.Location = new Point(654, 293);
            btnA6.Name = "btnA6";
            btnA6.Size = new Size(33, 28);
            btnA6.TabIndex = 83;
            btnA6.Text = "A6";
            btnA6.UseVisualStyleBackColor = false;
            // 
            // btnA4
            // 
            btnA4.BackColor = Color.DarkOrange;
            btnA4.FlatAppearance.BorderColor = Color.Purple;
            btnA4.FlatAppearance.BorderSize = 0;
            btnA4.FlatStyle = FlatStyle.Flat;
            btnA4.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA4.ForeColor = SystemColors.ControlText;
            btnA4.Location = new Point(634, 244);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(33, 28);
            btnA4.TabIndex = 81;
            btnA4.Text = "A4";
            btnA4.UseVisualStyleBackColor = false;
            // 
            // btnA3
            // 
            btnA3.BackColor = Color.DarkOrange;
            btnA3.FlatAppearance.BorderColor = Color.Purple;
            btnA3.FlatAppearance.BorderSize = 0;
            btnA3.FlatStyle = FlatStyle.Flat;
            btnA3.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA3.ForeColor = SystemColors.ControlText;
            btnA3.Location = new Point(634, 210);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(33, 28);
            btnA3.TabIndex = 80;
            btnA3.Text = "A3";
            btnA3.UseVisualStyleBackColor = false;
            // 
            // btnA2
            // 
            btnA2.BackColor = Color.DarkOrange;
            btnA2.FlatAppearance.BorderColor = Color.Purple;
            btnA2.FlatAppearance.BorderSize = 0;
            btnA2.FlatStyle = FlatStyle.Flat;
            btnA2.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA2.ForeColor = SystemColors.ControlText;
            btnA2.Location = new Point(634, 179);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(33, 27);
            btnA2.TabIndex = 79;
            btnA2.Text = "A2";
            btnA2.UseVisualStyleBackColor = false;
            // 
            // btnA1
            // 
            btnA1.BackColor = Color.DarkOrange;
            btnA1.FlatAppearance.BorderSize = 0;
            btnA1.FlatStyle = FlatStyle.Flat;
            btnA1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA1.ForeColor = SystemColors.ControlText;
            btnA1.Location = new Point(634, 149);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(33, 24);
            btnA1.TabIndex = 78;
            btnA1.Text = "A1";
            btnA1.UseVisualStyleBackColor = false;
            // 
            // avion
            // 
            avion.Image = (Image)resources.GetObject("avion.Image");
            avion.Location = new Point(523, 114);
            avion.Name = "avion";
            avion.Size = new Size(257, 408);
            avion.SizeMode = PictureBoxSizeMode.StretchImage;
            avion.TabIndex = 77;
            avion.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(10, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(493, 239);
            panel3.TabIndex = 55;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkOrange;
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(245, 28);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 199);
            panel6.TabIndex = 42;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Beige;
            panel8.Controls.Add(label25);
            panel8.Controls.Add(btnFelx);
            panel8.Controls.Add(label22);
            panel8.Controls.Add(label23);
            panel8.Controls.Add(label24);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label15);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(194, 193);
            panel8.TabIndex = 57;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(32, 166);
            label25.Name = "label25";
            label25.Size = new Size(135, 20);
            label25.TabIndex = 65;
            label25.Text = "Precio por pasajero";
            // 
            // btnFelx
            // 
            btnFelx.BackColor = Color.DarkOrange;
            btnFelx.FlatAppearance.BorderColor = Color.Purple;
            btnFelx.FlatAppearance.BorderSize = 0;
            btnFelx.FlatStyle = FlatStyle.Flat;
            btnFelx.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFelx.ForeColor = SystemColors.ButtonHighlight;
            btnFelx.Location = new Point(53, 130);
            btnFelx.Name = "btnFelx";
            btnFelx.Size = new Size(83, 33);
            btnFelx.TabIndex = 64;
            btnFelx.Text = "$272.15";
            btnFelx.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(3, 98);
            label22.Name = "label22";
            label22.Size = new Size(99, 21);
            label22.TabIndex = 63;
            label22.Text = "Asiento Plus";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(3, 72);
            label23.Name = "label23";
            label23.Size = new Size(188, 21);
            label23.TabIndex = 62;
            label23.Text = "1 equipaje de mano(23kg)";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(3, 51);
            label24.Name = "label24";
            label24.Size = new Size(142, 21);
            label24.TabIndex = 61;
            label24.Text = "1 artículo personal";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(32, 29);
            label18.Name = "label18";
            label18.Size = new Size(127, 20);
            label18.TabIndex = 57;
            label18.Text = "Más posibilidades";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label15.Location = new Point(72, 6);
            label15.Name = "label15";
            label15.Size = new Size(41, 23);
            label15.TabIndex = 39;
            label15.Text = "Flex";
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumOrchid;
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(13, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 201);
            panel5.TabIndex = 41;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Beige;
            panel7.Controls.Add(label26);
            panel7.Controls.Add(btnClassic);
            panel7.Controls.Add(label21);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label17);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(194, 195);
            panel7.TabIndex = 56;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(22, 168);
            label26.Name = "label26";
            label26.Size = new Size(135, 20);
            label26.TabIndex = 66;
            label26.Text = "Precio por pasajero";
            // 
            // btnClassic
            // 
            btnClassic.BackColor = Color.Purple;
            btnClassic.FlatAppearance.BorderColor = Color.Purple;
            btnClassic.FlatAppearance.BorderSize = 0;
            btnClassic.FlatStyle = FlatStyle.Flat;
            btnClassic.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassic.ForeColor = SystemColors.ButtonHighlight;
            btnClassic.Location = new Point(45, 132);
            btnClassic.Name = "btnClassic";
            btnClassic.Size = new Size(83, 33);
            btnClassic.TabIndex = 60;
            btnClassic.Text = "$160.29";
            btnClassic.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(3, 100);
            label21.Name = "label21";
            label21.Size = new Size(132, 21);
            label21.TabIndex = 59;
            label21.Text = "Asiento Economy";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(3, 79);
            label20.Name = "label20";
            label20.Size = new Size(188, 21);
            label20.TabIndex = 58;
            label20.Text = "1 equipaje de mano(10kg)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(3, 58);
            label19.Name = "label19";
            label19.Size = new Size(142, 21);
            label19.TabIndex = 57;
            label19.Text = "1 artículo personal";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label14.Location = new Point(63, 8);
            label14.Name = "label14";
            label14.Size = new Size(65, 23);
            label14.TabIndex = 39;
            label14.Text = "Classic";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(43, 31);
            label17.Name = "label17";
            label17.Size = new Size(103, 20);
            label17.TabIndex = 56;
            label17.Text = "Más completo";
            // 
            // subMenuTickets
            // 
            subMenuTickets.Controls.Add(panel4);
            subMenuTickets.Controls.Add(cmbNiño);
            subMenuTickets.Controls.Add(cmbAdulto);
            subMenuTickets.Controls.Add(label11);
            subMenuTickets.Controls.Add(label12);
            subMenuTickets.Controls.Add(label10);
            subMenuTickets.Controls.Add(label9);
            subMenuTickets.Location = new Point(786, 114);
            subMenuTickets.Name = "subMenuTickets";
            subMenuTickets.Size = new Size(253, 230);
            subMenuTickets.TabIndex = 54;
            subMenuTickets.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightCyan;
            panel4.Controls.Add(label13);
            panel4.Location = new Point(12, 140);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 79);
            panel4.TabIndex = 55;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(13, 9);
            label13.Name = "label13";
            label13.Size = new Size(207, 60);
            label13.TabIndex = 49;
            label13.Text = "Pasajeros de 14 años o menos \r\ndeberán viajar con sus padres\r\no un adulto responsable.";
            // 
            // cmbNiño
            // 
            cmbNiño.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNiño.FormattingEnabled = true;
            cmbNiño.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cmbNiño.Location = new Point(141, 92);
            cmbNiño.Name = "cmbNiño";
            cmbNiño.Size = new Size(69, 31);
            cmbNiño.TabIndex = 50;
            cmbNiño.Text = "0";
            // 
            // cmbAdulto
            // 
            cmbAdulto.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAdulto.FormattingEnabled = true;
            cmbAdulto.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cmbAdulto.Location = new Point(141, 26);
            cmbAdulto.Name = "cmbAdulto";
            cmbAdulto.Size = new Size(69, 31);
            cmbAdulto.TabIndex = 45;
            cmbAdulto.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 103);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 48;
            label11.Text = "De 2 a 11 años";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label12.Location = new Point(12, 80);
            label12.Name = "label12";
            label12.Size = new Size(56, 23);
            label12.TabIndex = 47;
            label12.Text = "Niños";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 37);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 46;
            label10.Text = "Desde 12 años";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            label9.Location = new Point(12, 14);
            label9.Name = "label9";
            label9.Size = new Size(71, 23);
            label9.TabIndex = 45;
            label9.Text = "Adultos";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCantTicket);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(870, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 79);
            panel2.TabIndex = 2;
            // 
            // btnCantTicket
            // 
            btnCantTicket.FlatStyle = FlatStyle.Flat;
            btnCantTicket.Image = (Image)resources.GetObject("btnCantTicket.Image");
            btnCantTicket.Location = new Point(57, 32);
            btnCantTicket.Name = "btnCantTicket";
            btnCantTicket.Size = new Size(57, 33);
            btnCantTicket.TabIndex = 56;
            btnCantTicket.UseVisualStyleBackColor = true;
            btnCantTicket.Click += btnCantTicket_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpFechaSalida);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpFechaRegreso);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(512, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 79);
            panel1.TabIndex = 1;
            // 
            // panelOpcionesVuelo
            // 
            panelOpcionesVuelo.Controls.Add(cmbPaisOrigen);
            panelOpcionesVuelo.Controls.Add(label2);
            panelOpcionesVuelo.Controls.Add(cmbPaisDestino);
            panelOpcionesVuelo.Controls.Add(label4);
            panelOpcionesVuelo.Location = new Point(10, 29);
            panelOpcionesVuelo.Name = "panelOpcionesVuelo";
            panelOpcionesVuelo.Size = new Size(496, 79);
            panelOpcionesVuelo.TabIndex = 0;
            // 
            // FormCompraTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1145, 706);
            Controls.Add(panelViajes);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label16);
            Controls.Add(txtID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCompraTicket";
            Text = "FormCompraTicket";
            panelViajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avion).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            subMenuTickets.ResumeLayout(false);
            subMenuTickets.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelOpcionesVuelo.ResumeLayout(false);
            panelOpcionesVuelo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label16;
        private TextBox txtID;
        private Label label2;
        private Label label3;
        private ComboBox cmbPaisOrigen;
        private Label label4;
        private ComboBox cmbPaisDestino;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpFechaSalida;
        private DateTimePicker dtpFechaRegreso;
        private Panel panelViajes;
        private Panel panel2;
        private Panel panel1;
        private Panel panelOpcionesVuelo;
        private PictureBox pictureBox1;
        private Button btnCantTicket;
        private Panel subMenuTickets;
        private Label label9;
        private Panel panel4;
        private Label label13;
        private ComboBox cmbNiño;
        private ComboBox cmbAdulto;
        private Label label11;
        private Label label12;
        private Label label10;
        private Panel panel3;
        private Panel panel6;
        private Label label18;
        private Label label15;
        private Panel panel5;
        private Label label17;
        private Label label14;
        private Panel panel8;
        private Panel panel7;
        private Label label20;
        private Label label19;
        private Button btnFelx;
        private Label label22;
        private Label label23;
        private Label label24;
        private Button btnClassic;
        private Label label21;
        private Label label25;
        private Label label26;
        private PictureBox avion;
        private Button btnB5;
        private Button btnB4;
        private Button btnB3;
        private Button btnA5;
        private Button btnB2;
        private Button btnA6;
        private Button btnA4;
        private Button btnA3;
        private Button btnA2;
        private Button btnA1;
        private Button btnB6;
        private Button btnB1;
        private Button btnComprar;
    }
}