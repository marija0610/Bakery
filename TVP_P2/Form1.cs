using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_P2
{
    public partial class Form1 : Form
    {
        Baza baza;
        List<Artikal> listaA;
        List<Artikal> lAPrikaz;
        List<Grupa> listaG;
        List<Racun> racuni;
        List<Artikal> lprikazA;
        List<Artikal> prikazlA;
        Racun rac;
        Artikal artikal;
        public Form1()
        {
            InitializeComponent();
            baza = new Baza();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Artikal";
                OleDbDataReader reader = cmd.ExecuteReader();
                listaA = new List<Artikal>();

                pnlKupovina.Visible = true;
                pnlKupovina.BringToFront();
                pnlDodajA.Visible = false;
                pnlBrisiR.Visible = false;
                while (reader.Read())
                {
                    Artikal a = new Artikal();
                    a.Id = int.Parse(reader["id_artikla"].ToString());
                    a.Naziv = reader["naziv"].ToString();
                    a.Cena = double.Parse(reader["cena"].ToString());
                    a.Popust = int.Parse(reader["popust"].ToString());
                    listaA.Add(a);
                }

                cmd.CommandText = "SELECT * FROM Grupa";
                reader.Close();
                reader = cmd.ExecuteReader();
                listaG = new List<Grupa>();
                while (reader.Read())
                {
                    Grupa g = new Grupa();
                    g.Id = int.Parse(reader["id_grupa"].ToString());
                    g.Naziv = reader["naziv"].ToString();
                    listaG.Add(g);
                    cbGrupa.Items.Add(g.Naziv);
                }

                foreach (Artikal a in listaA)
                {
                    cmd.CommandText = "SELECT * FROM Povezi WHERE id_artikla =" + a.Id.ToString()+"";
                    reader.Close();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    a.Id_g = int.Parse(reader["id_grupa"].ToString());
                }

                cmd.CommandText = "SELECT * FROM Racun";
                reader.Close();
                reader = cmd.ExecuteReader();
                racuni = new List<Racun>();
                while (reader.Read())
                {
                    Racun r = new Racun();
                    r.IdR = int.Parse(reader["id_racun"].ToString());
                    r.Cena =double.Parse( reader["cena"].ToString());
                    r.DatIzdavanja = (DateTime)reader["datum_vreme"];
                    racuni.Add(r);
                }

                rac = new Racun(0,DateTime.Now,new List<Artikal>());
                artikal = new Artikal("", 0, 0, -1);
               
                

            }
            finally { baza.ZatvoriKonekciju(); }


            for (int i =0; i<listaG.Count;i++)
            {
                Button but = new Button();
                but.Height = 50;
                but.Width = 80;
                but.Left = 15;
                if (i % 2 != 0)
                    but.Left += 15 + 65;
                but.Top = 35;
                but.Top += i / 2 * 50;
                but.Text = listaG[i].Naziv;
                but.Click += klik;
                but.Font = new Font(FontFamily.GenericSerif, 13F);
                but.BackColor = Color.LightBlue;
                pnlKupovina.Controls.Add(but);
            }

        }
        private void klik(object sender, EventArgs e)
        {
            try
            {
                
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Artikal";
                OleDbDataReader reader = cmd.ExecuteReader();
                listaA = new List<Artikal>();

                pnlKupovina.Visible = true;
                pnlKupovina.BringToFront();
                pnlDodajA.Visible = false;
                pnlBrisiR.Visible = false;
                while (reader.Read())
                {
                    Artikal a = new Artikal();
                    a.Id = int.Parse(reader["id_artikla"].ToString());
                    a.Naziv = reader["naziv"].ToString();
                    a.Cena = double.Parse(reader["cena"].ToString());
                    a.Popust = int.Parse(reader["popust"].ToString());
                    listaA.Add(a);
                }

                foreach (Artikal a in listaA)
                {
                    cmd.CommandText = "SELECT * FROM Povezi WHERE id_artikla =" + a.Id.ToString() + "";
                    reader.Close();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    a.Id_g = int.Parse(reader["id_grupa"].ToString());
                }

            }
            finally { baza.ZatvoriKonekciju(); }
            int idG =0;
            foreach(Grupa g in listaG)
            {
                if((sender as Button).Text.Equals(g.Naziv))
                    idG = g.Id;
            }
            lAPrikaz = new List<Artikal>();
            foreach (Artikal a in listaA)
            {
                if (a.Id_g == idG)
                    lAPrikaz.Add(a);
            }

            listBox1.DataSource = lAPrikaz;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i<numericUpDown1.Value; i++)
                rac.ListaA.Add(lAPrikaz[listBox1.SelectedIndex]);
            //rac.ListaA.AddRange(lAPrikaz[listBox1.SelectedIndex], numericUpDown1.Value.ToString());
            lstRacun.DataSource = new List<Artikal>();
            lstRacun.DataSource = rac.ListaA;
            double cena=0;
            foreach (Artikal a in rac.ListaA)
                cena += a.vratiCenuPopust();
            txtUkupnaC.Text = cena.ToString();

        }

        private void pnlKupovina_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                txtCenaK.Text = (lAPrikaz[listBox1.SelectedIndex].Cena * int.Parse(numericUpDown1.Value.ToString())).ToString();
                txtCenaPopust.Text = (lAPrikaz[listBox1.SelectedIndex].vratiCenuPopust() * int.Parse(numericUpDown1.Value.ToString())).ToString();
                txtUsteda.Text = (double.Parse(txtCenaK.Text) - double.Parse(txtCenaPopust.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Prvo morate oznaciti stavku iz listBoxa");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                txtCenaK.Text = (lAPrikaz[listBox1.SelectedIndex].Cena * int.Parse(numericUpDown1.Value.ToString())).ToString();
                txtCenaPopust.Text = (lAPrikaz[listBox1.SelectedIndex].vratiCenuPopust() * int.Parse(numericUpDown1.Value.ToString())).ToString();
                txtUsteda.Text = (double.Parse(txtCenaK.Text) - double.Parse(txtCenaPopust.Text)).ToString();
            }
            else
                MessageBox.Show("Prvo oznacite stavku iz listBoXa!");
        }

        private void btnStornirajStavku_Click(object sender, EventArgs e)
        {
            rac.ListaA.RemoveAt(lstRacun.SelectedIndex);
            lstRacun.DataSource = new List<Artikal>();
            lstRacun.DataSource = rac.ListaA;
            double cena = 0;
            foreach (Artikal a in rac.ListaA)
                cena += a.Cena;
            txtUkupnaC.Text = cena.ToString();

        }

        private void btnIzdajracun_Click(object sender, EventArgs e)
        {
            rac.DatIzdavanja = DateTime.Now;
            rac.Cena = double.Parse(txtUkupnaC.Text);
            baza.OtvoriKonekciju();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = baza.Conn;
            cmd.CommandText = "INSERT INTO Racun(cena, datum_vreme) VALUES(@param1,@param2)";
            cmd.Parameters.AddWithValue("@param1", rac.Cena.ToString());
            cmd.Parameters.AddWithValue("@param2", rac.DatIzdavanja.ToString());
            cmd.ExecuteNonQuery();
            baza.ZatvoriKonekciju();
            rac = new Racun(0, DateTime.Now, new List<Artikal>());
            lstRacun.DataSource = new List<Artikal>();
            txtUkupnaC.Text = "";
            MessageBox.Show("Uspesno ste sačuvali racun");
        }

        private void button4_Click(object sender, EventArgs e) // Dodavanje artikla
        {
            if (txtArtikal.Text.Trim().Length != 0 || txtCenaA.Text.Trim().Length != 0 || txtPopustA.Text.Trim().Length != 0)
            {
                artikal.Naziv = txtArtikal.Text;
                artikal.Cena = double.Parse(txtCenaA.Text);
                artikal.Popust = int.Parse(txtPopustA.Text);
                foreach (Grupa g in listaG)
                    if (cbGrupa.Text.Equals(g.Naziv))
                        artikal.Id_g = g.Id;

                baza.OtvoriKonekciju();

                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = baza.Conn;
                cmd1.Connection = baza.Conn;

                cmd1.CommandText = "SELECT * FROM ARTIKAL";
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                int br = 0;
                while (reader1.Read())
                {
                    if (reader1["naziv"].ToString().Equals(txtArtikal.Text))
                    {
                        MessageBox.Show("Artikl već postoji u bazi");
                        br = 1;
                    }
                }
                if (br != 1)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "INSERT INTO Artikal(naziv, cena, popust) VALUES('"+artikal.Naziv+"',@param2,@param3)";  //dva nacina za dodavanje
                    //cmd.Parameters.AddWithValue("@param1", artikal.Naziv);
                    cmd.Parameters.AddWithValue("@param2", artikal.Cena);
                    cmd.Parameters.AddWithValue("@param3", artikal.Popust);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT * FROM ARTIKAL";
                    OleDbDataReader reader = cmd.ExecuteReader();

                    int pomIndeks = -1;

                    while (reader.Read())
                    {

                        if (reader["naziv"].Equals(artikal.Naziv))
                            pomIndeks = int.Parse(reader["id_artikla"].ToString());

                    }
                    reader.Close();
                    reader1.Close();


                    if (pomIndeks != -1)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "INSERT INTO Povezi(id_grupa,id_artikla) VALUES(@param1,@param2)";
                        cmd.Parameters.AddWithValue("@param1", artikal.Id_g);
                        cmd.Parameters.AddWithValue("@param2", pomIndeks);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Uspesno ste dodali artikal");
                    }

                }

               
               

                baza.ZatvoriKonekciju();
                artikal = new Artikal("", 0, 0, -1);

                listBox2.DataSource = prikazlA;

                txtArtikal.Clear();
                txtCenaA.Clear();
                txtPopustA.Clear();
                cbGrupa.ResetText();
            }
            else
                MessageBox.Show("Unesite sve podatke");
        }



        private void btnObrisiR_Click(object sender, EventArgs e)
        {
            if(lstRacuni.SelectedIndex!=-1)
            {
                
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "DELETE FROM Racun WHERE id_racun=@param1";
                cmd.Parameters.AddWithValue("@param1", int.Parse(lstRacuni.Text.Split(' ')[0]));
                cmd.ExecuteNonQuery();
                baza.ZatvoriKonekciju();
                lstRacuni.Items.RemoveAt(lstRacuni.SelectedIndex);

            }
            else
            {
                MessageBox.Show("Prvo morate oznaciti stavku iz listBoxa");
            }
        }


        private void btnPrikazRac_Click(object sender, EventArgs e)
        {

            try
            {
                
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Racun";
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Close();
                reader = cmd.ExecuteReader();
                racuni = new List<Racun>();
                while (reader.Read())
                {
                    Racun r = new Racun();
                    r.IdR = int.Parse(reader["id_racun"].ToString());
                    r.Cena = double.Parse(reader["cena"].ToString());
                    r.DatIzdavanja = (DateTime)reader["datum_vreme"];
                    racuni.Add(r);
                }

                rac = new Racun(0, DateTime.Now, new List<Artikal>());

            }
            finally { baza.ZatvoriKonekciju(); }

            lstRacuni.Items.Clear();
            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();
            d1 = dtpDatOd.Value;
            d2 = dtpDatDo.Value;

            if (d1 > d2)
            {
                MessageBox.Show("Unesite validan opseg datuma.");
            }
            else
            {
                var linq = from ra in racuni
                           where ra.DatIzdavanja >= d1 && ra.DatIzdavanja <= d2
                           select ra;
                List<Racun> uOpsegu = linq.ToList();
                foreach (Racun r in uOpsegu)
                {
                    lstRacuni.Items.Add(r);
                }
            }
        }

        private void kupovinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlKupovina.Visible = true;
            pnlKupovina.BringToFront();
            pnlDodajA.Visible = false;
            pnlBrisiR.Visible = false;
        }

        private void dodavanjeArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDodajA.Visible = true;
            pnlDodajA.BringToFront();
            pnlKupovina.Visible = false;
            pnlBrisiR.Visible = false;
        }

        private void brisanjeizmenaRacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlBrisiR.Visible = true;
            pnlBrisiR.BringToFront();
            pnlKupovina.Visible = false;
            pnlDodajA.Visible = false;
        }

        private void dtpDatDo_ValueChanged(object sender, EventArgs e)
        {
            dtpDatDo.MaxDate = DateTime.Now;
        }

        private void pnlBrisiR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Artikal";
                OleDbDataReader reader = cmd.ExecuteReader();
                listaA = new List<Artikal>();

                while (reader.Read())
                {
                    Artikal a = new Artikal();
                    a.Id = int.Parse(reader["id_artikla"].ToString());
                    a.Naziv = reader["naziv"].ToString();
                    a.Cena = double.Parse(reader["cena"].ToString());
                    a.Popust = int.Parse(reader["popust"].ToString());
                    listaA.Add(a);
                }

                foreach (Artikal a in listaA)
                {
                    cmd.CommandText = "SELECT * FROM Povezi WHERE id_artikla =" + a.Id.ToString() + "";
                    reader.Close();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    a.Id_g = int.Parse(reader["id_grupa"].ToString());
                }

            }
            finally { baza.ZatvoriKonekciju(); }
            int idG = 0;
            foreach (Grupa g in listaG)
            {
                if (cbGrupa.Text.Equals(g.Naziv))
                    idG = g.Id;
            }
            lprikazA = new List<Artikal>();
            foreach (Artikal a in listaA)
            {
                if (a.Id_g == idG)
                    lprikazA.Add(a);
            }

            listBox2.DataSource = lprikazA;
        }
    }
}
