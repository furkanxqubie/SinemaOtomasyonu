namespace sinematik
{
    partial class FrmBiletOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletOlustur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbFilmAdi = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbTarih = new System.Windows.Forms.ComboBox();
            this.lblYonetmenAra = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblSeansSec = new System.Windows.Forms.Label();
            this.panelSEANS = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblKoltukSayisi = new System.Windows.Forms.Label();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbBiletTuru = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtKoltuklar = new System.Windows.Forms.TextBox();
            this.lblGelenKoltuk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KoltukPaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.listeGelenKoltuk = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbBelirlenen = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 40);
            this.panel1.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(754, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "[BİLET OLUŞTURMA EKRANI]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBarkod);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(246, 53);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLET NO";
            // 
            // txtBarkod
            // 
            this.txtBarkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarkod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBarkod.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtBarkod.Location = new System.Drawing.Point(10, 32);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.ReadOnly = true;
            this.txtBarkod.Size = new System.Drawing.Size(233, 18);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(246, 53);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AD SOYAD";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdSoyad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtAdSoyad.Location = new System.Drawing.Point(10, 32);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(233, 18);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTelNo);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox3.Location = new System.Drawing.Point(8, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(246, 53);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TELEFON NUMARASI";
            // 
            // txtTelNo
            // 
            this.txtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTelNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtTelNo.Location = new System.Drawing.Point(10, 32);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(233, 18);
            this.txtTelNo.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbFilmAdi);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox4.Location = new System.Drawing.Point(8, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(246, 46);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FİLM ADI";
            // 
            // cbFilmAdi
            // 
            this.cbFilmAdi.BackColor = System.Drawing.Color.White;
            this.cbFilmAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilmAdi.FormattingEnabled = true;
            this.cbFilmAdi.Location = new System.Drawing.Point(10, 18);
            this.cbFilmAdi.Name = "cbFilmAdi";
            this.cbFilmAdi.Size = new System.Drawing.Size(233, 25);
            this.cbFilmAdi.TabIndex = 0;
            this.cbFilmAdi.SelectedIndexChanged += new System.EventHandler(this.cbFilmAdi_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbTarih);
            this.groupBox5.Controls.Add(this.lblYonetmenAra);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox5.Location = new System.Drawing.Point(8, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(246, 53);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TARİH";
            // 
            // cbTarih
            // 
            this.cbTarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbTarih.FormattingEnabled = true;
            this.cbTarih.Location = new System.Drawing.Point(10, 25);
            this.cbTarih.Name = "cbTarih";
            this.cbTarih.Size = new System.Drawing.Size(233, 25);
            this.cbTarih.TabIndex = 10;
            this.cbTarih.SelectedIndexChanged += new System.EventHandler(this.cbTarih_SelectedIndexChanged);
            // 
            // lblYonetmenAra
            // 
            this.lblYonetmenAra.AutoSize = true;
            this.lblYonetmenAra.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYonetmenAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(164)))), ((int)(((byte)(26)))));
            this.lblYonetmenAra.Location = new System.Drawing.Point(170, 2);
            this.lblYonetmenAra.Name = "lblYonetmenAra";
            this.lblYonetmenAra.Size = new System.Drawing.Size(67, 13);
            this.lblYonetmenAra.TabIndex = 9;
            this.lblYonetmenAra.Text = "gg/aa/yyyy";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblSeansSec);
            this.groupBox6.Controls.Add(this.panelSEANS);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox6.Location = new System.Drawing.Point(8, 325);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox6.Size = new System.Drawing.Size(246, 72);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SAAT/SEANS";
            // 
            // lblSeansSec
            // 
            this.lblSeansSec.AutoSize = true;
            this.lblSeansSec.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeansSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(164)))), ((int)(((byte)(26)))));
            this.lblSeansSec.Location = new System.Drawing.Point(188, 5);
            this.lblSeansSec.Name = "lblSeansSec";
            this.lblSeansSec.Size = new System.Drawing.Size(49, 13);
            this.lblSeansSec.TabIndex = 11;
            this.lblSeansSec.Text = "lblSeans";
            this.lblSeansSec.Visible = false;
            // 
            // panelSEANS
            // 
            this.panelSEANS.AutoScroll = true;
            this.panelSEANS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSEANS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSEANS.Location = new System.Drawing.Point(10, 21);
            this.panelSEANS.Name = "panelSEANS";
            this.panelSEANS.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelSEANS.Size = new System.Drawing.Size(233, 48);
            this.panelSEANS.TabIndex = 0;
            this.panelSEANS.WrapContents = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblKoltukSayisi);
            this.groupBox7.Controls.Add(this.cbSalon);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox7.Location = new System.Drawing.Point(8, 403);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox7.Size = new System.Drawing.Size(246, 53);
            this.groupBox7.TabIndex = 49;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SALON ADI";
            // 
            // lblKoltukSayisi
            // 
            this.lblKoltukSayisi.AutoSize = true;
            this.lblKoltukSayisi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(164)))), ((int)(((byte)(26)))));
            this.lblKoltukSayisi.Location = new System.Drawing.Point(157, 2);
            this.lblKoltukSayisi.Name = "lblKoltukSayisi";
            this.lblKoltukSayisi.Size = new System.Drawing.Size(82, 13);
            this.lblKoltukSayisi.TabIndex = 12;
            this.lblKoltukSayisi.Text = "lblKoltukSayisi";
            this.lblKoltukSayisi.Visible = false;
            // 
            // cbSalon
            // 
            this.cbSalon.BackColor = System.Drawing.Color.White;
            this.cbSalon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSalon.FormattingEnabled = true;
            this.cbSalon.Location = new System.Drawing.Point(10, 25);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(233, 25);
            this.cbSalon.TabIndex = 0;
            this.cbSalon.SelectedIndexChanged += new System.EventHandler(this.cbSalon_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbBiletTuru);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox8.Location = new System.Drawing.Point(8, 455);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox8.Size = new System.Drawing.Size(246, 53);
            this.groupBox8.TabIndex = 50;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "BİLET TÜRÜ";
            // 
            // cbBiletTuru
            // 
            this.cbBiletTuru.BackColor = System.Drawing.Color.White;
            this.cbBiletTuru.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbBiletTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBiletTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBiletTuru.FormattingEnabled = true;
            this.cbBiletTuru.Items.AddRange(new object[] {
            "YETİŞKİN",
            "ÖĞRENCİ"});
            this.cbBiletTuru.Location = new System.Drawing.Point(10, 25);
            this.cbBiletTuru.Name = "cbBiletTuru";
            this.cbBiletTuru.Size = new System.Drawing.Size(233, 25);
            this.cbBiletTuru.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtKoltuklar);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox9.Location = new System.Drawing.Point(8, 507);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox9.Size = new System.Drawing.Size(246, 53);
            this.groupBox9.TabIndex = 47;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "SEÇİLEN KOLTUK(LAR)";
            // 
            // txtKoltuklar
            // 
            this.txtKoltuklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKoltuklar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtKoltuklar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKoltuklar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtKoltuklar.Location = new System.Drawing.Point(10, 32);
            this.txtKoltuklar.Name = "txtKoltuklar";
            this.txtKoltuklar.ReadOnly = true;
            this.txtKoltuklar.Size = new System.Drawing.Size(233, 18);
            this.txtKoltuklar.TabIndex = 0;
            // 
            // lblGelenKoltuk
            // 
            this.lblGelenKoltuk.AutoSize = true;
            this.lblGelenKoltuk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelenKoltuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(164)))), ((int)(((byte)(26)))));
            this.lblGelenKoltuk.Location = new System.Drawing.Point(647, 214);
            this.lblGelenKoltuk.Name = "lblGelenKoltuk";
            this.lblGelenKoltuk.Size = new System.Drawing.Size(117, 21);
            this.lblGelenKoltuk.TabIndex = 54;
            this.lblGelenKoltuk.Text = "lblGelenKoltuk";
            this.lblGelenKoltuk.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(164)))), ((int)(((byte)(26)))));
            this.label5.Location = new System.Drawing.Point(587, 620);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "SEÇİLEN KOLTUK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(487, 620);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "DOLU KOLTUK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(390, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "BOŞ KOLTUK";
            // 
            // KoltukPaneli
            // 
            this.KoltukPaneli.AutoScroll = true;
            this.KoltukPaneli.Location = new System.Drawing.Point(260, 115);
            this.KoltukPaneli.Name = "KoltukPaneli";
            this.KoltukPaneli.Size = new System.Drawing.Size(522, 442);
            this.KoltukPaneli.TabIndex = 56;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(164)))), ((int)(((byte)(26)))));
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.FlatAppearance.BorderSize = 0;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlustur.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Location = new System.Drawing.Point(8, 566);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(246, 34);
            this.btnOlustur.TabIndex = 51;
            this.btnOlustur.Text = "BİLET OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // listeGelenKoltuk
            // 
            this.listeGelenKoltuk.FormattingEnabled = true;
            this.listeGelenKoltuk.ItemHeight = 25;
            this.listeGelenKoltuk.Location = new System.Drawing.Point(643, 238);
            this.listeGelenKoltuk.Name = "listeGelenKoltuk";
            this.listeGelenKoltuk.Size = new System.Drawing.Size(120, 54);
            this.listeGelenKoltuk.TabIndex = 59;
            this.listeGelenKoltuk.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::sinematik.Properties.Resources.farklikoltuk;
            this.pictureBox4.Location = new System.Drawing.Point(497, 585);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 62;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sinematik.Properties.Resources.farklsari;
            this.pictureBox3.Location = new System.Drawing.Point(600, 585);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sinematik.Properties.Resources.farkimavi;
            this.pictureBox2.Location = new System.Drawing.Point(396, 585);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lbBelirlenen
            // 
            this.lbBelirlenen.FormattingEnabled = true;
            this.lbBelirlenen.ItemHeight = 25;
            this.lbBelirlenen.Location = new System.Drawing.Point(643, 312);
            this.lbBelirlenen.Name = "lbBelirlenen";
            this.lbBelirlenen.Size = new System.Drawing.Size(120, 54);
            this.lbBelirlenen.TabIndex = 63;
            this.lbBelirlenen.Visible = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(8, 606);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(246, 34);
            this.btnTemizle.TabIndex = 64;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // FrmBiletOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 646);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KoltukPaneli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.lbBelirlenen);
            this.Controls.Add(this.lblGelenKoltuk);
            this.Controls.Add(this.listeGelenKoltuk);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(360, 80);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmBiletOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmBiletOlustur";
            this.Load += new System.EventHandler(this.FrmBiletOlustur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtBarkod;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtAdSoyad;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtTelNo;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ComboBox cbFilmAdi;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ComboBox cbTarih;
        public System.Windows.Forms.Label lblYonetmenAra;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label lblSeansSec;
        public System.Windows.Forms.FlowLayoutPanel panelSEANS;
        public System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.Label lblKoltukSayisi;
        public System.Windows.Forms.ComboBox cbSalon;
        public System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.ComboBox cbBiletTuru;
        public System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.TextBox txtKoltuklar;
        public System.Windows.Forms.Label lblGelenKoltuk;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel KoltukPaneli;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ListBox listeGelenKoltuk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox lbBelirlenen;
        public System.Windows.Forms.Button btnTemizle;
    }
}