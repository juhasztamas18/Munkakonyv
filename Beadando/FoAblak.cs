using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class FoAblak : Form
    {
        string fileUt = "G:\\Programozás\\Beadando\\Beadando\\" + kiaz.Nev + "Munkasok.txt";
        static Felhasznalo kiaz;
        List<Munkas> munkasok = new List<Munkas>();
        public FoAblak()
        {
            InitializeComponent();

            if (File.Exists(fileUt))
            {
                StreamReader sR = new StreamReader(fileUt, Encoding.UTF8);
                while (!sR.EndOfStream)
                {
                    string[] s = sR.ReadLine().Split(';');
                    Munkas f = new Munkas(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToInt32(s[3]));
                    munkasok.Add(f);
                    ListViewItem lvi = new ListViewItem(s[0]);
                    lvi.SubItems.Add(s[1]);
                    lvi.SubItems.Add(s[2]);
                    lvi.SubItems.Add(s[3]);
                    lvAdatok.Items.Add(lvi);
                }
                sR.Close();
            }
        }

        internal static Felhasznalo Kiaz
        {
            get
            {
                return kiaz;
            }

            set
            {
                kiaz = value;
            }
        }

        private void FoAblak_Load(object sender, EventArgs e)
        {
            this.Text = kiaz.Nev;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            label1.Visible = tbNev.Visible = tbTelefon.Visible = tbNap.Visible = tbBer.Visible = btnFelvesz.Visible =! tbBer.Visible;
            tbFizetes.Visible = label4.Visible = false;
        }

        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            if (tbNev.Text == "" || tbTelefon.Text == "" || tbNap.Text == "" ||  tbBer.Text=="")
            {
                MessageBox.Show("Valamelyik mezőt üresen hagyta");
            }
            else
            {
                Munkas f = munkasok.Find(x => x.Telefonszam.Equals(tbTelefon.Text));
                if (f != null)
                {
                    MessageBox.Show("Már létezik ilyen munkas");
                }
                else
                {
                    Munkas munkas = new Munkas(tbNev.Text, tbTelefon.Text, Convert.ToInt32(tbNap.Text), Convert.ToInt32(tbBer.Text));
                    munkasok.Add(munkas);
                    ListViewItem lvi = new ListViewItem(tbNev.Text);
                    lvi.SubItems.Add(tbTelefon.Text);
                    lvi.SubItems.Add(tbNap.Text);
                    lvi.SubItems.Add(tbBer.Text);
                    lvAdatok.Items.Add(lvi);
                    clear();
                    StreamWriter sW = new StreamWriter(fileUt, true, Encoding.UTF8);
                    sW.WriteLine(munkas.Nev + ";" + munkas.Telefonszam + ";" + munkas.Napok + ";" + munkas.Ber);
                    sW.Close();
                }
            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void rbSzerkesztes_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            label3.Visible = btnKesz.Visible= tbNev.Visible = tbTelefon.Visible = tbNap.Visible =tbBer.Visible = !label3.Visible;
            tbFizetes.Visible = label4.Visible = false;
        }


        private void lvAdatok_MouseClick(object sender, MouseEventArgs e)
        {
                       
            tbNev.Text = lvAdatok.SelectedItems[0].SubItems[0].Text;
            tbTelefon.Text = lvAdatok.SelectedItems[0].SubItems[1].Text;
            tbNap.Text = lvAdatok.SelectedItems[0].SubItems[2].Text;
            tbBer.Text = lvAdatok.SelectedItems[0].SubItems[3].Text;
            tbFizetes.Visible = label4.Visible = false;

        }

        private void clear()
        {
            tbNev.Clear();
            tbTelefon.Clear();
            tbNap.Clear();
            tbBer.Clear();
        }
        private void ujraIr()
        {
            File.Delete(fileUt);
            StreamWriter sW = new StreamWriter(fileUt, true, Encoding.UTF8);
            foreach (Munkas a in munkasok)
            {
                sW.WriteLine(a.Nev + ";" + a.Telefonszam + ";" + a.Napok + ";" + a.Ber);
            }

            sW.Close();
        }
        private void btnKesz_Click(object sender, EventArgs e)
        {
            if (tbNev.Text == "" || tbTelefon.Text == "" || tbNap.Text == "" || tbBer.Text == "")
            {
                MessageBox.Show("Valamelyik mezőt üresen hagyta");
            }
            else
            {

                lvAdatok.SelectedItems[0].SubItems[0].Text = tbNev.Text ;
                lvAdatok.SelectedItems[0].SubItems[1].Text = tbTelefon.Text;
                lvAdatok.SelectedItems[0].SubItems[2].Text = tbNap.Text;
                lvAdatok.SelectedItems[0].SubItems[3].Text = tbBer.Text;
               // Console.Write(" tomi vagyok"+lvAdatok.SelectedIndices[0]);
                munkasok.RemoveAt(lvAdatok.SelectedIndices[0]);
                Munkas munkas = new Munkas(tbNev.Text, tbTelefon.Text, Convert.ToInt32(tbNap.Text), Convert.ToInt32(tbBer.Text));
                munkasok.Add(munkas);
                clear();
                ujraIr();
                
            }

        }

        private void munkásBéreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbFizetes.Visible = label4.Visible = !label4.Visible;
            tbFizetes.Text =""+ Convert.ToInt32(lvAdatok.SelectedItems[0].SubItems[2].Text)*Convert.ToInt32(lvAdatok.SelectedItems[0].SubItems[3].Text);

        }

        private void összeFizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int osszeg = 0;
            foreach (Munkas a in munkasok)
            {
                osszeg += a.Napok * a.Ber;
            }
            MessageBox.Show("A munkások össz bére: " + osszeg);
        }

        private void táblazatTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos benne hogy törli a táblázatot?","Táblázat törlése!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                munkasok.Clear();
                File.Delete(fileUt);
                lvAdatok.Items.Clear();

            }
        }

        private void munkásEltávolitásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            munkasok.RemoveAt(lvAdatok.SelectedIndices[0]);
            lvAdatok.Items.Remove(lvAdatok.SelectedItems[0]);
            ujraIr();
        }
    }
}
