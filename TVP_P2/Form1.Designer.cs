namespace TVP_P2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kupovinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeizmenaRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlKupovina = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCenaPopust = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsteda = new System.Windows.Forms.TextBox();
            this.txtCenaK = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pnlDodajA = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cbGrupa = new System.Windows.Forms.ComboBox();
            this.txtPopustA = new System.Windows.Forms.TextBox();
            this.txtCenaA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtikal = new System.Windows.Forms.TextBox();
            this.pnlBrisiR = new System.Windows.Forms.Panel();
            this.btnPrikazRac = new System.Windows.Forms.Button();
            this.lstRacuni = new System.Windows.Forms.ListBox();
            this.btnObrisiR = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDatDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDatOd = new System.Windows.Forms.DateTimePicker();
            this.lstRacun = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIzdajracun = new System.Windows.Forms.Button();
            this.btnStornirajStavku = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUkupnaC = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.pnlKupovina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlDodajA.SuspendLayout();
            this.pnlBrisiR.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kupovinaToolStripMenuItem,
            this.dodavanjeArtiklaToolStripMenuItem,
            this.brisanjeizmenaRacunaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(681, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kupovinaToolStripMenuItem
            // 
            this.kupovinaToolStripMenuItem.Name = "kupovinaToolStripMenuItem";
            this.kupovinaToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.kupovinaToolStripMenuItem.Text = "Kupovina";
            this.kupovinaToolStripMenuItem.Click += new System.EventHandler(this.kupovinaToolStripMenuItem_Click);
            // 
            // dodavanjeArtiklaToolStripMenuItem
            // 
            this.dodavanjeArtiklaToolStripMenuItem.Name = "dodavanjeArtiklaToolStripMenuItem";
            this.dodavanjeArtiklaToolStripMenuItem.Size = new System.Drawing.Size(143, 25);
            this.dodavanjeArtiklaToolStripMenuItem.Text = "Dodavanje artikla";
            this.dodavanjeArtiklaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeArtiklaToolStripMenuItem_Click);
            // 
            // brisanjeizmenaRacunaToolStripMenuItem
            // 
            this.brisanjeizmenaRacunaToolStripMenuItem.Name = "brisanjeizmenaRacunaToolStripMenuItem";
            this.brisanjeizmenaRacunaToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.brisanjeizmenaRacunaToolStripMenuItem.Text = "Brisanje računa";
            this.brisanjeizmenaRacunaToolStripMenuItem.Click += new System.EventHandler(this.brisanjeizmenaRacunaToolStripMenuItem_Click);
            // 
            // pnlKupovina
            // 
            this.pnlKupovina.Controls.Add(this.label13);
            this.pnlKupovina.Controls.Add(this.txtCenaPopust);
            this.pnlKupovina.Controls.Add(this.listBox1);
            this.pnlKupovina.Controls.Add(this.button1);
            this.pnlKupovina.Controls.Add(this.label4);
            this.pnlKupovina.Controls.Add(this.label3);
            this.pnlKupovina.Controls.Add(this.label2);
            this.pnlKupovina.Controls.Add(this.label1);
            this.pnlKupovina.Controls.Add(this.txtUsteda);
            this.pnlKupovina.Controls.Add(this.txtCenaK);
            this.pnlKupovina.Controls.Add(this.numericUpDown1);
            this.pnlKupovina.Location = new System.Drawing.Point(9, 34);
            this.pnlKupovina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlKupovina.Name = "pnlKupovina";
            this.pnlKupovina.Size = new System.Drawing.Size(663, 260);
            this.pnlKupovina.TabIndex = 1;
            this.pnlKupovina.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKupovina_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = " Izaberite kategoriju:";
            // 
            // txtCenaPopust
            // 
            this.txtCenaPopust.Location = new System.Drawing.Point(548, 84);
            this.txtCenaPopust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCenaPopust.Name = "txtCenaPopust";
            this.txtCenaPopust.ReadOnly = true;
            this.txtCenaPopust.Size = new System.Drawing.Size(91, 20);
            this.txtCenaPopust.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(184, 16);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(208, 212);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(407, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj na račun";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usteda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena sa popustom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kolicina";
            // 
            // txtUsteda
            // 
            this.txtUsteda.Location = new System.Drawing.Point(548, 123);
            this.txtUsteda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsteda.Name = "txtUsteda";
            this.txtUsteda.ReadOnly = true;
            this.txtUsteda.Size = new System.Drawing.Size(91, 20);
            this.txtUsteda.TabIndex = 3;
            // 
            // txtCenaK
            // 
            this.txtCenaK.Location = new System.Drawing.Point(548, 50);
            this.txtCenaK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCenaK.Name = "txtCenaK";
            this.txtCenaK.ReadOnly = true;
            this.txtCenaK.Size = new System.Drawing.Size(91, 20);
            this.txtCenaK.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(548, 13);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pnlDodajA
            // 
            this.pnlDodajA.Controls.Add(this.label14);
            this.pnlDodajA.Controls.Add(this.listBox2);
            this.pnlDodajA.Controls.Add(this.button4);
            this.pnlDodajA.Controls.Add(this.cbGrupa);
            this.pnlDodajA.Controls.Add(this.txtPopustA);
            this.pnlDodajA.Controls.Add(this.txtCenaA);
            this.pnlDodajA.Controls.Add(this.label9);
            this.pnlDodajA.Controls.Add(this.label8);
            this.pnlDodajA.Controls.Add(this.label7);
            this.pnlDodajA.Controls.Add(this.label6);
            this.pnlDodajA.Controls.Add(this.txtArtikal);
            this.pnlDodajA.Location = new System.Drawing.Point(4, 34);
            this.pnlDodajA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDodajA.Name = "pnlDodajA";
            this.pnlDodajA.Size = new System.Drawing.Size(663, 260);
            this.pnlDodajA.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(375, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 18);
            this.label14.TabIndex = 10;
            this.label14.Text = "Artikli iz izabrane grupe:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(376, 43);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(248, 199);
            this.listBox2.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(96, 188);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 53);
            this.button4.TabIndex = 8;
            this.button4.Text = "Dodaj atikl";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbGrupa
            // 
            this.cbGrupa.FormattingEnabled = true;
            this.cbGrupa.Location = new System.Drawing.Point(164, 13);
            this.cbGrupa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGrupa.Name = "cbGrupa";
            this.cbGrupa.Size = new System.Drawing.Size(129, 21);
            this.cbGrupa.TabIndex = 7;
            this.cbGrupa.SelectedIndexChanged += new System.EventHandler(this.cbGrupa_SelectedIndexChanged);
            // 
            // txtPopustA
            // 
            this.txtPopustA.Location = new System.Drawing.Point(164, 128);
            this.txtPopustA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPopustA.Name = "txtPopustA";
            this.txtPopustA.Size = new System.Drawing.Size(129, 20);
            this.txtPopustA.TabIndex = 6;
            // 
            // txtCenaA
            // 
            this.txtCenaA.Location = new System.Drawing.Point(164, 89);
            this.txtCenaA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCenaA.Name = "txtCenaA";
            this.txtCenaA.Size = new System.Drawing.Size(129, 20);
            this.txtCenaA.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Grupa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Popust";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Naziv artikla";
            // 
            // txtArtikal
            // 
            this.txtArtikal.Location = new System.Drawing.Point(164, 49);
            this.txtArtikal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArtikal.Name = "txtArtikal";
            this.txtArtikal.Size = new System.Drawing.Size(129, 20);
            this.txtArtikal.TabIndex = 0;
            // 
            // pnlBrisiR
            // 
            this.pnlBrisiR.Controls.Add(this.btnPrikazRac);
            this.pnlBrisiR.Controls.Add(this.lstRacuni);
            this.pnlBrisiR.Controls.Add(this.btnObrisiR);
            this.pnlBrisiR.Controls.Add(this.label11);
            this.pnlBrisiR.Controls.Add(this.label10);
            this.pnlBrisiR.Controls.Add(this.dtpDatDo);
            this.pnlBrisiR.Controls.Add(this.dtpDatOd);
            this.pnlBrisiR.Location = new System.Drawing.Point(9, 34);
            this.pnlBrisiR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBrisiR.Name = "pnlBrisiR";
            this.pnlBrisiR.Size = new System.Drawing.Size(663, 260);
            this.pnlBrisiR.TabIndex = 0;
            this.pnlBrisiR.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBrisiR_Paint);
            // 
            // btnPrikazRac
            // 
            this.btnPrikazRac.BackColor = System.Drawing.Color.LightBlue;
            this.btnPrikazRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazRac.Location = new System.Drawing.Point(24, 156);
            this.btnPrikazRac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrikazRac.Name = "btnPrikazRac";
            this.btnPrikazRac.Size = new System.Drawing.Size(132, 68);
            this.btnPrikazRac.TabIndex = 5;
            this.btnPrikazRac.Text = "Prikaži račune";
            this.btnPrikazRac.UseVisualStyleBackColor = false;
            this.btnPrikazRac.Click += new System.EventHandler(this.btnPrikazRac_Click);
            // 
            // lstRacuni
            // 
            this.lstRacuni.FormattingEnabled = true;
            this.lstRacuni.Location = new System.Drawing.Point(365, 37);
            this.lstRacuni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstRacuni.Name = "lstRacuni";
            this.lstRacuni.Size = new System.Drawing.Size(274, 186);
            this.lstRacuni.TabIndex = 4;
            // 
            // btnObrisiR
            // 
            this.btnObrisiR.BackColor = System.Drawing.Color.LightBlue;
            this.btnObrisiR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiR.Location = new System.Drawing.Point(207, 156);
            this.btnObrisiR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisiR.Name = "btnObrisiR";
            this.btnObrisiR.Size = new System.Drawing.Size(132, 68);
            this.btnObrisiR.TabIndex = 3;
            this.btnObrisiR.Text = "Obriši";
            this.btnObrisiR.UseVisualStyleBackColor = false;
            this.btnObrisiR.Click += new System.EventHandler(this.btnObrisiR_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Datum do:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Datum od:";
            // 
            // dtpDatDo
            // 
            this.dtpDatDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatDo.Location = new System.Drawing.Point(118, 83);
            this.dtpDatDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatDo.Name = "dtpDatDo";
            this.dtpDatDo.Size = new System.Drawing.Size(222, 24);
            this.dtpDatDo.TabIndex = 1;
            this.dtpDatDo.ValueChanged += new System.EventHandler(this.dtpDatDo_ValueChanged);
            // 
            // dtpDatOd
            // 
            this.dtpDatOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatOd.Location = new System.Drawing.Point(118, 36);
            this.dtpDatOd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatOd.Name = "dtpDatOd";
            this.dtpDatOd.Size = new System.Drawing.Size(222, 24);
            this.dtpDatOd.TabIndex = 0;
            // 
            // lstRacun
            // 
            this.lstRacun.FormattingEnabled = true;
            this.lstRacun.Location = new System.Drawing.Point(20, 349);
            this.lstRacun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstRacun.Name = "lstRacun";
            this.lstRacun.ScrollAlwaysVisible = true;
            this.lstRacun.Size = new System.Drawing.Size(470, 160);
            this.lstRacun.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Racun";
            // 
            // btnIzdajracun
            // 
            this.btnIzdajracun.BackColor = System.Drawing.Color.LightBlue;
            this.btnIzdajracun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzdajracun.Location = new System.Drawing.Point(519, 310);
            this.btnIzdajracun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzdajracun.Name = "btnIzdajracun";
            this.btnIzdajracun.Size = new System.Drawing.Size(122, 50);
            this.btnIzdajracun.TabIndex = 4;
            this.btnIzdajracun.Text = "Izdaj račun";
            this.btnIzdajracun.UseVisualStyleBackColor = false;
            this.btnIzdajracun.Click += new System.EventHandler(this.btnIzdajracun_Click);
            // 
            // btnStornirajStavku
            // 
            this.btnStornirajStavku.BackColor = System.Drawing.Color.LightBlue;
            this.btnStornirajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStornirajStavku.Location = new System.Drawing.Point(519, 374);
            this.btnStornirajStavku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStornirajStavku.Name = "btnStornirajStavku";
            this.btnStornirajStavku.Size = new System.Drawing.Size(122, 56);
            this.btnStornirajStavku.TabIndex = 5;
            this.btnStornirajStavku.Text = "Storniraj stavku";
            this.btnStornirajStavku.UseVisualStyleBackColor = false;
            this.btnStornirajStavku.Click += new System.EventHandler(this.btnStornirajStavku_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(515, 447);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ukupna cena";
            // 
            // txtUkupnaC
            // 
            this.txtUkupnaC.Location = new System.Drawing.Point(519, 480);
            this.txtUkupnaC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUkupnaC.Name = "txtUkupnaC";
            this.txtUkupnaC.ReadOnly = true;
            this.txtUkupnaC.Size = new System.Drawing.Size(123, 20);
            this.txtUkupnaC.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 525);
            this.Controls.Add(this.txtUkupnaC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnStornirajStavku);
            this.Controls.Add(this.btnIzdajracun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstRacun);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlKupovina);
            this.Controls.Add(this.pnlDodajA);
            this.Controls.Add(this.pnlBrisiR);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlKupovina.ResumeLayout(false);
            this.pnlKupovina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlDodajA.ResumeLayout(false);
            this.pnlDodajA.PerformLayout();
            this.pnlBrisiR.ResumeLayout(false);
            this.pnlBrisiR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kupovinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeizmenaRacunaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlKupovina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsteda;
        private System.Windows.Forms.TextBox txtCenaPopust;
        private System.Windows.Forms.TextBox txtCenaK;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel pnlDodajA;
        private System.Windows.Forms.Panel pnlBrisiR;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstRacun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIzdajracun;
        private System.Windows.Forms.Button btnStornirajStavku;
        private System.Windows.Forms.ComboBox cbGrupa;
        private System.Windows.Forms.TextBox txtPopustA;
        private System.Windows.Forms.TextBox txtCenaA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArtikal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lstRacuni;
        private System.Windows.Forms.Button btnObrisiR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDatDo;
        private System.Windows.Forms.DateTimePicker dtpDatOd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUkupnaC;
        private System.Windows.Forms.Button btnPrikazRac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBox2;
    }
}

