using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Beadando
{
    public partial class BelepesFrm : Form
    {
        string fileUt = "C:\\Users\\Public\\Felhasznalok.txt";
        List<Felhasznalo> lista = new List<Felhasznalo>();
        public BelepesFrm()
        {
            InitializeComponent();

            if (File.Exists(fileUt))
            {
                StreamReader sR = new StreamReader(fileUt, Encoding.UTF8);
                while (!sR.EndOfStream)
                {
                    string[] s = sR.ReadLine().Split(';');
                    Felhasznalo f = new Felhasznalo(s[0], s[1]);
                    lista.Add(f);
                }
                sR.Close();
            }
        }

        private void cbRegisztral_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = tbJelszUjra.Visible = btRegisztracio.Visible = !btRegisztracio.Visible;
            belepesBtn.Visible =! btRegisztracio.Visible;
        }

        private void btRegisztracio_Click(object sender, EventArgs e)
        {
            if (felhasznaloTb.Text== "" || jelszoTb.Text == "" || tbJelszUjra.Text!=jelszoTb.Text)
            {
                MessageBox.Show("Sikertelen regisztráció");
            }
            else
            {
                Felhasznalo f = lista.Find(x => x.Nev.Equals(felhasznaloTb.Text));
                if (f != null)
                {
                    MessageBox.Show("Már létezik ilyen felhasználó");
                }
                else
                {
                    Felhasznalo felhasznalo = new Felhasznalo(felhasznaloTb.Text, jelszoTb.Text);
                    lista.Add(felhasznalo);
                    tbJelszUjra.Text = felhasznaloTb.Text = jelszoTb.Text = String.Empty;
                    cbRegisztral.Checked = false;
                    MessageBox.Show("Sikeresen regisztrált!");
                    StreamWriter sW = new StreamWriter(fileUt, true, Encoding.UTF8);
                    sW.WriteLine(felhasznalo.Nev + ";" + felhasznalo.Jelszo);
                    sW.Close();
                }
            }
        }

        private void belepesBtn_Click(object sender, EventArgs e)
        {

            Felhasznalo f = lista.Find(x => x.Nev.Equals(felhasznaloTb.Text) && x.Jelszo.Equals(jelszoTb.Text));
            if ( f!=null)
            {
                FoAblak.Kiaz = f;
                FoAblak F = new FoAblak();
                F.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Téves felhasznaló vagy jelszó");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void BelepesFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
